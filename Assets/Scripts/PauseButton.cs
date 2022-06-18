using UnityEngine;

public class PauseButton : MonoBehaviour
{
    [SerializeField] private GameObject pauseScreen;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            PauseGame();
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        pauseScreen.SetActive(true);
    }
}
