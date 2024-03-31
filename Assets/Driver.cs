using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 300f;
    // serialize field - making available to modify the value of the variable in UNITY inspector
    [SerializeField] float moveSpeed = 15f;
    [SerializeField] float slowSpeed = 10f;
    [SerializeField] float boostSpeed = 25f;
    void Start()
    {
        
        
    }

    void Update()
    {
        // this is to change the transform component of the 2D capsule
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
    void OnCollisionEnter2D(Collision2D other) {
        moveSpeed = slowSpeed;    
    }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Boost")
        {
            Debug.Log("you are boosting!");
            moveSpeed = boostSpeed;
        }
    }
}
