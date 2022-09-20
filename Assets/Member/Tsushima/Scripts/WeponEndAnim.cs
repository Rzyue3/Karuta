using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WeponEndAnim : MonoBehaviour
{
    [SerializeField]
    private GameObject P1;
    [SerializeField]
    private GameObject P2;
    [SerializeField]
    private Animator LeftAnim;
    [SerializeField]
    private Animator RightAnim;

    private IEnumerator cutinanim()
    {
        P1.SetActive(false);
        P2.SetActive(false);
        LeftAnim.SetBool("CutAnim",false);
        RightAnim.SetBool("CutAnim",false);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("MainGameScene");

    }
}
