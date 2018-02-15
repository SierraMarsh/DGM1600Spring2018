using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ui;

public class ListsandLoops : MonoBehaviour {
public TheIncredibles TheIncredibles;
public Text AddMember;

private void OnMouseDown()
{
	TheIncredibles.FamilyList.Add(AddMember.Text);
}


}
