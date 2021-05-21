﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseLook : MonoBehaviour
{

    public float mouseSensitivity = 100f;

    public Transform playerBody;

    float xRotation = 0f;

    Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);

        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

       if(Physics.Raycast(ray, out hit) && hit.collider.GetComponent<Interactable>() != null)
        {
            Interactable interactible = hit.collider.GetComponent<Interactable>();
            Debug.Log(interactible.gameObject.name);

            if (Vector3.Distance(playerBody.position, interactible.transform.position) <= interactible.radius)
            {
                Debug.Log("touch the sphere... owo");
                //display UI to pick up and then check for key down to add to inventory
            }

        }
        //else
        //{
            //Debug.Log("nothing here");
        //}
    }
}
