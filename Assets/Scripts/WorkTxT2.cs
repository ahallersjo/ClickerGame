using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WorkTxT2 : MonoBehaviour
{
    private TextMeshProUGUI LevelTxT;
    public WorkerCat workercost;

    private void Start()
    {
        LevelTxT = GetComponent<TextMeshProUGUI>();
        workercost.Levelup += DisplayLevel;
        DisplayLevel();
    }
    private void DisplayLevel()
    {
        LevelTxT.SetText("Cost:" + workercost.CurrentCost.ToString());
    }

}
