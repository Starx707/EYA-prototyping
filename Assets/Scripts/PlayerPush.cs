using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class PlayerPush : MonoBehaviour
{
    [SerializeField] GameObject _player;

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Ball"))
        {
            hit.gameObject.GetComponent<Rigidbody>().AddForceAtPosition(gameObject.transform.forward * 100f, hit.point);
        }

        if (hit.gameObject.CompareTag("Sand"))//slow down the player speed & sprint speed
        {
            _player.GetComponent<ThirdPersonController>().MoveSpeed = 2f;
            _player.GetComponent<ThirdPersonController>().SprintSpeed = 3.5f;
        }
        else
        {
            _player.GetComponent<ThirdPersonController>().MoveSpeed = 4.5f;
            _player.GetComponent<ThirdPersonController>().MoveSpeed = 6f;
        }
    }
}
