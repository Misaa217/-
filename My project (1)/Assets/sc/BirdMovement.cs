using UnityEngine;
using UnityEngine.InputSystem;

public class BirdMovement : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 3.0f;

    void Update()
    {
        if (Keyboard.current != null && Keyboard.current.wKey.isPressed)
        {
            transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        }
    }
}
