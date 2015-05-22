using UnityEngine;
using System.Collections;

public class PlatformMoving : MonoBehaviour
{
    public GameObject[] Platforms;
    public GameObject GameObject;
    public Rigidbody2D rb;
    public float speed = 0;
    private bool isEdged = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var velocity = rb.velocity;
        var pos = rb.position;
        if (gameObject.transform.position.x >= Platforms[1].transform.position.x)
        {
            speed = -0.9f;
            pos.x += -0.05f;
            rb.position = pos;
            isEdged = true;
           
        }
        if (gameObject.transform.position.x <= Platforms[0].transform.position.x)
        {
            speed = 0.9f;
            pos.x += 0.05f;
            rb.position = pos;
            isEdged = true;
           
        }
        if (!isEdged)
        {
            velocity.x = speed;
            rb.velocity = velocity;
        }
        else
        {
            isEdged = false;
        }

        
     
    }
    void FixedUpdate()
    {
        
       
    }
}
