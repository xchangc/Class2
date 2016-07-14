using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour
{
    [Header("Player object values")]
    public Ball ball;
    [Tooltip("Speed in units per second")]
    [Range(1,144f)]
    public float speed;

    public void Update()
    {
        float h = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float v = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        ball.Move(new Vector3(h, 0f, v));

    }
}
