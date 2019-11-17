using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : AliveObj
{




    protected override void Awake()
    {
        base.Awake();
        entity.Name = "主角"; 
        entity.Fight = 50;
        entity.Defence = 20;
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
