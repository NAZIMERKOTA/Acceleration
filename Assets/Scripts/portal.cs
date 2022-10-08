using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class portal : MonoBehaviour
{
    public float second;
    public Text level;
    public Text time;
    public Text currentScore;
    public GameObject panel;
    public Text level1;

    int whichScene;

    /*public Text level2;
    public Text level3;
    public Text level4;
    public Text level5;
    public Text level6;
    public Text level7;
    public Text level8;
    public Text level9;
    public Text level10;*/

    private void Start()
    {
      
        second = 0;
        level.text = "Level:" + SceneManager.GetActiveScene().buildIndex.ToString();
        whichScene = SceneManager.GetActiveScene().buildIndex;
        

        /*level1.text = "High Score:" + PlayerPrefs.GetFloat("level1").ToString("0");
        level2.text = "High Score:" + PlayerPrefs.GetFloat("level2").ToString("0");
        level3.text = "High Score:" + PlayerPrefs.GetFloat("level3").ToString("0");
        level4.text = "High Score:" + PlayerPrefs.GetFloat("level4").ToString("0");
        level5.text = "High Score:" + PlayerPrefs.GetFloat("level5").ToString("0");
        level6.text = "High Score:" + PlayerPrefs.GetFloat("level6").ToString("0");
        level7.text = "High Score:" + PlayerPrefs.GetFloat("level7").ToString("0");
        level8.text = "High Score:" + PlayerPrefs.GetFloat("level8").ToString("0");
        level9.text = "High Score:" + PlayerPrefs.GetFloat("level9").ToString("0");
        level10.text = "High Score:" + PlayerPrefs.GetFloat("level10").ToString("0");*/



    }
    private void Update()
    {
        second += Time.deltaTime;
        time.text = second.ToString("0.00");
        
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        
        if (collision.gameObject.tag == "Player")
        {
            currentScore.text = "Current Score:" + second.ToString("0.00");
            panel.SetActive(true);

            if (whichScene == PlayerPrefs.GetInt("levels"))
            {
                PlayerPrefs.SetInt("levels", PlayerPrefs.GetInt("levels")+1);
            }


            for (int i = 1; i <= SceneManager.sceneCountInBuildSettings -2; i++)
            {
                if (whichScene == i)
                {
                    if (second < PlayerPrefs.GetFloat("level" + i) || PlayerPrefs.GetFloat("level" + i) == 0)
                    {

                        PlayerPrefs.SetFloat("level" + i, second);

                    }
                    level1.text = "High Score:" + PlayerPrefs.GetFloat("level" + i).ToString("0.00");

                }
            }

          
            //SceneManager.LoadScene(whichScene+1);
        }
    }
}
