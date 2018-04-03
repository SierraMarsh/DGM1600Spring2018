using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour {

    public MovePattern MovePattern; 
    private CharacterController controller;
       private Vector3 moveDirection = Vector3.zero;

    public void Start () {
 controller = GetComponent<CharacterController>();
    }

    void Update() {
        MovePattern.Move(controller, transform);
        
    }
}
