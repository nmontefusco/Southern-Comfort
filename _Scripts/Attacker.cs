using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Attacker : MonoBehaviour {

public float seenEverySeconds;
private float currentSpeed;
private GameObject currentTarget;
private Animator animator;

	
	void Start ()
    {
		animator = GetComponent<Animator>();
	}
	
	//attacker will move if no defender in view.
	void Update () 
	{
		transform.Translate(Vector3.left *currentSpeed * Time.deltaTime);

        if (!currentTarget) 
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
        if (currentTarget)
        {
            Health health = currentTarget.GetComponent<Health>();
            if (health)
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

