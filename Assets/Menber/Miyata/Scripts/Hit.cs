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

    

    public GameObject gamemanager;
    Shuffle script;
    NextKaruta nextkaruta;
    GameMaster gamemaster;
    public int tett;
    public int tetslabe;

    void Start()
    {
        Player1Atk = true;
        Player2Atk = true;

        script = gamemanager.GetComponent<Shuffle>(); 
        nextkaruta = gamemanager.GetComponent<NextKaruta>();
    }

    void Update()
    {
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
        if(Player1Atk &&Input.GetMouseButtonDown(0) && Player1CT)
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
    public void OnTriggerStay(Collider Hit)
    {
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
                Player1ct = false;
                Debug.Log("Hit!!");
                CardHP -= 50;
                // �J�[�h��HP��0�ɂȂ����炱�̃I�u�W�F�N�g��j��
                if (CardHP <= 0)
                {
                            gamemaster = gamemanager.GetComponent<GameMaster>();

                    if(gameObject == nextkaruta.randompickObj)
                    {
                        Debug.Log(KarutaLabel);
                        Debug.Log(gamemaster.textNumber);
                        Debug.Log("NextK");
                        nextkaruta.testNextKaruta();
                        //nextkaruta.NextKRe1 = true;
                    }
                    else
                    {
                        Debug.Log("elseHP0 P1");
                        Debug.Log(KarutaLabel);
                        Debug.Log(gamemaster.textNumber);
                        Debug.Log("tett" + tett);

                        // useListから削除
                        //DestroyNum = script.useList.IndexOf(this.gameObject);
                        //script.useList.Remove(this.gameObject);
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


    }
    */
    public void Damage()
    {
        Debug.Log("HP-");
        Debug.Log(tetslabe);
    }


}