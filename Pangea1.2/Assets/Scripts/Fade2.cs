using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade2 : MonoBehaviour
{
    public GameObject removeObject;
    public GameObject removeObject2;
    public GameObject revealObject;
    

    void PlayFade()
    {
        StartCoroutine(MovePeople());
    }

    void StopFade()
    {
        //fade_effect.SetActive(false);
    }

    IEnumerator MovePeople()
    {
        yield return new WaitForSeconds(0f);
        removeObject.SetActive(false);
        removeObject2.SetActive(false);
        revealObject.SetActive(true);
    }
}
