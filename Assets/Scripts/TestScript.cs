using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public InputAction updateAction;
    public InputAction removeAction;
    public InputAction destroyEntity;

    int entityId;

    List<System.Action> cleanUpFns = new();

    // Start is called before the first frame update
    void Start()
    {
        updateAction.Enable();
        removeAction.Enable();
        destroyEntity.Enable();

        updateAction.performed += OnUpdate;
        removeAction.performed += OnRemove;
        destroyEntity.performed += OnEntityDestroyed;

        // Gets the ID of the entity created by the Registry
		entityId = Ecsact.Defaults.Registry.CreateEntity();
        Debug.Log("create entity");

        cleanUpFns.AddRange(new[] {
            // Callback that's invoked on the removal of a component
            Ecsact.Defaults.Runtime.OnInitComponent<example.Example>((entity, component) => {
                Debug.Log("Init: " + component.example_value);
            }),
            Ecsact.Defaults.Runtime.OnUpdateComponent<example.Example>((entity, component) => {
                Debug.Log("Update: " + component.example_value);
            }),
            Ecsact.Defaults.Runtime.OnRemoveComponent<example.Example>((entity, component) => {
                Debug.Log("Remove: " + component.example_value);
            }),
            Ecsact.Defaults.Runtime.OnEntityDestroyed((entity, placeholder) => {
                Debug.Log("Entity Destroyed in test script");
            })
		});

        // Create a Example component from our .ecsact file
		var exampleComponent = new example.Example {
			example_value = 5,
		};

		// Add the declared example component to your entity 
		Ecsact.Defaults.Runner.executionOptions.AddComponent(
			entityId,
			exampleComponent
		);
    }

    public void OnUpdate(InputAction.CallbackContext context) {
        Debug.Log("Update!");
        
        var component = Ecsact.Defaults.Registry.GetComponent<example.Example>(entityId);
        component.example_value += 1;

        Ecsact.Defaults.Runner.executionOptions.UpdateComponent(
			entityId,
			component
		);
    }

    public void OnRemove(InputAction.CallbackContext context) {

        Ecsact.Defaults.Runner.executionOptions.RemoveComponent<example.Example>(
			entityId
		);
        Debug.Log("Remove!");
    }

    public void OnEntityDestroyed(InputAction.CallbackContext context) {
        Debug.Log("Try Destroy");
        Ecsact.Defaults.Runner.executionOptions.DestroyEntity(entityId);
    }
}
