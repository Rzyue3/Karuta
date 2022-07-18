using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mag : MonoBehaviour
{
    public int player1Mag;
    public int player2Mag;
    private float player1ReTime;
    private float player2ReTime;
    [SerializeField]
    Image player1cooldown;
    [SerializeField]
    Image player2cooldown;
    float test1;
    float test2;

    int nowP1mag;
    int nowP2mag;
    public bool zeroammo1;
    public bool zeroammo2;

    [SerializeField]
    CsvDataLoad csvdataload;

    // Start is called before the first frame update
    void Start()
    {
        player1Mag = csvdataload.WeaponBullets[Test.selectCharaNumber1];
        player2Mag = csvdataload.WeaponBullets[Icon2P.selectCharaNumber2];
        player1ReTime = csvdataload.WeaponReloadTime[Test.selectCharaNumber1];
        player2ReTime = csvdataload.WeaponReloadTime[Icon2P.selectCharaNumber2];

        nowP1mag = player1Mag;
        nowP2mag = player2Mag;
    }

    // Update is called once per frame
    void Update()
    {
        if(nowP1mag == 0)
        {
                        reloadnow(0);

            Debug.Log ("経過時間(秒)" + Time.time);
        }

        if(nowP2mag == 0)
            reloadnow(1);
        //player1cooldown.fillAmount -= Time.deltaTime;
    }

    public void reloadMag(int i)
    {
        if(i == 0)
        {
            if(nowP1mag != 0)
            {
                nowP1mag--;
                player1cooldown.fillAmount -= 1.0f / player1Mag;
            }
            else
                zeroammo1 = true;
        }
        else
        {
            if(nowP2mag != 0)
            {
                nowP2mag--;
                player2cooldown.fillAmount -= 1.0f / player2Mag;
            }
            else
                zeroammo2 = true;
        }
    }

    private void reloadnow(int i)
    {
        if(i == 0)
        {
            player1cooldown.fillAmount += 0.9f / (player1ReTime * 60);
            if(player1cooldown.fillAmount >= 1)
            {
                zeroammo1 = false;
                nowP1mag = player1Mag;
                Debug.Log ("経過時間(秒)" + Time.time);

            }
        }
        else
        {
            player2cooldown.fillAmount += 0.9f / (player2ReTime * 60);
            if(player2cooldown.fillAmount >= 1)
            {
                zeroammo2 = false;
                nowP2mag = player2Mag;
            }

        }
    }
}
