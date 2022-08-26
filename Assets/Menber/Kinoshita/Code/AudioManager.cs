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
        M_1,
        M_2,
        M_3,
        M_4,
        M_5,
    }

    public enum WAudioName
    {
        W_a = 0,
        W_i,
        W_u,
        W_e,
        W_o,
        W_Ka,
        W_Ki,
        W_Ku,
        W_Ke,
        W_Ko,
        W_Sa,
        W_Si,
        W_Su,
        W_Se,
        W_So,
        W_Ta,
        W_Ti,
        W_Tu,
        W_Te,
        W_To,
        W_Na,
        W_Ni,
        W_Nu,
        W_Ne,
        W_No,
        W_Ha,
        W_Hi,
        W_Hu,
        W_He,
        W_Ho,
        W_Ma,
        W_Mi,
        W_Mu,
        W_Me,
        W_Mo,
        W_Ya,
        W_Yu,
        W_Yo,
        W_Ra,
        W_Ri,
        W_Ru,
        W_Re,
        W_Ro,
        W_Wa,
        W_1,
        W_2,
        W_3,
        W_4,
        W_5,
    }

    

    //再生する男性音声をリスト化
    public List<AudioClip> MListAudioClip = new List<AudioClip>();

    //再生する女性音声をリスト化
    public List<AudioClip> WListAudioClip = new List<AudioClip>();
    
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

    public void Play(float speed, WAudioName SoundType)
    {
        //
        
    }
}