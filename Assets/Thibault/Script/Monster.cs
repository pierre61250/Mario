using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Monster : MonoBehaviour
{
   private void OnTriggerEnter(Collider collision)
         {
             if (collision.gameObject.CompareTag("Player"))
             {
                SceneManager.LoadScene("Loosing");
             }
   }
}
