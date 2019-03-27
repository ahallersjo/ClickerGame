using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BaseCat : MonoBehaviour
{
    public virtual event Action Upgradelevel;

    public int startCost = 100;
    public int CatLvl;
    public int CurrentCost;
    public event Action Levelup;
    public virtual void Awake()
    {
        CurrentCost = (int)(startCost);
    }
    public virtual void OnMouseDown()
    {
        if (ScoreManager.score >= CurrentCost)
        {
            ClickEffect();
        }
    }
    public virtual void ClickEffect()
    {
        ScoreManager.score -= (int)(CurrentCost);
        CatLvl += 1;
        CurrentCost = (int)(CurrentCost * CatLvl * 1.3f);
    }
    protected virtual void LevelUpEvent()
    {
        Levelup?.Invoke();
    }
}
