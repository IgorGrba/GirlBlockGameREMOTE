using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    private void Start()
    {
        Application.targetFrameRate = 60;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Items"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
