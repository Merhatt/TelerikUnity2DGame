using UnityEngine;
using System.Collections;

public class GoblinAI : MonoBehaviour
{
    public Animator animator;
    public float Speed;
    public GameObject Player;
    public GameObject Goblin;
    public Rigidbody2D RBGoblin;
    public GameObject StartG;
    public GameObject EndG;
    public GameObject AttackStart;
    public GameObject AttackEnd;
    public GameObject IddlePlace;
    private bool isMoving;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        

            if (Player.transform.position.x >= this.StartG.transform.position.x && Player.transform.position.x <= Goblin.transform.position.x)
            {
                this.animator.SetInteger("State", 1);
            }
            else if (Player.transform.position.x <= EndG.transform.position.x && Player.transform.position.x > Goblin.transform.position.x)
            {
                this.animator.SetInteger("State", 2);
            }
            if (Player.transform.position.x >= this.AttackStart.transform.position.x && Player.transform.position.x <= Goblin.transform.position.x)
            {
                this.animator.SetInteger("State", 3);
            }
            else if (Player.transform.position.x <= AttackEnd.transform.position.x && Player.transform.position.x > Goblin.transform.position.x)
            {
                this.animator.SetInteger("State", 4);
            }
            if (Player.transform.position.x < this.StartG.transform.position.x || Player.transform.position.x > EndG.transform.position.x)
            {
                this.animator.SetInteger("State", 0);
            }
        

    }
    void FixedUpdate() 
    {
        if (animator.GetInteger("State") == 1 || animator.GetInteger("State") == 3)
        {
            var pos = RBGoblin.position;
            pos.x -= Speed;
            RBGoblin.position = pos;

        }
        if (animator.GetInteger("State") == 2 || animator.GetInteger("State") == 4)
        {
            var pos = RBGoblin.position;
            pos.x += Speed;
            RBGoblin.position = pos;

        }

    }
}
