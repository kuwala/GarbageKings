using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSlider : MonoBehaviour
{
    public float slideValue = 0f;
    public float slideYDistance = 1f;
    private float startY;
    public int knobSelect = 1;
    private opzController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<opzController>();
        startY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {

        if (knobSelect == 1)
        {
            slideValue = controller.knob1;
        }
        else if (knobSelect == 2)
        {
            slideValue = controller.knob2;
        }
        else if (knobSelect == 3)
        {
            slideValue = controller.knob3;
        }
        else if (knobSelect == 4)
        {
            slideValue = controller.knob4;
        }
        transform.position = new Vector3(transform.position.x, startY + slideYDistance * slideValue,transform.position.z);
    }
}
