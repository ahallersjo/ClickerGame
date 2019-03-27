using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour

{

    private void OnMouseEnter()
    {
        //changecolour
        GetComponent<SpriteRenderer>().color = Color.yellow;

    }
    public void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.gray;
        ScoreManager.score += WorkerCat.clickpoints;
    }
    public void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().color = Color.yellow;
    }
    private void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
    }
}

