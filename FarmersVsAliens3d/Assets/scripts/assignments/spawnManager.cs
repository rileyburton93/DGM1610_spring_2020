﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public int enemyIndex;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(enemyPrefabs[enemyIndex], new Vector3(0, 0, 0), enemyPrefabs[enemyIndex].transform.rotation);
        }

        
    }
}
