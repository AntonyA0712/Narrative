using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_StopMovement : MonoBehaviour
{
    MovementScript _movescript;


    // Start is called before the first frame update
    void Start()
    {
        _movescript = GetComponent<MovementScript>();
    }

    public void StopPlayer()
    {
        _movescript.enabled = false;
    }

    public void StartPlayer()
    {
        _movescript.enabled = true;
    }
}
