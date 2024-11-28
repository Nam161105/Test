using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleTrigger : MonoBehaviour
{
    [SerializeField] protected Transform _ground;
    [SerializeField] protected Transform posTarget;
    [SerializeField] protected float _speed;
    protected bool _hasMove = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !_hasMove)
        {
            _hasMove = true;
        }
    }

    private void Update()
    {
        if (_hasMove)
        {
            _ground.position = Vector3.MoveTowards(_ground.position, posTarget.position, _speed * Time.deltaTime);

            if(_ground.position == posTarget.position)
            {
                _hasMove = false;
            }
        }
    }
}
