using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] PlayerMovements movements = default;
    private GameManager gManager;
    // Start is called before the first frame update
    void Start()
    {
        gManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        if (other.collider.tag == "Obstacle") {
            // GetComponent<Rigidbody>().AddForce(0, 1000, 0, ForceMode.Acceleration);
            GetComponent<Rigidbody>().AddExplosionForce(700,this.transform.position, 100);
            this.movements.enabled = false;
            gManager.GameOver();
        }
    }


}
