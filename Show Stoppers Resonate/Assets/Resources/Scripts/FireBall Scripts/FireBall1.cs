using UnityEngine;
using System.Collections;

public class FireBall1 : MonoBehaviour {

	public AudioClip thro;

	Player1 player;
	public GameObject ballStateObj;
	public BallCollisions ballState;
	
	public GameObject PrefabManager;
	public PrefabManager prefabManagerScript;
	
	public GameObject ballPrefab;
	
	public GameObject BallSourceObj;
	public BallForce ballForceScript;

	Vector2 pos;
	
	public GameObject gameObject = null;
	
	// Use this for initialization
	void Start () 
	{
		player = GetComponent<Player1>();
		BallSourceObj = GameObject.Find ("BallSource");
		ballForceScript = BallSourceObj.GetComponent<BallForce>();
		
		ballStateObj = GameObject.Find ("BallState");
		ballState = ballStateObj.GetComponent<BallCollisions>();
		
		PrefabManager = GameObject.Find ("PrefabManager");
		prefabManagerScript = PrefabManager.GetComponent<PrefabManager>();
		
		ballPrefab = prefabManagerScript.Prefabs [0];
	}
	
	// Update is called once per frame
	void Update () 
	{
		pos.x = player.myPos.x +0.0f;
		pos.y = player.myPos.y +3f;
		
		if (player.hasBall == true) 
		{
			if (player.facingRight == true)
			{
				ballForceScript.fireSpeed = 4000;
			}
			if (player.facingRight == false)
			{
				ballForceScript.fireSpeed = -4000;
			}
			
			if (Input.GetButtonDown ("BButton_P2") || Input.GetButtonDown ("BallButton")) 
			{
				audio.clip = thro;
				audio.Play();
				ballState.lastHad = 2;
				GameObject Ball = Instantiate (prefabManagerScript.Prefabs[0]/*call from array her*/, pos, Quaternion.identity) as GameObject;
				Ball.name = "Ball";
				player.hasBall = false;
			}
		}
	}
}