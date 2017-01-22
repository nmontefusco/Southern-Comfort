using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour {

public float seenEverySeconds;
public float currentSpeed;
private GameObject currentTarget;
private Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(Vector3.left *currentSpeed * Time.deltaTime);
		if(!currentTarget) 
		{
		  animator.SetBool("Is_Attacking",false);
		}
	}

	public void SetSpeed(float speed) 
	{
		currentSpeed= speed;
	}

	//called from the animator at the time of actual attack
	public void StrikeCurrentTarget(float damage) 
	{
	 if(currentTarget)
	 {
	   Health health= currentTarget.GetComponent<Health>();
	   if(health) 
	   {
	    health.dealDamage(damage);
	   }
	 }
	}




	public void Attack(GameObject obj) 
	{
	    currentTarget = obj;
	}



}
