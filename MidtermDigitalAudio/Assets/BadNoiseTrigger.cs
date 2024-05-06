using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadNoiseTrigger : MonoBehaviour
{
    private bool flag = false;
    void Update()
    {
        if(flag)
        {

            //
            //PUT SOUND HERE
            //


        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            flag = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            flag = false;
        }
    }
}

