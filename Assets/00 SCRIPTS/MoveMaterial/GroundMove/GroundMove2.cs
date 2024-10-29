using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMove2 : MoveMaterial
{

    [SerializeField] protected float _speed;
    protected Vector3 _target;
    protected bool _hasMoved = false;

    private void Update()
    {
        if (_hasMoved)
        {
            transform.position = Vector3.MoveTowards(transform.position, _target, _speed * Time.deltaTime);
        }
    }


    public override void Moving()
    {
        if (!_hasMoved)
        {
            _target = transform.position;
            _target.x += 1.8f;
            _hasMoved = true;
        }
    }

}
