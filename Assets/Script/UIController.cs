using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

	public enum MenuState{

		Game_Play = 0,
		Start_Game = 1,
		Game_Over = 2,
	}

	[SerializeField]
	private GameObject level, gamePlay, start, gameOver;
	[SerializeField]
	private Text playerOneScoreFinal, playerTwoScoreFinal;

	private MenuState menuState;

	public void DisplayMainMenu()
	{
		start.SetActive (true);
		gameOver.SetActive (false);
		gamePlay.SetActive (false);
		level.SetActive (false);
		menuState = MenuState.Game_Play;
	}

	public void DisplayStartGame()
	{
		start.SetActive (false);
		gameOver.SetActive (false);
		gamePlay.SetActive (true);
		level.SetActive (true);
		menuState = MenuState.Start_Game;
	}


	public void DisplayGameOver()
	{
		start.SetActive (false);
		gameOver.SetActive (true);
		gamePlay.SetActive (false);
		level.SetActive (false);
		menuState = MenuState.Game_Over;
	}

	public MenuState State
	{
		get{
			return menuState;
		}
	}

	public int PlayerOneScoreFinal
	{
		set{
			playerOneScoreFinal.text = value.ToString ();
		}
	}

	public int PlayerTwoScoreFinal
	{
		set{
			playerTwoScoreFinal.text = value.ToString ();
		}
	}
}
