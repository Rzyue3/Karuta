using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public enum EAudioName
    {
        M_a = 0,
        M_i,
        M_u,
        M_e,
        M_o,
        M_Ka,
        M_Ki,
        M_Ku,
        M_Ke,
        M_Ko,
        M_Sa,
        M_Si,
        M_Su,
        M_Se,
        M_So,
        M_Ta,
        M_Ti,
        M_Tu,
        M_Te,
        M_To,
        M_Na,
        M_Ni,
        M_Nu,
        M_Ne,
        M_No,
        M_Ha,
        M_Hi,
        M_Hu,
        M_He,
        M_Ho,
        M_Ma,
        M_Mi,
        M_Mu,
        M_Me,
        M_Mo,
        M_Ya,
        M_Yu,
        M_Yo,
        M_Ra,
        M_Ri,
        M_Ru,
        M_Re,
        M_Ro,
        M_Wa,
    }

    //再生する音声をリスト化
    public List<AudioClip> ListAudioClip = new List<AudioClip>();

    // Start is called before the first frame update
    void Start()
    {
        //他のスクリプトで再生するコード
        Play(1.0f, EAudioName.M_a);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play(float speed, EAudioName SoundType)
    {
        //
        
    }

}