using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSystems : MonoBehaviour {
    [RuntimeInitializeOnLoadMethod]
    static void SetMoveSystems() {
        var rt = EcsactRuntime.GetOrLoadDefault();

        rt.dynamic.SetSystemExecutionImpl<example.UpdatePosition>(ctx => {
            UpdatePosition(ctx);
        });

        rt.dynamic.SetActionExecutionImpl<example.StartVerticalMove>(ctx => {
            StartVerticalMove(ctx);
        }); 

        rt.dynamic.SetActionExecutionImpl<example.StopVerticalMove>(ctx => {
            StopVerticalMove(ctx);
        });

        rt.dynamic.SetActionExecutionImpl<example.StartHorizontalMove>(ctx => {
            StartHorizontalMove(ctx);
        }); 

        rt.dynamic.SetActionExecutionImpl<example.StopHorizontalMove>(ctx => {
            StopHorizontalMove(ctx);
        });

        rt.dynamic.SetSystemExecutionImpl<example.UpdateVerticalVelocity>(ctx => {
            UpdateVerticalVelocity(ctx);
        });

        rt.dynamic.SetSystemExecutionImpl<example.UpdateHorizontalVelocity>(ctx => {
            UpdateHorizontalVelocity(ctx);
        });
    }

    internal static void UpdatePosition
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

    internal static void UpdateVerticalVelocity
        ( EcsactRuntime.SystemExecutionContext context
        )
    {
        var moving = context.Get<example.VerticalMoving>();
        var velocity = context.Get<example.Velocity>();

        var force = moving.value * velocity.force;

        velocity.y_value += force;
        context.Update<example.Velocity>(velocity);
    }

    internal static void UpdateHorizontalVelocity
        ( EcsactRuntime.SystemExecutionContext context
        )
    {
        var moving = context.Get<example.HorizontalMoving>();
        var velocity = context.Get<example.Velocity>();

        var force = moving.value * 0.1f;

        velocity.x_value += force;
        context.Update<example.Velocity>(velocity);
    }

    internal static void StartVerticalMove
        ( EcsactRuntime.SystemExecutionContext context
        )
    {
        var action = context.Action<example.StartVerticalMove>();

        context.Add<example.VerticalMoving>(new example.VerticalMoving{
            value = action.y_change,
        });
    }

    internal static void StopVerticalMove
        ( EcsactRuntime.SystemExecutionContext context
        )
    {
        context.Remove<example.VerticalMoving>();
    }

    internal static void StartHorizontalMove
        ( EcsactRuntime.SystemExecutionContext context
        )
    {
        var action = context.Action<example.StartHorizontalMove>();

        context.Add<example.HorizontalMoving>(new example.HorizontalMoving {
            value = action.x_change
        });
    }

    internal static void StopHorizontalMove
        ( EcsactRuntime.SystemExecutionContext context
        )
    {
        context.Remove<example.HorizontalMoving>();
    }
}
