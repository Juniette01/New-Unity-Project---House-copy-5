using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour {

	public Transform Spawnpoint;
	public GameObject Prefab;

	// Use this for initialization
	void OnTriggerEnter () {
		Instantiate (Prefab, Spawnpoint.position, Spawnpoint.rotation);
	}
}