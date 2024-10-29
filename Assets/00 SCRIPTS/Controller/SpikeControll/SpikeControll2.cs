using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeControll2 : MonoBehaviour
{
    [SerializeField] protected SpikeMovement2 _spike;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Balloon2"))
        {
            Destroy(collision.gameObject);
            _spike.Moving();
        }
    }
}
