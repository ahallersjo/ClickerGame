using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class CatCat : BaseCat
{
    public int catcash;
    public override void Awake()
    {
        base.Awake();
        catcash = 1;    
    }
    private void Start()
    {
        StartCoroutine(PointsOverTime());
    }

    public virtual IEnumerator PointsOverTime()
    {
        yield return new WaitForSeconds(1);
        ScoreManager.score += CatLvl * catcash; //Denna ger arv till senare därför har vi catlvl * catcash och inte bara catlvl som poäng
        StartCoroutine(PointsOverTime());
    }
}
