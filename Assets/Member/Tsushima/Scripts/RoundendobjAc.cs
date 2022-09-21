using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundendobjAc : MonoBehaviour
{
    public List<GameObject> endobj = new List<GameObject>();
    [SerializeField]
    private List<GameObject> textobj = new List<GameObject>();
    [SerializeField]
    private List<GameObject> alphaobj = new List<GameObject>();


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
            endobj[8].SetActive(true);
            for(int g = 0; g < 5; g++) 
            {
                var txobj = textobj[g].GetComponent<RoundGetText>();
                var alpha = alphaobj[g].GetComponent<Roundendobjalpha>();
                alpha.set();
                txobj.endtext(Num);
            }
            var alpha2 = alphaobj[5].GetComponent<Roundendobjalpha>();
            alpha2.set();
            var tlobj = textobj[5].GetComponent<RoundGetTitleText>();
            tlobj.endtitletext(Num);

            var sprd = obj.GetComponent<Canvas>();
            sprd.sortingOrder = 15;
            obj.transform.position = new Vector3(-1100f,0,0);
            obj.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
            Vector3 kero;  //①仮の変数宣言

            kero = obj.transform.localScale; //◆現在の大きさを代入


            kero.x = 1.2f * 3;  //②変数keroのx座標を1増やして代入
            kero.y = 1.7f * 3;

            obj.transform.localScale = kero; //③大きさに変数keroを代入
            obj.SetActive(true);
            yield return new WaitForSeconds(9);
            for(int z = 0; z < 4;z++)
            {
                endobj[z].SetActive(false);
                var alpobj = alphaobj[z].GetComponent<Roundendobjalpha>();
                alpobj.Fill.fillAmount = 1.0f;
                alpobj.flag = false;
            }
            var alpobj2 = alphaobj[5].GetComponent<Roundendobjalpha>();
            alpobj2.Fill.fillAmount = 1.0f;
            alpobj2.flag = false;

            endobj[8].SetActive(false);
            obj.SetActive(false);

        }
        else if(i == 1)
        {
            for(int j = 4; j < 8; j++)
            {
                var img = endobj[j].GetComponent<Image>();
                img.fillAmount = 0;
                endobj[j].SetActive(true);
                yield return new WaitForSeconds(1);
            }
           endobj[8].SetActive(true);
            for(int g = 0; g < 5; g++) 
            {
                var txobj = textobj[g].GetComponent<RoundGetText>();
                var alpha = alphaobj[g].GetComponent<Roundendobjalpha>();
                alpha.set();
                txobj.endtext(Num);
            }
            var alpha2 = alphaobj[5].GetComponent<Roundendobjalpha>();
            alpha2.set();
            var tlobj = textobj[5].GetComponent<RoundGetTitleText>();
            tlobj.endtitletext(Num);

            var sprd = obj.GetComponent<Canvas>();
            sprd.sortingOrder = 15;
            obj.transform.position = new Vector3(-1100f,0,0);
            obj.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
            Vector3 kero;  //①仮の変数宣言

            kero = obj.transform.localScale; //◆現在の大きさを代入


            kero.x = 1.2f * 3;  //②変数keroのx座標を1増やして代入
            kero.y = 1.7f * 3;

            obj.transform.localScale = kero; //③大きさに変数keroを代入
            obj.SetActive(true);
            yield return new WaitForSeconds(9);
            for(int z = 4; z < 8;z++)
            {
                endobj[z].SetActive(false);
            }
            for(int g = 0; g < 4;g++)
            {
                var alpobj = alphaobj[g].GetComponent<Roundendobjalpha>();
                alpobj.Fill.fillAmount = 1.0f;
                alpobj.flag = false;
            }
            var alpobj2 = alphaobj[5].GetComponent<Roundendobjalpha>();
            alpobj2.Fill.fillAmount = 1.0f;
            alpobj2.flag = false;

            endobj[8].SetActive(false);
            obj.SetActive(false);
        }
    }


}
