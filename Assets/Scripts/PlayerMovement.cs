using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public float runSpeed = 25f;
    float horizontalMove = 0.0f;
    public float speed = 5.0f;
    public Transform Player;
    public GameObject LaserBolt;
    public AudioSource shot;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        void shootBullet()
        {
            GameObject bolt = Instantiate(LaserBolt) as GameObject;
            bolt.transform.position = Player.transform.position;
        }
        if (Input.GetKeyDown("space"))
        {
            shootBullet();
            playShot();
        }



    }
    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, false);
    }
    public void playShot()
    {
        shot.Play();
    }
}

