using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    [SerializeField] float moveSpeed = 100f;
    [SerializeField] float steerSpeed = 200f;

    void Update()
    {
        float move = 0;
        float steer = 0;

        if (Keyboard.current.wKey.isPressed)
        {
            move = .03f;
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            move = -.03f;
        }


        if (Keyboard.current.aKey.isPressed)
        {
            steer = .5f;
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            steer = -.5f;
        }

        float moveAmount = move * moveSpeed * Time.deltaTime;
        float steerAmount = steer * steerSpeed * Time.deltaTime;

        transform.Translate(0, moveAmount, 0);
        transform.Rotate(0, 0, steerAmount);
    }
}
