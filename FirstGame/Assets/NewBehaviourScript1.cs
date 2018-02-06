using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour {



public Powerup MyPowerUp;


 void OnMouseDown()
{
 if (MyPowerUp.Powerlevel >= 100)	
{ print("I have the POWER!!!");
}
	}
}
