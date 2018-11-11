using UnityEngine;

public class relativeFollow : MonoBehaviour
{
    public Transform playerCameraFollower;
    //public Transform portal;
    //public Transform otherPortal;
    // Update is called once per frame
    void LateUpdate()
    {
        transform.localPosition = playerCameraFollower.localPosition;
        transform.localRotation = playerCameraFollower.localRotation;
        //transform.position = playerCamera.position - portal.position;
    }
}