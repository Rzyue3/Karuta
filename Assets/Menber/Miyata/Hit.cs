using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    // ���_����������
    // ����t��������

    // ���O�t��
    // �J�[�h�̏���HP�ݒ�
    public int CardHP = 150;

    private bool Player1Atk, Player2Atk;

    private float _P1time, _P2time;


    void Start()
    {
        
        
     


    }

    void Update()
    {


        // Rigidbody��Never Sleep�Ŕ����������Ă��鎞
        // 1�N���b�N��2��ȏ�E�����Ƃ�����̂ŉ��}���u�Ƃ��� 0.05 �̃f�B���C�����Ă܂�
        // �����C
        if (Player1Atk == false)
        {
            _P1time += Time.deltaTime;
            {
                if (_P1time >= 0.05f)
                {
                    _P1time = 0.0f;
                    Player1Atk = true;
                }
            }
        }

        // Rigidbody��Never Sleep�Ŕ����������Ă��鎞
        // 1�N���b�N��2��ȏ�E�����Ƃ�����̂ŉ��}���u�Ƃ��� 0.05 �̃f�B���C�����Ă܂�
        // �����C
        if (Player2Atk == false)
        {
            _P2time += Time.deltaTime;
            if (_P1time >= 0.05f)
            {
                _P1time = 0.0f;
                Player1Atk = true;
            }
        }

    }
    public void OnTriggerStay2D(Collider2D Hit)
    {
        // �N���X�w�A(Player�^�O�̕�)���d�Ȃ��Ă��鎞�}�E�X���N���b�N��
        // �J�[�h��HP��50���炷
        if (Input.GetMouseButtonDown(0) && Hit.CompareTag("Player") && Player1Atk)
        {
            Debug.Log("Hit!!");
            CardHP -= 50;
            // �J�[�h��HP��0�ɂȂ����炱�̃I�u�W�F�N�g��j��
            if (CardHP <= 0)
            {
                Destroy(this.gameObject);
                
            }
        }
        if (Input.GetMouseButtonDown(0) && Hit.CompareTag("Player") && Player2Atk)
        {
            Debug.Log("Hit!!");
            CardHP -= 50;
            // �J�[�h��HP��0�ɂȂ����炱�̃I�u�W�F�N�g��j��
            if (CardHP <= 0)
            {
                Destroy(this.gameObject);
               
            }
        }

    }

}