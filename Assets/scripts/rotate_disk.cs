using UnityEngine;

public class rotate_disk : MonoBehaviour
{
    public float speed;
    public GameObject center;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(center.transform.position, new Vector3(0, 0, 1), speed * Time.deltaTime);

    }
}
