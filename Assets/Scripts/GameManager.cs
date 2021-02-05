using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool hasGameEnded = false;
    [SerializeField] private float restartDelay = 3f;
    [SerializeField] private GameObject completeLevelUI = default;

    public void LevelCompleted() {
        completeLevelUI.SetActive(true);
    }
    public void GameOver() {

        if(!hasGameEnded) {
            hasGameEnded = true;
            Invoke("Restart", restartDelay);
        }
    }

    private void Restart() {
        hasGameEnded = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
