using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GenerateBlock : MonoBehaviour {
    int entityId;

    public InputAction mouseAction;
    example.PerformGenerateBlock generateBlockAction;

    void Start() {
        mouseAction.Enable();
        mouseAction.performed += OnMouseClick;

        entityId = Ecsact.Defaults.Registry.CreateEntity();

        Ecsact.Defaults.Registry.AddComponent<example.BlockGenerator>(
            entityId,
            new example.BlockGenerator {
                fake_value = 1,
            }
        );
    }

    public void OnMouseClick
        ( InputAction.CallbackContext context
        )
    {
        Vector3 mousePos = Mouse.current.position.ReadValue();
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);

        generateBlockAction.pos_x = (int)worldPos.x;
        generateBlockAction.pos_y = (int)worldPos.y;

        Ecsact.Defaults.Runner.executeOptions.PushAction(
            generateBlockAction
        );
    }
}
