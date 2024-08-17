using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScipts : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown("left"))
        {
            Debug.Log("Going left");
        }
        else if (Input.GetKeyDown("right"))
        {
            Debug.Log("Going right");
        }
        else if (Input.GetKeyDown("up"))
        {
            Debug.Log("Going up");
        }
        else if (Input.GetKeyDown("down"))
        {
            Debug.Log("Going down");
        }
    }
}
