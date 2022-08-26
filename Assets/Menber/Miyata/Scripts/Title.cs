using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    private string Starttag="Starttag";

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag==Starttag)
        {
            SceneManager.LoadScene("WeponsScene");
        }
    }
}
