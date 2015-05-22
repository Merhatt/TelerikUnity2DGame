using UnityEngine;
using System.Collections;


public class PlayerMovment: MonoBehaviour
{
    public GameObject starGo;
    public Rigidbody2D rb;
    public int level;
    public bool left;
    public bool right;
    public float movmentSpeed;
    public float jumpSpeed = 3;
    private bool isJumped;
    private Animator animator;
    public AudioClip jumpSound;
    public AudioClip proujineSound;
    public AudioClip Star;
    private AudioSource audioSource;
    
    void Start()
    {
        
        this.animator = this.GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
       
    }

    void Update() 
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {

            left = true;
            this.animator.SetInteger("State", 2);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            right = true;
            this.animator.SetInteger("State", 1);
        }
        if (!left && !right)
        {
            this.animator.SetInteger("State", 0);

        }
        if (Input.GetKey(KeyCode.UpArrow) && !isJumped)
        {
            if (isJumped == false)
            {
                var velocity = rb.velocity;
                velocity.y = jumpSpeed;
                rb.velocity = velocity;
                isJumped = true;
                this.audioSource.PlayOneShot(jumpSound);


            }


        }
    }
    

    public void Menu()
    {
        Application.LoadLevel("LevelSelector");
    }
    public void Reset()
    {
        var transform = GetComponent<Transform>();
        transform.position = new Vector3(0, 0, 0);   
    }


    void FixedUpdate()
    {
        if (left)
        {
           var velocity = rb.velocity;
           velocity.x = -movmentSpeed;
           rb.velocity = velocity;
           left = false;
        }
        if (right)
        {
            var velocity = rb.velocity;
            velocity.x = movmentSpeed;
            rb.velocity = velocity;
            right = false;
        }
        if (!left && !right)
        {
             this.animator.SetInteger("State", 0);
        }
        

    }
  

    public void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumped = false;
           
        }
        if (collision.gameObject.CompareTag("Jump"))
        {
              var velocity = rb.velocity;
                velocity.y = jumpSpeed + 3;
                rb.velocity = velocity;
                isJumped = true;
                this.audioSource.PlayOneShot(proujineSound);
        }
        if (collision.gameObject.CompareTag("Spikes"))
        {
         
            var transform = GetComponent<Transform>();
            transform.position = new Vector3(0, 0, 0);     
        }

        if (collision.gameObject.CompareTag("Finish"))
        {
           
          this.audioSource.PlayOneShot(Star);
          Invoke("LevelSelector", 2);
          Destroy(starGo);



        }
        
    }
    void LevelSelector ()
    {
        if (PlayerPrefs.GetInt("NowLevel") < level+1)
        {
                PlayerPrefs.SetInt("NowLevel", level+1);
        }
        Application.LoadLevel("LevelSelector");
    }
   
}
