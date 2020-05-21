using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawn : MonoBehaviour
{
    public GameObject asteroid;
    public float spawnTime = 6.0f;
    private Vector2 screenBounds;

    // Use this for initialization
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(asteroidspawning());
    }
    private void spawnasteroid()
    {
        GameObject spawn = Instantiate(asteroid) as GameObject;
        spawn.transform.position = new Vector2(Random.Range(-265, 325), 450);
    }
    IEnumerator asteroidspawning()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);
            spawnasteroid();
        }
    }
}