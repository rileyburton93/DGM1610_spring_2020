using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptA1_3 : A1Obstacle
{
    //Color scripts inherit from a1o
      
    public override Color DamageColor
    {
        get { return Color.red; }
    }
   
}

/* // Start is called before the first frame update
void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}*/
