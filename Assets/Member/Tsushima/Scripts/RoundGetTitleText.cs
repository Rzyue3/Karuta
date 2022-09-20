using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundGetTitleText : MonoBehaviour
{
    [SerializeField]
    private Text text;
    [SerializeField]
    private string[] texts;//Unity上で入力するstringの配列

    public void endtitletext(int i)
    {
        text.text = texts[i];
    }
}
