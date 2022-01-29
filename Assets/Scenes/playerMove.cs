using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public float speed;
    public float jump;
    
    private int grounded;
    private float move;
    private Rigidbody2D rigidbody2;
    // Start is called before the first frame update
    void Start()
    {
        //start grounded so player can jump & find rigidbody for transformations
        grounded = 1;
        rigidbody2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //horizontal movement
        move = Input.GetAxis("Horizontal");
        rigidbody2.velocity = new Vector2(move * speed, rigidbody2.velocity.y);


        //find if player is moving vertically, if not moving vertically then allow jump, otherwise dont
        if (rigidbody2.velocity.y == 0f){
            grounded = 1;
        }else{
            grounded = 0;
        }
        if (Input.GetButtonDown("Jump") && grounded == 1)
        {
            rigidbody2.AddForce(new Vector2(rigidbody2.velocity.x, jump));
        }
    }

    

    
}
