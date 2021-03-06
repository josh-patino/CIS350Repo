/*
* Josh Patino 
* Step 1 A6
* singleton template class
*/ 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
   private static T instance; 
   public static T Instance
   {
       get {return instance; }
   }

   public static bool isInitialized 
   {
       get {return instance != null;}
   }

    private void Awake()
    {
      if (instance == null)
      {
          Debug.LogError("singlton trying to instaniate a second instance");
      }  
      else
      {
          instance = (T)this; 
      }
    }

    protected virtual void OnDestroy()
    {
        if (instance == this)
        {
            instance = null; 
        }
    }


}

