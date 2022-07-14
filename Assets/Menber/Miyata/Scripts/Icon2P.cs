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

    int selectCharaNumber;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == Speedobj)
        {
            selectCharaNumber = 1; //スピードが押されたとき1を代入
            Speed2.gameObject.SetActive(true);
            Balance2.gameObject.SetActive(false);
            Power2.gameObject.SetActive(false);

        }
        else if(other.gameObject == Balanceobj)
        {
            selectCharaNumber = 2; //バランスが押されたとき2を代入
            Speed2.gameObject.SetActive(false);
            Balance2.gameObject.SetActive(true);
            Power2.gameObject.SetActive(false);

        }
        else if(other.gameObject == Powerobj)
        {
            selectCharaNumber = 3; //パワーが押されたとき3を代入
            Speed2.gameObject.SetActive(false);
            Balance2.gameObject.SetActive(false);
            Power2.gameObject.SetActive(true);
        }
        if(other.gameObject.tag==Readytag)
        {
            SceneManager.LoadScene("MainGameScene");
        }
    }
}
