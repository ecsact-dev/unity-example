using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddBlock 
    : MonoBehaviour
    , Ecsact.UnitySync.IOnInitComponent<example.Block>
    , Ecsact.UnitySync.IOnInitComponent<example.Position>
{
    GameObject blockObj; 

    void Awake() {
        blockObj = Resources.Load("Block") as GameObject;
    }

    public void OnInitComponent(in example.Block component) {
    }

    public void OnInitComponent(in example.Position component) {
        Instantiate(
            blockObj,
            gameObject.transform.position,
            Quaternion.identity,
            gameObject.transform
        );
    }
}