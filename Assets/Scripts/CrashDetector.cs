using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Ground")
        {
            SceneManager.LoadScene(0);
            Debug.Log("ITS OVER ANAKIN!!!");
        }
        
    }
}
