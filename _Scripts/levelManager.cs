using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelManager : MonoBehaviour {

    public float autoLoadNextLevelAfter;
    public bool is_levelwon = true;
     void Start()
    {
        if (is_levelwon)
        {
            Invoke("LoadNextLevel", autoLoadNextLevelAfter);
            is_levelwon = false;
        }
        
    }

    public void Loadlevel(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
