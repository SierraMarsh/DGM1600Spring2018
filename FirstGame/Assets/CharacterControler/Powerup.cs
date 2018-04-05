using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : ScriptableObject 
{
	public int PowerLevel;
	public MovePattern MovePatternTrasfer;
	public MovePattern Transfer()
	{
		return MovePatternTrasfer;
	}
}


