using UnityEngine;
using System.Collections;

public class BallForce : MonoBehaviour {

	public GameObject ballStateObj;
	public BallCollisions ballState;
	
	public float fireSpeed = 5000; 

	void Start()
	{
		ballState = ballStateObj.GetComponent<BallCollisions>();
		ballStateObj = GameObject.Find ("BallState");

		rigidbody2D.AddForce (new Vector2 (fireSpeed, 0));
	}
}
