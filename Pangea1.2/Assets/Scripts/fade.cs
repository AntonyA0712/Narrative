using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fade : MonoBehaviour
{
    public GameObject fade_effect;

    void Start()
    {
        fade_effect = GetComponent<GameObject>();
    }

    void PlayFade()
    {
        fade_effect.SetActive(true);
    }

    void StopFade()
    {
        fade_effect.SetActive(false);
    }
}
