using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Load2nd : MonoBehaviour
{
    [SerializeField]
    Button speed;
    [SerializeField]
    Button balance;
    [SerializeField]
    Button power;
    [SerializeField]
    Button ready;
    
    int selectCharaNumber;

    void Start()
    {
        selectCharaNumber = 0; //selectCharaNumberの初期化
    }

    // public void OnClickA()
    // {
    //     selectCharaNumber = 1; //スピードが押されたとき0を代入
    // }
    // public void OnClickB()
    // {
    //     selectCharaNumber = 2; //バランスが押されたとき1を代入
    // }

    // public void OnClickC()
    // {
    //     selectCharaNumber = 3; //パワーが押されたとき2を代入
    // }

    // public void OnClickStart()
    // {
    //     PlayerPrefs.SetInt("CHARA_NUMBER", selectCharaNumber);
    //     SceneManager.LoadScene("MainGameScene");
    // }
    
}
