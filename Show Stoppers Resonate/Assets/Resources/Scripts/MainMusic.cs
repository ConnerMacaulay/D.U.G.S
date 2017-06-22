using UnityEngine;
using System.Collections;

public class MainMusic : MonoBehaviour 
{
	static bool AudioBegin = false; 
	void Awake()
	{
		if (!AudioBegin) {
			audio.Play ();
			DontDestroyOnLoad (gameObject);
			AudioBegin = true;
		} 
	}
	void Update () 
	{
		if(Application.loadedLevelName == "EndScreen")
		{
			audio.Stop();
			AudioBegin = false;
		}
	}
}
