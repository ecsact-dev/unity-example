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
    
    void Start() {
        // Create an instance of the Ecsact Runtime
        runtime = EcsactRuntime.GetOrLoadDefault();

        // Get the Default Registry
        runner = FindObjectOfType<Ecsact.DefaultFixedRunner>();
        // Create an entity using the runner's registry id
        entityId = runtime.core.CreateEntity(runner.registryId);

        // Callback that's invoked on component update
        runtime.OnUpdateComponent<example.Example>((entity, Component) => {
            Debug.Log("Example Updated");
        });

        // Callback that's invoked on the removal of the component
        action = runtime.OnRemoveComponent<example.ToBeRemoved>((entity, component) => {
            Debug.Log("Example compoent Removed");
        });

        // Declare an Example component type
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

        //Add system implementation for our AddToExample system from .ecsact
        runtime.dynamic.SetSystemExecutionImpl<example.AddToExample>(ctx => {
            AddToExampleSystem(ctx);
        });
    }

    void AddToExampleSystem
        ( EcsactRuntime.SystemExecutionContext context
        )
    {
        // Get a component from the context
        var value = context.Get<example.Example>();
        
        //Modify and update its value
        value.example_value +=1;
        context.Update<example.Example>(value);

        if(value.example_value >= 300) {
            // Remove the component from the context
            context.Remove<example.ToBeRemoved>();
        }
    }

    void FixedUpdate() {
        // Get the component to log its value
        var component = runtime.core.GetComponent<example.Example>(
            runner.registryId,
            entityId
        );

        Debug.Log(component.example_value);
    }
    void OnDestroy() {
        action();
    }
}
