using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Febuary8thPowerup : ScriptableObject {

public int Powerlevel = 10;
public void RunPowerUP ()
{
//Adds Value 
Debug.Log(Powerlevel);
}

//Here is what I understand about Math operators, its suprisingly alot given that I flunked Math 1060. The whole A + B = C makes prefect sense to me.
//In the game I feel that this is super useful because really what we are doing is adding a shifting element to our game by have causitional elements
//that numarically work. So in this case we tell the program first what the rules are that would be our formula, saying run these numbers to feed the object 
//this results. BAsically making actions have consequince in the game. It will run through the formula in the order it finds it. 
// So we could have (A + B ==C) which is just producing a sum. of course we need to define the variables which would have been done first. 
//If that didnt do what we wanted we could get rid of it or  add to it (A + B =-C) or (A + B =+ C) BAsically having the system churn out a number.
//(C > A - B)
//if we want to devide it has to make a whole number as a int (A / B == 2) (I feel like this will always make it 2?)
//(C =< A = B)
//


}
