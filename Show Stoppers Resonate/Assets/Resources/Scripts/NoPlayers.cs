using UnityEngine;
using System.Collections;

public class NoPlayers : MonoBehaviour {

	public int numPlayers;

	public void PlayerNumners(int numPlayers)
	{
		switch (numPlayers) 
		{
			case 1: print ("There is 1 player");
				break;
			default: print ("There are no player");
				break;
		}
	}
}
