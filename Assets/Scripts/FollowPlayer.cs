using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform player = default;
    [SerializeField] private Vector3 offset = default;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {        
        
    }

    private void FixedUpdate() {
        transform.position = player.position + offset;
    }
}
