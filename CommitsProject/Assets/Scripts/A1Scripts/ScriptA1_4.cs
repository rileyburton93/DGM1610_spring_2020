using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//using .ui means this will be able to show UI text on screen

public class ScriptA1_4 : MonoBehaviour
{   //damage/health script 4 playa

    public const int totalHP = 20;
    //const never changes, this should always display as 20
    public int playerHP = totalHP;
    public Text yourHP;
    public Text hp;

    // Update is called once per frame
    void Update()
    {
        yourHP.text = playerHP.ToString();
        hp.text = totalHP.ToString();
        
    }

    public void TakeDamage(int amount)
    {
        playerHP -= amount;
        if(playerHP <= 0)
        {
            playerHP = 0;
            print("GAME OVER");
        }
    }

}
