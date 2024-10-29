using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockController1 : MonoBehaviour
{
    [SerializeField] protected RockMove1 move1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Balloon"))
        {
            Destroy(collision.gameObject);
            move1.Moving();
        }
    }
}
