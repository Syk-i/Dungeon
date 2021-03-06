﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour {
    public enum PlayerState
    {
        walk,
        attack,
        interact
    }
    public PlayerState currentState;
    public float speed;
    public Rigidbody2D myRigidbody;
    private Vector3 change;
    public Animator animator;

    //references

	// Use this for initialization
	void Start () {
        currentState = PlayerState.walk;

        animator = GetComponent<Animator>();
        myRigidbody = GetComponent<Rigidbody2D>();
        animator.SetFloat("moveX", 0);
        animator.SetFloat("moveY", -1);
	}
	
	// Update is called once per frame
	void Update () {
        change = Vector3.zero;

        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
        if (Input.GetButtonDown("attack")&& currentState != PlayerState.attack)
        {
            StartCoroutine(AttackCo());

        }
        else if(currentState == PlayerState.walk)
        {
            UpdateAnimationAndMove();

        }

        
       

        
	}
    private IEnumerator AttackCo()
    {
        animator.SetBool("attacking", true);
        currentState = PlayerState.attack;
        yield return null;
        animator.SetBool("attacking", false);
        yield return new WaitForSeconds(.33f);
        currentState = PlayerState.walk;

    }
    void UpdateAnimationAndMove()
    {
        if (change != Vector3.zero)
        {
            MoveCharacter();
            animator.SetFloat("moveX", change.x);
            animator.SetFloat("moveY", change.y);
            animator.SetBool("moving", true);

        }
        else
        {
            animator.SetBool("moving", false);
        }

    }
    void MoveCharacter()
    {
         change.Normalize();
        myRigidbody.MovePosition(transform.position + change * speed * Time.deltaTime);
    }
     
}
