using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextKarutaDestroy : MonoBehaviour
{
    Hit hit;        // 拾ってきたカルタから格納
    NextKaruta nextkaruta;
    GameObject obj;

    void Start() 
    {
        obj = GameObject.Find("GameManager");
        nextkaruta = obj.GetComponent<NextKaruta>();
        hit = gameObject.GetComponent<Hit>();
        
    }

    void Update()
    {
        if(hit.CardHP <= 0 )
        {
            nextkaruta.test004 = true;
            Debug.Log("DestroyCS");
        }
        
    }
}
