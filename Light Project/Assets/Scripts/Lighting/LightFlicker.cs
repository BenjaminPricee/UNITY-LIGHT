using UnityEngine;
using System.Collections.Generic;

public class LightFlicker : MonoBehaviour
{
    public new Light light;

    private bool flick;
    private int flickDelay;
    
    private int setIntesity;
    private float minIntensity;
    private float maxIntensity;

    void Start()
    {
        light = GetComponent<Light>();
        flick = false;
        flickDelay = 0;
        setIntesity = 1;
        minIntensity = 0f;
        maxIntensity = 0.75f;
}

    void Update()
    {
        if (flick)
        {
            if(flickDelay > 0)
            {
                flickDelay -= 1;
            }
            else
            {
                flickDelay = 0;
                light.intensity = setIntesity;
                flick = false;
            }
        }
        else
        {
            int chance = Random.Range(0, 75);
            if (chance == 1)
            {
                light.intensity = Random.Range(minIntensity, maxIntensity);
                flickDelay = Random.Range(0, 50);
                flick = true;
            }
        }
    }

}