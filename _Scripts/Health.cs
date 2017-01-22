using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

public float health = 100;

public void dealDamage(float damage) 
	{
	   health-=damage;
	   if(health<=0) 
	   {
	     //optionally trigger death animation
	     DestroyObject();
	   }
	}

public void DestroyObject()
{
 Destroy(gameObject);
}
}

 