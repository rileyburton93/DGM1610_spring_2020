using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variables : MonoBehaviour
{// Declaration
    public int cookieBox;
    public float waterBottle;
    
    public double rbi;
    public GameObject player;
    public float amount;
    public float money;
    public float cost;

    


    // Start is called before the first frame update
    void Start()

    {
        Cookies(amount, money, cost);



        cookieBox = 20;
  
        Debug.Log("How many cookies are in the box " + cookieBox);
        //Function call
        CheckScore();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Cookies(float amount, float money, float cost)
    {
        float total;

       total = money - cost * amount;

        print(total);
    }

    void CheckScore()
    {
        print("Hello World!");
    }
}