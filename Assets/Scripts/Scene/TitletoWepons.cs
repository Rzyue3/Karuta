using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitletoWepons : MonoBehaviour
{
void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
                SceneManager.LoadScene("WeponsScene");
        }
        
    }
    
}
