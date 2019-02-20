using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
	int min = 1;
	int max = 1000;
	int guess = 500;
	// Start is called before the first frame update
	void Start()
	{
		StartGame();
	}

	void StartGame()
	{
		min = 1;
		max = 1000;
		guess = 500;
		Debug.Log("Welcome to number wizard, yo");
		Debug.Log("Please choose a number between:\n" + min + " and " + max);
		Debug.Log("Tell me if your number is higher or lower than " + guess);
		Debug.Log("Push up = Higher, Push Down = Lower, Push Enter = Correct");
		max = max + 1;
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			min = guess;
			NextGuess();
		}
		else if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			max = guess;
			NextGuess();
		}
		else if (Input.GetKeyDown(KeyCode.Return))
		{
			Debug.Log("Yes, " + guess + " is my number");
			StartGame();
		}
	}
	void NextGuess()
	{
		guess = (max + min) / 2;
		Debug.Log("Is it higher or lower than " + guess);
	}
}
