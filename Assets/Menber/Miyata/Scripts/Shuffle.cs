using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuffle : MonoBehaviour
{
    public List<GameObject> Card;
    public List<GameObject> useList = new List<GameObject>();
    [SerializeField]
    private GameObject parent;
    [SerializeField]
    Transform Parent2;//親

    private GameObject randomObj;   // ランダムに拾ったカルタを格納
    private int choiceNum;  // ランダムに拾ったカルタが被らないように元Listから削除
    private int _cardset;   // 配列の中身を回す
    private float x,y;  // カルタ配置座標

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            // ランダムにカルタを拾ってくる
            randomObj = Card[Random.Range(0, Card.Count)];
            useList.Add(randomObj);
            choiceNum = Card.IndexOf(randomObj);
            Card.RemoveAt(choiceNum);
        }
        x = -1350f;
        y = 350f;
        // オブジェクト生成(useListの_cardsetの番号オブジェクトを指定座標に配置)
        for(int f = 0;f < 3;f++)
        {
             // カルタを配置
            for(int j = 0; j < 10; j ++)
            {
                parent = (GameObject)Instantiate(useList[_cardset], new Vector3( x, y, 5f), Quaternion.Euler(0, 180, 0),Parent2);
                //++_cardset;
                x += 300;
            }
            x = -1350;
            y -= 350;
        }
    }

}
