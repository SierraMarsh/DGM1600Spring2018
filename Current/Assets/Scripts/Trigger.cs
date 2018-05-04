using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {
public float PowerUp = 0.2;

	public Powerup Powerup;
	private void OnTriggerEnter(Collider obj)
	{ 
		if (HealthBar.fillAmount += PowerUp)
		if (HealthBar.fillAmount > 0)
		

	
        obj.GetComponent<MoveCharacter>().Player.MovePattern = Powerup.MovePattern;
		gameObject.SetActive(false);
	
	}
	
}
