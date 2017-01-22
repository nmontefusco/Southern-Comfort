using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour {

	public Camera myCamera;
	private eggDisplay EggDisplay;

	void Start()
	{
	  EggDisplay= GameObject.FindObjectOfType<eggDisplay>();
	}

	void OnMouseDown()
	{
	   Vector2 rawPos= CalculateWorldPointOfMouseClick();
	   Vector2 roundedPos= SnapToGrid(rawPos);
	   GameObject defender= Button.selectedDefender;

	   int defenderCost= defender.GetComponent<Defenders>().eggCost;
	   if(EggDisplay.UseEggs(defenderCost) == eggDisplay.Status.SUCCESS)
	   {
	     SpawnDefender(roundedPos,defender);
	   } 

	}

	void SpawnDefender(Vector2 roundedPos, GameObject defender)
	{
	 GameObject newDef = Instantiate(defender,roundedPos,Quaternion.identity) as GameObject;
	}

	Vector2 SnapToGrid(Vector2 rawWorldPos) 
	{
	float newX= Mathf.RoundToInt(rawWorldPos.x);
	float newY= Mathf.RoundToInt(rawWorldPos.y);

	 return new Vector2(newX,newY);
	}

	Vector2 CalculateWorldPointOfMouseClick()
	{
	  float mouseX= Input.mousePosition.x;
	  float mouseY= Input.mousePosition.y;
	  float distanceFromCamera=10f;

	  Vector3 weirdTriplet = new Vector3(mouseX,mouseY,distanceFromCamera);

	  Vector2 worldPos= myCamera.ScreenToWorldPoint(weirdTriplet);

	  return worldPos;
	}
}
