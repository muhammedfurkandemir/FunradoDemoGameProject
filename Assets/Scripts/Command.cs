using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command //sanal sınıf oluşturarak imza sınıfımızla classlarımza imzalarını vereceğiz.
{
    public abstract void Execute(Animator anim);
}

public class Idle : Command
{
    public override void Execute(Animator anim)
    {
        anim.SetTrigger("isIdle");
    }
}
public class Run : Command
{
    public override void Execute(Animator anim)
    {
        anim.SetTrigger("isRun");
    }
}
public class Attack : Command
{
    public override void Execute(Animator anim)
    {
        anim.SetTrigger("isAttack");
    }
}
public class DoNothing : Command
{
    public override void Execute(Animator anim)
    {

    }
}
