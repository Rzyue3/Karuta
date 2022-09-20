using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[DisallowMultipleComponent]
public class Shuffle : MonoBehaviour
{
    public List<GameObject> Card;
    public List<GameObject> useList = new List<GameObject>();
    public List<GameObject> setList = new List<GameObject>();
    
    [SerializeField]
    private List<Texture2D> KarutaBack;

    [SerializeField]
    GameObject Parent1;
    [SerializeField]
    Transform Parent2;//親

    [SerializeField]
    private float speed;
    float step;

    public int DestroyNum2;

    private GameObject randomObj;   // ランダムに拾ったカルタを格納
    private int choiceNum;  // ランダムに拾ったカルタが被らないように元Listから削除
    private int _cardset;   // 配列の中身を回す
    private float x,y;  // カルタ配置座標
    private GameObject testGameObj;

    private bool endflag;

    void Update()
    {
        step = speed * Time.deltaTime;
    }

/*
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
                var hit = setList[_cardset].GetComponent<Hit>();
                hit.Arrangenum += _count;
                hit.NextK = false;
                ++_cardset;
                x += 335;
                _count ++;
            }
            x = -1500;
            y -= 450;
        }
        
    
    }
*/
    public IEnumerator shufflekarutaAnim()
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
        //x = 1580;
        //y = -580;
        int _count = 0;

        // オブジェクト生成(useListの_cardsetの番号オブジェクトを指定座標に配置)
        for(int f = 0;f < 3;f++)
        {
            // カルタを配置
            for(int j = 0; j < 10; j ++)
            {
                //setList[_cardset] = Instantiate(useList[_cardset], new Vector3( x, y, 5f), Quaternion.identity,Parent2) as GameObject;
                var obj = Instantiate(useList[_cardset], new Vector3( x, y, 5f), Quaternion.identity,Parent2) as GameObject;
                //yield return new WaitForSeconds(0.2f);

                setList.Add(obj);
                var rimg = obj.GetComponent<RawImage>();
                rimg.texture = KarutaBack[Random.Range(0, KarutaBack.Count)];
                var hit = obj.GetComponent<Hit>();
                hit.Arrangenum += _count;
                hit.NextK = false;
                obj.SetActive(true);
                
                ++_cardset;
                x += 335;
                _count ++;


                
            }
            x = -1500;
            y -= 450;
        }
        yield return new WaitForSeconds(1);
    }
}
