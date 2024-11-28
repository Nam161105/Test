using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManger : MonoBehaviour
{
    protected static AudioManger instance;
    public static AudioManger Instance {  get { return instance; } }



    public AudioSource musicAM;
    public AudioSource sfxAM;

    public AudioClip bgClip;
    public AudioClip jumpClip;
    public AudioClip winClip;
    public AudioClip dieClip;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        musicAM.clip = bgClip;
        musicAM.Play();
    }

    public void PlaySFX(AudioClip sfxClip)
    {
        sfxAM.PlayOneShot(sfxClip);
    }
}
