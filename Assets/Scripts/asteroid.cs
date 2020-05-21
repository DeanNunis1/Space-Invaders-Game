using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroid : MonoBehaviour
{
    public float speed = 10.0f;
    public Rigidbody2D rigid;
    public Vector2 screenBounds;


    // Use this for initialization
    void Start()
    {
        rigid = this.GetComponent<Rigidbody2D>();
        rigid.velocity = new Vector2(0, -speed);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < (screenBounds.y +20)* -1)
        {
            Destroy(this.gameObject);
        }
    }
}
