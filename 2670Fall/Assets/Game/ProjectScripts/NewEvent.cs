using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//Made By Anthony Romrell
public class NewEvent : MonoBehaviour
{
	//public UnityEvent Event;
	public int EmitRate = 100;
	public ParticleSystem Particles;
	
	private void OnMouseDown()
	{
		Particles.Emit(EmitRate);
	}
}