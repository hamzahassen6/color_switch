using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infintiy : MonoBehaviour
{
    public GameObject cam;
    public GameObject fan;
    public GameObject disk;






    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        float x= Vector2.SqrMagnitude(cam.transform.position - fan.transform.position);
       
        if (x > 100) 
        {
           
         //   Debug.Log(x);
            Instantiate(fan, new Vector3(0,21,-11), Quaternion.Euler(0,0,0));
            Destroy(fan);
            fan = null;
            




        }
    }
}
