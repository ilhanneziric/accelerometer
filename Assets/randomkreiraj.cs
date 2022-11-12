using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class randomkreiraj : MonoBehaviour
{
   public GameObject[] objects;
   void Start()
   {
      funkcija();
   }

   public void funkcija()
   {
      var rand = Random.Range(0, objects.Length);
      Instantiate(objects[rand], transform.position, Quaternion.identity);
   }
}
