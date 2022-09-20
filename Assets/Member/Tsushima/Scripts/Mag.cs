using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mag : MonoBehaviour
{
    public int player1Mag;
    public int player2Mag;
    public bool zeroammo1;
    public bool zeroammo2;
    
    public int nowP1mag;
    public int nowP2mag;
    private float player1ReTime;
    private float player2ReTime;
    private float _count1;
    private float _count2;


    [SerializeField]
    CsvDataLoad csvdataload;
    [SerializeField]
    Image player1cooldown;
    [SerializeField]
    Image player2cooldown;
    [SerializeField]
    GameMaster gamemaster;

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
//            Debug.Log ("経過時間(秒)" + Time.time);
        }

        if(nowP2mag == 0)
            reloadnow(1);
        //player1cooldown.fillAmount -= Time.deltaTime;

        if (Input.GetButtonDown("Relo1")) 
        {
            player1cooldown.fillAmount = 0.0f;
            zeroammo1 = true;
            nowP1mag = 0;
        }
        if (Input.GetButtonDown("Relo2")) 
        {
            player2cooldown.fillAmount = 0.0f;

            zeroammo2 = true;
            nowP2mag = 0;
        }

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
            _count1 += Time.deltaTime;
            player1cooldown.fillAmount = _count1 / player1ReTime;
            if(player1cooldown.fillAmount >= 1)
            {
                zeroammo1 = false;
                nowP1mag = player1Mag;
                _count1 = 0.0f;
//                Debug.Log ("経過時間(秒)" + Time.time);

            }
        }
        else
        {
            _count2 += Time.deltaTime;
            player2cooldown.fillAmount = _count2 / player2ReTime;
            if(player2cooldown.fillAmount >= 1)
            {
                zeroammo2 = false;
                nowP2mag = player2Mag;
                _count2 = 0.0f;
            }

        }
    }

    public void initmag()
    {
        player1cooldown.fillAmount = 1.0f;
        player2cooldown.fillAmount = 1.0f;
        zeroammo1 = false;
        nowP1mag = player1Mag;
        _count1 = 0.0f;
        zeroammo2 = false;
        nowP2mag = player2Mag;
        _count2 = 0.0f;
    }
}
