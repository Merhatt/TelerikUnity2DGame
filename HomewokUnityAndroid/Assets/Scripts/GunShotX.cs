using UnityEngine;
using System.Collections;

public class GunShotX : MonoBehaviour
{
    public GameObject[] Platforms;
    public GameObject GameObject;
    public Transform transform;
    public Rigidbody2D rb;
    public Animator animator;
    public AudioClip ShotSound;
    private AudioSource audioSource;
    public float speed = 0;

    private bool isEdged = false;

    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        this.audioSource.PlayOneShot(ShotSound);
    }

    // Update is called once per frame
    void Update()
    {
        var velocity = rb.velocity;
     
        if (gameObject.transform.position.x >= Platforms[1].transform.position.x)
        {
            transform.position = Platforms[0].transform.position;
            this.animator.SetInteger("State", 1);
            this.audioSource.PlayOneShot(ShotSound);

            
        }

        if (gameObject.transform.position.x >= Platforms[2].transform.position.x)
        {
            
            this.animator.SetInteger("State", 0);

        }
      
            velocity.x = speed;
            rb.velocity = velocity;
        
       



    }
}
