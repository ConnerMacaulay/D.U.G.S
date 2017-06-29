using UnityEngine;
using System.Collections;

public class BallCollisions : MonoBehaviour {

   	public bool pickUp;
	public bool gotBall;

	public int lastHad;

	public GameObject Ball;
    public int collide;


    void Start()
	{
		pickUp = false;
		gotBall = false;
        collide = 0;
	}

	void Update()
	{
        if (collide >= 2)
        {
            collide = 0;
            pickUp = true;
        }
        
		Ball = GameObject.Find ("Ball");
	}
}
