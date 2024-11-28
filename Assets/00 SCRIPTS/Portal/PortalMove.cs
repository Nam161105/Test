using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalMove : MonoBehaviour
{
    [SerializeField] protected Transform posA;
    [SerializeField] protected Transform posB;
    [SerializeField] protected float _speed;
    protected bool moveToB = true;
    private void Start()
    {
        transform.position = posA.position;
    }

    private void Update()
    {
        if(moveToB)
        {
            transform.position = Vector3.MoveTowards(transform.position, posA.position, _speed * Time.deltaTime);
            if(Vector2.Distance(transform.position, posA.position) < 0.1f)
            {
                moveToB = false;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, posB.position, _speed * Time.deltaTime);
            if (Vector2.Distance(transform.position, posB.position) < 0.1f)
            {
                moveToB = true;
            }
        }
    }
}
