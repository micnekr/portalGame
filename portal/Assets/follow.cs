using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour {
    public Transform obj;
	void Update () {
        transform.position = obj.position;
        transform.rotation = obj.rotation;
	}
}
