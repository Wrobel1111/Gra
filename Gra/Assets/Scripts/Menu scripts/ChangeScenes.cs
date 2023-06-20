using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
	[SerializeField]
	string SceneName;
	public void ChangeScenesFunction()
	{
		SceneManager.LoadScene(SceneName);
	}
}
