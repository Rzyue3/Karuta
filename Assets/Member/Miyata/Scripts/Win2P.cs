using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win2P : MonoBehaviour
{
    [SerializeField]
    private GameObject back;
    [SerializeField]
    private GameObject obj;
    [SerializeField]
    private Shoot shot1p;
    [SerializeField]
    private Shot2P shot2p;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void Result2()
    {
        back.SetActive(true);
        obj.SetActive(true);
        shot1p.GetComponent<Shoot>().enabled = false;
        shot2p.GetComponent<Shot2P>().enabled = false;
        Debug.Log("shotが消えた");
    }
}
