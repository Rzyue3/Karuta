using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuffle : MonoBehaviour
{
    public List<GameObject> Card;
    public List<GameObject> useList = new List<GameObject>();
    private GameObject randomObj;
    private int choiceNum;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 30; i++)
        {
            //cardListの中からランダムで1つを選ぶ
            //選んだオブジェクトをuseListに追加
            //選んだオブジェクトのリスト番号を取得
            //同じリスト番号をcardListから削除
            randomObj = Card[Random.Range(0, Card.Count)];
            useList.Add(randomObj);
            choiceNum = Card.IndexOf(randomObj);
            Card.RemoveAt(choiceNum);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
