using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class ActivateItem : MonoBehaviour
{
    [SerializeField] private GameObject realItem;
    [SerializeField] private GameObject fakeItem;


    [SerializeField] private GameObject sparkleParticle;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hole"))
        {
            realItem.SetActive(false);
            fakeItem.SetActive(true);


            var sparkleVFX = Instantiate(sparkleParticle, fakeItem.transform.position, quaternion.identity);
            
            Destroy(sparkleVFX, 1.5f);
            
        }
    }
}
