using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controler : MonoBehaviour
{
    Rigidbody2D rb;

    float horizontal;
    float vertical;
    public float speed =400;
    public Transform startPoint;


    void Start()
     {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        rb = GetComponent<Rigidbody2D>();
       
     }

    
    void Update()
    {
      /* horizontal = 0;
        vertical = 0;

        if (Input.GetKey(KeyCode.W))
        {
            
            vertical++;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            vertical--;
        }

        if(Input.GetKey(KeyCode.D))
        {
            horizontal++;
        }
        else if(Input.GetKey(KeyCode.A))
        {
            horizontal--;
        }
        gameObject.transform.Translate(horizontal / 10, vertical / 10, 0);*/


         horizontal = Input.acceleration.x;
         vertical =Input.acceleration.y + 0.6f;
         rb.velocity = new Vector2(horizontal*speed*Time.deltaTime,vertical*speed*Time.deltaTime);
         /*Debug.Log("horizo" + horizontal);
         Debug.Log(vertical);*/


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //int whichScene = SceneManager.GetActiveScene().buildIndex;
        if (collision.gameObject.tag == "obstacle")
        {
            Handheld.Vibrate();
            gameObject.transform.position = startPoint.transform.position;
            //SceneManager.LoadScene(whichScene);
        }
    }


}
