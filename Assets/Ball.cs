using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{
    Rigidbody _CaschedRB;
    private Vector3 _Move;

    public void Start()
    {
        _CaschedRB = GetComponent<Rigidbody>();
    }

    public void Move(Vector3 move)
    {
        _Move += move;
    }

    public void FixedUpdate()
    {
        _CaschedRB.AddForce(_Move);

        _Move = Vector3.zero;
    }
}
