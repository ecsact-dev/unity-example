using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddExample : MonoBehaviour
{
    // An entityId, which will be assigned to the return of CreateEntity
    int entityId;

    void Start() {

        // Gets the ID of the entity created by the Registry
        entityId = Ecsact.Defaults.Registry.CreateEntity();
        
        // Create a Example component from our .ecsact file
        var exampleComponent = new example.Example {
            example_value = 5,
        };

        // Add the declared example component to your entity 
        Ecsact.Defaults.Registry.AddComponent(
            entityId,
            exampleComponent
        );
        
        // Check component callback to get feedback
        Ecsact.Defaults.Runtime.OnInitComponent<example.Example>(
            (component, entity) => {
                Debug.Log("Example component added");
            }
        );
    }
}
