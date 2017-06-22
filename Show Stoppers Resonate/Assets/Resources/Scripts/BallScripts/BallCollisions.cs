using UnityEngine;
using System.Collections;

public class BallCollisions : MonoBehaviour {

	public bool pickUp;
	public bool gotBall;

	public int lastHad;

	public GameObject Ball;



	void Start()
	{
		pickUp = false;
		gotBall = false;
		//Ball = GameObject.Find ("Ball");
		print ("hello");
	}

	void Update()
	{

		Ball = GameObject.Find ("Ball");
	}
}
