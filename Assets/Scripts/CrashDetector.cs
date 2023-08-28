using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] CircleCollider2D headCollider;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(0);
        Debug.Log("ITS OVER ANAKIN!!!");
    }
}
