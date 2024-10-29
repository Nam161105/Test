using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeMovement2 : MoveMaterial
{
    [SerializeField] protected float _speed;
    protected Vector3 _target;
    protected bool _isMove;

    private void Update()
    {
        if (_isMove)
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, _target, _speed * Time.deltaTime);
        }
    }

    public override void Moving()
    {
        _target = this.transform.position;
        _target.x -= 1.5f;
        _isMove = true;
    }
}
