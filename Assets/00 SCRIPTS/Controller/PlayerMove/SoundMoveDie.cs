using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMoveDie : Move
{
    public AudioManger _am;

    private void Awake()
    {
        _am = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManger>();
    }

    private void Update()
    {
        this.Moving2();
    }

    protected void Moving2()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _am.PlaySFX(_am.jumpClip);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Spike"))
        {
            _am.PlaySFX(_am.dieClip);
        }
    }
}
