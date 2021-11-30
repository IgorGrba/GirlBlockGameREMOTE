using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class Items : MonoBehaviour
{
   
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hole"))
        {
            GameManager.instance.DecreaseItemCount();
            Destroy(this.gameObject);

            if (GameManager.instance.itemCount <= 0)
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    }
    
}
