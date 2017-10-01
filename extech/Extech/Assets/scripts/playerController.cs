using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

/*
    TODO:
        - set the player to only be able to move when
        the mouse position is a certain distance away from the player
*/
    mouseLookat _mouseLookat;
    Transform target;

    public float moveSpeed = 5f;
    public float rotateSpeed = 2f;

    private void Awake()
    {
        //mouseLookat script
        _mouseLookat = gameObject.GetComponent<mouseLookat>();
    }

    private void Start()
    {
        //LOOKAT MOVEMENT TARGET - FROM mouseLookat script
        target = _mouseLookat.target;
    }

    void Update ()
    {
        //PLAYER LOOK AT MOVEMENT//

        //LOOKAT TARGET = THE LOOKAT OBJECTS X AND Z BUT USING THE PLAYERS Y POSITION
        //SO THAT THE PLAYER ONLY ROTATES ON THE Y AXIS
        Vector3 targetPostition = new Vector3(target.position.x, this.transform.position.y, target.position.z);
        //MOVING THE PLAYER TO LOOKAT THE TARGET POSITION
        transform.LookAt(targetPostition);

        //PLAYER KEY INPUT MOVEMENT//
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * moveSpeed *Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
    }
}
