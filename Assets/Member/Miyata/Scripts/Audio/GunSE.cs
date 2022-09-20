using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSE : MonoBehaviour
{
    private  AudioSource audioSourceSE;
    public  AudioClip se;
 
    private void Start()
    {
        audioSourceSE = gameObject.GetComponent<AudioSource>();
    }
 
    public  void SettingPlaySE()
    {
        audioSourceSE.PlayOneShot(se);
    }
}
