using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(CharacterController))]
[AddComponentMenu("Control Script/keyMov")]
public class keyMov : MonoBehaviour
{
    public float initialSpeed = 0.0f;
    public float impulse = 0.5f;
    public float Maxspeed = 1.0f;
    public float gravity = 9.8f;

    private CharacterController characterController;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {
            initialSpeed += impulse;
            if (initialSpeed > Maxspeed)
            {
                initialSpeed = Maxspeed;
            }
        }
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            initialSpeed -= impulse;
            if(initialSpeed < 0)
            {
                initialSpeed = 0;
            }
            
        }
        
        float deltaX = Input.GetAxis("Horizontal") * impulse * initialSpeed;
        float deltaZ = Input.GetAxis("Vertical") * impulse * initialSpeed;
        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, impulse);

        movement.y = gravity;
        movement = transform.TransformDirection(movement);
        characterController.Move(movement);
    }
}
