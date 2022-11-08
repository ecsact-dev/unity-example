using UnityEngine;

public class AddBlock 
	: MonoBehaviour
	, Ecsact.UnitySync.IRequired<example.Position>
	, Ecsact.UnitySync.IRequired<example.Block>
	, Ecsact.UnitySync.IOnInitComponent<example.Position>
{
	GameObject blockObj; 

	void Awake() {
		blockObj = Resources.Load("Block") as GameObject;
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
