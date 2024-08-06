using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlane : MonoBehaviour
{
    [SerializeField] private GameObject _respawnPlayer;
    [SerializeField] private GameObject _respawnBall;
    [SerializeField] private Transform _respawnOfTestBall;

    private void OnTriggerEnter(Collider GameObject)
    {
        if (GameObject.GetComponent<PlayerMovement>())
        {
            GameObject.transform.position = _respawnPlayer.transform.position;
        }
        else if (GameObject.CompareTag("Ball"))
        {
            GameObject.transform.position = _respawnPlayer.transform.position;
        }
        else if (GameObject.CompareTag("TestBall"))
        {
            GameObject.transform.position = _respawnOfTestBall.position;
        }
    }
}