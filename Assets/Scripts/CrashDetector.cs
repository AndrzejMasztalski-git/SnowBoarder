using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float lostReloadDelay = 1.0f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Ground")
        {
            Invoke("ReloadScene", lostReloadDelay);
        }
        
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }

    
}
