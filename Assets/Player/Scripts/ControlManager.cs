using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlManager : MonoBehaviour
{

    Animator animator;
    public Transform cameraTransform;
    public CharacterController characterController;
    public ControlState controlState;

    public float mouseSensitivity = 150f;
    int isLookingControllerHash;
    int velocityXHash;
    int velocityYHash;

    float gravity = 0f;
    float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        velocityYHash = Animator.StringToHash("velocityY");
        velocityXHash = Animator.StringToHash("velocityX");

        controlState = new NormalControlState(animator, velocityYHash, velocityXHash, this);
    }

    // Update is called once per frame
    void Update()
    {
        handleRotation();
        handleGravity();
        controlState.handleMovement();
    }


    private void handleGravity()
    {
        gravity -= 9.81f * Time.deltaTime;
        characterController.Move(new Vector3(0f, gravity, 0f));
        if (characterController.isGrounded) gravity = 0;
    }

    void handleRotation()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        cameraTransform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        transform.Rotate(Vector3.up * mouseX);
    }

}
