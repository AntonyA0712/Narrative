using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class night : MonoBehaviour
{

    public GameObject nightlight;
    public GameObject player;

    public GameObject removeObject;
    public GameObject removeObject2;
    public GameObject removeObject3;
    public GameObject revealObject;

    void Night_true()
    {
        nightlight.transform.rotation = new Quaternion(-9.5f, -30f, 0,0);

        player.transform.position = new Vector3(-6.69f, 2.42f, -25.87f);
        player.transform.rotation = new Quaternion(0, 90, 0,0);

        StartCoroutine(MovePeople_true());
    }
    IEnumerator MovePeople_true()
    {
        yield return new WaitForSeconds(0f);

        removeObject.SetActive(false);
        removeObject2.SetActive(false);
        removeObject3.SetActive(false);
        revealObject.SetActive(true);
    }

    void Night_false()
    {
        nightlight.transform.rotation = new Quaternion(-9.5f, -30f, 0, 0);

        player.transform.position = new Vector3(-6.69f, 2.42f, -25.87f);
        player.transform.rotation = new Quaternion(0, 90, 0, 0);

        StartCoroutine(MovePeople_false());
    }

    IEnumerator MovePeople_false()
    {
        yield return new WaitForSeconds(0f);

        removeObject.SetActive(false);
        removeObject2.SetActive(false);
        removeObject3.SetActive(false);
        revealObject.SetActive(false);

    }
}
