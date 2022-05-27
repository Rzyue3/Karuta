using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Load : MonoBehaviour
{
    [SerializeField] private GameObject _loadingUI;
    [SerializeField] private Slider _slider;
    public void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            _loadingUI.SetActive(true);
            StartCoroutine(LoadScene());

        }
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
}
