using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnScene : MonoBehaviour
{
    private string SceneName; 
    void Start() 
    {
        DontDestroyOnLoad(this.gameObject);

    }
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.G))
            SceneManager.LoadScene("Title");

        if(Input.GetMouseButtonDown(1))
        {
            SceneName = SceneManager.GetActiveScene().name;
            if(SceneName == "WeponsScene")
            {
                SceneManager.LoadScene("Title");
            }
            //else if(SceneName == "WeponsScene)
        }
        
        // ここにコントローラー
        if(Input.GetMouseButtonDown(1))
        {
            SceneName = SceneManager.GetActiveScene().name;
            if(SceneName == "WeponsScene")
            {
                SceneManager.LoadScene("Title");
            }
            //else if(SceneName == "WeponsScene)
        }

    }
}
