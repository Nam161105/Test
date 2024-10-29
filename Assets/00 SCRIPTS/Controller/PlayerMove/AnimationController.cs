using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerState = Move.PlayerState;

public class AnimationController : MonoBehaviour
{
    protected Animator _animator;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        this.Turning();
    }

    protected void Turning()
    {
        if (Input.GetAxisRaw("Horizontal") == -1)
        {
            this.transform.localScale = new Vector3(-1, 1, 1);
        }
        if (Input.GetAxisRaw("Horizontal") == 1)
        {
            this.transform.localScale = new Vector3(1, 1, 1);
        }
    }
    public void UpdateAni(PlayerState playerState)
    {
        for(int i = 0;i <= (int)PlayerState.Die;i++)
        {
            string stateName = ((PlayerState)i).ToString();
            if(playerState == (PlayerState)i)
            {
                _animator.SetBool(stateName, true);
            }
            else _animator.SetBool(stateName, false);
        }
    }
}
