using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A3Script2 : MonoBehaviour
{

    public int enemyHP;
    public int maxHealth = 1;
    public Transform spawnPoint;
   
    // Start is called before the first frame update
    void Start()
    {
        enemyHP = maxHealth;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
            {
            enemyHP = enemyHP - 1;
            print("Enemy is Injured");
            }
        
    }

    

    public void TakeHP(int amount)
    {
        enemyHP -= amount;
        if (enemyHP <= 0)
        {
            enemyHP = 0; 
            transform.position = spawnPoint.position;
            transform.rotation = spawnPoint.rotation;
            enemyHP = maxHealth;
        }

    }
}
