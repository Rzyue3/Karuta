using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Load : MonoBehaviour
{
    [SerializeField] private GameObject _loadingUI;
    [SerializeField] private Slider _slider;

    public int ready1, ready2;

    void Start()
    {
        ready1 = 0; //ready1‚ğ‰Šú‰»
        ready2 = 0; //ready2‚ğ‰Šú‰»

    }
    IEnumerator LoadScene()
    {
        AsyncOperation async = SceneManager.LoadSceneAsync("MainGameScene"); 
        while (!async.isDone)
        {
            _slider.value = async.progress;
            yield return null;
        }
    }
    public void Ready()
    {
        if(ready1!=0&&ready2!=0)
        {
            _loadingUI.SetActive(true);
            StartCoroutine(LoadScene());
        }
        
    }
    public void Speed()
    {
        if(ready1==0)
        {
            if(Input.GetMouseButtonDown(0))
            {
                ready1 = 1;
            }
        }
    }
    public void Balance()
    {
        if(Input.GetMouseButton(0))
        {
            ready1 = 2;
        }

    }
    public void Power()
    {
        if (Input.GetMouseButton(0))
        {
            ready1 = 3;
        }
    }
}
