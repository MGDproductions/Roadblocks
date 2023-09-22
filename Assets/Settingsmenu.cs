using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Settingsmenu : MonoBehaviour
{
    public UnityEngine.Audio.AudioMixer Music;


    public void SetMusicVolume (float music)
    {
        Music.SetFloat("music", music);
    }

    public UnityEngine.Audio.AudioMixer FX;


    public void SetFxVolume(float fx)
    {
        FX.SetFloat("fx", fx);
    }

}
