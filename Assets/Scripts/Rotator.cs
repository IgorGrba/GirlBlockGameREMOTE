using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class Rotator : MonoBehaviour
{

    [SerializeField] private Transform platform;
    [SerializeField] private float duration = 3;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("TopRight"))
        {
            platform.DOLocalRotate(new Vector3(15, 0, -10), duration);
        }
        else if (other.gameObject.CompareTag("TopLeft"))
        {
            platform.DOLocalRotate(new Vector3(15, 0, 10), duration);
        }
        else if (other.gameObject.CompareTag("TopMiddle"))
        {
            platform.DOLocalRotate(new Vector3(15, 0, 0), duration);
        }
        else if (other.gameObject.CompareTag("Middle"))
        {
            platform.DOLocalRotate(new Vector3(0, 0, 0), duration);
        }
        else if (other.gameObject.CompareTag("BottomLeft"))
        {
            platform.DOLocalRotate(new Vector3(-15, 0, 10), duration);
        }
        else if (other.gameObject.CompareTag("BottomMiddle"))
        {
            platform.DOLocalRotate(new Vector3(-15, 0, 0), duration);
        }
        else if (other.gameObject.CompareTag("BottomRight"))
        {
            platform.DOLocalRotate(new Vector3(-15, 0, -10), duration);
        }
        else if (other.gameObject.CompareTag("LeftSide"))
        {
            platform.DOLocalRotate(new Vector3(0, 0, 10), duration);
        }
        else if (other.gameObject.CompareTag("RightSide"))
        {
            platform.DOLocalRotate(new Vector3(0, 0, -10), duration);
        }
    }
    
}
