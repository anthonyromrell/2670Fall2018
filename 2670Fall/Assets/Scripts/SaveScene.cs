using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

[CreateAssetMenu(fileName = "SaveScene")]
public class SaveScene : ScriptableObject
{

	public void SaveSceneFunc ()
	{
		AssetDatabase.SaveAssets();
		Debug.Log("Saved");
	}
}
