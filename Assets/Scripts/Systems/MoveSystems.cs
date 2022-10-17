using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSystems : MonoBehaviour {

    [Ecsact.DefaultSystemImpl(typeof(example.UpdatePosition))]
    public static void UpdatePosition
        ( EcsactRuntime.SystemExecutionContext context
        )
    {
        var position = context.Get<example.Position>();
        var velocity = context.Get<example.Velocity>();

        position.prev_x = position.x;
        position.prev_y = position.y;

        position.x += velocity.x_value;
        position.y += velocity.y_value;

        context.Update<example.Velocity>(velocity);
        context.Update<example.Position>(position);
    }

    [Ecsact.DefaultSystemImpl(typeof(example.UpdateVerticalVelocity))]
    public static void UpdateVerticalVelocity
        ( EcsactRuntime.SystemExecutionContext context
        )
    {
        var moving = context.Get<example.VerticalMoving>();
        var velocity = context.Get<example.Velocity>();

        var force = moving.value * velocity.force;

        velocity.y_value += force;
        context.Update<example.Velocity>(velocity);
    }

    [Ecsact.DefaultSystemImpl(typeof(example.UpdateHorizontalVelocity))]
    public static void UpdateHorizontalVelocity
        ( EcsactRuntime.SystemExecutionContext context
        )
    {
        var moving = context.Get<example.HorizontalMoving>();
        var velocity = context.Get<example.Velocity>();

        var force = moving.value * velocity.force;

        velocity.x_value += force;
        context.Update<example.Velocity>(velocity);
    }

    [Ecsact.DefaultSystemImpl(typeof(example.StartVerticalMove))]
    public static void StartVerticalMove
        ( EcsactRuntime.SystemExecutionContext context
        )
    {
        var action = context.Action<example.StartVerticalMove>();

        context.Add<example.VerticalMoving>(new example.VerticalMoving{
            value = action.y_change,
        });
    }

    [Ecsact.DefaultSystemImpl(typeof(example.StopVerticalMove))]
    public static void StopVerticalMove
        ( EcsactRuntime.SystemExecutionContext context
        )
    {
        context.Remove<example.VerticalMoving>();
    }

    [Ecsact.DefaultSystemImpl(typeof(example.StartHorizontalMove))]
    public static void StartHorizontalMove
        ( EcsactRuntime.SystemExecutionContext context
        )
    {
        var action = context.Action<example.StartHorizontalMove>();

        context.Add<example.HorizontalMoving>(new example.HorizontalMoving {
            value = action.x_change
        });
    }

    [Ecsact.DefaultSystemImpl(typeof(example.StopHorizontalMove))]
    public static void StopHorizontalMove
        ( EcsactRuntime.SystemExecutionContext context
        )
    {
        context.Remove<example.HorizontalMoving>();
    }
}
