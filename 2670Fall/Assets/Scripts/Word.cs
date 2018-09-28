using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Word")]
public class Word : ScriptableObject
{
	public List<Letter> Letters;
	
	public UnityEvent Solved;
	
	public string TheWord;
	

	public void Solving()
	{
		foreach (var letter in TheWord)
		{
			//mark as solved;
		}
	}
}