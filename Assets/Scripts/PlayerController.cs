using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform player;
    public CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private float playerSpeed = 50f;
    private float jumpHeight = 1.0f;
    private float gravityValue = -9.81f;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVeloity;
    public Transform cam;


    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    // Update is called once per frame
    void Update()
    {
        float y = Input.GetAxis("Jump");
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        groundedPlayer = controller.isGrounded;

        if (groundedPlayer)
        {
            playerVelocity.y = 0f;
        }

        

        Vector3 move = new Vector3(x, 0, z).normalized;

        

        if (move.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(move.x, move.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(player.eulerAngles.y, targetAngle, ref turnSmoothVeloity,
                turnSmoothTime);
            player.rotation = Quaternion.Euler(0f, angle, 0f);
            Vector3 moveDirection = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            playerVelocity.y += y;
            playerVelocity.y += gravityValue * Time.deltaTime;
            moveDirection.y = playerVelocity.y;
            controller.Move(moveDirection.normalized * Time.deltaTime * playerSpeed);
        }
        




    }
}
