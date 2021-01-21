using UnityEngine;

public class move : MonoBehaviour
{
    public Rigidbody2D rb;
    public float force = 5f;
    public Vector2 jump;
    public Transform death;
    public AudioSource drop;
    public AudioSource bg ;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        jump = new Vector2(0, 1);
        bg.Play();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("getting key and ready to jump");
            rb.AddForce(jump * force, ForceMode2D.Impulse);
            drop.Play();
        }



    }
    /*************player death*****************/
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "destroyer")
        {
            Debug.Log("player loose");
            Destroy(this.gameObject);
        }


    }








}
