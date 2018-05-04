using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour {
     public GameObject Player = GameObject.FindGameObjectWithTag("Player");
 
     void OnCollisionEnter(Collision collision)
     {
         if( collision.gameObject.tag == "Player" )
         {
             Destroy(collision.gameObject);
             GameObject PlayerClone = (GameObject)Instantiate(Player, new Vector3(0,1,0), Quaternion.identity);
         }
     }
 }
