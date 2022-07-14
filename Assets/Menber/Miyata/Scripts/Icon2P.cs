using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Icon2P : MonoBehaviour
{
   private string Speedtag="speedtag";
    private string Balancetag="balancetag";
    private string Powertag="powertag";
    private string Readytag="readytag";


    [SerializeField] GameObject  Speed2;
    [SerializeField] GameObject  Balance2;
    [SerializeField] GameObject  Power2; 


    int selectCharaNumber;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag==Speedtag)
        {
             selectCharaNumber = 1; //スピードが押されたとき1を代入
             Speed2.gameObject.SetActive(true);
        }
        if(other.gameObject.tag==Balancetag)
        {
            selectCharaNumber = 2; //バランスが押されたとき2を代入
            Balance2.gameObject.SetActive(true);
        }
        if(other.gameObject.tag==Powertag)
        {
            selectCharaNumber = 3; //パワーが押されたとき3を代入
            Power2.gameObject.SetActive(true);
        }
        if(other.gameObject.tag==Readytag)
        {
            SceneManager.LoadScene("MainGameScene");
        }
    }
}

