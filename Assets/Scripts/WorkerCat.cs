using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class WorkerCat : BaseCat
{

    public static int clickpoints = 1;
    public override void Awake()
    {
        base.Awake();
        CatLvl = 1;
    }
    public override void ClickEffect()
    {
        base.ClickEffect();
        clickpoints += 1;
        LevelUpEvent(); 
    }
}
