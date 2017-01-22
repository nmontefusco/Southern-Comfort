using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defenders : MonoBehaviour {

public int eggCost= 100;
private eggDisplay EggDisplay;

void Start() 
   {
     EggDisplay= GameObject.FindObjectOfType<eggDisplay>();

   }
	public void AddEggs(int amount) 
	{
	 EggDisplay.AddEggs(amount);
	}
}
