using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
   private GameObject spawner;
   private GameObject player;
   private GameObject walker;

   private Transform spawnTransform;

   [SerializeField] private GameObject mechant = default;


   private float distance;

   private void Awake()
   {
      spawner = gameObject;
      player = GameObject.Find("Player");
      spawnTransform = transform;
   }

   // Update is called once per frame
   void Update()
   {
      distance = Vector3.Distance(spawnTransform.position, player.transform.position);
      if (distance < 4f && spawnTransform.childCount < 1)
      {
         GameObject walker = Instantiate(mechant,spawnTransform.position,Quaternion.identity,spawnTransform);
      }

   }
}
