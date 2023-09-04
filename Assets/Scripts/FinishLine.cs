using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float winReloadDelay = 1.0f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Invoke("ReloadScene", winReloadDelay);
        }
        
    }

    void ReloadScene()
    {
        SceneManager.LoadScene("Level1");
    }
}
