using UnityEngine;
using System.Collections;

public class SnakeController : MonoBehaviour {

    public GameObject[] Platforms;
    public GameObject GameObject;
    public Animator animator;
    public Rigidbody2D rb;
    public float speed = 0;
    private bool isEdged = false;
    // Use this for initialization
    void Start()
    {
        this.animator.SetInteger("State", 0);
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
            this.animator.SetInteger("State", 1);

        }
        if (gameObject.transform.position.x <= Platforms[0].transform.position.x)
        {
            speed = 0.9f;
            pos.x += 0.05f;
            rb.position = pos;
            isEdged = true;
            this.animator.SetInteger("State", 0);

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
}
