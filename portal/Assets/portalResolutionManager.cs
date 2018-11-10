using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalResolutionManager : MonoBehaviour
{
    public Camera cameraB;

    public Material cameraMatB;

    public Camera cameraA;

    public Material cameraMatA;

    // Use this for initialization
    void Start()
    {
        if (cameraB.targetTexture != null)
        {
            cameraB.targetTexture.Release();
        }
        cameraB.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMatB.mainTexture = cameraB.targetTexture;

        if (cameraA.targetTexture != null)
        {
            cameraA.targetTexture.Release();
        }
        cameraA.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMatA.mainTexture = cameraA.targetTexture;
    }
}
