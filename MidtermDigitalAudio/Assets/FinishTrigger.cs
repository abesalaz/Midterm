using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    [SerializeField] private Canvas endscreen;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            endscreen.enabled = true;
            //
            //SOUND GOES HERE
            //


        }
    }
}
