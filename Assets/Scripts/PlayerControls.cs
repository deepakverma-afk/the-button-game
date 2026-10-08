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

