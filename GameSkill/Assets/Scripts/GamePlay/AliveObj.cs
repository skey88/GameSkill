using Skill;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AliveObj : MonoBehaviour
{
    public Entity entity=new Entity ();
    protected virtual void Awake()
    {
        entity.Name = "狗熊01";
        entity.Hp = 100;
        entity.MaxHp = 100;
        entity.Mp = 100;
        entity.MaxMp = 100;
        entity.Fight = 20;
        entity.Defence = 10;
    }

}
