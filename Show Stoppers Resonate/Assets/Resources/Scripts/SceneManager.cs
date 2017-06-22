using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour 
{
	// Update is called once per frame
	public void ChangeScene (int sceneWanted)
	{
		Application.LoadLevel (sceneWanted);
	}

	public void ExitScene()
	{
		Application.Quit();
	}
}