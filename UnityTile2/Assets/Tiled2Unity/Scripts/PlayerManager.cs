using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerManager : MonoBehaviour
{

    Rigidbody2D rigibody;
    Animator anim;
    float speed = 4f;
    // Use this for initialization
    void Start()
    {
        rigibody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        if (movement != Vector2.zero)
        {
            rigibody.MovePosition(rigibody.position + movement * Time.deltaTime * speed);
        }
    }
}