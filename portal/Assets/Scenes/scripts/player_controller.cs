using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour {
    private CharacterController cC;
    public float InputDelay = 0.1f;
    public float walkSpeed = 12;
    private bool isJumping;
    public AnimationCurve jumpCurve;
    public float jumpMultiplier;
    public KeyCode jumpKey;
    void Start()
    {
        cC = GetComponent<CharacterController>();

    }
    private void Update()
    {
        move();
    }
    void move()
    {
        Vector3 forwardMovement = walkSpeed * Input.GetAxis("Vertical") * transform.forward;
        Vector3 sideMovement = walkSpeed * Input.GetAxis("Horizontal") * transform.right;
        cC.SimpleMove(forwardMovement + sideMovement);
        jumpInput();
    }
    void jumpInput ()
    {
        if (Input.GetKeyDown(jumpKey) && !isJumping)
        {
            isJumping = true;
            StartCoroutine(jumpEvent()); 
        }
    }
    private IEnumerator jumpEvent()
    {
        float maxSlope = cC.slopeLimit;
        cC.slopeLimit = 90;
        float timeInAir = 0;
        do
        {
            float jumpForce = jumpCurve.Evaluate(timeInAir);
            cC.Move(Vector3.up * jumpForce * jumpMultiplier * Time.deltaTime);
            timeInAir += Time.deltaTime;
            yield return null;
        } while (!cC.isGrounded && cC.collisionFlags != CollisionFlags.Above);
        isJumping = false;
        cC.slopeLimit = maxSlope;
    }
}
