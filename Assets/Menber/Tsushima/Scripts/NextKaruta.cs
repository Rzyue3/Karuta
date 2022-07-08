using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextKaruta : MonoBehaviour
{
    // 宣言
    public GameObject Sf;   // シャッフル
    [SerializeField]
    public GameObject randompickObj;    // ランダムに拾ってきたカルタ
    private GameObject testObj;
    
    Hit hit;        // 拾ってきたカルタから格納
    Hit hit2;
    public Shuffle shuffle;    // シャッフルを格納
    public GameMaster gamemaster;

    public int P1Score,P2Score; // どちらがラウンドを取ったか、勝敗管理
    public int LabelNum;        // カルタの番号格納
    public int DestroyNum;     // ひろったカルタをuseListから削除するための変数

    

    public bool NextKRe1 = false;   // 次のラウンドに移行するためのフラグ
    public bool NextKRe2 = false;   // 次のラウンドに移行するためのフラグ 
    public bool NextGM = false;     // 次のラウンドに移行するためのフラグ

    public int testint;
    public bool testflag = false;
    public bool tetetet = false;

    public bool wakaran = false;

    public bool test004 = false;
    void Start()
    {
        // 変数に格納 
        shuffle = Sf.GetComponent<Shuffle>();
        randompickObj = null;
        DestroyNum = 0;
        testint = 0;
        tetetet = false;
    }

    void Update()
    {
        Debug.Log("Testすぐ消す" + testint);
        if(tetetet)
        {
            hit2 = testObj.GetComponent<Hit>();
            if(tetetet && DestroyNum == hit2.tetslabe)
            {
                Debug.Log("ok");
            }
            else if (tetetet && DestroyNum != hit2.tetslabe)
            {
                tetetet = false;
                Debug.Log(DestroyNum);
                Debug.Log(testint);
                Debug.Log(hit.tetslabe);
                Debug.Log("miss");
            }

        }

        if(!randompickObj && test004)
        {
            Debug.Log("test");
        }
        // プレイヤー1が取得
        if(NextKRe1)
        {
            Debug.Log("NextRe1");
            NextKRe1 = false;
            ++P1Score;          
            testflag = true;            // 現在の指定カルタをリストから削除
            randompickObj = null;   // randomObjを初期化
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
            //DestroyK();
            randompickObj = null;
            pkKrt();
            NextGM = true;

            /*
            26/18:26 ここに取得処理最新
            */
        }

    }
    public void pkKrt()
    {
        if(wakaran)
        {

            testhitnum(hit.tetslabe,DestroyNum);
        }
        else
        {
            randompickObj = shuffle.useList[Random.Range(0, shuffle.useList.Count)];
            Debug.Log("get");
            DestroyNum = shuffle.useList.IndexOf(randompickObj);
            hit = randompickObj.GetComponent<Hit>();
            
            Debug.Log("Hitget");
            hit.NextK = true;
            LabelNum = hit.KarutaLabel;
            testint = DestroyNum;
            Debug.Log("Dstrynum" + DestroyNum);

            Debug.Log("LabelNum" + LabelNum);

            Debug.Log("tetslabe.nextK" + hit.tetslabe);

        }

/*     
        if (testflag)
        {
            testflag = false;
            Debug.Log("DestroyK1");
            //DestroyNum = shuffle.useList.IndexOf(randomObj);
            Debug.Log("DestroyK2");
            shuffle.useList.RemoveAt(hit.tetslabe);
            Destroy(randomObj);

        }
        else
        {
        randomObj = shuffle.useList[Random.Range(0, shuffle.useList.Count)];
        Debug.Log("get");
        DestroyNum = shuffle.useList.IndexOf(randomObj);
        hit = randomObj.GetComponent<Hit>();
        //randomObj.AddComponent<Destroy>();
        Debug.Log("Hitget");      
        hit.NextK = true;
        LabelNum = hit.KarutaLabel;

        }
 */

    }

    public void Deskaruta()
    {
        Debug.Log("DestroyK1");
        //DestroyNum = shuffle.useList.IndexOf(randomObj);
        Debug.Log("DestroyK2");
        shuffle.useList.RemoveAt(hit.tetslabe);
        Destroy(randompickObj);

    }

    /*
    public void DestroyK()
    {
        Debug.Log("DestroyK1");
        DestroyNum = shuffle.useList.IndexOf(randomObj);
        Debug.Log("DestroyK2");
        shuffle.useList.RemoveAt(DestroyNum);
        randomObj.SetActive(false);

    }
    */

    public void testhitnum(int i,int j)
    {
        gamemaster = Sf.GetComponent<GameMaster>();

        Debug.Log("DestroyNUm" + j);
        Debug.Log("testhitnum" + i);
        if(i == j)
        {
            Debug.Log("Clea");
        }
        else
        {
            Debug.Log("nonono");
        }

    }

    public void testNextKaruta()
    {
        Debug.Log("NextRe1");
        NextKRe1 = false;
        ++P1Score;
        testflag = true;            // 現在の指定カルタをリストから削除
        pkKrt();            //           
        //DestroyK();            // 現在の指定カルタをリストから削除
        randompickObj = null;   // randomObjを初期化
        pkKrt();            // 次のカルタ指定
        NextGM = true;      // GameMasterも初期化

    }
}
