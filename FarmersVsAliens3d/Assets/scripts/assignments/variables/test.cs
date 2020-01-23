using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{// Declaration
    public int cookieBox;
    public float waterBottle;
    private string firstName;
    public double rbi;
    public GameObject player;
    public float heart;
    public float feelgood;
    public float beans;
    public float farts;



    // Start is called before the first frame update
    void Start()

    {

        Cookies(farts, feelgood, beans);


        cookieBox = 20;
        firstName = "Bobby";
        Debug.Log("How many cookies are in the box " + cookieBox);
        //Function call
        CheckScore();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Heart(float beans, float heart, float feelgood)
    {
        heart = beans + feelgood;

    }

    void Cookies(float beans, float feelgood, float farts)
    {

        feelgood = beans * farts;


        print(feelgood);
    }

    void CheckScore()
    {
        print("Hello World!");
    }
}
