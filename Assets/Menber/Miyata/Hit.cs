using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    // 得点処理未実装
    // お手付き未実装

    // 名前付け
    // カードの初期HP設定
    public int CardHP = 150;

    private bool Player1Atk, Player2Atk;

    private float _P1time, _P2time;


    void Start()
    {
        
        
     


    }

    void Update()
    {


        // RigidbodyのNever Sleepで判定を回収している時
        // 1クリックで2回以上拾うことがあるので応急処置として 0.05 のディレイを入れてます
        // 未改修
        if (Player1Atk == false)
        {
            _P1time += Time.deltaTime;
            {
                if (_P1time >= 0.05f)
                {
                    _P1time = 0.0f;
                    Player1Atk = true;
                }
            }
        }

        // RigidbodyのNever Sleepで判定を回収している時
        // 1クリックで2回以上拾うことがあるので応急処置として 0.05 のディレイを入れてます
        // 未改修
        if (Player2Atk == false)
        {
            _P2time += Time.deltaTime;
            if (_P1time >= 0.05f)
            {
                _P1time = 0.0f;
                Player1Atk = true;
            }
        }

    }
    public void OnTriggerStay2D(Collider2D Hit)
    {
        // クロスヘア(Playerタグの物)が重なっている時マウス左クリックで
        // カードのHPを50減らす
        if (Input.GetMouseButtonDown(0) && Hit.CompareTag("Player") && Player1Atk)
        {
            Debug.Log("Hit!!");
            CardHP -= 50;
            // カードのHPが0になったらこのオブジェクトを破壊
            if (CardHP <= 0)
            {
                Destroy(this.gameObject);
                
            }
        }
        if (Input.GetMouseButtonDown(0) && Hit.CompareTag("Player") && Player2Atk)
        {
            Debug.Log("Hit!!");
            CardHP -= 50;
            // カードのHPが0になったらこのオブジェクトを破壊
            if (CardHP <= 0)
            {
                Destroy(this.gameObject);
               
            }
        }

    }

}