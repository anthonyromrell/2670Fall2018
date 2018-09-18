using UnityEngine;

[CreateAssetMenu(fileName = "FloatBool")]
public class FloatBool : FloatAxis 
{
	public override float Value
	{
		get { return Input.GetButton(InputType) ? value : 0; }
	}	
}