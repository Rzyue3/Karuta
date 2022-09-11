using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit2P : MonoBehaviour
{

    [SerializeField] private GameObject _pos;
    private float rayDistance;
    Hit script;

    private void Start()
    {
        rayDistance=50.0f; //���C�̒���
    }

    void Update()
    {
        var direction = transform.forward;

        if (Input.GetButtonDown("Fire3_2")) //�E�N���b�N���ꂽ�Ƃ�
        {

            Ray ray = new Ray(_pos.transform.position, direction); //�W���̍��W
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, rayDistance))
            {    
            
                if (hit.collider.CompareTag("Karuta")) // �^�O���r
                {
                    Debug.Log("当たった");
                    script = hit.collider.GetComponent<Hit>();
                    //Destroy(hit.collider.gameObject); // �I�u�W�F�N�g��j��
                }
            }
        }
    }
}

    
