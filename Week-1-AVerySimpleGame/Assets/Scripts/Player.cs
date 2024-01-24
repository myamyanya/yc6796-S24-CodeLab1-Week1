using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    public float forceAmount = 5;
    
    // For Jumping
    public float jumpForceAmount = 0.1f;
    public float jumpStrength = 1.0f;
    public bool isJumping = false;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // This part is the WASD controller
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(forceAmount * Vector3.forward);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(forceAmount * Vector3.back);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(forceAmount * Vector3.left);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(forceAmount * Vector3.right);
        }
        
        // Jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isJumping = true;
        }
        
        if (isJumping && Input.GetKey(KeyCode.Space))
        {
            jumpForceAmount += jumpStrength;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            rb.AddForce(jumpForceAmount * Vector3.up);

            if (isJumping)
            {
                jumpForceAmount = 0.1f;
                isJumping = false;
            }
        }
    }
}
