using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    private GameManager gManager = default;

    private void Start() {
        gManager = FindObjectOfType<GameManager>();
    }
    private void OnTriggerEnter(Collider other) {
        gManager.LevelCompleted();
    }
}
