using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2Material : MonoBehaviour
{
    [SerializeField] protected Transform _material;
    [SerializeField] protected Transform posMaterial;
    [SerializeField] protected Transform _capsule;
    [SerializeField] protected Transform posCapsule;
    [SerializeField] protected float _speed;
    protected bool _isMove = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !_isMove)
        {
            _isMove = true;
        }
    }

    private void Update()
    {
        if (_isMove)
        {
            if(_material.position != posMaterial.position)
            {
                _material.position = Vector3.MoveTowards(_material.position, posMaterial.position, _speed * Time.deltaTime);
            }

            if(_capsule.position != posCapsule.position)
            {
                _capsule.position = Vector3.MoveTowards(_capsule.position, posCapsule.position, _speed * Time.deltaTime);
            }

            if(_material.position == posMaterial.position && _capsule.position == posCapsule.position)
            {
                _isMove = false;
            }
        }
    }
}
