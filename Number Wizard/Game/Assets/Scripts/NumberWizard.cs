using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	
	/*
		Numbers don't reset due to the fact 
		max and min are now at the last guessed numbers 
		ie: you complete the game on 761, that will be your max guess.
		as you set max and min in every update it will keep max / min at that 
	*/
	int max;
	int min;
	int guess;
	
	// Use this for initialization
	void Start () {
		StartGame();
	}
	
	void StartGame () {
		max = 1000;
		min = 1;
		guess = Random.Range(min, max);
		
		print("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
		print("Welcome to Number Wizard");
		print("Pick a number in your head. But don't tell me!");
		
		print("The highest number you can pick is "+ max);
		print("The lowest number you can pick is " + min);
		
		print("Is the number lower or higher than " + guess + "?");
		print("Up = higher, Down = lower, Return = equal.");
		
		max = max + 1;
	}
	
	// Update is called once per frame
	void Update () {
		/*
			Using else if instead of multiple if statements
			to only log one key press at a time.
		*/
		if(Input.GetKeyDown(KeyCode.UpArrow)){
			//print("Up Arrow Pressed");
			min = guess;
			NextGuess();
		}else if(Input.GetKeyDown(KeyCode.DownArrow)){
			//print("Down arrow pressed");
			max = guess;
			NextGuess();
		}else if(Input.GetKeyDown(KeyCode.Return)){
			print("I Won!");
			StartGame();
		}
	}
	
	void NextGuess(){
		guess = (max + min) / 2;
		print("Higher or lower than " + guess);
		print("Up = higher, Down = lower, Return = equal.");
	}
}
