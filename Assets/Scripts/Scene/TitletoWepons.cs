using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitletoWepons : MonoBehaviour
{
    public void onButtonClick()
    {
        SceneManager.LoadScene("WeponsScene");
    }
}
