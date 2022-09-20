using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarutaMove : MonoBehaviour
{
    public bool moveflag;
    private Vector3 targetpos;

    private float speed;
    private float step;
    private Vector3 stap;
    void Start()
    {
        stap = this.gameObject.transform.position;
        speed = 300f;
    }
    void Update()
    {
        step = speed * Time.deltaTime;
        if(moveflag)
        {
            Debug.Log(targetpos);
            this.gameObject.transform.position = Vector3.MoveTowards(transform.position,targetpos,step);
        }
    }

    public void startmove(Vector3 vec)
    {
        targetpos = vec;
        moveflag = true;
    }

}
