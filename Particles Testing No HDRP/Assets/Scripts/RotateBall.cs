using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSpark : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*
        transform.position = new Vector3(Mathf.Cos(Time.time) * 7f, 0, 0);
        */
        transform.eulerAngles = new Vector3(0, Time.time * 360f, 0);

    }
}
