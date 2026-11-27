using UnityEngine;
using UnityEngine.InputSystem;

public class BirdMovement : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 3.0f;

    void Update()
    {
        Vector3 movement = Vector3.zero;

        if (Keyboard.current != null && Keyboard.current.wKey.isPressed)
        {
            movement += Vector3.forward; 
        }

        if (Keyboard.current.aKey.isPressed)
        {
            movement += Vector3.left;
        }

        if (Keyboard.current.sKey.isPressed)
        {
            movement += Vector3.back;
        }

        if (Keyboard.current.dKey.isPressed)
        {
            movement += Vector3.right;
        }

        movement = movement.normalized;

        transform.position += movement * moveSpeed * Time.deltaTime;


    }
}
