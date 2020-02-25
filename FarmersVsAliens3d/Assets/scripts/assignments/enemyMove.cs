using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{
    
    public GameObject player;
    public Rigidbody enemyRb;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
       // transform.LookAt(player);
       // transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
    void FixedUpdate()
    {

        enemyRb.AddForce((player.transform.position - transform.position).normalized * moveSpeed);

    }
}
