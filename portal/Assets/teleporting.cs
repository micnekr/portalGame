using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleporting : MonoBehaviour {

    public Transform playerFollower;
    public Transform player;
    public Transform playerCam;
    public Transform otherCam;
    void LateUpdate () {
		if(playerFollower.localPosition.y <= 0 && Vector3.Distance(playerFollower.position, transform.position) < 4)
        {
            player.position = otherCam.position - playerCam.localPosition;
        }
	}
}
