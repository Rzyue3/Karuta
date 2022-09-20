using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cardcrack : MonoBehaviour
{
    [SerializeField]
    Image crack;
    int maxhp;
    GameObject objParent;
    Hit hit;

    void Start()
    {
        maxhp = 150;
        objParent = transform.parent.gameObject;
        hit = objParent.GetComponent<Hit>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            Damagecrack();
        }
        
    }

    public void Damagecrack()
    {
        Debug.Log(hit.CardHP);
        Debug.Log(0.0067f * (maxhp - hit.CardHP));
        crack.fillAmount = 0.0066f * (maxhp - hit.CardHP);

    }

    public void destroyimg()
    {
        crack.fillAmount = 0.0f;
    }
}
