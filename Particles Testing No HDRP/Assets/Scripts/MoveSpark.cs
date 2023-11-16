using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpark : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(Mathf.Cos(Time.time) * 7f, 2, 0);
        /*
        transform.eulerAngles = new Vector3(0, 0, Time.time * 360f);
        */

    }
}
