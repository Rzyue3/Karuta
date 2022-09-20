using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreP2 : MonoBehaviour
{
    [SerializeField]
    private GameObject p1_obj = null; //textオブジェクト
    [SerializeField]
    private GameMaster master; //p1Scoreをもってくる
    // Start is called before the first frame update
    void Start()
    {
        Text p1_text = p1_obj.GetComponent<Text>();

        if(master.P1Score==0)
        {
            p1_text.text = "1P獲得枚数\n"+
                           "0枚";
        }
        else if(master.P2Score==1)
        {
            p1_text.text = "1P獲得枚数\n"+
                           "1枚";
        }
        else
        {
            p1_text.text = "1P獲得枚数\n"+
                           "2枚";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
