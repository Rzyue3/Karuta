using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutAnim : MonoBehaviour
{
    // カットイン試運転用
    [SerializeField]
    private Animator LeftAnim;
    [SerializeField]
    private Animator RightAnim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(Input.GetMouseButtonDown(0))
        {
            LeftAnim.SetBool("CutAnim",true);
            RightAnim.SetBool("CutAnim",true);
        }

        if(Input.GetMouseButtonDown(1))
        {
            LeftAnim.SetBool("CutAnim",false);
            RightAnim.SetBool("CutAnim",false);
        }
        */
    }
}
