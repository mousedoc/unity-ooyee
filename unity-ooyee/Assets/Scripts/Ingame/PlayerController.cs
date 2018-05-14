using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{
    protected HeadController Head { get; private set; }
    protected BodyController Body { get; private set; }
    public Rigidbody2D Rigid { get; private set; }

    private Vector2 moveDirection = Vector2.zero;
    public float speed = 10.0f;

	private void Awake()
	{
        Head = GetComponentInChildren<HeadController>();
        Body = GetComponentInChildren<BodyController>();
        Rigid = GetComponent<Rigidbody2D>();
	}

    private void Update()
	{
        moveDirection = Vector2.zero;

        if (Input.GetKey(KeyCode.UpArrow))
            moveDirection += Vector2.up;
        if (Input.GetKey(KeyCode.DownArrow))
            moveDirection += Vector2.down;
        if (Input.GetKey(KeyCode.LeftArrow))
            moveDirection += Vector2.left;
        if (Input.GetKey(KeyCode.RightArrow))
            moveDirection += Vector2.right;

        moveDirection.Normalize();

        if (moveDirection.x > 0)
            Head.Rotate(Quaternion.Euler(.0f, 180.0f, .0f));
        else if (moveDirection.x < 0)
            Head.Rotate(Quaternion.Euler(Vector3.zero));
	}

	private void FixedUpdate()
	{
        Move();
	}

	private void Move()
	{
        Rigid.velocity += moveDirection * speed *Time.deltaTime;
	}
}
