using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Made By Anthony Romrell
public class DoubleJump : MonoBehaviour
{
	private Vector3 temp;
	private CharacterController _controller;

	private void Start()
	{
		_controller = GetComponent<CharacterController>();
	}

	private int CanJump;

	private void Update()
	{
		if (_controller.isGrounded)
		{
			CanJump = 2;
		}

		if (Input.GetButtonDown("Jump") && CanJump > 0)
		{
			temp.y = 4;
			CanJump--;
		}
		
		temp.y -= 9 * Time.deltaTime;
		_controller.Move(temp * Time.deltaTime);

	}
}
