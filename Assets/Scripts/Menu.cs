using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject menuUI = default;
    [SerializeField] private GameObject instructionPanel = default;
    public void StartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Help() {
        menuUI.SetActive(false);
        instructionPanel.SetActive(true);
    }

    public void Quit() {
        Application.Quit();
    }

    public void Back() {
        instructionPanel.SetActive(false);
        menuUI.SetActive(true);
    }
}
