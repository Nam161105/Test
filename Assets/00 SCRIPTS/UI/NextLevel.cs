using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextLevel : MonoBehaviour
{
    [SerializeField] protected string levelName;
    [SerializeField] protected Animator _animator;
    protected void LoadLevel()
    {
        StartCoroutine(LoadLevelTime());
    }


    IEnumerator LoadLevelTime() {
        _animator.SetTrigger("End");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(levelName);
        _animator.SetTrigger("Start");
    }
    protected void InvokeNextLevel()
    {
        Invoke("LoadLevel", 1.5f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            this.InvokeNextLevel();
        }
    }
}
