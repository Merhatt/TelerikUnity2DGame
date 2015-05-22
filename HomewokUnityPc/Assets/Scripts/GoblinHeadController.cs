using UnityEngine;
using System.Collections;

public class GoblinHeadController : MonoBehaviour {

    public Rigidbody2D Goblin;
    public Rigidbody2D Head;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        var transform = Goblin.position;
        Head.position = transform;
	}
}
