using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move1Point : MonoBehaviour
{
    [SerializeField] protected Transform _ground;
    [SerializeField] protected Transform _pos;
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
            _ground.position = Vector3.MoveTowards(_ground.position, _pos.position, _speed * Time.deltaTime);

            if(_ground.position == _pos.position)
            {
                _isMove = false;
                StartCoroutine(LifeTime());
            }
        }
        
    }

    protected IEnumerator LifeTime()
    {
        yield return new WaitForSeconds(1.5f);
        _ground.GetComponent<SpriteRenderer>().enabled = false;
        _ground.GetComponent<Collider2D>().enabled = false;
    }
}
