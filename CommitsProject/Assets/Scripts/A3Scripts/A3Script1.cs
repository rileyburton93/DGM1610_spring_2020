using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A3Script1 : MonoBehaviour
{
    public GameObject player;
    public Rigidbody enemyRb;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player Cube");
    }

    void FixedUpdate()
    {

        enemyRb.AddForce((player.transform.position - transform.position).normalized * moveSpeed);

    }

}
