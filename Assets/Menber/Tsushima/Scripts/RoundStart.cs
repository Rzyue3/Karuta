using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundStart : MonoBehaviour
{
    [SerializeField]
    private GameObject gamemanager;
    GameMaster gamemaster;
    [SerializeField]
    private GameObject P1Crosshair;
    [SerializeField]
    private GameObject P2Crosshair;
    [SerializeField]
    private Text text;
    private string disptext;

    [SerializeField]
    private GameObject roundstartobj;
    private CanvasGroup _canvasGroup;
    private int _count;
    void Start()
    {
        gamemaster = gamemanager.GetComponent<GameMaster>();
        gamemaster.textStop = false;
        _canvasGroup = roundstartobj.GetComponent<CanvasGroup>();

        StartCoroutine("FadeCo");
    }

    void Update()
    {
        
    }


    private IEnumerator FadeCo()
    {
        _canvasGroup = roundstartobj.GetComponent<CanvasGroup>();
        P1Crosshair.SetActive(false);
        P2Crosshair.SetActive(false);
        _count++;
        //disptext = ToString(_count);
        text.text = _count.ToString() + "枚目";

        gamemaster.textStop = false;
            // 透明度が0以上なら繰り返す
            while(1.0f > _canvasGroup.alpha)
            {
                // 1秒でイメージがフェードアウトする
                _canvasGroup.alpha += Time.deltaTime;
                // 0以下になったら0に補正する
                if(1.0f < _canvasGroup.alpha)
                {
                    _canvasGroup.alpha = 1.0f;

                }
                // 1フレーム待つ
                yield return null; 
            }

        yield return new WaitForSeconds(2);
        Debug.Log("IEnume");

            // 透明度が0以上なら繰り返す
            while(0.0f < _canvasGroup.alpha)
            {
                // 1秒でイメージがフェードアウトする
                _canvasGroup.alpha -= Time.deltaTime;
                // 0以下になったら0に補正する
                if(0.0f > _canvasGroup.alpha)
                {
                    _canvasGroup.alpha = 0.0f;

                }
                // 1フレーム待つ
                yield return null; 
            }
        gamemaster.textStop = true;
        P1Crosshair.SetActive(true);
        P2Crosshair.SetActive(true);
    }

}
