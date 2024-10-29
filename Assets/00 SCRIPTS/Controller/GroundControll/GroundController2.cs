using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController2 : MonoBehaviour
{
    [SerializeField] protected List<GroundMove2> _groundMovement;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Balloon3"))
        {
            foreach (GroundMove2 m in _groundMovement)
            {
                Destroy(collision.gameObject);
                m.Moving();
            }
        }
    }
}
