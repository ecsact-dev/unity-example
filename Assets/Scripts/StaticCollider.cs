using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticCollider : MonoBehaviour
{
    int entityId;
    EcsactRuntime rt;
    Ecsact.DefaultFixedRunner runner;

    void Start() {
        runner = FindObjectOfType<Ecsact.DefaultFixedRunner>();
        rt = EcsactRuntime.GetOrLoadDefault();

        entityId = rt.core.CreateEntity(runner.registryId);

        var xScale = System.Convert.ToInt32(gameObject.transform.localScale.x);
        var yScale = System.Convert.ToInt32(gameObject.transform.localScale.y);

        var xPos = (int)gameObject.transform.position.x;
        var yPos = (int)gameObject.transform.position.y;

        rt.core.AddComponent<example.Collider>(
            runner.registryId,
            entityId,
            new example.Collider{
                x_radius = xScale,
                y_radius = yScale
            }
        );

        rt.core.AddComponent<example.Position>(
            runner.registryId,
            entityId,
            new example.Position{
                x = xPos,
                y = yPos
            }
        );
    }
}
