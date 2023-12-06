using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Animator myDoor = null;
    public bool openTrigger = false;
    public bool closeTrigger = false;
    public string nameAnimDoor = "door";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (openTrigger)
            {
                print(myDoor);
               myDoor.Play(nameAnimDoor, 0, 0.0f);
               gameObject.SetActive(false);
            } else {
                myDoor.Play(nameAnimDoor, 0, 0.0f);
                gameObject.SetActive(false);
            }
        }
    }
}
