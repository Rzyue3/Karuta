using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundendobjAc : MonoBehaviour
{
    public List<GameObject> endobj = new List<GameObject>();

    [SerializeField]
    private GameObject Testobj;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //StartCoroutine(objactive(0,Testobj));
        }
    }

    public IEnumerator objactive(int i,int Num, GameObject obj)
    {
        if(i == 0)
        {
            for(int j = 0; j < 4; j++)
            {
                var img = endobj[j].GetComponent<Image>();
                img.fillAmount = 0;
                endobj[j].SetActive(true);
                yield return new WaitForSeconds(1);
            }
            var sprd = obj.GetComponent<Canvas>();
            sprd.sortingOrder = 15;
            obj.transform.position = new Vector3(-1100f,0,0);
            Vector3 kero;  //①仮の変数宣言

            kero = obj.transform.localScale; //◆現在の大きさを代入


            kero.x *= 3;  //②変数keroのx座標を1増やして代入
            kero.y *= 3;

            obj.transform.localScale = kero; //③大きさに変数keroを代入
            obj.SetActive(true);
            yield return new WaitForSeconds(4);
            for(int z = 0; z < 4;z++)
            {
                endobj[z].SetActive(false);
            }
            obj.SetActive(false);

        }
        else if(i == 1)
        {
            for(int j = 5; j < 8; j++)
            {
                var img = endobj[j].GetComponent<Image>();
                img.fillAmount = 0;
                endobj[j].SetActive(true);
                yield return new WaitForSeconds(1);
            }
            var canv = obj.GetComponent<Canvas>();
            obj.transform.position = new Vector3(-1100f,0,0);
            Vector3 kero;  //①仮の変数宣言

            kero = obj.transform.localScale; //◆現在の大きさを代入


            kero.x *= 3;  //②変数keroのx座標を1増やして代入
            kero.y *= 3;

            obj.transform.localScale = kero; //③大きさに変数keroを代入
            obj.SetActive(true);
            yield return new WaitForSeconds(4);
            for(int z = 0; z < 4;z++)
            {
                endobj[z].SetActive(false);
            }
            obj.SetActive(false);

        }
    }

    private void objmoveresize()
    {

    }

}
