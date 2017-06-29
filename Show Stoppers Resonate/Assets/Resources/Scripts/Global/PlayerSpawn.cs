using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour {

    public int spawnID;

    public GameObject PrefabManager;
    public PrefabManager prefabManagerScript;
    
    // Use this for initialization
    void Start ()
    {
      // Instantiate(prefabManagerScript.Prefabs[spawnID], gameObject.transform.position);

    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
