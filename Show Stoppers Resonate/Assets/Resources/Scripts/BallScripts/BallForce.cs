using UnityEngine;
using System.Collections;

public class BallForce : MonoBehaviour {

	public GameObject ballStateObj;
	public BallCollisions ballState;
    public Rigidbody2D rb2D;
	
	public float fireSpeed = 5000; 

	void Start()
	{
        rb2D = GetComponent<Rigidbody2D>();
		ballState = ballStateObj.GetComponent<BallCollisions>();
		ballStateObj = GameObject.Find ("BallState");

		rb2D.AddForce (new Vector2 (fireSpeed, 0));
	}
}
