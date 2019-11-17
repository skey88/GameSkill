using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Skill;
public class GameManager : MonoBehaviour
{

    public AliveObj playerObj;
    public AliveObj enemyObj;
    private Attribute attribute;
    private Skill.Skill sk;

    private void Awake()
    {
        sk = new Skill.Skill();
        attribute = new Attribute();
        attribute.CostMp = 5;
        sk.Target = playerObj.entity;
        sk.Caster = enemyObj.entity;

        sk.Init(playerObj.entity, enemyObj.entity, attribute);
    }




    IEnumerator Start()
    { 
         
        //检验流程
        bool isvalid = sk.IsValid(new MpVerify());
        if (!isvalid)
        {
            sk.Interrupt(new InterruptValid());
        } 

        Debug.Log("准备 吟唱");
        Task.TimeCondition cond = new Task.TimeCondition(5f);
        cond.Start();
        Task.Task task = new Task.Task("吟唱动画", cond);

        yield return StartCoroutine(sk.Sing(task));

        Debug.Log("吟唱 结束");
    }

    public void Att()
    {


    }

}
