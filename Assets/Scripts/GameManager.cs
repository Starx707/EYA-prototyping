using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public GameObject p1;
    public GameObject p2;

    // Start is called before the first frame update
    void Start()
    {
        var player1 = PlayerInput.Instantiate(p1, controlScheme: "WASD", pairWithDevice: Keyboard.current);
        var player2 = PlayerInput.Instantiate(p2, controlScheme: "Arrows", pairWithDevice: Keyboard.current);
    }
}
