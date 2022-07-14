using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[DisallowMultipleComponent]
public class GameMaster : MonoBehaviour
{
    public TestNextKarutaPik testnextkarutapik;
    RoundStart roundstart;
    //public NextKaruta nextkaruta;      // インスペクターから拾う
    Shuffle shuffle;    // シャッフルを格納

    public GameObject gamemanager;   // シャッフル
    
    //private GameObject NextText; // Textオブジェクト
    [SerializeField]
    private Text text;
    private float _time;               // ランダムに読み上げ始める時の現在の時間
    private float _randTime;           // ランダムに読み上げ始める時間

    public string[] texts;//Unity上で入力するstringの配列
    public int textNumber;//何番目のtexts[]を表示させるか
    string displayText;//表示させるstring
    int textCharNumber;//何文字目をdisplayTextに追加するか
    int displayTextSpeed; //全体のフレームレートを落とす変数
    public bool textStop; //テキスト表示を始めるか

    [SerializeField]
    private int textspeed;

    public int tetetest;
    public bool testbool;
    
    [SerializeField]
    private int P1Score;
    [SerializeField]
    private int P2Score;
    [SerializeField]
    private List<GameObject> scoreobj;

    void Start()
    {
        //text = NextText.GetComponent<Text>();
        P1Score = 0;
        P2Score = 0;
        shuffle = gamemanager.GetComponent<Shuffle>();
        roundstart = gamemanager.GetComponent<RoundStart>();

        testbool = false;
        textStop = false;
        shuffle.shufflekaruta();
//        nextkaruta.pkKrt();
        testnextkarutapik.startC();
        testnextkarutapik.randompick();
        TimeSet();
        KarutaSystem();
    }

    void Update()
    {
        /*
        if(testbool)
        {
            testbool = false;
            testnextkarutapik.Destroykaruta(textNumber);
        }
        
        // 勝敗
        if(nextkaruta.P1Score >= 3)
        {
            
        }
        if(nextkaruta.P2Score >= 3)
        {

        }

        // 次のラウンドに移行するためのセットアップ
        if(nextkaruta.NextGM)
        {
            nextkaruta.NextGM = false;
            NextText.GetComponent<Text>().text = null;  // テキストを初期化
            TimeSet();
            KarutaSystem();
        }
*/
        // テキスト表示
        if(textStop)
        {
            _time += Time.deltaTime;
            if(_randTime <= _time)
            {
                displayTextSpeed++;
                if (displayTextSpeed % textspeed == 0)//textspeedに一回プログラムを実行するif文
                {

                    if (textCharNumber != texts[textNumber].Length)//もしtext[textNumber]の文字列の文字が最後の文字じゃなければ
                    {
                        displayText = displayText + texts[textNumber][textCharNumber];//displayTextに文字を追加していく
                        textCharNumber = textCharNumber + 1;//次の文字にする
                    }
                }
            }
            text.text = displayText;
        }

    }

    // 読み上げるタイミングをランダムにする
    void TimeSet()
    {
        _randTime = Random.Range(2.0f,10.0f);
    }

    // ラベル番号管理とテキスト表示開始
    void KarutaSystem()
    {
        _time = 0.0f;
        textNumber = testnextkarutapik.LabelNum;
        Debug.Log("GameMaster" + textNumber);
        textStop = true;
        /*
        switch(nextkaruta.LabelNum)
        {
            case 1:
            {
                textStop = true;
                break;
            }
            case 2:
            {
                break;
            }
        }
        */
    }

    public void testText()
    {
        



    }

    public void gameSet(int i)
    {
        if(i == 1)
        {
            P1Score++;
            switch(P1Score)
            {
                case 1:scoreobj[0].SetActive(true);break;
                case 2:scoreobj[1].SetActive(true);break;
                case 3:scoreobj[2].SetActive(true);break;
            }
            Debug.Log("Player1Score:" + P1Score);
            if(P1Score == 3)
            {
                SceneManager.LoadScene("Win");
            }
        }
        else
        {
            P2Score++;
            if(P2Score == 3)
            {
                SceneManager.LoadScene("Lose");
            }

        }
        displayText = "";
        //NextText.GetComponent<Text>().text = displayText;
        Debug.Log("テキスト初期化");
        textNumber = -1;
        textCharNumber = 0;
        textStop = false;
        testnextkarutapik.randompick();
        TimeSet();
        KarutaSystem();
        //アタッチしてない早くやれ 07091533
        roundstart.StartCoroutine("FadeCo");

    }
/*    void TextTTS()
    {
       if (textStop == false) //テキストを表示させるif文
        { 
            displayTextSpeed++;
            if (displayTextSpeed % 5 == 0)//５回に一回プログラムを実行するif文
            {

                if (textCharNumber != texts[textNumber].Length)//もしtext[textNumber]の文字列の文字が最後の文字じゃなければ
                {
                    displayText = displayText + texts[textNumber][textCharNumber];//displayTextに文字を追加していく
                    textCharNumber = textCharNumber + 1;//次の文字にする
                }
            }
            Text nexttext = NextText.GetComponent<Text> ();
        } 
    }
*/
}
