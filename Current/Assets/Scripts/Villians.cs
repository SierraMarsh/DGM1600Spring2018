using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villians : MonoBehaviour {

  
    void Start () 
    {
        string[] strings = new string[3];
        
        strings[0] = "Dr. Evil";
        strings[1] = "Dr. Chaos";
        strings[2] = "Minion";
        
        foreach(string item in strings)
        {
            print ("Bite Me");
        }
    }
}

