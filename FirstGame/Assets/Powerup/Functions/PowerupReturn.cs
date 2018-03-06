using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupReturn : MonoBehaviour {

	public Player CurrentPlayer;

	public int PowerLevel = 10;

	public int PowerLevelIncrease = 2;

	public int IncreasePowerLevel()
	{
		PowerLevel += PowerLevelIncrease;
		PowerLevel *= PowerLevelIncrease;
		return PowerLevel;
	}
private void OnMouseDown()
{
	CurrentPlayer.Health = IncreasePowerLevel();
}


}
