using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
	public void StartGame()
	{
		SceneManager.LoadSceneAsync("MainScene");
	}

	public void ExitGame()
	{
		Application.Quit();
	}
}
