﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multiply : Calculation {
 public override float Calculate (string a, string b)
		{
		aNum = float.Parse(a);
		bNum = float.Parse(b);

			return aNum * bNum;

}
