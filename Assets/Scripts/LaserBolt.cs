using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBolt : MonoBehaviour
{
    public float speed = 500.0f;
    public Rigidbody2D rigid;
    private Vector2 screenBounds;
    public GameObject explosion;

    // Use this for initialization
    void Start()
    {
        rigid = this.GetComponent<Rigidbody2D>();
        rigid.velocity = new Vector2(0, speed);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    void Update()
    {
      
        if (transform.position.y > screenBounds.y)
        {
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "asteroid(clone)")
        {
            Score.ScoreValue += 1;
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
    
}