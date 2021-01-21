using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colortester : MonoBehaviour
{
    
    private void Start()
    {
        
       
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {

       if (collision.GetComponent<SpriteRenderer>().color != this.GetComponent<SpriteRenderer>().color  )
        {
            
            Destroy(collision.gameObject);
        }






        
    }















}
