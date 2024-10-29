using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeController3 : MonoBehaviour
{
    [SerializeField] protected SpikeMove3 _spikeMove;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Balloon"))
        {
            Destroy(collision.gameObject);
            _spikeMove.Moving();
        }
    }
}
