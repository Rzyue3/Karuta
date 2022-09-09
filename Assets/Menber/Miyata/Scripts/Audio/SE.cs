using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE : MonoBehaviour
{
    private  AudioSource audioSourceSE;
    public  AudioClip se;
 
    private void Start()
    {
        audioSourceSE = gameObject.GetComponent<AudioSource>();
        DontDestroyOnLoad(this.gameObject);
    }
 
    public  void SettingPlaySE()
    {
        audioSourceSE.PlayOneShot(se);
    }
}
