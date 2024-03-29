﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : MonoBehaviour {


	private string vegetableName;
	private TextMesh vegetableUI;

	private void Awake() {
		vegetableUI = GetComponentInChildren<TextMesh>();
	}

	public void OnInteract(Player player){

		if(vegetableName == null){
			vegetableName = player.RemoveVegetable();
			if(vegetableName != null) vegetableUI.text = vegetableName;
		}
		else{
			if(player.AddVegetable(vegetableName)){
				Reset();
			}
		}
	}

	public void Reset(){
		vegetableName = null;
		vegetableUI.text = "-";
	}
}
