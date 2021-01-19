using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{ public Rigidbody2D rb;
  public  float force=5f;
    public Vector2 jump;

    // Start is called before the first frame update
    void Start()
    {
       rb=gameObject.GetComponent<Rigidbody2D>();
        jump = new Vector2(0,1) ;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("hmm");
                rb.AddForce(jump * force,ForceMode2D.Impulse);
        }
        


      
    }
}
