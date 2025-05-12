using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Hearts : MonoBehaviour
{
    [SerializeField] private RawImage[] hearts;
    private int heartCount = 5;

    void Update()
    {
        switch (heartCount)
        {
            case 0:
                hearts[0].GetComponent<RawImage>().enabled = false;
                break;

            case 1:
                hearts[1].GetComponent<RawImage>().enabled = false;
                break;
            case 2:
                hearts[2].GetComponent<RawImage>().enabled = false;
                break;
            case 3:
                hearts[3].GetComponent<RawImage>().enabled = false;
                break;
            case 4:
                hearts[4].GetComponent<RawImage>().enabled = false;
                break;

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            heartCount--;
        }

       if(heartCount == 0)
        {
            GameOver();
        }
            
    }
    private void GameOver()
    {
        SceneManager.LoadScene(3);
    }
}



