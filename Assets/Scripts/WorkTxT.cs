using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WorkTxT : MonoBehaviour
{
    private TextMeshProUGUI LevelTxT;
    public WorkerCat workerCat;

    private void Start()
    {
        LevelTxT = GetComponent<TextMeshProUGUI>();
        workerCat.Levelup += DisplayLevel;
        DisplayLevel();
    }
    private void DisplayLevel()
    {
        LevelTxT.SetText("LvL:" + workerCat.CatLvl.ToString());
    }

}
