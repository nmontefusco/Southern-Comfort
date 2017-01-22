using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class eggDisplay : MonoBehaviour {

private Text eggText;
private int eggs = 100;
public enum Status {SUCCESS,FAILURE};
	// Use this for initialization

   void Start () 
   {
     eggText= GetComponent<Text>();
     UpdateDisplay();
   }
	


   public void AddEggs(int amount)
	{
	  eggs += amount;
	  UpdateDisplay();
	}

   public Status UseEggs(int amount)
   {
    if(eggs>=amount)
    {
     eggs-=amount;
     UpdateDisplay();
     return Status.SUCCESS;
    }
     return Status.FAILURE; 
    }

   private void UpdateDisplay()
   {
     eggText.text = eggs.ToString();
   }
}
