using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinSound : MonoBehaviour
{
    public AudioManger _am;

    private void Awake()
    {
        _am = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManger>();    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _am.PlaySFX(_am.winClip);
        }
    }
}
