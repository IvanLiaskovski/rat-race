using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6f;
    public float jumpHeight = 2f;
    public float gravity = -20f;

    private CharacterController controller;
    private Vector3 velocity;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Проверяем землю ДО движения
        if (controller.isGrounded)
        {
           // Debug.Log("НА ЗЕМЛЕ");

            if (velocity.y < 0)
            {
                velocity.y = -2f;
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("ПРЫЖОК!");
                velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            }
        }

        // Движение
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        // Гравитация
        velocity.y += gravity * Time.deltaTime;

        // Вертикальное движение
        controller.Move(velocity * Time.deltaTime);
    }
}

