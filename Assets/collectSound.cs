using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectSound : MonoBehaviour {

	public AudioSource collectSource;

	// Use this for initialization
	void Start () {
		collectSource = GetComponent<AudioSource> ();
	}
	


	void OnCollisionEnter (Collision collision){
		if (collision.gameObject.tag == "Player") {
			collectSource.Play ();
		}

	}
}
