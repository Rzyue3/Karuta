using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{

    // 
    public int CardHP = 150;

    private bool Player1Atk, Player2Atk,Player1ct,Player1CT,Player2ct,Player2CT;
    public bool NextK;

    private float _P1time, _P2time;

    private int DestroyNum;

    public int KarutaLabel;

    public bool crackflag;

    public GameObject gamemanager;
    
    Shuffle script;
    NextKarutaPik nextpik;
    GameMaster gamemaster;
    [SerializeField]
    Cardcrack crack;
    
    [SerializeField]
    float LimitSpeed;

    public int Arrangenum;

    private Vector3 startpos;

    [SerializeField]
    private GameObject whiteobj;

    [SerializeField]
    private Canvas Rightletter;

    private Animator anim;
    private bool animendflag;
    private float animendflagtimer;

    private bool inf;

    void Start()
    {
        startpos = this.gameObject.transform.position;
        Player1Atk = true;
        Player2Atk = true;
        crackflag = false;
        inf = true;
        script = gamemanager.GetComponent<Shuffle>(); 
        gamemaster = gamemanager.GetComponent<GameMaster>();
        nextpik = gamemanager.GetComponent<NextKarutaPik>();
        anim = this.gameObject.GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        Rigidbody rb = this.GetComponent<Rigidbody>(); // rigidbodyを取得
        if (rb.velocity.magnitude > LimitSpeed)
        {
            rb.velocity = new Vector3(rb.velocity.x / 1.5f, rb.velocity.y / 1.5f, rb.velocity.z / 1.5f);
        }

    }

    void Update()
    {


        // 画面外にいかないように
        var min = Camera.main.ViewportToWorldPoint(Vector2.zero);
        var max = Camera.main.ViewportToWorldPoint(Vector2.one);
        if(this.gameObject.transform.position.x < min.x || this.gameObject.transform.position.y < min.y || this.gameObject.transform.position.x > min.x || this.gameObject.transform.position.y > min.y)
        {
            Debug.Log("成功");
            this.gameObject.transform.position = new Vector3
            (
                Mathf.Clamp( this.gameObject.transform.position.x, min.x, max.x ),
                Mathf.Clamp( this.gameObject.transform.position.y, min.y, max.y ),
                0.0f
            );
        }

        if(gamemaster.karutainitpos)
        {
            this.gameObject.transform.position = startpos;
        }

    
        if (Player1Atk == false)
        {
            _P1time += Time.deltaTime;
            {
                if (_P1time >= 0.1f)
                {
                    _P1time = 0.0f;
                    Player1Atk = true;
                }
            }
        }

        if (Player2Atk == false)
        {
            _P2time += Time.deltaTime;
            if (_P2time >= 0.1f)
            {
                _P2time = 0.0f;
                Player1Atk = true;
            }
        }
        if(Player1Atk && Player1CT)
        {
            Player1ct = true;
            Player1Atk = false;
        }

        if(animendflag)
        {
            animendflagtimer += Time.deltaTime;
            if(animendflagtimer >= 0.8f)
            {
                anim.SetBool("HitAnim",false);
                animendflag = false;
                animendflagtimer = 0.0f;
            }
        }
    }


    public void OnTriggerEnter(Collider Hit)
    {
        if(Hit.CompareTag("Bullet1"))
        {
            if(NextK)
            {
                CardHP -= Damagesc.player1damage;
                if(CardHP <= 145)
                    whiteobj.SetActive(true);
                Debug.Log("当たりました");
                crackflag = true;
                Destroy(Hit);
                crack.Damagecrack();
                if(!animendflag)
                {
                    anim.SetBool("HitAnim",true);
                    animendflag = true;
                }
                animendflagtimer = 0.0f;
                if(CardHP<=0)
                {
                    Rightletter.sortingOrder = 20;
//                    StartCoroutine(gamemaster.gameSetco(0,this.gameObject));
                    gamemaster.gameSetco(0,this.gameObject);
                    this.gameObject.SetActive(false);
                    crack.destroyimg();
                    whiteobj.SetActive(false);
                    gamemaster.textobj.SetActive(false);
                    gamemaster.DestroyCount++;
                }
            }

        }
        
        if(Hit.CompareTag("Bullet2"))
        {
            if(NextK)
            {
                CardHP -= Damagesc.player2damage;
                if(CardHP <= 145)
                    whiteobj.SetActive(true);
                crack.Damagecrack();
                Debug.Log("当たりました");
                crackflag = true;
                Destroy(Hit);
                if(!animendflag)
                {
                    anim.SetBool("HitAnim",true);
                    animendflag = true;
                }
                if(CardHP<=0)
                {
                    Rightletter.sortingOrder = 20;
//                    StartCoroutine(gamemaster.gameSetco(1,this.gameObject));
                    gamemaster.gameSetco(1,this.gameObject);
                    this.gameObject.SetActive(false);
                    crack.destroyimg();
                    whiteobj.SetActive(false);
                    gamemaster.textobj.SetActive(false);
                    gamemaster.DestroyCount++;
                }
            }
        }
       
    }


    


}