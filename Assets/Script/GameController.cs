using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	[SerializeField] private PlayerController playerController;
	[SerializeField] private CustomerSpawner customerSpawner;

	private UIController uIController;

	private List<Plate> plate = new List<Plate> ();
	private List<ChoppingBoard> choppingBoard = new List<ChoppingBoard> ();

	private void Awake()
	{
		uIController = GetComponent<UIController> ();
	}


	private void Start()
	{
		GameObject[] plateObj = GameObject.FindGameObjectsWithTag (Tags.PLATE);
		foreach(GameObject obj in plateObj)
		{
			plate.Add (obj.GetComponent<Plate>());
		}

		GameObject[] choppingBoardObj = GameObject.FindGameObjectsWithTag (Tags.CHOPPING_BOARD);
		foreach(GameObject obj in choppingBoardObj)
		{
			choppingBoard.Add (obj.GetComponent<ChoppingBoard>());
		}

		StopGame ();
		uIController.DisplayMainMenu ();
	}

	private void Update()
	{

//		if(uIController.State == UIController.MenuState.Start_Game && !playerController.CanPlayersMove)
//		{
//			StopGame ();
//			uIController.PlayerOneScoreFinal = playerController.PlayerOneScore;
//			uIController.PlayerTwoScoreFinal = playerController.PlayerTwoScore;
//			uIController.DisplayGameOver ();
//
//		}
	}

	private void ResetGame()
	{
		playerController.Reset ();
		customerSpawner.Reset ();
		foreach (ChoppingBoard board  in choppingBoard) board.Reset ();
		foreach (Plate plates in plate) plates.Reset ();
		
	}

	private void StopGame()
	{
		playerController.StopPlayers (true);
		customerSpawner.ToSpawn = false;
	}

	public void StartGame()
	{
		ResetGame ();
		playerController.StopPlayers (false);
		customerSpawner.ToSpawn = true;
	}
}
