using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Roundendobjalpha : MonoBehaviour
{
    [SerializeField]
    public Image Fill;
    [SerializeField]
    private int setnum;
    [SerializeField]
    private GameObject obj;
    public bool flag;

    void Update()
    {
        if(flag)
            Fill.fillAmount -= 1.0f / 30;        
    }

    private IEnumerator setflag(int i)
    {
        //Fill.fillAmount = 1.0f;
        yield return new WaitForSeconds(i);
        obj.SetActive(true);
        flag = true;

    }

    public void set()
    {
        Debug.Log("獲得表示");
        flag = false;
        Fill.fillAmount = 1.0f;
        StartCoroutine(setflag(setnum));
    }
}
