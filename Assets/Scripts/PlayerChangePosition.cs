using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChangePosition : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] private GameObject player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Area1")
        {
            cam.transform.position = new Vector3 (0, 0, -10);
            player.transform.position = new Vector3(-1.09f, -4.14f, 0);
        }

        if (collision.gameObject.tag == "Area2")
        {
            cam.transform.position = new Vector3 (0, -11.75f, -10);
            player.transform.position = new Vector3(0, -7.59f, 0);
        }
    }
}
