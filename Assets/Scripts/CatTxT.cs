using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CatTxT : MonoBehaviour
{
    private TextMeshProUGUI LevelTxT;
    public BaseCat baseCat;

    private void Start()
    {
        LevelTxT = GetComponent<TextMeshProUGUI>();
        baseCat.Levelup += DisplayLevel;
    }

    private void Update()
    {
        DisplayLevel();
        
    }

    private void DisplayLevel()
    {
        LevelTxT.SetText("LvL:" + baseCat.CatLvl);
    }

}
