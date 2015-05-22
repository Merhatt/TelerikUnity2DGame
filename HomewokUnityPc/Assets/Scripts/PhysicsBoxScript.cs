using UnityEngine;
using System.Collections;

public class PhysicsBoxScript : MonoBehaviour
{

    public GameObject Begin;
    public GameObject PhysicsBox;
    // Use this for initialization
    void Start()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Spikes"))
        {
            var transform = PhysicsBox.transform.position;
            transform = Begin.transform.position;
            PhysicsBox.transform.position = transform; 


        }
    }
}
