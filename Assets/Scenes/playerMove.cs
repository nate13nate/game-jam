using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
  public float speed;
  public float jump;

  private bool grounded = true; // start grounded so player can jump & find rigidbody for transformations
  private float move;
  private Rigidbody2D rigidbody2;

  // Start is called before the first frame update
  void Start()
  {
    rigidbody2 = GetComponent<Rigidbody2D>();
  }

  // Update is called once per frame
  void Update()
  {
    //horizontal movement
    move = Input.GetAxis("Horizontal");

    //find if player is moving vertically, if not moving vertically then allow jump, otherwise dont
    grounded = rigidbody2.velocity.y == 0f;

    if (Input.GetButtonDown("Jump") && grounded) rigidbody2.AddForce(new Vector2(0, jump));
  }

  void FixedUpdate()
  {
    rigidbody2.velocity = new Vector2(move * speed, rigidbody2.velocity.y);
  }
}
