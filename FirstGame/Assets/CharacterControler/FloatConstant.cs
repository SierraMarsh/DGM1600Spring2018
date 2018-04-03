using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class FloatConstant : InputBace {
	public float FloatValue = 0;
public override float SetFloat()
{
	return FloatValue;
}
}
