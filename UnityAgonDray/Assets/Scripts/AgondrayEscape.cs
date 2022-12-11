using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgondrayEscape : MonoBehaviour
{
    public bool hasRedKey { get; set; }
    public bool hasYellowKey { get; set; }
    public bool hasGreenKey { get; set; }

    private void Start()
    {
        hasRedKey = false;
        hasYellowKey = false;
        hasGreenKey = false;
    }

    public void KeyGrab(string KeyType)
    {
        if(KeyType == "Red")
        {
            hasRedKey = true;
            Debug.Log(hasRedKey);
        }
        if(KeyType == "Yellow")
        {
            hasYellowKey = true;
            Debug.Log(hasYellowKey);
        }
        if(KeyType == "Green")
        {
            hasGreenKey = true;
            Debug.Log(hasGreenKey);
        }
    }
    private void Update()
    {
    }
}
