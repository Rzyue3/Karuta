using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load2nd : MonoBehaviour
{
    int selectCharaNumber;

    void Start()
    {
        selectCharaNumber = 0; //selectCharaNumberの初期化
    }

    public void OnClickA()
    {
        selectCharaNumber = 0; //スピードが押されたとき0を代入
    }
    public void OnClickB()
    {
        selectCharaNumber = 1; //バランスが押されたとき1を代入
    }

    public void OnClickC()
    {
        selectCharaNumber = 2; //パワーが押されたとき2を代入
    }

    public void OnClickStart()
    {
        PlayerPrefs.SetInt("CHARA_NUMBER", selectCharaNumber);
        SceneManager.LoadScene("MainGameScene");
    }
}
