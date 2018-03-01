using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpTrigger : MonoBehaviour {

	public Powerup MyPowerUp;

void OnTriggerEnter()
{
	AddPower(MyPowerUp);
}

void AddPower (Powerup powerup)
{
	print(powerup.PowerLevel);
}
}
