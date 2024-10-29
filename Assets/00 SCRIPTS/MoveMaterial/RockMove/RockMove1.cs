using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockMove1 : MoveMaterial
{
    [SerializeField] protected float _speed;
    protected Vector3 target;
    [SerializeField] protected int distanceMove;
    protected bool _isMove = false;

    private void Update()
    {
        if (_isMove)
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, target, _speed * Time.deltaTime);
        }
    }

    public override void Moving()
    {
        if(!_isMove)
        {
            target = this.transform.position;
            target.x -= distanceMove;
            _isMove = true;
        }
    }

}
