using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command //sanal sınıf oluşturarak imza sınıfımızla classlarımza imzalarını vereceğiz.
{
    public abstract void Execute(Animator anim,bool animState);
}

public class Run : Command
{
    public override void Execute(Animator anim, bool animState)
    {
        anim.SetBool("isRunning", animState);
    }
}
public class Attack : Command
{
    public override void Execute(Animator anim, bool animState)
    {
        anim.SetTrigger("isAttack");
    }
}
public class DoNothing : Command
{
    public override void Execute(Animator anim, bool animState)
    {

    }
}
