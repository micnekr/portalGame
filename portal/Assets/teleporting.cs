using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleporting : MonoBehaviour {

    public Transform playerFollower;
    public Transform player;
    public Transform playerCam;
    public Transform otherCam;
    void LateUpdate () {
		if(playerFollower.localPosition.y <= 0 && Mathf.Abs(playerFollower.localPosition.z) < 10 && Mathf.Abs(playerFollower.localPosition.x) < 50)
        {
            Debug.Log(player.position);
            player.position = otherCam.position - playerCam.localPosition;
            Debug.Log(player.localPosition);
        }
	}
}
