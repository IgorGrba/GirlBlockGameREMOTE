using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Unity.Mathematics;
using UnityEngine.SceneManagement;

public class Items : MonoBehaviour
{

    [SerializeField] private GameObject confettiVFX;
    [SerializeField] private GameObject amazingText;
    [SerializeField] private GameObject levelCompletedText;
    [SerializeField] private GameObject level1;

    [SerializeField] private Transform girlPosition;

    [SerializeField] private GameObject girlClone;
    [SerializeField] private GameObject girlReal;

    [SerializeField] private GameObject blastVFX;
    [SerializeField] private Transform blastVFXPos;


    [SerializeField] private Transform platformReset;


    [SerializeField] private GameObject camera1;
    [SerializeField] private GameObject camera2;


    [SerializeField] private Animator doorAnim;
    [SerializeField] private Animator platformAnim;

    [SerializeField] private GameObject items;
    [SerializeField] private GameObject itemsDuplicate;


    
    


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hole"))
        {
            GameManager.instance.DecreaseItemCount();

            if (GameManager.instance.itemCount <= 0)
            {
                Invoke("ActivateDoor", 1f);
                Invoke("ActivatePlatform", 1.5f);
                Invoke("EndScreen", 4f);

            }
        }
    }


     private  void ActivateDoor()
    {
        doorAnim.SetTrigger("DoorOpen");
    }
     
     private  void ActivatePlatform()
    {
        platformAnim.SetTrigger("PlatformRising");
    }


     private void EndScreen()
     {
         level1.SetActive(false);
         confettiVFX.SetActive(true);
         amazingText.SetActive(true);
         levelCompletedText.SetActive(true);
                
         itemsDuplicate.SetActive(false);
         items.SetActive(true);
         camera1.SetActive(false);
         camera2.SetActive(true);
         girlReal.SetActive(false);
         platformReset.DORotate(new Vector3(0f, 0f, 0f), 0);
         girlClone.SetActive(true);
     }
     
     
}
