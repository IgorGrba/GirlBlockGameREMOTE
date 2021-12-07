using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
   public static GameManager instance = null;
   public int itemCount = 8;


   private void Awake()
   {
      if (instance == null)
      {
         instance = this;
      }
      else if (instance != null)
      {
         Destroy(gameObject);
      }
      DontDestroyOnLoad(this.gameObject);
   }

   


   public void DecreaseItemCount()
   {
      itemCount--;
   }
   
   
   
}
