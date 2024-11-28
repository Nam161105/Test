using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovement : MoveMaterial
{
    [SerializeField] protected float _moveSpeed;
    protected Vector3 _target; 
    protected bool _hasMoved = false;
    [SerializeField] protected float distance;

    private void Update()
    {
        if (_hasMoved)
        {
            transform.position = Vector3.MoveTowards(transform.position, _target, _moveSpeed * Time.deltaTime);
        }
    }

   
    public override void Moving()
    {
        if (!_hasMoved) 
        {
            _target = transform.position; 
            _target.x -= distance;
            _hasMoved = true;  
        }
    }

}
