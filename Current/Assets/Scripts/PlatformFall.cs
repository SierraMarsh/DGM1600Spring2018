using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformFall : MonoBehaviour {
 
     public float timeToDestroy = 10.0f;
     
     void OnCollisionEnter(Collision c){
         if(c.gameObject.name.Equals("Platform")){
             Destroy(c.gameObject, timeToDestroy);
         }
     }
 }
