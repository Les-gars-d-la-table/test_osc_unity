using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BALLSCRIPT : MonoBehaviour
{

    public GameObject SparkBall;

    public static float ScaleValue(float value, float inputMin, float inputMax, float outputMin, float outputMax)
    {
        return Mathf.Clamp(((value - inputMin) / (inputMax - inputMin) * (outputMax - outputMin) + outputMin), outputMin, outputMax);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Cos(Time.time) * 7f, 0, 0);
        transform.eulerAngles = new Vector3(0, 0, Time.time * 360f);

    }

    private void LateUpdate()
    {
        float position = SparkBall.transform.position.x;
        position = ScaleValue(position, -7, 7, 0, 255);
    }

}
