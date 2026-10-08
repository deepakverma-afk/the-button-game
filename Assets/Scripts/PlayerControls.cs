using UnityEngine;

public class PlayerControls : MonoBehaviour
[SerializeField] CharacterController controller;
[SerializeField] Vector3 playerVelocity;
[serializeField] bool groundedPlayer;
[serializeField] float playerSpeed;
[SerializeField] float gravityValue;
[serializeField] GameObject activeChar;
[serializeField] float moveHorizontal;
[serializeField] float moveVertical;
[serializeField] float speed = 4;
[serializeField] float rotateSpeed = 4;
[serializeField] float jumpHeight = 1.2f;
[serializeField] bool isJumping;


void start()
{
    playerSpeed = 4;
    gravityValue = -20;
 
}

void update()
{
    groundedPlayer = controller.isGrounded;
    if (groundedPlayer && playerVelocity.y < 0)
    {
        playerVelocity.y = 0f;
    }
    transform.Rotate(0, inputGetAxis("Horizontal") * rotateSpeed, 0);
    vector3 forward = transform. TransformDirection(Vector3.forward);
    float curSpeed = speed * inputGetAxis("Vertical");
    controller.SimpleMove(forward * curSpeed);
    if (input.GetButtonDown("Jump") && groundedPlayer)
    {
        isJumping = true;
        activeChar.GetComponent<Animator>().play("Jump");
        playerVelocity.y += 10;
    }
    playerVelocity.y += gravityValue * Time.deltaTime;
    controller.Move(playerVelocity * Time.deltaTime);

    if (input.GetKey(KeyCode.W) || input.GetKey(KeyCode.S) || input.GetKey(KeyCode.A) || input.GetKey(KeyCode.D))
   {
    this gameObject.GetComponent<CharacterController>().minMoveDistance = 0.001f;
    if (isJumping == false)
    {
        activeChar.GetComponent<Animator>().play("Run");
    }


   }

   else
    {
     this.gameObject.GetComponent<CharacterController>().minMoveDistance = 0.901f;
     if (isJumping == false)
     {
          activeChar.GetComponent<Animator>().play("Idle");
     }
    }
}