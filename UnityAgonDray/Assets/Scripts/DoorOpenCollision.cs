/***
 * Author: Sage
 * Create: 11/30/22
 * Modified:
 * Description: Opens door
 ***/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenCollision : MonoBehaviour
{
    public AgondrayEscape manager;
    public string animtionParamater;
    Animator anim;
    public string KeyType;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Being Touched");

        if (KeyType == "Red")
        {
            Debug.Log("Has Red Key = " + manager.hasRedKey);
            if (other.tag == "Player" && manager.hasRedKey)
            {
                Debug.Log("Door Open");
                anim.SetBool(animtionParamater, true);
            }
        }

        if (KeyType == "Yellow")
        {
            Debug.Log("Has Yellow Key = " + manager.hasYellowKey);
            if (other.tag == "Player" && manager.hasYellowKey)
            {
                Debug.Log("Door Open");
                anim.SetBool(animtionParamater, true);
            }
        }

        if (KeyType == "Green")
        {
            Debug.Log("Has Green Key = " + manager.hasGreenKey);
            if (other.tag == "Player" && manager.hasGreenKey)
            {
                Debug.Log("Door Open");
                anim.SetBool(animtionParamater, true);
            }
        }


    }
}
