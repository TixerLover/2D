using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDelay : MonoBehaviour
{
    [SerializeField] private GameObject buttonOff;
    [SerializeField] private int time;
    [SerializeField] private GameObject Maven;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            StartCoroutine(ActiveButton(time));
        }
    }

    IEnumerator ActiveButton(int time)
    {
        Maven.SetActive(false);
        buttonOff.SetActive(false);
        yield return new WaitForSeconds(time);
        Maven.SetActive(true);
        buttonOff.SetActive(true);
    }
}
