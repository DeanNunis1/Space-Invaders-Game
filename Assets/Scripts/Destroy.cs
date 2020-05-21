using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("hit detected");
        Score.ScoreValue += 1;
        if (other.name == "asteroid(clone)");
        {
            Destroy(other.gameObject);
        }
    }
}
