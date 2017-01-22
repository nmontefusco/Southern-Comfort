using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

public static GameObject selectedDefender;
public GameObject defenderPrefab;

private Button[] buttonArray;


	void Start()
	{
	   buttonArray=GameObject.FindObjectsOfType<Button>();
		foreach(Button thisButton in buttonArray) {
	 thisButton.GetComponent<SpriteRenderer>().color = Color.black;
	 }
	}


	void Update () 
	{
		
	}

	void OnMouseDown()

	{
	 

	 foreach(Button thisButton in buttonArray) {
	 thisButton.GetComponent<SpriteRenderer>().color = Color.black;
	 }
		GetComponent<SpriteRenderer>().color= Color.white;
		selectedDefender= defenderPrefab;
	}
}
