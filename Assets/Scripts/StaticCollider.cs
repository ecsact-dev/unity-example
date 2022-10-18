using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticCollider : MonoBehaviour
{
    int entityId;

    void Start() {
        entityId = Ecsact.Defaults.Registry.CreateEntity();

        var xScale = System.Convert.ToInt32(gameObject.transform.localScale.x);
        var yScale = System.Convert.ToInt32(gameObject.transform.localScale.y);

        var xPos = (int)gameObject.transform.position.x;
        var yPos = (int)gameObject.transform.position.y;

        Ecsact.Defaults.Registry.AddComponent<example.Collider>(
            entityId,
            new example.Collider{
                x_radius = xScale,
                y_radius = yScale
            }
        );

        Ecsact.Defaults.Registry.AddComponent<example.Position>(
            entityId,
            new example.Position{
                x = xPos,
                y = yPos
            }
        );
    }
}
