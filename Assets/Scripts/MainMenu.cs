using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Text level1;
    public Text level2;
    public Text level3;
    public Text level4;
    public Text level5;
    public Text level6;
    public Text level7;
    public Text level8;
    public Text level9;
    public Text level10;

    [SerializeField]
    private Button[] levelsButton;

    private void Start()
    {
        level1.text = "High Score:" + PlayerPrefs.GetFloat("level1").ToString("0.00");
        level2.text = "High Score:" + PlayerPrefs.GetFloat("level2").ToString("0.00");
        level3.text = "High Score:" + PlayerPrefs.GetFloat("level3").ToString("0.00");
        level4.text = "High Score:" + PlayerPrefs.GetFloat("level4").ToString("0.00");
        level5.text = "High Score:" + PlayerPrefs.GetFloat("level5").ToString("0.00");
        level6.text = "High Score:" + PlayerPrefs.GetFloat("level6").ToString("0.00");
        level7.text = "High Score:" + PlayerPrefs.GetFloat("level7").ToString("0.00");
        level8.text = "High Score:" + PlayerPrefs.GetFloat("level8").ToString("0.00");
        level9.text = "High Score:" + PlayerPrefs.GetFloat("level9").ToString("0.00");
        level10.text = "High Score:" + PlayerPrefs.GetFloat("level10").ToString("0.00");

       for(int i = 0; i < levelsButton.Length; i++)
        {
            if (i+1 > PlayerPrefs.GetInt("levels"))
            {
                levelsButton[i].interactable = false;
               

            }
        }
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
    public void Quit()
    {
        Application.Quit();
    }
    public void LevelSelect()
    {
        SceneManager.LoadScene(12);
    }
    public void mainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void leve1()
    {
        SceneManager.LoadScene(1);
    }
    public void leve2()
    {
        SceneManager.LoadScene(2);
    }
    public void leve3()
    {
        SceneManager.LoadScene(3);
    }
    public void leve4()
    {
        SceneManager.LoadScene(4);
    }
    public void leve5()
    {
        SceneManager.LoadScene(5);
    }
    public void leve6()
    {
        SceneManager.LoadScene(6);
    }
    public void leve7()
    {
        SceneManager.LoadScene(7);
    }
    public void leve8()
    {
        SceneManager.LoadScene(8);
    }
    public void leve9()
    {
        SceneManager.LoadScene(9);
    }
    public void leve10()
    {
        SceneManager.LoadScene(10);
    }
}
