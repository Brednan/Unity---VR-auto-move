using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Dictionary<KeyCode, Vector3> directions { get; private set; }

    public Rigidbody rb;

    public float speed = 1;

    public Transform Camera;

    private CharacterController CharCont;

    public Transform Player;

    public bool moveForward;

    public float toggleAngle = 30.0f;

    private Vector3 velocity = Vector3.zero;

    private void Start()

            {
        
        
        CharCont = GetComponent<CharacterController>();

        directions = new Dictionary<KeyCode, Vector3>() {
        { KeyCode.W, Vector3.forward},
        { KeyCode.S, Vector3.back},
        {KeyCode.A, Vector3.left},
        {KeyCode.D, Vector3.right} };
    }

    void Update()
    {
        if ((Camera.eulerAngles.x <= toggleAngle && Camera.eulerAngles.x < 90.0f))
        {
            moveForward = true;

        }
        else
        {
            moveForward = false;
        }
        if (moveForward)
        {


            Vector3 forward = (Camera.TransformDirection(Vector3.forward * speed));

            //CharCont.transform.position += transform.TransformDirection(forward) * Time.deltaTime * speed * 2.5f;

            CharCont.SimpleMove(forward * speed);
        }

    }
    }





