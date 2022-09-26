using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GenerateBlock : MonoBehaviour {
    EcsactRuntime rt;
    Ecsact.DefaultFixedRunner runner;
    int entityId;

    public InputAction mouseAction;
    example.PerformGenerateBlock generateBlockAction;

    void Start() {
        mouseAction.Enable();
        mouseAction.performed += OnMouseClick;

        runner = FindObjectOfType<Ecsact.DefaultFixedRunner>();
        rt = EcsactRuntime.GetOrLoadDefault();

        entityId = rt.core.CreateEntity(runner.registryId);

        rt.core.AddComponent<example.BlockGenerator>(
            runner.registryId,
            entityId,
            new example.BlockGenerator {
                fake_value = 1,
            }
        );

        rt.dynamic.SetActionExecutionImpl<example.PerformGenerateBlock>( ctx => {
            PerformGenerateBlock(ctx);
        });

        rt.dynamic.SetSystemExecutionImpl<example.GenerateBlock>(ctx => {
            GenerateBlockSys(ctx);
        });
    }

    public void PerformGenerateBlock
        ( EcsactRuntime.SystemExecutionContext context
        )
    {
        var action = context.Action<example.PerformGenerateBlock>();

        context.Add<example.QueueBlock>(new example.QueueBlock{
            pos_x = action.pos_x,
            pos_y = action.pos_y
        });
    }

    public void GenerateBlockSys
        ( EcsactRuntime.SystemExecutionContext context
        )
    {
        var builder = context.Generate();
        var block = context.Get<example.QueueBlock>();

        builder
            .AddComponent<example.CanMove>(
                new example.CanMove{}
            )
            .AddComponent<example.Block>(
                new example.Block{}
            )
            .AddComponent<example.Position>(
                new example.Position{x = block.pos_x, y = block.pos_y}
            )
            .AddComponent<example.Collider>(
                new example.Collider{x_radius = 4, y_radius = 4}
            )
            .AddComponent<example.Velocity>(
                new example.Velocity{x_value = 0, y_value = 0, force = 0.1f}
            )
            .Finish();
    }

    public void OnMouseClick
        ( InputAction.CallbackContext context
        )
    {
        Vector3 mousePos = Mouse.current.position.ReadValue();
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);

        generateBlockAction.pos_x = (int)worldPos.x;
        generateBlockAction.pos_y = (int)worldPos.y;

        runner.executeOptions.PushAction<example.PerformGenerateBlock>(
            generateBlockAction
        );
    }

}
