using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreP1 : MonoBehaviour
{
    [SerializeField]
    private GameObject p2_obj; //textオブジェクト
    [SerializeField]
    private GameMaster acquisition; //p2Scoreを持ってくる
    // Start is called before the first frame update
    void Start()
    {
        Text p2_text = p2_obj.GetComponent<Text>();

        if(acquisition.P2Score==0)
        {
            p2_text.text = "2P獲得枚数\n"+
                           "0枚";
        }
        else if(acquisition.P2Score==1)
        {
            p2_text.text = "2P獲得枚数\n"+
                           "1枚";
        }
        else
        {
            p2_text.text = "2P獲得枚数\n"+
                           "2枚";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
