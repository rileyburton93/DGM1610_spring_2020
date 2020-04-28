using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A2Script3 : MonoBehaviour
{   // projectile script

   
        public GameObject projectilePrefab;
        private Rigidbody rb;


        void Start()
        {
        rb = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Instantiate(projectilePrefab, transform.position,
                    projectilePrefab.transform.rotation);
            }
        }
        
}
