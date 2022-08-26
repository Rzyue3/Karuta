using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] float m_force = 20;
    [SerializeField] float m_radius = 5;
    [SerializeField] float m_upwards = 0;
    Vector3 m_position;

    public void blowoff ()
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
                if(distance <= 175f) 
                {
                    continue;
                }
                rb.AddExplosionForce(m_force, m_position, m_radius, m_upwards, ForceMode.Impulse);

            }

        }
    }
}