using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MidiJack;

public class opzController : MonoBehaviour
{
    public float knob1 = 0f;
    public float knob2 = 0f;
    public float knob3 = 0f;
    public float knob4 = 0f;

    public float knob1Alt = 0f;
    public float knob2Alt = 0f;
    public float knob3Alt = 0f;
    public float knob4Alt = 0f;
    private bool toggleControls;
    public float knobAltRate = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        toggleControls = true;
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.BackQuote))
        {
            toggleControls = !toggleControls;
        }
        if(toggleControls)
        {
            if (Input.GetKey(KeyCode.Alpha7))
            {
                knob1 += knobAltRate;
                while(knob1 > 1)
                {
                    knob1 -= 1;
                }
            }
            if (Input.GetKey(KeyCode.Alpha8))
            {
                knob2 += knobAltRate;
                while (knob2 > 1)
                {
                    knob2 -= 1;
                }
            }
            if (Input.GetKey(KeyCode.Alpha9))
            {
                knob3 += knobAltRate;
                while (knob3 > 1)
                {
                    knob3 -= 1;
                }
            }
            if (Input.GetKey(KeyCode.Alpha0))
            {
                knob4 += knobAltRate;
                while (knob4 > 1)
                {
                    knob4 -= 1;
                }
            }
        }
        else
        {
            knob1 = MidiMaster.GetKnob(1);
            knob2 = MidiMaster.GetKnob(2);
            knob3 = MidiMaster.GetKnob(3);
            knob4 = MidiMaster.GetKnob(4);
        }

    }
}
