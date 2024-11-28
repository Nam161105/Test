using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalController : MonoBehaviour
{
    [SerializeField] protected GameObject portalPos;
    [SerializeField] protected GameObject _player;

    private void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if(Vector2.Distance(_player.transform.position, transform.position) > 0.3f)
            {
                StartCoroutine(PortalIn());
            }
        }
    }

    protected IEnumerator PortalIn()
    {
        yield return new WaitForSeconds(0.1f);
        _player.transform.position = portalPos.transform.position;
        yield return new WaitForSeconds(0.1f);
    }
}
