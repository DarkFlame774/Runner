using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScrpt : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float jumpStrength = 0;
    public LogicScript logic;
    public bool playerIsAlive = true;
    Animator anim;



    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        anim = GetComponent<Animator>();
        
    }
    // Update is called once per frame
    void Update()
    {
        anim.SetBool("Jump", false);

        if (Input.GetKeyDown(KeyCode.Space) && transform.position.y < -1 && playerIsAlive)
        {
            myRigidBody.velocity = Vector2.up * jumpStrength;
            anim.SetBool("Jump",true);
            

        }
        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {

        }
        else
        {
            logic.gameOver();
            Time.timeScale = 0;
            playerIsAlive = false;
        }
        
    }



}
