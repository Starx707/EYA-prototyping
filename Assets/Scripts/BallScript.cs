using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;

   public void normalAngularDrag()
    {
        rb.angularDrag = 8;
        Debug.Log("Anglular drag normalized");
    }
}
