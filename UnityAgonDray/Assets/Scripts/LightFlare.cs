using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlare : MonoBehaviour
{
    public Light light;
    int i;
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
        i = 1;
    }

    // Update is called once per frame
    void Update()
    {
        light.intensity = Mathf.PingPong(Time.time * 6*i, 7*i);
        if(light.intensity > 60)
        {
            light.intensity = 0;
            this.enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            OffLight();
        }
    }

    private void OffLight()
    {
        light.color = Color.red;
        i = 10;

    }
}
