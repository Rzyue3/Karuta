using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextKaruta : MonoBehaviour
{
    // 宣言
    public GameObject Sf;   // シャッフル
    private GameObject randomObj = null;    // ランダムに拾ってきたカルタ
    
    Hit hit;        // 拾ってきたカルタから格納
    Shuffle shuffle;    // シャッフルを格納

    public int P1Score,P2Score; // どちらがラウンドを取ったか、勝敗管理
    public int LabelNum;        // カルタの番号格納
    private int DestroyNum;     // ひろったカルタをuseListから削除するための変数



    public bool NextKRe1 = false;   // 次のラウンドに移行するためのフラグ
    public bool NextKRe2 = false;   // 次のラウンドに移行するためのフラグ 
    public bool NextGM = false;     // 次のラウンドに移行するためのフラグ

    void Start()
    {
        // 変数に格納 
        shuffle = Sf.GetComponent<Shuffle>(); 
    }

    void Update()
    {
        // プレイヤー1が取得
        if(NextKRe1)
        {
            NextKRe1 = false;
            ++P1Score;          
            pkKrt();            // 現在の指定カルタをリストから削除
            randomObj = null;   // randomObjを初期化
            pkKrt();            // 次のカルタ指定
            NextGM = true;      // GameMasterも初期化

            /*
            26/18:26 ここに取得処理最新
            */
        }

        // プレイヤー2が取得
        if(NextKRe2)
        {
            NextKRe2 = false;
            ++P2Score;          
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
            randomObj = shuffle.useList[Random.Range(0, shuffle.useList.Count)];
            hit = randomObj.GetComponent<Hit>();
            hit.NextK = true;
            LabelNum = hit.KarutaLabel;
        }
        else
        {
            DestroyNum = shuffle.useList.IndexOf(randomObj);
            shuffle.useList.RemoveAt(DestroyNum);
            Destroy(randomObj);

        }
    }
}
