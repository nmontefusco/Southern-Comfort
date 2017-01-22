using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class musicManager : MonoBehaviour {

    public AudioClip[] levelMusicChangeArray;
    private AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        DontDestroyOnLoad(gameObject);
        Debug.Log("Don't destroy on load" + name);
        SceneManager.sceneLoaded += OnSceneLoad;
    }

    //delegates are methods used as variables
   

    void OnSceneLoad(Scene scene, LoadSceneMode mode)
    {
        //get current scene and store it as integer
        int thisSceneIndex = SceneManager.GetActiveScene().buildIndex;

        AudioClip thisLevelMusic = levelMusicChangeArray[thisSceneIndex];

        if (thisLevelMusic)
        {
            audioSource.clip = thisLevelMusic;
            audioSource.loop = true;
            audioSource.Play();
        }
    }

   public void changeVolume(float volume)
    {
        audioSource.volume = volume;
    }
}
