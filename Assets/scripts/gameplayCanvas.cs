using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameplayCanvas : MonoBehaviour {

	public static gameplayCanvas instance;
	public GameObject directionalLight;
	public monster[] monsters;
	public Text txtToys;
	public string toysString;
	public int toysTotal = 3;
	private int toysFound = 0;

	//youwinttext
	public GameObject youWinText;
	//reset
	public float resetDelay;

	//sound
	public AudioSource collectSource;

	void Awake()
	{
		instance = this;

	}

	// Use this for initialization
	void Start () {

		updateCanvas ();

		//sound
		collectSource = GetComponent<AudioSource> ();
	}

	public void updateCanvas()
	{
		toysString = toysFound.ToString () + "/" + toysTotal.ToString ();
		txtToys.text = toysString;
	}


	public void findToy()
	{
		toysFound++;
		updateCanvas ();
		//sound
		collectSource.Play ();

		//win
		if (toysFound >= toysTotal) {
			directionalLight.SetActive(true);

			for (int n = 0; n < monsters.GetLength (0); n++) 
			{
				monsters [n].death ();
			}


			//win message
			youWinText.SetActive (true);

			//slow down time
			Time.timeScale = .5f;
			//restart game
			Invoke("Reset", resetDelay);


		}


	}




	//reset function
	void Reset ()
	{
		Time.timeScale = 1f;
		//Application.LoadLevel (Application.loadedLevel);
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);

	}

}


