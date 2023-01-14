using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float turnSpeed = 50.0f;
    public string horizontalAxis = "Horizontal";
    public string verticalAxis = "Vertical";
    public GameManager gameManager;

    private void Update()
    {
        float h = Input.GetAxis(horizontalAxis);
        float v = Input.GetAxis(verticalAxis);
        transform.Rotate(0, h * turnSpeed * Time.deltaTime, 0);
        transform.Translate(0, 0, v * moveSpeed * Time.deltaTime);
    }
}