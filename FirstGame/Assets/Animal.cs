using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {
	//See comments about what I understand below all scripted functions.

	// Use this for initialization
	//this declares what start will do
	void Start () {
		print("my animal is eating");
		print("now my animal is sleeping.");
		print("I love my cat");
		print("no I really don't");
	}
	void OnMouseDown()
	{
	  print("meow");
	  print("Don't touch me");	
	}

	// Update is called once per frame
	void Update () {
		
	}
}
// Let start with my explination of these > // they seem to mean I can be snarky but to myself and nobody playing my game can see.
//quite honestly I am struggling, at lunch at my variosu jobs i've been reading the C+ plus book but I think im getting stuck between what I thought it would be like and how it is.
//I am having fun though. I understand that if we are going to start a game we have to start with one thing and telling it to do something.
//(monobehavior is biggest box that comes with unity pre-made functions)
//Class means that its about to do something and is enclosed in {}
//a function, like void means your about to name the function and then tell it to do stuff. It knows it is a functions by these ()
//name the function then you can say Start, which means it will run when you start
//and then say something like print which means it will print or write itself in your game when the game does the afformentioned start.
//then tell it what to print
//so print (blah blah blah)'
//  ; these are like periods. they tell the code your done with that part.
//this is all i've got
//I think you should show us something complicated and break it down so we know what yo look for when we are breaking down the simpler parts. 
//Sorry

