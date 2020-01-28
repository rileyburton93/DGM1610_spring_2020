﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 0.1f);
        
    }

    // detect collision with another object
    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("Floor"))
        {
            Debug.Log("Colliding with Floor");
        }
        else if(other.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Colliding with Obstacle");
        }
        else
        {
            Debug.Log("...");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("You have entered the trigger!");
    }
}