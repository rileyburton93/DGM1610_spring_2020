using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptA1_2 : A1Obstacle
    //blue obstacle color behaviors
{   //abstract allows the override command for this inherited class

    public override Color DamageColor
    {
       get { return Color.blue; }
    }
    //override Color damageColor = Color.blue;
}

