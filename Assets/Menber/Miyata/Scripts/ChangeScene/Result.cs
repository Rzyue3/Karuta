using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Result : MonoBehaviour
//リザルト画面から武器選択画面への遷移スクリプト
{

    private string PlayerTag="Player1";
    private string PlayerTag2="Player2";

    public void OnTriggerStay(Collider other)
    {
        Debug.Log("判定");
        if(other.gameObject.tag == PlayerTag && Input.GetButton("Fire3"))
        {
            SceneManager.LoadScene("WeaponsScene");
        }
        if(other.gameObject.tag == PlayerTag2 && Input.GetButton("Fire3_2"))
        {
            SceneManager.LoadScene("WeaponsScene");
        }
    }
}
