<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour
{
    public List<GameObject> useList;

    private int _cardset;
    private float x,y;

    private int vecX;   //自然なかるた配置を作るための変数X
    private int vecY;   //自然なかるた配置を作るための変数Y
    private int vecZ;   //自然なかるた配置を作るための変数Z
    // Start is called before the first frame update
    void Start()
    {
        x = -1350f;
        y = 350f;
        // オブジェクト生成(useListの_cardsetの番号オブジェクトを指定座標に配置)
        for(int i = 0;i < 3;i++)
        {
             
            for(int j = 0; j < 10; j ++)
            {
                //カルタを自然にぐちゃぐちゃ配置する為のランダム
                vecX = Random.Range(-30,30);
                vecY = Random.Range(-30,30);
                vecZ = Random.Range(-15,15);


                Instantiate(useList[_cardset], new Vector3( x + vecX, y + vecY, 5f), 
                Quaternion.Euler(0, 180, vecZ));
                x += 300;
            }
            x = -1350;
            y -= 350;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
=======
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour
{
    public List<GameObject> useList;

    private int _cardset;
    private float x,y;

    private int vecX;   //自然なかるた配置を作るための変数X
    private int vecY;   //自然なかるた配置を作るための変数Y
    private int vecZ;   //自然なかるた配置を作るための変数Z
    // Start is called before the first frame update
    void Start()
    {
        x = -1350f;
        y = 350f;
        // オブジェクト生成(useListの_cardsetの番号オブジェクトを指定座標に配置)
        for(int i = 0;i < 3;i++)
        {
             
            for(int j = 0; j < 10; j ++)
            {
                //カルタを自然にぐちゃぐちゃ配置する為のランダム
                vecX = Random.Range(-30,30);
                vecY = Random.Range(-30,30);
                vecZ = Random.Range(-15,15);


                Instantiate(useList[_cardset], new Vector3( x + vecX, y + vecY, 5f), 
                Quaternion.Euler(0, 180, vecZ));
                x += 300;
            }
            x = -1350;
            y -= 350;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
>>>>>>> gssh
}