using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AddStar : MonoBehaviour
{
      public static int collisionsCount = 0;
      public TextMeshProUGUI collisionsText; // Assure-toi de faire référence à ton objet Text UI dans l'éditeur Unity


      private void OnTriggerEnter(Collider collision)
      {
          if (collision.gameObject.CompareTag("Player"))
          {
              AddStar.collisionsCount++;
              UpdateCollisionsText(); // Mets à jour le texte à chaque collision
              Destroy(gameObject);
          }
      }

      void UpdateCollisionsText()
      {
          // Assure-toi que collisionsText existe avant de tenter de le mettre à jour
          if (collisionsText != null)
          {
              collisionsText.text = collisionsCount.ToString();
          }
      }
}
