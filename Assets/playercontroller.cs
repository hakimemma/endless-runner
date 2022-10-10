using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public GameObject groundChecker;
    public LayerMask whatIsGround;

    public float jumpForce = 200f;

    float maxSpeed = 6.0f;
    bool isOnGround = false;

    //create reference to the Rigidbody2D so we can manipulate it
    Rigidbody2D playerObject;

    // Start is called before the first frame update
    void Start()
    {
        //Find the Rigidbody2D component that is attatched to the same object as this script
        playerObject = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //create a 'float' that will be equal to the players horizontal input
        float movementValueY = Input.GetAxis("Vertical");
        float movementValueX = 1.0f;


        //change the X velocity of the Rigidbody2D to be equal to the moment value
        playerObject.velocity = new Vector2(movementValueX * maxSpeed, playerObject.velocity.y);
        playerObject.AddForce(new Vector2(0f, movementValueY));


        //check to see if the ground check object is touching the ground
        isOnGround = Physics2D.OverlapCircle(groundChecker.transform.position, 0.01f, whatIsGround);

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround == true)
        {
            playerObject.AddForce(new Vector2(0.0f, jumpForce));
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            maxSpeed = 10.0f;
        }
         else
        {
            maxSpeed = 5.0f;
        }
           


    }

}
   
