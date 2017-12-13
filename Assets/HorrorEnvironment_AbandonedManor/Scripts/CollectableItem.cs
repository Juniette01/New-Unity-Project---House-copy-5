using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableItem : MonoBehaviour {
	public int value;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Player") {
			//mesh collider is on child objectm, otherwise we'd use other.gameObject
			Destroy (gameObject);
		
		}
			
	}
}
