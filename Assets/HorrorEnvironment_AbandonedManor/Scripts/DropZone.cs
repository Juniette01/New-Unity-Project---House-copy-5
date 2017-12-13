using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropZone : MonoBehaviour {
	public GameObject droppedObjectPlacement;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.GetComponent<Droppable>() != null) {
			other.GetComponentInParent<BackPack> ().itemInHands = false;
			other.gameObject.transform.parent = droppedObjectPlacement.transform;
			other.gameObject.transform.localPosition = new Vector3 (0, 0, 0);
			Debug.Log ("Dropped Item");
			Debug.Log ("Game Object Other: " + other.name);
			other.GetComponent<BoxCollider> ().isTrigger = true;
			if (other.GetComponent<Throwable> () != null) {
				other.GetComponent<Throwable> ().SetThrowable (false);
			}

		}
	}



}
