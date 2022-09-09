using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    public AudioClip audioClip;
    AudioSource audioSource;
    private string PlayerTag="Player1";
    private string PlayerTag2="Player2";

    public SE se;
    
    private void Start() {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = audioClip;

    }
    
    public void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == PlayerTag && Input.GetButton("Fire3"))
        {
            se.SettingPlaySE();
            SceneManager.LoadScene("WeponsScene");
        }
        if(other.gameObject.tag == PlayerTag2 && Input.GetButton("Fire3_2"))
        {
            se.SettingPlaySE();
            SceneManager.LoadScene("WeponsScene");
        }
    }
}
