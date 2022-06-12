using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
	[SerializeField] private GameObject pauseScreen;

	public void Continue()
	{
		Time.timeScale = 1;
		pauseScreen.SetActive(false);
	}

	public void ToMenu()
	{
		SceneManager.LoadScene("MainMenu");
	}

	public void Exit()
	{
		Application.Quit();
	}
}