using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class TweenToPlayer : MonoBehaviour
{
    [SerializeField] private Transform playerPosition;
    [SerializeField] private float maxRange=0.7f;

    private void Start()
    {
        Invoke("MoveToPlayer", UnityEngine.Random.Range(0,maxRange));
    }

    
    
    void MoveToPlayer()
    {
        transform.DOMove(playerPosition.transform.position, 1f);
        transform.DOScale(new Vector3(0.1f, 0.1f, 0.1f), 2f);
        
        Destroy(gameObject, 1f);
    }
}
