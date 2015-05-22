using UnityEngine;
using System.Collections;

public class PlatformMooverUpDown : MonoBehaviour {

    public GameObject[] Platforms;
    public GameObject GameObject;
    private bool isEdged = false;
    public Rigidbody2D rb;
    public float speed = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var velocity = rb.velocity;
        var pos = rb.position;
        if (gameObject.transform.position.y >= Platforms[1].transform.position.y)
        {
            speed = -1.3f;
            pos.y += -0.05f;
            rb.position = pos;
            isEdged = true;

        }
        if (gameObject.transform.position.y <= Platforms[0].transform.position.y)
        {
            speed = 1.3f;
            pos.y += 0.05f;
            rb.position = pos;
            isEdged = true;
        }
        if (!isEdged)
        {
            velocity.y = speed;
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
