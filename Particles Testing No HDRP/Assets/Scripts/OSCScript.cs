using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using extOSC;

public class OSCScript : MonoBehaviour
{

    public extOSC.OSCReceiver oscReceiver;
    public extOSC.OSCTransmitter oscTransmitter;
    public GameObject spark0;
    public GameObject spark1;
    public GameObject spark2;
    public GameObject spark3;
    public GameObject spark4;
    public GameObject spark5;

    // max value scaling function
    public static float ScaleValue(float value, float inputMin, float inputMax, float outputMin, float outputMax)
    {
        return Mathf.Clamp(((value - inputMin) / (inputMax - inputMin) * (outputMax - outputMin) + outputMin), outputMin, outputMax);
    }


    // Start is called before the first frame update
    void Start()
    {
        // get info from the *stuff* max sends to unity via OSC
        oscReceiver.Bind("/slice0", slice0);
        oscReceiver.Bind("/slice1", slice1);
        oscReceiver.Bind("/slice2", slice2);
        oscReceiver.Bind("/slice3", slice3);
        oscReceiver.Bind("/slice4", slice4);
        oscReceiver.Bind("/slice5", slice5);
    }

    void slice0(OSCMessage oscMessage)
    {
        // X: -13 to 13, Y (z in the scene): -6 to 6
        // float of the X coordinate
        float preXCoord;
        if (oscMessage.Values[0].Type == OSCValueType.Int)
        {
            preXCoord = oscMessage.Values[0].IntValue;
        }
        else if (oscMessage.Values[0].Type == OSCValueType.Float)
        {
            preXCoord = oscMessage.Values[0].FloatValue;
        }
        else
        {
            // Si la valeur n'est ni un float ou int, on quitte la méthode :
            return;
        }

        
        // float of the Y coordinate
        float preYCoord;
        if (oscMessage.Values[1].Type == OSCValueType.Int)
        {
            preYCoord = oscMessage.Values[1].IntValue;
        }
        else if (oscMessage.Values[1].Type == OSCValueType.Float)
        {
            preYCoord = oscMessage.Values[1].FloatValue;
        }
        else
        {
            // Si la valeur n'est ni un float ou int, on quitte la méthode :
            return;
        }

        float xCoord = ScaleValue(preXCoord, 0, 100, -13, 13);
        float yCoord = ScaleValue(preYCoord, 0, 100, -6, 6);

        spark0.transform.position = new Vector3(xCoord, 1, yCoord);

        Debug.Log("Slice0: " + xCoord + " " + yCoord);
    }

    void slice1(OSCMessage oscMessage)
    {
        // X: -13 to 13, Y (z in the scene): -6 to 6
        // float of the X coordinate
        float preXCoord;
        if (oscMessage.Values[0].Type == OSCValueType.Int)
        {
            preXCoord = oscMessage.Values[0].IntValue;
        }
        else if (oscMessage.Values[0].Type == OSCValueType.Float)
        {
            preXCoord = oscMessage.Values[0].FloatValue;
        }
        else
        {
            // Si la valeur n'est ni un float ou int, on quitte la méthode :
            return;
        }


        // float of the Y coordinate
        float preYCoord;
        if (oscMessage.Values[1].Type == OSCValueType.Int)
        {
            preYCoord = oscMessage.Values[1].IntValue;
        }
        else if (oscMessage.Values[1].Type == OSCValueType.Float)
        {
            preYCoord = oscMessage.Values[1].FloatValue;
        }
        else
        {
            // Si la valeur n'est ni un float ou int, on quitte la méthode :
            return;
        }

        float xCoord = ScaleValue(preXCoord, 0, 100, -13, 13);
        float yCoord = ScaleValue(preYCoord, 0, 100, -6, 6);

        spark1.transform.position = new Vector3(xCoord, 1, yCoord);

        Debug.Log("Slice1: " + xCoord + " " + yCoord);
    }

    void slice2(OSCMessage oscMessage)
    {
        // X: -13 to 13, Y (z in the scene): -6 to 6
        // float of the X coordinate
        float preXCoord;
        if (oscMessage.Values[0].Type == OSCValueType.Int)
        {
            preXCoord = oscMessage.Values[0].IntValue;
        }
        else if (oscMessage.Values[0].Type == OSCValueType.Float)
        {
            preXCoord = oscMessage.Values[0].FloatValue;
        }
        else
        {
            // Si la valeur n'est ni un float ou int, on quitte la méthode :
            return;
        }


        // float of the Y coordinate
        float preYCoord;
        if (oscMessage.Values[1].Type == OSCValueType.Int)
        {
            preYCoord = oscMessage.Values[1].IntValue;
        }
        else if (oscMessage.Values[1].Type == OSCValueType.Float)
        {
            preYCoord = oscMessage.Values[1].FloatValue;
        }
        else
        {
            // Si la valeur n'est ni un float ou int, on quitte la méthode :
            return;
        }

        float xCoord = ScaleValue(preXCoord, 0, 100, -13, 13);
        float yCoord = ScaleValue(preYCoord, 0, 100, -6, 6);

        spark2.transform.position = new Vector3(xCoord, 1, yCoord);

        Debug.Log("Slice2: " + xCoord + " " + yCoord);
    }

    void slice3(OSCMessage oscMessage)
    {
        // X: -13 to 13, Y (z in the scene): -6 to 6
        // float of the X coordinate
        float preXCoord;
        if (oscMessage.Values[0].Type == OSCValueType.Int)
        {
            preXCoord = oscMessage.Values[0].IntValue;
        }
        else if (oscMessage.Values[0].Type == OSCValueType.Float)
        {
            preXCoord = oscMessage.Values[0].FloatValue;
        }
        else
        {
            // Si la valeur n'est ni un float ou int, on quitte la méthode :
            return;
        }


        // float of the Y coordinate
        float preYCoord;
        if (oscMessage.Values[1].Type == OSCValueType.Int)
        {
            preYCoord = oscMessage.Values[1].IntValue;
        }
        else if (oscMessage.Values[1].Type == OSCValueType.Float)
        {
            preYCoord = oscMessage.Values[1].FloatValue;
        }
        else
        {
            // Si la valeur n'est ni un float ou int, on quitte la méthode :
            return;
        }

        float xCoord = ScaleValue(preXCoord, 0, 100, -13, 13);
        float yCoord = ScaleValue(preYCoord, 0, 100, -6, 6);

        spark3.transform.position = new Vector3(xCoord, 1, yCoord);

        Debug.Log("Slice3: " + xCoord + " " + yCoord);
    }

    void slice4(OSCMessage oscMessage)
    {
        // X: -13 to 13, Y (z in the scene): -6 to 6
        // float of the X coordinate
        float preXCoord;
        if (oscMessage.Values[0].Type == OSCValueType.Int)
        {
            preXCoord = oscMessage.Values[0].IntValue;
        }
        else if (oscMessage.Values[0].Type == OSCValueType.Float)
        {
            preXCoord = oscMessage.Values[0].FloatValue;
        }
        else
        {
            // Si la valeur n'est ni un float ou int, on quitte la méthode :
            return;
        }


        // float of the Y coordinate
        float preYCoord;
        if (oscMessage.Values[1].Type == OSCValueType.Int)
        {
            preYCoord = oscMessage.Values[1].IntValue;
        }
        else if (oscMessage.Values[1].Type == OSCValueType.Float)
        {
            preYCoord = oscMessage.Values[1].FloatValue;
        }
        else
        {
            // Si la valeur n'est ni un float ou int, on quitte la méthode :
            return;
        }

        float xCoord = ScaleValue(preXCoord, 0, 100, -13, 13);
        float yCoord = ScaleValue(preYCoord, 0, 100, -6, 6);

        spark4.transform.position = new Vector3(xCoord, 1, yCoord);

        Debug.Log("Slice4: " + xCoord + " " + yCoord);
    }

    void slice5(OSCMessage oscMessage)
    {
        // X: -13 to 13, Y (z in the scene): -6 to 6
        // float of the X coordinate
        float preXCoord;
        if (oscMessage.Values[0].Type == OSCValueType.Int)
        {
            preXCoord = oscMessage.Values[0].IntValue;
        }
        else if (oscMessage.Values[0].Type == OSCValueType.Float)
        {
            preXCoord = oscMessage.Values[0].FloatValue;
        }
        else
        {
            // Si la valeur n'est ni un float ou int, on quitte la méthode :
            return;
        }


        // float of the Y coordinate
        float preYCoord;
        if (oscMessage.Values[1].Type == OSCValueType.Int)
        {
            preYCoord = oscMessage.Values[1].IntValue;
        }
        else if (oscMessage.Values[1].Type == OSCValueType.Float)
        {
            preYCoord = oscMessage.Values[1].FloatValue;
        }
        else
        {
            // Si la valeur n'est ni un float ou int, on quitte la méthode :
            return;
        }

        float xCoord = ScaleValue(preXCoord, 0, 100, -13, 13);
        float yCoord = ScaleValue(preYCoord, 0, 100, -6, 6);

        spark5.transform.position = new Vector3(xCoord, 1, yCoord);

        Debug.Log("Slice5: " + xCoord + " " + yCoord);
    }


}
