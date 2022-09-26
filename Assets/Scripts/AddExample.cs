using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddExample : MonoBehaviour
{
    // Create an instance of the Ecsact Runtime
    EcsactRuntime runtime;

    //Declare the default runner, which holds our registries
    Ecsact.DefaultFixedRunner runner;

    //An entityId, which will be assigned to the return of CreateEntity
    int entityId;

    void Start() {

        //Allows access to the EcasctRuntime, which is needed for most cases
        runtime = EcsactRuntime.GetOrLoadDefault();

        //Get the default runner assigned in Project Settings -> Ecsact
        runner = FindObjectOfType<Ecsact.DefaultFixedRunner>();

        //Gets the ID of the entity created by the runtime
        entityId = runtime.core.CreateEntity(runner.registryId);
        
        //Create a Example component from our .ecsact file
        var exampleComponent = new example.Example {
            example_value = 5,
        };

        
        runtime.core.AddComponent(
            runner.registryId,
            entityId,
            exampleComponent
        );

        
        runtime.OnInitComponent<example.Example>((component, entity) => {
            Debug.Log("Example component added");
        });
    }
}
