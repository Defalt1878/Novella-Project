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
		Time.timeScale = 1;
		SceneManager.LoadScene("MainMenu");
	}

	public void Exit()
	{
		Time.timeScale = 1;
		Application.Quit();
	}
}