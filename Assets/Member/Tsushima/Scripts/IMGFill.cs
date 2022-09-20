using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IMGFill : MonoBehaviour
{
    [SerializeField]
    private Image Fill;

    void Start()
    {
        Fill.fillAmount = 0.0f;
    }

    void Update()
    {
        Fill.fillAmount += 1.0f / 30;        
    }
}
