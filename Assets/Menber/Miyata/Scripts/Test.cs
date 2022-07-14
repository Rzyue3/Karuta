using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Test : MonoBehaviour
{
    private string Speedtag="speedtag";
    private string Balancetag="balancetag";
    private string Powertag="powertag";
    private string Readytag="readytag";
    [SerializeField] GameObject  Speed;
    [SerializeField] GameObject  Balance;
    [SerializeField] GameObject  Power; 

    int selectCharaNumber;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag==Speedtag)
        {
            selectCharaNumber = 1; //スピードが押されたとき1を代入
            Speed.gameObject.SetActive(true);
        }
        if(other.gameObject.tag==Balancetag)
        {
            selectCharaNumber = 2; //バランスが押されたとき2を代入
            Balance.gameObject.SetActive(true);
        }
        if(other.gameObject.tag==Powertag)
        {
            selectCharaNumber = 3; //パワーが押されたとき3を代入
            Power.gameObject.SetActive(true);
        }
        if(other.gameObject.tag==Readytag)
        {
            SceneManager.LoadScene("MainGameScene");
        }
    }
}
