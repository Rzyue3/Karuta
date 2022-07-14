using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damagesc : MonoBehaviour
{
    private GameObject WeaponStats;
    [SerializeField]
    private GameObject gamemanager;
    private Load2nd load2nd;
    private CsvDataLoad csvdataload;

    public int player1damage;
    public int player2damage;
    // Start is called before the first frame update
    void Start()
    {
        //WeaponStats = GameObject.Find ("ReturnScene");
        //load2nd = WeaponStats.GetComponent<Load2nd>();
        //Dataload(load2nd.OO,load2nd.OO);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Dataload(int i,int j)
    {
//        player1damage = csvdataload.WeaponAtk[i];
  //      player2damage = csvdataload.WeaponAtk[j];
    }
}
