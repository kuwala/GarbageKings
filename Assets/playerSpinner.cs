using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSpinner : MonoBehaviour
{
    private opzController controller;
    private float rot = 0.0f;
    public int mapToKnob = 1;
    public float scaler = 1f;
    private void Awake()
    {
        rot = transform.rotation.eulerAngles.z;
        print(rot);
    }
    void Start()
    {
        controller = GetComponent<opzController>();
        //rot = transform.rotation.z;

    }

    // Update is called once per frame
    void Update()
    {
        float rotZ = 0f;
        if(mapToKnob == 1)
        {
            rotZ = controller.knob1.Map(1, 0, 0, 360);

        } else if(mapToKnob == 2)
        {
            rotZ = controller.knob2.Map(1, 0, 0, 360);

        } else if (mapToKnob == 3)
        {
            rotZ = controller.knob3.Map(1, 0, 0, 360);

        } else if (mapToKnob == 4)
        {
            rotZ = controller.knob4.Map(1, 0, 0, 360);

        }
        Quaternion target = Quaternion.Euler(0, 0, rotZ * scaler + rot);
        transform.rotation = target;
         
        
    }

}

public static class ExtensionMethods
{
    public static float Map(this float value, float from1, float to1, float from2, float to2)
    {
        return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
    }
}
