using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class TestNextKarutaPik : MonoBehaviour
{    
    [SerializeField]
    private GameObject gamemanager;
    
    private Shuffle shuffle;
    private Hit hit;
    private GameMaster gamemaster;

    [SerializeField]
    private List<GameObject> karutaList;

    public GameObject nextobj;
    public int DestroyNum;
    public int LabelNum;
    public int thiskaruta;
    private int test;

    public bool deletetest = false;
    void Start()
    {
        gamemaster = gamemanager.GetComponent<GameMaster>();
        shuffle = gamemanager.GetComponent<Shuffle>();


    }

    public void randompick()
    {
        Debug.Log(karutaList.Count);
        nextobj = shuffle.setList[Random.Range(0, shuffle.setList.Count)];
        Debug.Log("動いてる？" + nextobj.activeSelf); 
        //while()
        Debug.Log("getCard");
        DestroyNum = shuffle.setList.IndexOf(nextobj);
        shuffle.setList.RemoveAt(DestroyNum);

        Debug.Log(nextobj);
        Debug.Log("DestroyNum" + DestroyNum);
        //deletetest = true;
        hit = nextobj.GetComponent<Hit>();
        hit.NextK = true;
        thiskaruta = hit.tetslabe;
        LabelNum = hit.KarutaLabel;
        //Debug.Log(shuffle.setList[1]);
        Debug.Log(nextobj);
    }

    public void startC()
    {
        karutaList = new List<GameObject>(shuffle.setList); 
    }
}
