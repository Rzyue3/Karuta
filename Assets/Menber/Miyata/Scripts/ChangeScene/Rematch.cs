using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rematch : MonoBehaviour
//リザルト画面から再戦への遷移スクリプト
{
    private string PlayerTag="Player1";
    private string PlayerTag2="Player2";

    public void OnTriggerStay(Collider other)
    {
        Debug.Log("判定");
        if(other.gameObject.tag==PlayerTag && Input.GetButtonDown("Fire3"))
        {
            SceneManager.LoadScene("MainGameScene");
        }
        if(other.gameObject.tag ==PlayerTag2 && Input.GetButtonDown("Fire3_2"))
        {
            SceneManager.LoadScene("MainGameScene");
        }
    }
}
