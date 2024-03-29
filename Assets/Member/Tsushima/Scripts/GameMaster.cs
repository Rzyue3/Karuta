using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[DisallowMultipleComponent]
public class GameMaster : MonoBehaviour
{
    public NextKarutaPik nextkarutapik;
    RoundStart roundstart;
    //public NextKaruta nextkaruta;      // インスペクターから拾う
    Shuffle shuffle;    // シャッフルを格納

    public GameObject gamemanager;   // シャッフル

    [SerializeField]
    AudioManager audiomanager;

    [SerializeField]
    RoundendobjAc Robjac;

    //private GameObject NextText; // Textオブジェクト
    [SerializeField]
    private Text text;
    private float _time;               // ランダムに読み上げ始める時の現在の時間
    private float _randTime;           // ランダムに読み上げ始める時間

    public string[] texts;//Unity上で入力するstringの配列
    public int textNumber;//何番目のtexts[]を表示させるか
    string displayText;//表示させるstring
    int textCharNumber;//何文字目をdisplayTextに追加するか
    float displayTextSpeed; //全体のフレームレートを落とす変数
    public bool textStop; //テキスト表示を始めるか
    [SerializeField]
    public GameObject textobj;

    [SerializeField]
    private float textspeed;

    [SerializeField]
    private GameObject P1Crosshair;
    [SerializeField]
    private GameObject P2Crosshair;

    // カルタの破壊された数
    [SerializeField]
    public int DestroyCount;
    
    [SerializeField]
    public int P1Score;
    [SerializeField]
    public int P2Score;
    [SerializeField]
    private List<GameObject> scoreobj;
    private float initTime;
    public int audiorand;
    AudioSource audioSource;
    public bool audiostart;

    [SerializeField]
    Shoot shot1p;
    [SerializeField]
    Shot2P shot2p;
    [SerializeField]
    Win1P win1p;
    [SerializeField]
    Win2P win2p;

    public bool initendflag;
    

    public bool karutainitpos;

    void Start()
    {
        //text = NextText.GetComponent<Text>();
        P1Score = 0;
        P2Score = 0;
        initTime = 0.0f;
        DestroyCount = 0;
        Debug.Log("オーディオ" + audiorand);
        shuffle = gamemanager.GetComponent<Shuffle>();
        roundstart = gamemanager.GetComponent<RoundStart>();
        audioSource = GetComponent<AudioSource>();
        audiorand = Random.Range(0,2);
        textStop = false;
        audiostart = false;
        StartCoroutine(shuffle.shufflekarutaAnim());
        nextkarutapik.startC();
        nextkarutapik.randompick();
        TimeSet();
        KarutaSystem();
        initendflag = true;
    }

    void Update()
    {
        // もし全てのカルタが破壊されたらタイトルへ戻す
        if(DestroyCount == 30)
        {
            SceneManager.LoadScene("Title");
        }

        // テキスト表示
        if(textStop)
        {
            textobj.SetActive(true);
            _time += Time.deltaTime;
            if(_randTime <= _time)
            {
                displayTextSpeed += Time.deltaTime;
                if (displayTextSpeed >= initTime)//textspeedに一回プログラムを実行するif文
                {
                    displayTextSpeed = 0;
                    initTime = textspeed;
                    if (textCharNumber != texts[textNumber].Length)//もしtext[textNumber]の文字列の文字が最後の文字じゃなければ
                    {
                        displayText = displayText + texts[textNumber][textCharNumber];//displayTextに文字を追加していく
                        textCharNumber = textCharNumber + 1;//次の文字にする
                    }
                }
                if(audiostart)
                {
                    audioplay(audiorand,textNumber);
                    audiostart = false;
                }
            }
            text.text = displayText;
        }

    }

    // 読み上げるタイミングをランダムにする
    void TimeSet()
    {
        if(DestroyCount >= 1)
            _randTime = Random.Range(10.0f,20.0f);
        _randTime = Random.Range(2.0f,10.0f);
    }

    // ラベル番号管理とテキスト表示開始
    void KarutaSystem()
    {
        _time = 0.0f;
        textNumber = nextkarutapik.LabelNum;
        Debug.Log("GameMaster" + textNumber);
        textStop = true;
    }

    public void audioplay(int i, int j)
    {
        if(i == 0)
        {
            audioSource.clip = audiomanager.MListAudioClip[j];
            audioSource.Play();
        }
        else
        {
            audioSource.clip = audiomanager.WListAudioClip[j];
            audioSource.Play();
        }
    }


    public void gameSetco(int i, GameObject obj)
    {
        P1Crosshair.SetActive(false);
        P2Crosshair.SetActive(false);
        shot1p.mag.initmag();
        shot2p.mag.initmag();
        shot1p.speedtype = false;
        shot2p.speedtype = false;
        displayText = "";
        Debug.Log("テキスト初期化");

        textCharNumber = 0;
        textStop = false;
        StartCoroutine(Robjac.objactive(i,textNumber,obj));
        textNumber = -1;
        _time = 0.0f;
        if(i == 0)
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
                StartCoroutine(win1p.Result());
                return;
            }
        }
        else
        {
            P2Score++;
            switch(P2Score)
            {
                case 1:scoreobj[3].SetActive(true);break;
                case 2:scoreobj[4].SetActive(true);break;
                case 3:scoreobj[5].SetActive(true);break;
            }
            if(P2Score == 3)
            {
                StartCoroutine(win2p.Result2());
                return;
            }

        }
        karutainitpos = true;

        audiorand = Random.Range(0,2);
        nextkarutapik.randompick();
        TimeSet();
        KarutaSystem();

        StartCoroutine(roundstart.FadeCo(0));

        karutainitpos = false;
    }

/*
    // どちらかがカルタを取った時実行
    public void gameSet(int i)
    {
        karutainitpos = true;
        if(i == 0)
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
            switch(P2Score)
            {
                case 1:scoreobj[3].SetActive(true);break;
                case 2:scoreobj[4].SetActive(true);break;
                case 3:scoreobj[5].SetActive(true);break;
            }
            if(P2Score == 3)
            {
                SceneManager.LoadScene("Lose");
            }

        }
        displayText = "";
        Debug.Log("テキスト初期化");
        textNumber = -1;
        textCharNumber = 0;
        textStop = false;
        karutainitpos = false;
        audiorand = Random.Range(0,2);
        nextkarutapik.randompick();
        TimeSet();
        KarutaSystem();
        roundstart.StartCoroutine("FadeCo");
        karutainitpos = false;

    }
*/
}
