using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win2P : MonoBehaviour
{
    [SerializeField]
    private GameObject back;
    [SerializeField]
    private GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        back.SetActive (false);
        obj.SetActive (false);
    }

    public void Result2()
    {
        back.SetActive(true);
        obj.SetActive(true);
    }
}
