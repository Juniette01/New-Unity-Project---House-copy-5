using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Target : MonoBehaviour 
{

	public float health = 30f;
	               
	public float sinkSpeed = 2.5f;              // The speed at which the enemy sinks through the floor when dead.
	public int scoreValue = 10;                 // The amount added to the player's score when the enemy dies.
	public AudioClip deathClip;                 // The sound to play when the enemy dies.

	public GameObject player;

	UnityEngine.AI.NavMeshAgent nav;

	//deathCam
	public GameObject deathCam;


	//private bool alive = true;



	Animator anim;                              // Reference to the animator.
	AudioSource enemyAudio;                     // Reference to the audio source.
              
	CapsuleCollider capsuleCollider;            
	                                           
	//bool isSinking;   

	void Awake ()
	{
		
		anim = GetComponent <Animator> ();
		enemyAudio = GetComponent <AudioSource> ();
		capsuleCollider = GetComponent <CapsuleCollider> ();

	}

	void Start()
	{
		nav = GetComponent<UnityEngine.AI.NavMeshAgent> ();
	}

	void Update ()
	{


		// If the enemy should be sinking...
//		if(isSinking)
//		{
//			// ... move the enemy down by the sinkSpeed per second.
//			transform.Translate (-Vector3.up * sinkSpeed * Time.deltaTime);
//		}
//		
			


	}

	public void TakeDamage (float amount)
	{
//		if(isDead)
//			// ... no need to take damage so exit the function.
//			return;

		// Play the hurt sound effect.
		enemyAudio.Play ();
		//		enemyAudio.clip = deathClip;

		health -= amount;
		if (health <= 0f) 
		{
			Die ();
		}
	}




	void Die ()
	{

		enemyAudio.clip = deathClip;
		enemyAudio.Play ();

		// The enemy is dead.
		//isDead = true;

		// Turn the collider into a trigger so shots can pass through it.
		capsuleCollider.isTrigger = true;

		// Tell the animator that the enemy is dead.
		anim.SetTrigger ("dead");
		anim.speed = 2f;
		nav.isStopped = true;


		//turn off monster script to fix camera issue
		GetComponent<monster> ().enabled = false;

		Destroy (gameObject, 2f);

	}


	//	public void StartSinking ()
	//	{
	//		// Find and disable the Nav Mesh Agent.
	//		GetComponent <UnityEngine.AI.NavMeshAgent> ().enabled = false;
	//
	//		// Find the rigidbody component and make it kinematic (since we use Translate to sink the enemy).
	//		GetComponent <Rigidbody> ().isKinematic = true;
	//
	//		// The enemy should no sink.
	//		isSinking = true;
	//
	//		// Increase the score by the enemy's score value.
	//		//commenting this scoremanager out for now
	//		//ScoreManager.score += scoreValue;
	//
	//		// After 2 seconds destory the enemy.
	//		Destroy (gameObject, 2f);
	//	}

}
