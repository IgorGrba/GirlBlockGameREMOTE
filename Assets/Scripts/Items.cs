using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class Items : MonoBehaviour
{

    [SerializeField] private GameObject confettiVFX;
    [SerializeField] private GameObject amazingText;
    [SerializeField] private GameObject levelCompletedText;
    [SerializeField] private GameObject level1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hole"))
        {
            GameManager.instance.DecreaseItemCount();
            Destroy(this.gameObject);

            if (GameManager.instance.itemCount <= 0)
            {
                level1.SetActive(false);
                confettiVFX.SetActive(true);
                amazingText.SetActive(true);
                levelCompletedText.SetActive(true);
            }
        }
    }
    
}
