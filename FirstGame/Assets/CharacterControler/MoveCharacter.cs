using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour {

    public Player Player; 
    private CharacterController controller;
       private Vector3 moveDirection = Vector3.zero;

    public void Start () {
 controller = GetComponent<CharacterController>();
    }

    void Update() {
        Player.MovePattern.Move(controller, transform);
        
    }
}
