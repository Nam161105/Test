using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinSound : MonoBehaviour
{
    protected bool _isPlay = false;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !_isPlay)
        {
            AudioManger.Instance.PlaySFX(AudioManger.Instance.winClip);
            _isPlay = true;
        }
    }
}
