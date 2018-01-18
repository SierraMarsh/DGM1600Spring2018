using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {

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
