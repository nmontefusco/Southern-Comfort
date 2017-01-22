using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

public GameObject projectile,projectileParent; 
private Animator animator;
private Spawner  myLaneSpawner;

void Start()
{

  animator= GameObject.FindObjectOfType<Animator>();

  //Creates a parent if necessary
  projectileParent = GameObject.Find("Projectiles");

  if(!projectileParent)
  {
    projectileParent = new GameObject("Projectiles");
  }

   SetMyLaneSpawner();

}



private void Fire() 
   {
      GameObject newProjectile = Instantiate(projectile, transform.Find("Gun").position, Quaternion.identity) as GameObject;
      newProjectile.transform.SetParent(projectileParent.transform);
   }

   // look through all spawners, and set myLaneSpawner if found
   void SetMyLaneSpawner() 
   {
    Spawner[] spawnerArray= GameObject.FindObjectsOfType<Spawner>();
     foreach(Spawner spawner in spawnerArray) 
     {
       if(spawner.transform.position.y == transform.position.y)
       {
         myLaneSpawner= spawner;
         return;
       } 
     }
     Debug.LogError(name + " can't find spawner in lane");

   }

  bool IsAttackerAheadInLane() 
  {
    if(myLaneSpawner.transform.childCount<=0)
    {
      return false;
    }
    foreach(Transform attacker in myLaneSpawner.transform)
    {
    if(attacker.transform.position.x > transform.position.x) 
    {
      return true;
    }

    }
    //Attacker in lane, but behind us
    return false;
  }

 void Update()
 {
  if(IsAttackerAheadInLane())
  {
    animator.SetBool("Is_Attacking",true);
  }
  else

  {
    animator.SetBool("Is_Attacking",false);
  }

 }
}
