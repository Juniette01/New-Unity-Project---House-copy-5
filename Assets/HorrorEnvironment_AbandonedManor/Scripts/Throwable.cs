using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Throwable : MonoBehaviour {
	public bool readyToThrow;
	public Text powerMeter;
	private float forceAmount;

	// Use this for initialization
	void Start () {
		readyToThrow = false;
	}

	public void SetThrowable(bool canThrow) {
		readyToThrow = canThrow;
	}

	void ResetTrigger() {
		GetComponent<BoxCollider> ().isTrigger = true;
		readyToThrow = false;
	}

	// Update is called once per frame
	void Update () {
		if (readyToThrow) {
			if (Input.GetKeyDown (KeyCode.LeftControl)) {
				forceAmount = 0f;
				GetComponentInParent<BackPack> ().itemInHands = false;
				transform.parent = null;
			}
			if (Input.GetKey (KeyCode.LeftControl)) {
				//make the force continuous
				forceAmount = forceAmount + .5f;
				powerMeter.text = forceAmount.ToString("FORCE AMOUNT: 0");
			}
			if (Input.GetKeyUp (KeyCode.LeftControl)) {
//				GetComponent<Rigidbody> ().AddForce (transform.forward * 25f, ForceMode.Acceleration);
				//one time hit
				GetComponent<Rigidbody> ().isKinematic = false;
				GetComponent<Rigidbody> ().AddForce (transform.forward * forceAmount, ForceMode.Impulse);
				Invoke ("ResetTrigger", 1);
			}
		}
			
	}
}
