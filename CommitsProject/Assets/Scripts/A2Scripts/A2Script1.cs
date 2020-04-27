using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A2Script1 : MonoBehaviour
{

        //player movement
        public float speed = 5;
        public float turnSpeed = 400;
        public float verticalInput;
        public float horizontalInput;
    
        // Start is called before the first frame update
        void Start()
        {
           
        }

        // Update is called once per frame
        void Update()
        {

        //getaxis automatically assigns getkeydown wasd for movement and udlr for turn

            verticalInput = Input.GetAxis("Vertical");
            horizontalInput = Input.GetAxis("Horizontal");

            transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
            transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);
        }
     
}
