using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Result : MonoBehaviour
//リザルト画面からタイトルへの遷移スクリプト
{
    private string Resulttag = "resulttag";

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag==Resulttag)
        {
            SceneManager.LoadScene("Title");
        }
    }
}
