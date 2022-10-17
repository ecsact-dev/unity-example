using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveControls : MonoBehaviour {
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
        Debug.Log("VerticalMove");

        startVerticalMoveAction.y_change = value;
        Ecsact.Defaults.Runner.executeOptions.PushAction(
            startVerticalMoveAction
        );
    }

    public void OnVerticalStop
        ( InputAction.CallbackContext context
        )
    {
        Ecsact.Defaults.Runner.executeOptions.PushAction(
            stopVerticalMoveAction
        );
    }

    public void OnHorizontalMove
        ( InputAction.CallbackContext context
        )
    {
        Debug.Log("HorMove");
        var value = context.ReadValue<float>();
        startHorizontalMoveAction.x_change = value;
        Ecsact.Defaults.Runner.executeOptions.PushAction(
            startHorizontalMoveAction
        );
    }

    public void OnHorizontalStop
        ( InputAction.CallbackContext context
        )
    {
        Ecsact.Defaults.Runner.executeOptions.PushAction(
            stopHorizontalMoveAction
        );
    }

}
