using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit2P : MonoBehaviour
{

    [SerializeField] private GameObject _pos;
    private float rayDistance;
    public GameObject atari;
    Hit script;

    private void Start()
    {
        rayDistance=50.0f; //レイの長さ
    }

    void Update()
    {
        var direction = transform.forward;

        if (Input.GetMouseButtonDown(1)) //右クリックされたとき
        {

            Ray ray = new Ray(_pos.transform.position, direction); //標準の座標
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, rayDistance))
            {    
                if (hit.collider.CompareTag("Karuta")) // タグを比較
                {
                    script = hit.collider.GetComponent<Hit>();
                    script.Damage();
                    //Destroy(hit.collider.gameObject); // オブジェクトを破壊
                }
            }
        }
    }
}

    
