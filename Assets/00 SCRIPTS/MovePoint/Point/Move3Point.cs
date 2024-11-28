using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move3Point : MonoBehaviour
{
    [SerializeField] protected Transform _ground;
    [SerializeField] protected Transform posA;
    [SerializeField] protected Transform posB;
    [SerializeField] protected Transform posC;
    [SerializeField] protected float _speed;
    protected int moveItem = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && moveItem == 0)
        {
            moveItem = 1;
        }
    }

    private void Update()
    {
        if (moveItem == 1)
        {
            _ground.position = Vector3.MoveTowards(_ground.position, posA.position, _speed * Time.deltaTime);

            if(_ground.position == posA.position)
            {
                moveItem = 2;
            }
        }
        else if(moveItem == 2)
        {
            _ground.position = Vector3.MoveTowards(_ground.position, posB.position, _speed * Time.deltaTime);

            if(_ground.position == posB.position)
            {
                moveItem = 3;
            }
        }
        else if (moveItem == 3)
        {
            _ground.position = Vector3.MoveTowards(_ground.position, posC.position, _speed * Time.deltaTime);

            if(_ground.position == posC.position)
            {
                moveItem = 4;
            }
        }
    }
}
