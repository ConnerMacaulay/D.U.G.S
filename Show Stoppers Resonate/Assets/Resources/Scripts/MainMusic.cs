using UnityEngine;
using System.Collections;

public class MainMusic : MonoBehaviour 
{
    public AudioSource audio;
	static bool AudioBegin = false; 
	void Awake()
	{
        audio = GetComponent<AudioSource>();
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
