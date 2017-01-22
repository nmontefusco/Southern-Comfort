using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour {

 public float levelSeconds=100;
 private Slider slider;
 private AudioSource audioSource;
 private bool IsEndOfLevel=false;
 private levelManager LevelManager;
 private GameObject winLabel;

	// Use this for initialization
	void Start () 
	{
          slider= GetComponent<Slider>();
          audioSource = GetComponent<AudioSource>();
          LevelManager = GameObject.FindObjectOfType<levelManager>();
          winLabel = GameObject.Find("You Win");
          winLabel.SetActive(false);


            
          
        }
	
	// Update is called once per frame
	void Update () 
	{
		slider.value = (Time.timeSinceLevelLoad/levelSeconds);

		bool timeIsUp= (Time.timeSinceLevelLoad>=levelSeconds); 

		if(timeIsUp && !IsEndOfLevel)
		{
		  audioSource.Play();
		  winLabel.SetActive(true);
		  Invoke("LoadNextLevel",audioSource.clip.length);
		  IsEndOfLevel = true;
		}
	}

	void LoadNextLevel() 
	{
	  LevelManager.LoadNextLevel();
	}
}
