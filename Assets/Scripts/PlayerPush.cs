using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class PlayerPush : MonoBehaviour
{
    [SerializeField] GameObject _player;
    [SerializeField] GameObject _playerStats;
    private int _stamina;

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Ball"))
        {
            _playerStats.GetComponent<PlayerStats>().DecreaseStamina();
            hit.gameObject.GetComponent<Rigidbody>().AddForceAtPosition(gameObject.transform.forward * 100f, hit.point);
        }
        //else //Doesn't quite work, keeps increasing, make another fuction for this
        //{
        //    Debug.Log("Not touching ball");
        //    _playerStats.GetComponent<PlayerStats>().IncreaseStamina(); 
        //}

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
