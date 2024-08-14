using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerStats : MonoBehaviour
{
    private int _maxStamina = 30;
    public int StaminaPlayer = 30;
    [SerializeField] private TextMeshProUGUI _staminaPoints;

    private void Update()
    {
        _staminaPoints.text = StaminaPlayer.ToString();
        if (StaminaPlayer == 0)
        {
            Debug.Log("Out of stamina");
        }
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (!hit.gameObject.CompareTag("Ball"))
        {
            StartCoroutine(IncreaseStamina());
        }
    }

    public void DecreaseStamina()
    {
        if(StaminaPlayer > 0)
        {
            StaminaPlayer = StaminaPlayer - 1;
        }
        else
        {
            Debug.Log("Out of stamina");
        }
        //Debug.Log("Current stamina is: " + StaminaPlayer);
    }

    //public void IncreaseStamina() 
    //{
    //    StaminaPlayer = StaminaPlayer + 1;
    //    //Debug.Log("Current stamina is: " + StaminaPlayer);
    //}

    public IEnumerator IncreaseStamina() //Doens't work as IEnumerator
    {
        yield return new WaitForSeconds(2f);
        if(StaminaPlayer < _maxStamina)
        {
            StaminaPlayer = StaminaPlayer + 1;
        }
        Debug.Log("Current stamina is: " + StaminaPlayer);
        yield return null;
    }
}
