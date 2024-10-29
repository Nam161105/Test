using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    protected Rigidbody2D _rb;
    [SerializeField] protected float _speed, _force;
    [SerializeField] protected bool _isGround;
    [SerializeField] PlayerState _playerState = PlayerState.Idle;
    [SerializeField] protected AnimationController _ani;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        this.Moving();
        this.UpdateState();
        _ani.UpdateAni(_playerState);
    }


    protected void Moving()
    {
        if (_playerState == PlayerState.Die)
        {
            return;
        }
        Vector2 move = _rb.velocity;
        move.x = Input.GetAxisRaw("Horizontal") * _speed;
        _rb.velocity = move;
        if (Input.GetKeyDown(KeyCode.Space) && _isGround)
        {
            _rb.AddForce(new Vector2(0, _force), ForceMode2D.Impulse);
            _isGround = false;
        }
    }

    protected void UpdateState()
    {
        if (_playerState == PlayerState.Die)
        {
            return; 
        }
        if (!_isGround)
        {
            _playerState = PlayerState.Jump;
        }
        else
        {
            if (_rb.velocity.x != 0)
            {
                _playerState = PlayerState.Run;
            }
            else _playerState = PlayerState.Idle;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _isGround = true;
        }
        if (collision.gameObject.CompareTag("Spike"))
        {
            _playerState = PlayerState.Die;
            _rb.velocity = Vector2.zero;
        }
    }

    public enum PlayerState
    {
        Idle,
        Run,
        Jump,
        Die
    }
}
