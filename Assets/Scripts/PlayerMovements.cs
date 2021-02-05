using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    [SerializeField] private Rigidbody rb = default;
    [SerializeField] float forwardForce = default;
    [SerializeField] float sidewaysForce = default;
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

    private void FixedUpdate() {
        // Debug.Log("Player "+rb.velocity);
        // if(Mathf.Abs(rb.velocity.z) < 25) {
        //     rb.AddForce(0, 0, forwardForce);
        // } else {
        //     rb.AddForce(0, 0, 25-rb.velocity.z, ForceMode.VelocityChange);
        // }

        rb.AddForce(0, 0, forwardForce, ForceMode.Force);

        if(Input.GetKey("h") || Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow)) {
            rb.AddForce(-sidewaysForce, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("l") || Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow)) {
            rb.AddForce(sidewaysForce, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f && !gManager.hasGameEnded) {
            gManager.GameOver();
        }
    }

}
