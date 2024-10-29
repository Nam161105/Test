using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour
{
    [SerializeField] protected List<GroundMovement> _groundMovement;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Balloon"))
        {
            foreach(GroundMovement m in _groundMovement)
            {
                Destroy(collision.gameObject);
                m.Moving();
            }
        }
    }
}
