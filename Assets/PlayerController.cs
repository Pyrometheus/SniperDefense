using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;//walking speed
    public float jump;//Jump height
    private bool grounded = true;//if not true then he cannot jump

    private Rigidbody2D rb2d;
    void Start()
    {
        //Get and store a reference to the Rigidbody2D component so that we can access it.
        rb2d = GetComponent<Rigidbody2D>();
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        //Declares Variable and uses Unity's Input.getAxis to Check for key presses and asign value from -1 to 1
        float moveHorizontal = Input.GetAxis("Horizontal");
        //adds Force along X-axis
        rb2d.velocity = new Vector2(moveHorizontal * speed, rb2d.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space) == true)
        {
            if(grounded == true)
            {
                rb2d.velocity = new Vector2(rb2d.velocity.x, jump);
            }
        }
    }
}
