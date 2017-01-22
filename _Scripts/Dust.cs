﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Attacker))]




public class Dust : MonoBehaviour {


private Animator anim;
private Attacker attacker;

	// Use this for initialization
	void Start () {

         anim= GetComponent<Animator>();
	 attacker = GetComponent<Attacker>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D collider) 
	{
	 GameObject obj= collider.gameObject;

	 if (!obj.GetComponent<Defenders>())
		{
		  return;
		}
		anim.SetBool("Is_Attacking",true);
	        attacker.Attack(obj);
	        }
}
