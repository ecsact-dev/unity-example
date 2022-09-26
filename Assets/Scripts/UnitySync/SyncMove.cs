using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using System;

public class SyncMove
    : MonoBehaviour
    , Ecsact.UnitySync.IRequired<example.Position>
    , Ecsact.UnitySync.IRequired<example.Block>
    , Ecsact.UnitySync.IOnInitComponent<example.Position>
    , Ecsact.UnitySync.IOnUpdateComponent<example.Position>
{
    Ecsact.DefaultFixedRunner runner;
    EcsactRuntime rt;
    
    private PlayerInput playerInput;

    private InputAction verticalMoveAction;
    private InputAction horizontalMoveAction;

    example.StartVerticalMove startVerticalMoveAction;
    example.StopVerticalMove stopVerticalMoveAction;

    example.Position position;
    
    example.StartHorizontalMove startHorizontalMoveAction;
    example.StopHorizontalMove stopHorizontalMoveAction;

    EcsactRuntime.ExecutionOptions executionOptions;

    public void OnInitComponent(in example.Position position) {
        gameObject.transform.position = new Vector3(position.x, position.y, 0);
    }

    public void OnUpdateComponent(in example.Position position) {
        gameObject.transform.position = new Vector3(position.x, position.y, 0);
    }
}
