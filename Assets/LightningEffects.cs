using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningEffects : MonoBehaviour
{
    Light Lightning;
    // Start is called before the first frame update
    void Start()
    {
        Lightning = GetComponent<Light>();
        Lightning.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.timeSinceLevelLoad);
        if (Time.timeSinceLevelLoad % 5.0f > 4.0f)
        {
            Lightning.enabled = true;
        } else
        {
            Lightning.enabled = false;
        }
    }
}
