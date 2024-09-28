using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    private float inputDirection;
    [SerializeField] private float jumpforce = 5f;


    void OnJump()
    {
        rb.velocity = new Vector2(0f, jumpforce); //makes the player jump (surprising innit?) //vectors = positions
        Debug.Log("jumping off the cliff"); //checking if everything works in the log
      
    }


}