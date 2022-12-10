using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 1f;

    // Ref to the RigidBody
    [SerializeField] Rigidbody2D rb;

    private Vector2 movement;

    // Update is called once per frame
    private void Update()
    {
        // Gets Input
        movement.x = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        // Makes Player Move
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
        
        // Clamps the player to stay on the screen
        if (rb.transform.position.x >= 22) 
        { 
            rb.transform.position = new Vector3(22f,-11.5f,0f);
        }
        if (rb.transform.position.x <= -22) 
        { 
            rb.transform.position = new Vector3(-22f,-11.5f,0f);
        }
    }
}
