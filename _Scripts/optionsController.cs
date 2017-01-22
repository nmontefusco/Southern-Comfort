using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class optionsController : MonoBehaviour {
    public Slider volumeSlider,difficultySlider;
    public levelManager levelManager;

    private musicManager musicManager;
	// Use this for initialization
	void Start ()
    {
        musicManager = GameObject.FindObjectOfType<musicManager>();
        volumeSlider.value = playerPreferencesManager.GetMasterVolume();
        difficultySlider.value = playerPreferencesManager.GetDifficulty();
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        musicManager.changeVolume(volumeSlider.value);
	}

    public void SaveAndExit()
    {
        playerPreferencesManager.SetMasterVolume(volumeSlider.value);
        playerPreferencesManager.SetDifficulty(difficultySlider.value);
        levelManager.Loadlevel("01a Main_Menu");
    }
    public void setDefaults()
    {
        volumeSlider.value = .80f;
        difficultySlider.value = 2;
    }
}
