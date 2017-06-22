using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour
{
	float velocityX;
	public Vector2 initialVelocity = new Vector2 (0.01f, 0f);
	

	private Rigidbody2D body2d;

	void Awake()
	{
		body2d = GetComponent<Rigidbody2D> ();
	}

	void Start()
	{

		var startVelX = initialVelocity.x * transform.localScale.x;

		body2d.velocity = new Vector2 (startVelX, initialVelocity.y);
	}
}
