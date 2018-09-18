using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Made By Anthony Romrell
[RequireComponent(typeof(CharacterController))]

public class CharacterMovement : MonoBehaviour 
{
	
	private CharacterController controller;
	public MovePattern Pattern;

	private void Start()
	{
		controller = GetComponent<CharacterController>();
	}

	void Update() {
		Pattern.Invoke(controller, transform);
	}
}