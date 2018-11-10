using UnityEngine;

public class relativeFollow : MonoBehaviour
{
    public Transform playerCamera;
    //public Transform portal;
    //public Transform otherPortal;
    // Update is called once per frame
    void LateUpdate()
    {
        transform.localPosition = playerCamera.localPosition;
        transform.localRotation = playerCamera.localRotation;
        //transform.position = playerCamera.position - portal.position;
    }
}