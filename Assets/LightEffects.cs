using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightEffects : MonoBehaviour
{

    Light Candlelight;
    float randomOffset;
    // Start is called before the first frame update
    void Start()
    {
        Candlelight = GetComponent<Light>();
        randomOffset = Random.value;
    }

    // Update is called once per frame
    void Update()
    {
        Candlelight.intensity = Mathf.PerlinNoise(0, 2.0f*Time.timeSinceLevelLoad+randomOffset);
        //Debug.Log(Mathf.PerlinNoise(0, Time.timeSinceLevelLoad));
    }
}