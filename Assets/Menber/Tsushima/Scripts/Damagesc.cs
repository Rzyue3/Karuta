using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damagesc : MonoBehaviour
{
    [SerializeField]
    private GameObject gamemanager;
    [SerializeField]
    private CsvDataLoad csvdataload;

    public static int player1damage;
    public static int player2damage;
    // Start is called before the first frame update
    void Start()
    {
        Dataload(Test.selectCharaNumber1,Icon2P.selectCharaNumber2);
    }


    public void Dataload(int i,int j)
    {
        player1damage = csvdataload.WeaponAtk[i];
        player2damage = csvdataload.WeaponAtk[j];
        Debug.Log("Player1Damage" + player1damage);
        Debug.Log("Player2Damage" + Icon2P.selectCharaNumber2);
    }
}
