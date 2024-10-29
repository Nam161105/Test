using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMove3 : MoveMaterial
{
    [SerializeField] protected float _speed;
    protected Vector3 target;
    protected bool _isMove = false;

    private void Update()
    {
        if (_isMove)
        {
            this.transform.position = Vector3.MoveTowards(transform.position, target, _speed * Time.deltaTime);
        }
    }

    public override void Moving()
    {
        target = transform.position;
        target.x += 12f;
        _isMove = true;
    }
}
