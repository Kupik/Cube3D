using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovmentScript : MonoBehaviour

{
    public Rigidbody rb;
    
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float jumpForce = 5f;
    private bool hasJump = true;
    public BoxCollider jumping;
  //  public float JumpForce = 5000f;



    void FixedUpdate ()
    {

        // add forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // JumpPlatform.AddForce(0, 0, forwardForce * Time.deltaTime);

        /* if(Input.GetKeyDown(KeyCode.Space) && !hasJump)
         {
             rb.AddForce(0, jumpForce, 0, ForceMode.Impulse);
             hasJump = false;
         }*/

        if (Input.GetButtonDown("Jump") && hasJump)
        {
            rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
            hasJump = false;
        }


        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

   


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Platform")
        {
            hasJump = true;
        }
    }




}
