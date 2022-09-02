using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class Shuffle : MonoBehaviour
{
    public List<GameObject> Card;
    public List<GameObject> useList = new List<GameObject>();
    public List<GameObject> setList = new List<GameObject>();
    
    

    [SerializeField]
    GameObject Parent1;
    [SerializeField]
    Transform Parent2;//親

    public int DestroyNum2;

    Hit hit;
    private GameObject randomObj;   // ランダムに拾ったカルタを格納
    private int choiceNum;  // ランダムに拾ったカルタが被らないように元Listから削除
    private int _cardset;   // 配列の中身を回す
    private float x,y;  // カルタ配置座標
    private GameObject testGameObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void shufflekaruta()
    {
        for (int i = 0; i < 30; i++)
        {
            // ランダムにカルタを拾ってくる
            randomObj = Card[Random.Range(0, Card.Count)];
            useList.Add(randomObj);
            choiceNum = Card.IndexOf(randomObj);
            Card.RemoveAt(choiceNum);
        }
        x = -1500f;
        y = 450f;
        int _count = 0;

        // オブジェクト生成(useListの_cardsetの番号オブジェクトを指定座標に配置)
        for(int f = 0;f < 3;f++)
        {
            // カルタを配置
            for(int j = 0; j < 10; j ++)
            {
                //setList[_cardset] = Instantiate(useList[_cardset], new Vector3( x, y, 5f), Quaternion.identity,Parent2) as GameObject;
                
                var obj = Instantiate(useList[_cardset], new Vector3( x, y, 5f), Quaternion.identity,Parent2) as GameObject;
                setList.Add(obj);
                obj.SetActive(true);
                hit = setList[_cardset].GetComponent<Hit>();
                hit.tetslabe += _count;
                hit.NextK = false;
                ++_cardset;
                x += 335;
                _count ++;
            }
            x = -1500;
            y -= 450;
        }
        
    
    }
}
