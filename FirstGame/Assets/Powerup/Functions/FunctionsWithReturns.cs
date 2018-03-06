using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsWithReturns : MonoBehaviour {
	public int Health;

	public int AddHealth(int value)
	{
		print("Hello There");
		//move a character
		return Health += value;
	}

	private void OnMouseDown()
	{
		Health = AddHealth(10);
		Players.Add(NewPLayer("Bob"));
	}

public List<string> Players;

public List<string> NewPLayers()
{
	return new List<string>();
}

public string NewPLayer (string name)
{
	return "name";
}

}