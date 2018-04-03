using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "MovePattern")]
public class MovePattern : ScriptableObject {
	public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
	private Vector3 moveDirection = Vector3.zero; 
    public InputBace Inputx;
    public InputBace Inputy;
    public InputBace Inputz;

public void Move(CharacterController controller, Transform mytransform)
{
	 if (controller.isGrounded) {
            moveDirection.x = Inputx.SetFloat();
            moveDirection.z = Inputz.SetFloat();
            moveDirection.y = Inputy.SetFloat();
            moveDirection = mytransform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;
            
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
}

}
