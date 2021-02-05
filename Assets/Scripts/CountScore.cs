using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountScore : MonoBehaviour
{
    [SerializeField] private Transform player = default;
    [SerializeField] private Text scoreText = default;
    [SerializeField] private Text levelNumber = default;
    // Start is called before the first frame update
    void Start()
    {
        if(SceneManager.GetActiveScene().buildIndex == 3) {
            levelNumber.text = "Final Level";
        } else {
            levelNumber.text = "Level " + SceneManager.GetActiveScene().buildIndex;
        }
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
    }
}
