using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class Move : MonoBehaviour
{
    Ecsact.DefaultFixedRunner runner;
    EcsactRuntime rt;

    int entityId;

    public InputAction verticalMoveAction;
    public InputAction horizontalMoveAction;

    example.StartVerticalMove startVerticalMoveAction;
    example.StopVerticalMove stopVerticalMoveAction;
    
    example.StartHorizontalMove startHorizontalMoveAction;
    example.StopHorizontalMove stopHorizontalMoveAction;

    EcsactRuntime.ExecutionOptions executionOptions;

    void Start() {
        verticalMoveAction.Enable();
        horizontalMoveAction.Enable();

        verticalMoveAction.performed += OnVerticalMove;
        horizontalMoveAction.performed += OnHorizontalMove;
        verticalMoveAction.canceled += OnVerticalStop;
        horizontalMoveAction.canceled += OnHorizontalStop;

        rt = EcsactRuntime.GetOrLoadDefault();

        runner = FindObjectOfType<Ecsact.DefaultFixedRunner>();

        entityId = rt.core.CreateEntity(runner.registryId);

        rt.core.AddComponent<example.Position>(
            runner.registryId,
            entityId,
            new example.Position{
                x = 0,
                y = 0
            }
        );

        rt.core.AddComponent<example.Velocity>(
            runner.registryId,
            entityId,
            new example.Velocity{
                x_value = 0.0f,
                y_value = 0.0f,
                force = 0.1f
            }
        );

        rt.core.AddComponent<example.Collider>(
            runner.registryId,
            entityId,
            new example.Collider{}
        );

        rt.core.AddComponent<example.CanMove>(
            runner.registryId,
            entityId,
            new example.CanMove{}
        );

        startVerticalMoveAction = new example.StartVerticalMove{};
        stopVerticalMoveAction = new example.StopVerticalMove{};
        startHorizontalMoveAction = new example.StartHorizontalMove{};
        stopHorizontalMoveAction = new example.StopHorizontalMove{};
    }

    void OnDisable() {
        verticalMoveAction.Disable();
        horizontalMoveAction.Disable();

        verticalMoveAction.performed -= OnVerticalMove;
        horizontalMoveAction.performed -= OnHorizontalMove;
        verticalMoveAction.canceled -= OnVerticalStop;
        horizontalMoveAction.canceled -= OnHorizontalStop;
    }

    public void OnVerticalMove
        ( InputAction.CallbackContext context
        )
    {
        var value = context.ReadValue<float>();

        startVerticalMoveAction.y_change = value;
        runner.executeOptions.PushAction<example.StartVerticalMove>(
            startVerticalMoveAction
        );
    }

    public void OnVerticalStop
        ( InputAction.CallbackContext context
        )
    {
        runner.executeOptions.PushAction<example.StopVerticalMove>(
            stopVerticalMoveAction
        );
    }

    public void OnHorizontalMove
        ( InputAction.CallbackContext context
        )
    {
        var value = context.ReadValue<float>();
        startHorizontalMoveAction.x_change = value;
        runner.executeOptions.PushAction<example.StartHorizontalMove>(
            startHorizontalMoveAction
        );
    }

    public void OnHorizontalStop
        ( InputAction.CallbackContext context
        )
    {
        runner.executeOptions.PushAction<example.StopHorizontalMove>(
            stopHorizontalMoveAction
        );
    }

    void FixedUpdate() {
        var position = rt.core.GetComponent<example.Position>(
            runner.registryId,
            entityId
        );

        gameObject.transform.position = new Vector3(position.x, position.y, 0);
    }
}
