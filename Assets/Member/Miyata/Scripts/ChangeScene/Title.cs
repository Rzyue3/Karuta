using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    [SerializeField]
    private GameObject P1;
    [SerializeField]
    private GameObject P2;
    [SerializeField]
    private Animator LeftAnim;
    [SerializeField]
    private Animator RightAnim;
    public AudioClip audioClip;
    AudioSource audioSource;
    private string PlayerTag="Player1";
    private string PlayerTag2="Player2";


    public SE se;
    
    private void Start() {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = audioClip;
        P1.SetActive(true);
        P2.SetActive(true);
    }
    
    public void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == PlayerTag && Input.GetButton("Fire3"))
        {
            se.SettingPlaySE();
            StartCoroutine("cutinanim");
        }
        if(other.gameObject.tag == PlayerTag2 && Input.GetButton("Fire3_2"))
        {
            se.SettingPlaySE();
            StartCoroutine("cutinanim");
        }
    }

    private IEnumerator cutinanim()
    {
        P1.SetActive(false);
        P2.SetActive(false);
        LeftAnim.SetBool("CutAnim",false);
        RightAnim.SetBool("CutAnim",false);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("WeponsScene");

    }
}
