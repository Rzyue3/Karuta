using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundGetText : MonoBehaviour
{
    [SerializeField]
    private Text text;
    [SerializeField]
    private string[] texts;//Unity上で入力するstringの配列

    public void endtext(int i)
    {
        text.text = texts[i];
    }
}
