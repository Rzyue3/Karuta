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

    int selectCharaNumber;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == Speedobj)
        {
            selectCharaNumber = 1; //スピードが押されたとき1を代入
            Speed.gameObject.SetActive(true);
            Balance.gameObject.SetActive(false);
            Power.gameObject.SetActive(false);

        }
        else if(other.gameObject == Balanceobj)
        {
            selectCharaNumber = 2; //バランスが押されたとき2を代入
            Speed.gameObject.SetActive(false);
            Balance.gameObject.SetActive(true);
            Power.gameObject.SetActive(false);

        }
        else if(other.gameObject == Powerobj)
        {
            selectCharaNumber = 3; //パワーが押されたとき3を代入
            Speed.gameObject.SetActive(false);
            Balance.gameObject.SetActive(false);
            Power.gameObject.SetActive(true);
        }
        else if(other.gameObject.tag==Readytag)
        {
            SceneManager.LoadScene("MainGameScene");
        }
    }
}
