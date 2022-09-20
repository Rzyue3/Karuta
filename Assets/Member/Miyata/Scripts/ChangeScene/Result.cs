using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Result : MonoBehaviour
//リザルト画面から武器選択画面への遷移スクリプト
{
    [SerializeField]
    private GameObject P1;
    [SerializeField]
    private GameObject P2;
    [SerializeField]
    private Animator LeftAnim;
    [SerializeField]
    private Animator RightAnim;
    private string PlayerTag="Player1";
    private string PlayerTag2="Player2";

    void Start()
    {
        P1.SetActive(true);
        P2.SetActive(true);
    }

    public void OnTriggerStay(Collider other)
    {
        Debug.Log(other);
        Debug.Log("判定");
        if(other.gameObject.tag == PlayerTag && Input.GetButtonDown("Fire3"))
        {
            StartCoroutine("cutinanim");
        }
        if(other.gameObject.tag == PlayerTag2 && Input.GetButtonDown("Fire3_2"))
        {
            StartCoroutine("cutinanim");
        }
    }

    private IEnumerator cutinanim()
    {
        Test.selectCharaNumber1 = 0;
        Icon2P.selectCharaNumber2 = 0;
        P1.SetActive(false);
        P2.SetActive(false);
        LeftAnim.SetBool("CutAnim",false);
        RightAnim.SetBool("CutAnim",false);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("WeponsScene");
    }
}
