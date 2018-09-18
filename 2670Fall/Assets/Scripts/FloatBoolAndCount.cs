using UnityEngine;

[CreateAssetMenu(fileName = "FloatBoolAndCount")]
public class FloatBoolAndCount : FloatBool
{
	public IntData Count;
	private int holdCount;

	private void OnEnable()
	{
		Count.Value = 0;
	}

	public override float Value
	{
		get
		{
			if (Count.Value > 0)
			{
				if (Input.GetButtonDown(InputType))
				{
					Count.Value--;
					return value;
				}
				return 0;
			}
			return 0;
		}
	}
}


