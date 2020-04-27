using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A2Script2 : MonoBehaviour
{
    //Player jump

    public float jumpHeight = 5;
    public bool isGrounded;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpHeight * 50);
        }
    }

    // detects whether is on the ground so it can jump
    void OnCollisionStay(Collision other)
    {

        if (other.gameObject.CompareTag("Ground") || other.gameObject.CompareTag("Obstacle"))
        {
            isGrounded = true;
            Debug.Log("grounded");
        }
    }
    // tried without oncollision exit, isgrounded never resets to false without
    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Ground") || other.gameObject.CompareTag("Obstacle"))
        {
            isGrounded = false;
            Debug.Log("not grounded");
        }
    }
}
