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
            OSCHandler.Instance.SendMessageToClient("pd", "/unity/bad", 0);
            flag = false;
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

