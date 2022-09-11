using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{

    [SerializeField]
    CsvDataLoad csvdataload;

    [SerializeField]
    private float KarutaSize;

    float m_force;
    float m_radius;
    float m_upwards;
    Vector3 m_position;

    float m_force2p;
    float m_radius2p;
    float m_upwards2p;
    Vector3 m_position2p;

    void Start()
    {
        m_force = csvdataload.WeaponExpPower[Test.selectCharaNumber1];
        m_radius = csvdataload.WeaponExpPower[Test.selectCharaNumber1];
        m_force2p = csvdataload.WeaponExpPower[Icon2P.selectCharaNumber2];
        m_radius2p = csvdataload.WeaponExpPower[Icon2P.selectCharaNumber2];

    }

    public void blowoff (int j)
    {
        if(j == 0)
        {
            Debug.Log("Explosion!");
            m_position = this.gameObject.transform.position;

            // 範囲内のRigidbodyにAddExplosionForce
            Collider[] hitColliders = Physics.OverlapSphere(m_position, m_radius);
            for(int i = 0; i < hitColliders.Length; i++)
            {

                var rb = hitColliders[i].GetComponent<Rigidbody>();
                float distance = Vector3.Distance(hitColliders[i].transform.position,this.gameObject.transform.position);
                if(rb)
                {
                    // カルタの枠撃っても動かないギリギリの数値のため、カルタのサイズ変更した場合はここも変えること。
                    if(distance <= KarutaSize) 
                    {
                        continue;
                    }
                    rb.AddExplosionForce(m_force, m_position, m_radius, m_upwards, ForceMode.Impulse);

                }

            }

        }
        else
        {
            Debug.Log("Explosion!");
            m_position2p = this.gameObject.transform.position;

            // 範囲内のRigidbodyにAddExplosionForce
            Collider[] hitColliders = Physics.OverlapSphere(m_position2p, m_radius2p);
            for(int i = 0; i < hitColliders.Length; i++)
            {

                var rb = hitColliders[i].GetComponent<Rigidbody>();
                float distance = Vector3.Distance(hitColliders[i].transform.position,this.gameObject.transform.position);
                if(rb)
                {
                    // カルタの枠撃っても動かないギリギリの数値のため、カルタのサイズ変更した場合はここも変えること。
                    if(distance <= KarutaSize) 
                    {
                        continue;
                    }
                    rb.AddExplosionForce(m_force2p, m_position2p, m_radius2p, m_upwards2p, ForceMode.Impulse);

                }

            }
    
        }
    }

}