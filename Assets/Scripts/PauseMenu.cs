using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    [SerializeField] private GameObject pauseMenuUI = default;
    [SerializeField] private GameObject instructionPanel = default;

    void Pause() {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Resume() {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Help() {
        pauseMenuUI.SetActive(false);
        instructionPanel.SetActive(true);
    }

    public void Quit() {
        Application.Quit();
    }

    public void Back() {
        instructionPanel.SetActive(false);
        pauseMenuUI.SetActive(true);
    }
    
    private void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            if(GameIsPaused) {
                Resume();
            } else {
                Pause();
            }
        }
    }
}
