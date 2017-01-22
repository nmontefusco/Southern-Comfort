using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {

private levelManager LevelManager;
 
	// Use this for initialization
	void Start () 
	{
	   LevelManager= GameObject.FindObjectOfType<levelManager>();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D() 
	{
	   LevelManager.Loadlevel("Lose");
	}
}
