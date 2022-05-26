using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextKaruta : MonoBehaviour
{
    GameObject tttst;
    Shuffle script;
    private GameObject randomObj = null;
    
    Hit hit;
    public int LabelNum;
    private int DestroyNum;

    private bool test001;

    public int P1Score,P2Score;

    public bool NextKRe1 = false;
    public bool NextKRe2 = false;
    public bool NextGM = false;

    void Start()
    {
        tttst = GameObject.Find ("GM"); 
        script = tttst.GetComponent<Shuffle>(); 
    }

    void Update()
    {
        if(NextKRe1)
        {
            NextKRe1 = false;
            ++P1Score;
            pkKrt();
            randomObj = null;
            pkKrt();
            NextGM = true;

            /*
            26/18:26 ここに取得処理最新
            */
        }
    }
    void pkKrt()
    {
        
        if(randomObj == null)
        {
            randomObj = script.useList[Random.Range(0, script.useList.Count)];
            hit = randomObj.GetComponent<Hit>();
            hit.NextK = true;
            LabelNum = hit.KarutaLabel;
        }
        else
        {
            DestroyNum = script.useList.IndexOf(randomObj);
            script.useList.RemoveAt(DestroyNum);
            Destroy(randomObj);

        }
    }
}
