using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{
    private void Awake()
    {
        if (!PlayerPrefs.HasKey("level1"))
        {
            PlayerPrefs.SetFloat("level1", 0);
        }

        if (!PlayerPrefs.HasKey("level2"))
        {
            PlayerPrefs.SetFloat("level2", 0);
        }

        if (!PlayerPrefs.HasKey("level3"))
        {
            PlayerPrefs.SetFloat("level3", 0);
        }

        if (!PlayerPrefs.HasKey("level4"))
        {
            PlayerPrefs.SetFloat("level4", 0);
        }

        if (!PlayerPrefs.HasKey("level5"))
        {
            PlayerPrefs.SetFloat("level5", 0);
        }

        if (!PlayerPrefs.HasKey("level6"))
        {
            PlayerPrefs.SetFloat("level6", 0);
        }

        if (!PlayerPrefs.HasKey("level7"))
        {
            PlayerPrefs.SetFloat("level7", 0);
        }

        if (!PlayerPrefs.HasKey("level8"))
        {
            PlayerPrefs.SetFloat("level8", 0);
        }

        if (!PlayerPrefs.HasKey("level9"))
        {
            PlayerPrefs.SetFloat("level9", 0);
        }

        if (!PlayerPrefs.HasKey("level10"))
        {
            PlayerPrefs.SetFloat("level10", 0);
        }

        if (!PlayerPrefs.HasKey("levels"))
        {
            PlayerPrefs.SetInt("levels", 1);
        }


    }
    public void mainMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }
    public void Continue()
    {
        Time.timeScale = 1.0f;
        
    }
    public void Pause()
    {
        Time.timeScale = 0;
    }
    public void PlayGame()
    {
        int whichScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(whichScene + 1);

    }
    public void Restart()
    {
        int whichScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(whichScene);


    }

}
