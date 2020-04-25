using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntsCS0 : MonoBehaviour
{
    //ints can declare integer values within methods/functions

    int coins = 2;

    // Start is called before the first frame update
    void Start()
    {
        coins = SumUp(coins);
        //sumUp should be a functions that multiplies the coins int
        Debug.Log(coins);
        //debug.log should show the result of the sumup function in console
    }

    int SumUp(int number)
        //number is a temporary variable that can be used in a function
    {
        int coinsSum;
        coinsSum = number * 2;
        return coinsSum;
        //return makes it so the actual end value is coinssum
    }

    // Update is called once per frame
    void Update()
    {
        //print (coins);
        //this might cause it to print every frame ang clog the console
    }
}
