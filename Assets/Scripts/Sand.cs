using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sand : MonoBehaviour
{

   [SerializeField] private GameObject _ball; //Overkill? Object is taken during the collision
    private bool _ballSlowedDown;


    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("test");
        var obj = collision.gameObject;
        if (obj.CompareTag("Ball")) //perhaps do this in ball itself
        {
            _ballSlowedDown = true;
            if (_ballSlowedDown == true && obj.GetComponent<Rigidbody>().angularDrag == 8) 
            { 
                obj.GetComponent<Rigidbody>().angularDrag = 16f;
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        var obj = collision.gameObject;
        if (obj.CompareTag("Ball"))
        {
            if (_ballSlowedDown == true && obj.GetComponent<Rigidbody>().angularDrag == 16)
            {
                obj.GetComponent<BallScript>().normalAngularDrag(); //if it isn't colliding anymore, change the drag back to 8
                _ballSlowedDown = false;
            }
        }
    }

}
