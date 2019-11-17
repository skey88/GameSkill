using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : AliveObj
{

    protected override void Awake()
    {
        base.Awake();
        entity.Name = "怪物01";
        entity.Fight = 10;
        entity.Defence = 10;
    }
}
