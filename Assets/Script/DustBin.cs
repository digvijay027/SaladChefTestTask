using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustBin : MonoBehaviour {

	public void OnInteract(Player player){
		if(player.ThrowInDustbin()){
			player.IncrementScore(Constants.ANGRY_CUSTOMER_PENALTY);
		}
	}
}
