using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A2Script3 : MonoBehaviour
{   // projectile script

    public GameObject projectilePrefab;
    public float projectileSpeed = 75f;

        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
          
            if (Input.GetKeyDown(KeyCode.F))
            {

            GameObject instantiateProjectile = Instantiate(projectilePrefab,
                transform.position, Quaternion.identity) as GameObject;
            Rigidbody projectileRigidbody = instantiateProjectile.GetComponent<Rigidbody>();
            projectileRigidbody.AddForce(transform.forward * projectileSpeed);
            //use transform not vector3
            Destroy(instantiateProjectile, 5f);
        }
        }

}
