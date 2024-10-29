using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManger : MonoBehaviour
{
    public AudioSource musicAM;
    public AudioSource sfxAM;

    public AudioClip bgClip;
    public AudioClip jumpClip;
    public AudioClip winClip;
    public AudioClip dieClip;
    private void Awake()
    {
        musicAM.clip = bgClip;
        musicAM.Play();
    }

    public void PlaySFX(AudioClip sfxClip)
    {
        sfxAM.clip = sfxClip;
        sfxAM.PlayOneShot(sfxClip);
    }
}
