using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			if (!other.GetComponentInChildren<BackPack> ().itemInHands) {
				GetComponent<Rigidbody> ().isKinematic = true;
				transform.parent = other.GetComponentInChildren<BackPack> ().transform;
				transform.position = transform.parent.position;
				transform.rotation = other.GetComponentInChildren<BackPack> ().transform.rotation;
				GetComponent<BoxCollider> ().isTrigger = false;
				if (GetComponent<Throwable> () != null) {
					GetComponent<Throwable> ().SetThrowable (true);
				}
				other.GetComponentInChildren<BackPack> ().itemInHands = true;
			} else {
			}

		}
	}
}
