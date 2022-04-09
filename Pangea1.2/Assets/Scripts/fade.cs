using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fade : MonoBehaviour
{
    //public GameObject fade_effect;
    //Animator myAnim;
    public GameObject removeObject;
    public GameObject revealObject;
    public GameObject revealObject2;
    void Start()
    {
        //myAnim = GetComponent<Animator>();
    }

    void PlayFade()
    {
        //myAnim.SetTrigger("fade");
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
        revealObject.SetActive(true);
        revealObject2.SetActive(true);
}
}
