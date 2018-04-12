using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Trigger : MonoBehaviour {
	public float PowerUp = 0.2
	public Image HealthBar

	public Powerup Powerup;
	private void OnTriggerEnter(Collider obj)
	{ 
		if (HealthBar.FillAmount += PowerUp)
		if (HealthBar.FillAmount > 0)}

	{
        obj.GetComponent<MoveCharacter>().MovePattern = Powerup.MovePattern;
		gameObject.SetActive(false);
	}

}
