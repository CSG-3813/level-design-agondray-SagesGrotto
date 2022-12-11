using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyGrab : MonoBehaviour
{
    public AgondrayEscape manager;
    public string KeyType;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            manager.KeyGrab(KeyType);
            gameObject.SetActive(false);
        }
    }
}
