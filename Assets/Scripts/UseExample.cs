using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class UseExample : MonoBehaviour
{
    EcsactRuntime runtime;
    Ecsact.DefaultFixedRunner runner;
    int entityId;
    System.Action action;
    
    void Start()
    {
        // Create an instance of the Ecsact Runtime
        runtime = EcsactRuntime.GetOrLoadDefault();

        // Example 1
        // Create a Registry from the instance
        //var registry = runtime.core.CreateRegistry("exampleReg");
        // Create an entity from the registry 
        //runtime.core.CreateEntity(registry);

        // Example 2 
        // Use a Default Registry
        runner = FindObjectOfType<Ecsact.DefaultFixedRunner>();
        // Create an entity using the runner's registry id
        entityId = runtime.core.CreateEntity(runner.registryId);

        runtime.OnUpdateComponent<example.Example>((entity, Component) => {
            // Debug.Log("update");
        });

        action = runtime.OnRemoveComponent<example.ToBeRemoved>((entity, component) => {
            Debug.Log("removed");
        });

        var exampleComponent = new example.Example {
            example_value = 5,
        };

        var removeComponent = new example.ToBeRemoved {};

        //Add component to your entity
        runtime.core.AddComponent(
            runner.registryId,
            entityId,
            exampleComponent
        );

        runtime.core.AddComponent(
            runner.registryId,
            entityId,
            removeComponent 
        );

        var component = runtime.core.GetComponent<example.Example>(
            runner.registryId,
            entityId
        );

        Debug.Log("Setting AddToExampleSystem");
        runtime.dynamic.SetSystemExecutionImpl<example.AddToExample>(ctx => {
            AddToExampleSystem(ctx);
        });
    }

    void AddToExampleSystem
        ( EcsactRuntime.SystemExecutionContext context
        )
    {
        var value = context.Get<example.Example>();
        
        value.example_value +=1;
        context.Update<example.Example>(value);

        if(value.example_value >= 300) {
            context.Remove<example.ToBeRemoved>();
        }
    }

    void FixedUpdate() {
        var component = runtime.core.GetComponent<example.Example>(
            runner.registryId,
            entityId
        );

        //Debug.Log(component.example_value);

    }
    void OnDestroy() {
        action();
    }
}
