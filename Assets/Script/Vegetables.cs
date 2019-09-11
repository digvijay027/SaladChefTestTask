using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vegetables : MonoBehaviour,IInteractable {

	private string vegetableName;

	private void Awake() {
		vegetableName = GetComponentInChildren<TextMesh>().text;
	}

	public void OnInteract(Player player){
		player.AddVegetable(vegetableName);
	}
}
