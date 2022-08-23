using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float speed = 5.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float verticalInput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     horizontalInput = Input.GetAxis("Horizontal");
     verticalInput = Input.GetAxis("Vertical");

      //Moves the vehicle forward on vertical input
      transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

      //Moves the car forward on  horizontal input
      //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
      transform.Rotate(Vector3.up,Time.deltaTime * turnSpeed * horizontalInput  );
    }
}
