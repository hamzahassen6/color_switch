using UnityEngine;

public class colorchanger : MonoBehaviour
{



    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.gameObject.name);

        if (col.GetComponent<SpriteRenderer>().color != gameObject.GetComponent<SpriteRenderer>().color)
        {
            
            col.GetComponent<SpriteRenderer>().color = gameObject.GetComponent<SpriteRenderer>().color;

        }




    }



}
