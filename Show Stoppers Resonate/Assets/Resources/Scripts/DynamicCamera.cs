using UnityEngine;
using System.Collections;

public class DynamicCamera : MonoBehaviour {

	//Minimum and Maximum x coordinates to create the viewport rect
	float minXval;
	float maxXval;

	//Minimum and Maximum y coordinates to create the viewport rect
	float minYval;
	float maxYval;

	//List of Player Gameobjects that can be referenced to define maximum and minimum x,y values
	public GameObject[] players;

	//Fixed camera size
	float camSize = 5.0f;

	//Camera options for greater control
	public float camSpeed = 2.0f;
	public float camDistance = 10.0f;
	public Vector2 cameraBuffer = new Vector2(0,2);

	//Display values
	public Vector3 finalLookAt = new Vector3 (0, 0, 0);
	public Vector3 position = new Vector3 (0, 0, 0);

	// Use this for initialization
	void Start () 
	{
		Debug.Log ("Camera Script Active");
	}
	
	void LateUpdate () 
	{
		//Define the maximum and minimum (x,y) coordinates for the camera according to the players' positions in the scene
		CalculateBounds();

		//Implement the (x,y) coordinates for the viewport and implement camera controls
		CalculateCameraPosAndSize();

	}

	void CalculateBounds()
	{
		//Set x maximums as infinity, set x minimums as negative infinity
		minXval = Mathf.Infinity;
		maxXval = -Mathf.Infinity;

		//Set y maximums as infinity, set y minimums as negative infinity
		minYval = Mathf.Infinity;
		maxYval = -Mathf.Infinity;

		//Find all active players in the scene 
		players = GameObject.FindGameObjectsWithTag ("Player");

		//Per player active in the scene
		foreach (GameObject player in players) 
		
		{
			//Player's current position in the scene is stored in tempPlayer
			Vector3 tempPlayer = player.transform.position;

			//Calculate x boundries according to the position saved in tempPlayer
			if (tempPlayer.x < minXval)
				minXval = tempPlayer.x;

			if (tempPlayer.x > maxXval)
				maxXval = tempPlayer.x;

			//Calculate y boundries according to the position saved in tempPlayer
			if (tempPlayer.y < minYval)
				minYval = tempPlayer.y;

			if (tempPlayer.y > maxYval)
				maxYval = tempPlayer.y;
		}
	}

	void CalculateCameraPosAndSize()
	{ 
		//Create an anchor point for the camera
		Vector3 cameraCenter = Vector3.zero;

		foreach (GameObject player in players) 
		{
			cameraCenter += player.transform.position;
		}

		Vector3 finalCameraCenter = cameraCenter / players.Length;

		//Rotation to define camera position
		Quaternion rotate;
		rotate = Quaternion.Euler(0,0,0);

		//Positions camera around point
		position = rotate * new Vector3(0f, 0f, -camDistance) + finalCameraCenter; 

		transform.rotation = rotate;

		transform.position = Vector3.Lerp(transform.position, position, camSpeed * Time.deltaTime);

		finalLookAt = Vector3.Lerp (finalLookAt, finalCameraCenter, camSpeed * Time.deltaTime);

		transform.LookAt(finalLookAt);

		//Define the camera x,y values
		float sizeX = maxXval - minXval + cameraBuffer.x;
		float sizeY = maxYval - minYval + cameraBuffer.y;
		camSize = (sizeX > sizeY ? sizeX : sizeY);

		//camera.orthographicSize = camSize * 0.5f;

	}

}
