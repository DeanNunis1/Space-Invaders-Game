using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
        {
        Debug.Log("hit detected");
        if (other.name == "asteroid(clone)");
            {
            SceneManager.LoadScene("MainMenu");
            }
        }
    }
