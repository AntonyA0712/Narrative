using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fade : MonoBehaviour
{
    //public GameObject fade_effect;
    Animator myAnim;
    public GameObject removeObject;
    public GameObject revealObject;

    void Start()
    {
        myAnim = GetComponent<Animator>();
    }

    void PlayFade()
    {
        //fade_effect.SetActive(true);
        myAnim.SetTrigger("fade");
        StartCoroutine(MovePeople());
    }

    void StopFade()
    {
        //fade_effect.SetActive(false);
    }

    IEnumerator MovePeople()
    {
        yield return new WaitForSeconds(1.5f);
        removeObject.SetActive(false);
        revealObject.SetActive(true);
    }
}
