using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerLook : MonoBehaviour {
    [SerializeField] private float mouseSensivity;
    float xClamp = 0;
    [SerializeField] private Transform player;
    private void Awake()
    {
        lockCursor();
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        cameraRotation();
	}
    void lockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void cameraRotation()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensivity * Time.deltaTime;
        xClamp += mouseY;
        if(xClamp > 90)
        {
            xClamp = 90;
            mouseY = 0;
            clumpXRotation(270);
        }
        else if (xClamp < -90)
        {
            xClamp = -90;
            mouseY = 0;
            clumpXRotation(90);
        }
        transform.Rotate(Vector3.left*mouseY);
        player.Rotate(Vector3.up * mouseX);
    }
    void clumpXRotation(float value)
    {
        Vector3 rot = transform.rotation.eulerAngles;
        rot.x = value;
        transform.eulerAngles = rot;
    }
}
