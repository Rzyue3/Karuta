using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour
{
    public List<GameObject> useList;

    private int _cardset;
    private float x,y;
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
                Instantiate(useList[_cardset], new Vector3( x, y, 5f), Quaternion.Euler(0, 180, 0));
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
}
