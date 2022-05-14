using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour
{
    public List<GameObject> useList;

    private int _cardset;

    // Start is called before the first frame update
    void Start()
    {
        // オブジェクト生成(useListの_cardsetの番号オブジェクトを指定座標に配置)
        for(int x = -4; x < 6; x++)
        {
            for(int y = -1; y < 2; y++)
            {
                Instantiate(useList[_cardset], new Vector3( x * 9f, y * 8f, 30), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
