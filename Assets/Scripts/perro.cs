using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class perro : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed = 300.0f;
    private Animator _animatorController;
    private CharacterController _characterController;
    
  
    // Start is called before the first frame update
    void Start()
    {
      _characterController = GetComponent<CharacterController>();
        _animatorController = GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Rotate(0, horizontal * turnSpeed * Time.deltaTime, 0);
        Vector3 move = transform.forward * vertical/2;
       _characterController.Move(move);
       _animatorController.SetBool("speed", move.z != 0);
    }
    private void OnCollision(Collision collision)
    {
    }

}
