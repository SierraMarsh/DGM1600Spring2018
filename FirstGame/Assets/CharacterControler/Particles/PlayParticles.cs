﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayParticles : MonoBehaviour {
	public ParticleSystem ParticleSystem;
	private void private void OnTriggerEnter(Collider other)
	{
		ParticleSystem.emit(100);
	}


}