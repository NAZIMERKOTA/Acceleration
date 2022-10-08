using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide : MonoBehaviour
{
    public GameObject SlidePrefab;
    public float speed = 2.0f;
    public Vector3 startPoint;
    public Vector3 endPoint;
    public Transform obj;
    // Start is called before the first frame update
    void Start()
    {
        
        //startPoint = obj.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.position = Vector3.MoveTowards(obj.transform.position, startPoint, speed*Time.deltaTime);
        if(obj.transform.position == startPoint)
        {
            startPoint = endPoint;
            if (startPoint == endPoint)
            {
                endPoint= obj.transform.position;
            }
        }
    }
}
