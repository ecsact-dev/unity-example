using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class BasicExample : MonoBehaviour {

	List<System.Action> cleanUpFns = new();
	
	void Start() {
		int entityId = Ecsact.Defaults.Registry.CreateEntity();
		
		cleanUpFns.AddRange(new[] {
			// Callback that's invoked on the removal of a component
			Ecsact.Defaults.Runtime.OnRemoveComponent<example.ToBeRemoved>((entity, component) => {
				Debug.Log("Example component removed");
			}),
			// Callback that's invoked on the removal of a component
			Ecsact.Defaults.Runtime.OnUpdateComponent<example.Example>((entity, component) => {
				Debug.Log(component.example_value);
			})
		});

		// Declare an Example component type
		var exampleComponent = new example.Example {
			example_value = 5,
		};

		// Declare a ToBeRemoved component type
		var removeComponent = new example.ToBeRemoved {};

		//Add components to your entity
		Ecsact.Defaults.Registry.AddComponent(
			entityId,
			exampleComponent
		);

		Ecsact.Defaults.Registry.AddComponent(
			entityId,
			removeComponent 
		);
	}

	void OnDestroy() {
		foreach(var cleanUpFn in cleanUpFns) {
			cleanUpFn();
		}
	}
}
