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
    [SerializeField] GameObject Speedobj;
    [SerializeField] GameObject Balanceobj;
    [SerializeField] GameObject Powerobj;

    [SerializeField]
    public static int selectCharaNumber1;
    public SE se;
    public AudioClip audioClip;
    AudioSource audioSource;

    public void OnTriggerStay(Collider other)
    {
        if(other.gameObject == Speedobj)
        {
            selectCharaNumber1 = 1; //スピードが押されたとき1を代入
            Speed.gameObject.SetActive(true);
            Balance.gameObject.SetActive(false);
            Power.gameObject.SetActive(false);

        }
        else if(other.gameObject == Balanceobj)
        {
            selectCharaNumber1 = 2; //バランスが押されたとき2を代入
            Speed.gameObject.SetActive(false);
            Balance.gameObject.SetActive(true);
            Power.gameObject.SetActive(false);

        }
        else if(other.gameObject == Powerobj)
        {
            selectCharaNumber1 = 3; //パワーが押されたとき3を代入
            Speed.gameObject.SetActive(false);
            Balance.gameObject.SetActive(false);
            Power.gameObject.SetActive(true);
        }
        else if(other.gameObject.tag==Readytag && selectCharaNumber1 > 0 && Icon2P.selectCharaNumber2 > 0 && Input.GetButton("Fire3"))
        {
            //loadint.P1csv = selectCharaNumber;
            se.SettingPlaySE();
            SceneManager.LoadScene("MainGameScene");
        }

    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("MainGameScene");

        }

    }
}
