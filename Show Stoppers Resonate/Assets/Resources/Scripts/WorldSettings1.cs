using UnityEngine;
using System.Collections;

public class WorldSettings1 : MonoBehaviour {

    public AudioSource audio;
	public AudioClip bell;
	public AudioClip applause;

	public int activePlayers = 0;

	public GameObject player;
	public Player p;
	public GameObject player1;
	public Player1 p1;
	public GameObject player2;
	public Player2 p2;
	public GameObject player3;
	public Player3 p3;

	// Use this for initialization
	void Start () 
	{
        audio = GetComponent<AudioSource>();

		player = GameObject.Find ("player");
		p = player.GetComponent<Player>();
		player1 = GameObject.Find ("player1");
		p1 = player1.GetComponent<Player1>();
		player2 = GameObject.Find ("player2");
		p2 = player2.GetComponent<Player2>();
		player3 = GameObject.Find ("player3");
		p3 = player3.GetComponent<Player3>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (p.playerStatus == true && p1.playerStatus == false && p2.playerStatus == false
		    && p3.playerStatus == false) 
		{
			audio.clip = applause;
			audio.Play();
			StartCoroutine(Win());
			print ("player 1 win");
		}
		
		else if (p.playerStatus == false && p1.playerStatus == true && p2.playerStatus == false
		         && p3.playerStatus == false) 
		{
			audio.clip = applause;
			audio.Play();
			StartCoroutine(Win());
			print ("player 2 win");
		}
		
		else if (p.playerStatus == false && p1.playerStatus == false && p2.playerStatus == true
		         && p3.playerStatus == false) 
		{
			audio.clip = applause;
			audio.Play();
			StartCoroutine(Win());
			print ("player 3 win");
		}
		
		else if (p.playerStatus == false && p1.playerStatus == false && p2.playerStatus == false
		         && p3.playerStatus == true) 
		{
			audio.clip = applause;
			audio.Play();
			StartCoroutine(Win());
			print ("player 4 win");
		}
	}

	IEnumerator Win()
	{
		audio.clip = bell;
		audio.Play();
		yield return new WaitForSeconds(2);
		Application.LoadLevel ("RoundScreen02");
	}


}


//Another object for loop it
