using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    void Start()
    {

        Debug.Log(sum(2, 4));
        Debug.Log(prod(2, 4));
        Debug.Log(div(2, 4));
    }
    float sum(float a, float b)
    {
        return a + b;
    }
    float prod(float a, float b)
    {
        return (a - b);
    }
    float div(float a, float b)
    {
        return a / b;
        if (b == 0)
        {
            Debug.Log("error");
        }
    }
}