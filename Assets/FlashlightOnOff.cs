using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightOnOff : MonoBehaviour
{

    Light Flashlight;
    // Start is called before the first frame update
    void Start()
    {
        Flashlight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            Flashlight.enabled = !Flashlight.enabled;
        }
    }
}
