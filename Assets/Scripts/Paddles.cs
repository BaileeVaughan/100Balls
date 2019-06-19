using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddles : MonoBehaviour
{
    public Animator paddle;

    private void Start()
    {
        paddle = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            paddle.SetBool("isOpen", true);
        }
        else
        {
            paddle.SetBool("isOpen", false);
        }
    }
}
