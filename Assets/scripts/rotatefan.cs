using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatefan : MonoBehaviour
{
    public float speed;
   
    // Start is called before the first frame update
    void Start()
    {
         
    }

    
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 1) * speed * Time.deltaTime);
    }
}
