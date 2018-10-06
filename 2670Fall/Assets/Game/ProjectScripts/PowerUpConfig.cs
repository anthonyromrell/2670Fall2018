using UnityEngine;

[CreateAssetMenu(fileName = "PowerUpConfig")]
public class PowerUpConfig : ScriptableObject
{
	public GameObject Prefab;
	public Sprite SpriteImage;
	public Color SpriteColor;

	public void OnConfigure()
	{
		var newPrefab = Instantiate(Prefab);
		newPrefab.name = this.name;
		
		var newSprite = newPrefab.GetComponent<SpriteRenderer>();
		newSprite.sprite = SpriteImage;
		newSprite.color = SpriteColor;
	}
}
