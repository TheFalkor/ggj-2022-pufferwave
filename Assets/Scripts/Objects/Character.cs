﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Character : MonoBehaviour
{
    private int playerNumber;
    private Player player;
    private Rigidbody2D rb;
    private Collider2D coll;

    public Rigidbody2D CharacterRigidBody { get => rb; }
    public Collider2D CharacterCollider { get => coll; }
    public Player CharacterPlayer { get => player; }


    public void MoveCharacter(Vector2 moveSpeed)
    {
        //Add animation controls here.
        rb.AddForce(moveSpeed, ForceMode2D.Force);
    }

    public void Jump(Vector2 jumpForce)
    {
        rb.AddForce(jumpForce,  ForceMode2D.Force);
        //Add animation and particle effects here.
    }

    public void UsePush()
    {
        //Complete after.
    }

    public void UseDuality()
    {
        //Complete after.
    }

    public void Die()
    {
        //Complete after.
    }

    public void ChangePlayerGrounding(bool isGrounded)
    {
        player.ChangePlayerGrounding(isGrounded);
    }

    #region Unity Methods
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //This collider may need to be replaced with the specific collider type.
        coll = GetComponent<Collider2D>();
        player = GetComponentInParent<Player>();
    }
    #endregion
}
