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
    [SerializeField] GameObject Speedobj;
    [SerializeField] GameObject Balanceobj;
    [SerializeField] GameObject Powerobj;

    [SerializeField]
    public static int selectCharaNumber2;
    public SE se;
    public AudioClip audioClip;
    AudioSource audioSource;

    public void OnTriggerStay(Collider other)
    {
        if(other.gameObject == Speedobj)
        {
            selectCharaNumber2 = 1; //スピードが押されたとき1を代入
            Speed2.gameObject.SetActive(true);
            Balance2.gameObject.SetActive(false);
            Power2.gameObject.SetActive(false);

        }
        else if(other.gameObject == Balanceobj)
        {
            selectCharaNumber2 = 2; //バランスが押されたとき2を代入
            Speed2.gameObject.SetActive(false);
            Balance2.gameObject.SetActive(true);
            Power2.gameObject.SetActive(false);

        }
        else if(other.gameObject == Powerobj)
        {
            selectCharaNumber2 = 3; //パワーが押されたとき3を代入
            Speed2.gameObject.SetActive(false);
            Balance2.gameObject.SetActive(false);
            Power2.gameObject.SetActive(true);
        }
        if(other.gameObject.tag==Readytag && Test.selectCharaNumber1 > 0 && selectCharaNumber2 > 0 && Input.GetButton("Fire3_2"))
        {
            //loadint.P2csv = selectCharaNumber;
            se.SettingPlaySE();
            SceneManager.LoadScene("MainGameScene");
        }
    }
}

