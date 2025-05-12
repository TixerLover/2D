using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] private GameObject player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "House")
        {
            cam.transform.position = new Vector3(0.07f, 16.08f, -10);
            player.transform.position = new Vector3(0.06f, 12.18f, 0);
        }

        if (collision.gameObject.tag == "Market1")
        {
            cam.transform.position = new Vector3(0.07f, 0.3f, -10);
            player.transform.position = new Vector3(-5.14f, 0.42f, 0);
        }

        if (collision.gameObject.tag == "Market2")
        {
            cam.transform.position = new Vector3(0.07f, 0.3f, -10);
            player.transform.position = new Vector3(7.36f, -0.08f, 0);
        }

        if (collision.gameObject.tag == "Entry")
        {
            cam.transform.position = new Vector3(22.01f, 0.3f, -10);
            player.transform.position = new Vector3(14.81f, -3.65f, 0);
        }

        if (collision.gameObject.tag == "Entry2")
        {
            cam.transform.position = new Vector3(22.01f, 0.3f, -10);
            player.transform.position = new Vector3(22.07f, 2.53f, 0);
        }

        if (collision.gameObject.tag == "City")
        {
            cam.transform.position = new Vector3(25.61f, 18.51f, -10);
            player.transform.position = new Vector3(25.3f, 14.85f, 0);
        }

        if (collision.gameObject.tag == "Inn")
        {
            cam.transform.position = new Vector3(-1.05f, 36.21f, -10);
            player.transform.position = new Vector3(-1.18f, 32.62f, 0);
        }
    }
}
