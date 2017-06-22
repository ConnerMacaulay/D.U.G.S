using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour {

	public GameObject ballStateObj;
	public BallCollisions ballState;

	public GameObject Platforms;

	// Use this for initialization
	void Start () 
	{
		Platforms = GameObject.Find ("Platforms");
		gameObject.transform.parent = Platforms.transform; 
		ballStateObj = GameObject.Find ("BallState");
		ballState = ballStateObj.GetComponent<BallCollisions> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnCollisionEnter2D (Collision2D other)
	{
		if(other.gameObject.tag == "ball")
		{
			ballState.pickUp = true;
			return;
		}
	}
}
