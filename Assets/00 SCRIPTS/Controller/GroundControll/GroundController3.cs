using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController3 : MonoBehaviour
{
    [SerializeField] protected GroundMove3 _groundMove;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Balloon"))
        {
            Destroy(collision.gameObject);
            _groundMove.Moving();
        }
    }
}
