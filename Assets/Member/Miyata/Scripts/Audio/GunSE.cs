using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSE : MonoBehaviour
{
    [SerializeField]
    private AudioSource  a;
    [SerializeField]
    private AudioClip balance;
    [SerializeField]
    private AudioClip speed;
    [SerializeField]
    private AudioClip power;
    [SerializeField]
    private AudioClip miss;
    [SerializeField]
    private AudioClip reload;
 
    
    public void Shot(int i)
    {
        if(i == 1)
        {
            a.PlayOneShot(speed);
        }
        else if(i == 2)
        {
            a.PlayOneShot(balance);
        }
        else
        {
            a.PlayOneShot(power);
        }
    }

    public void Miss()
    {
        a.PlayOneShot(miss);
    }

    public void ReLoad()
    {
        a.PlayOneShot(reload);
    }

    public void Speed()
    {

    }
    
}
