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
    NextKaruta nextkaruta;
    TestNextKarutaPik testpik;
    GameMaster gamemaster;
    [SerializeField]
    Cardcrack crack;
    
    [SerializeField]
    float LimitSpeed;

    public int tett;
    public int tetslabe;

    private Vector3 startpos;

    [SerializeField]
    private GameObject whiteobj;

    void Start()
    {
        startpos = this.gameObject.transform.position;
        Player1Atk = true;
        Player2Atk = true;
        crackflag = false;
        script = gamemanager.GetComponent<Shuffle>(); 
        nextkaruta = gamemanager.GetComponent<NextKaruta>();
        gamemaster = gamemanager.GetComponent<GameMaster>();
        testpik = gamemanager.GetComponent<TestNextKarutaPik>();
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


        

        /*
        if(Player2Atk &&Input.GetMouseButtonDown(0) && Player2CT)
        {
            Player2ct = true;
            Player2Atk = false;
        }
        */

    }
    /*
    public void OnTriggerStay(Collider Hit)
    {
        //Debug.Log("ColHit");
        //Debug.Log("hitLabelNum" + nextkaruta.LabelNum);
        if(!Player1Atk)
        {
            Player1CT = false;
        }
        if(!Player2Atk)
        {
            Player2CT = false;
        }

        if (Hit.CompareTag("Player1"))
        {
            Player1CT = true;
            if(Player1ct)
            {
                //gamemaster.tetetest = tetslabe;
                Player1ct = false;
                Debug.Log("Hit!!");
                CardHP -= 50;
//                CardHP -= damagesc.player1damage;
                // �J�[�h��HP��0�ɂȂ����炱�̃I�u�W�F�N�g��j��
                if (CardHP <= 0)
                {
                    Debug.Log("NextK" +NextK);
                    if(NextK)
                    {
                        gamemaster.gameSet(1);
//                        gamemaster.testText();
                        this.gameObject.SetActive(false);

                        //nextkaruta.NextKRe1 = true;
                    }
                    else
                    {

                        // useListから削除
                        //DestroyNum = script.setList.IndexOf(this.gameObject);
                        //script.setList.Remove(this.gameObject);
                        //Destroy(this.gameObject);
                        this.gameObject.SetActive (false);

                    }
                    
                }
            }           
        }

        
        if (Hit.CompareTag("Player2"))
        {
            Player2CT = true;
            if(Player2ct)
            {
                Player2ct = false;
                Debug.Log("Hit!!");
                CardHP -= 50;
                CardHP -= damagesc.player2damage;
                // �J�[�h��HP��0�ɂȂ����炱�̃I�u�W�F�N�g��j��
                if (CardHP <= 0)
                {
                    if(NextK)
                    {
                        Debug.Log("NextK");
                        nextkaruta.NextKRe2 = true;
                    }
                    // useListから削除
                    DestroyNum = script.useList.IndexOf(this.gameObject);
                    script.useList.RemoveAt(DestroyNum);
                    Destroy(this.gameObject);
                }
            }           
        }
        
    }
    */
    public void OnTriggerEnter(Collider Hit)
    {
        if(Hit.CompareTag("Player1"))
        {
            if(NextK)
            {
                //CardHP-=50;
                whiteobj.SetActive(true);
                CardHP -= Damagesc.player1damage;
                crack.Damagecrack();
                Debug.Log("当たりました");
                crackflag = true;
                Destroy(Hit);
                if(CardHP<=0)
                {
                    gamemaster.gameSet(0);
                    this.gameObject.SetActive(false);

                    gamemaster.DestroyCount++;
                    /*
                    if(NextK)
                    {
                        gamemaster.gameSet(0);
                        this.gameObject.SetActive(false);

                    }
                    else
                    {
                        this.gameObject.SetActive (false);
                    }
                    */
                }

            }
        }
        
        if(Hit.CompareTag("Player2"))
        {
            if(NextK)
            {
                //CardHP-=50;
                whiteobj.SetActive(true);
                CardHP -= Damagesc.player2damage;
                Debug.Log("当たりました");
                crackflag = true;
                Destroy(Hit);
                if(CardHP<=0)
                {
                    gamemaster.gameSet(0);
                    this.gameObject.SetActive(false);

                    gamemaster.DestroyCount++;
                    /*
                    if(NextK)
                    {
                        gamemaster.gameSet(0);
                        this.gameObject.SetActive(false);

                    }
                    else
                    {
                        this.gameObject.SetActive (false);
                    }
                    */
                }
            
            }
        }
       
    }
    /*
    使わないかもしれない
    void getkaruta()
    {
        if(NextKRe)
        {
            ここにカルタ取得時拡大処理
            transform
            Input.GetMouseButtonDown(0)
                DestroyNum = script.useList.IndexOf(this.gameObject);
                script.useList.RemoveAt(DestroyNum);
                Destroy(this.gameObject);

        }

*/
        
    
    


    
    public void Damage()
    {
        Debug.Log("HP-");
        Debug.Log(tetslabe);
    }

}