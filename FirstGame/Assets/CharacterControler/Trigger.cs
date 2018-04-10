﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

	public Powerup Powerup;
	private void OnTriggerEnter(Collider obj)
	{
        obj.GetComponent<MoveCharacter>().MovePattern = Powerup.MovePattern;
		gameObject.SetActive(false);
	}

}
