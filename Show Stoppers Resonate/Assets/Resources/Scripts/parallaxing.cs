using UnityEngine;
using System.Collections;

public class parallaxing : MonoBehaviour {
	
	public Transform[] backgrounds;			//Array of all the back and for grounds 
	private float[] parrallaxScale;			//The proportion of the cameras movement to move the backgrounds by
	public float smoothing = 1f;			//How smooth the parralax is going to be (always above)
	
	private Transform cam;					//Main cameras transform
	private Vector3 previousCamPos;			//Store the cams pos in the previous frame
	
	//Called before start
	void Awake ()
	{
		//Set cameras reffrence
		cam = Camera.main.transform;
		
	}
	
	// Use this for initialization
	void Start () 
	{
		//Previous frame at current frames pos
		previousCamPos = cam.position;
		
		//assigning the correct parallaxscales
		parrallaxScale = new float[backgrounds.Length];
		
		for (int i = 0; i < backgrounds.Length; i++) 
		{
			parrallaxScale[i] = backgrounds[i].position.z*-1;
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		//for each background
		for (int i = 0; i < backgrounds.Length; i++) 
		{
			// The parrallax is the opposite of the camera 
			float parallax = (previousCamPos.x - cam.position.x) * parrallaxScale[i];
			
			//set a target x pos which is the current pos + the parrallax
			float backgroundTargetPosX = backgrounds[i].position.x + parallax;
			
			//create a target pps which is the background's current position with its target x position
			Vector3 backgroundTargetpos = new Vector3 (backgroundTargetPosX,backgrounds[i].position.y, backgrounds[i].position.z);
			
			// fade between current position and teh target position using lerp
			backgrounds[i].position = Vector3.Lerp (backgrounds[i].position, backgroundTargetpos, smoothing * Time.deltaTime);
		}
		
		//set the previousCamPos to the cameras position at the end of the frame
		previousCamPos = cam.position;
	}
	
}
