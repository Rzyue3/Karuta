using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAnim : MonoBehaviour
{
    [SerializeField]
    private Animator LeftAnim;
    [SerializeField]
    private Animator RightAnim;
    void Start()
    {
        LeftAnim.SetBool("CutAnim",true);
        RightAnim.SetBool("CutAnim",true);
    }

}
