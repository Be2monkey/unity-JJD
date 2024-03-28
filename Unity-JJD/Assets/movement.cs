using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum speeds { Slow = 0, Normal = 1, Fast = 2, Faster = 3, Fastest = 4};
public class movement : MonoBehaviour
{
    public speeds CurrentSpeed;
    float[] speedValues = { 8.6f, 10.4f, 12.96f, 15.6f, 19.27f };

    public Transform GroundCheckTransform;
    public float GroundCheckRadius;
    public LayerMask GroundMask;

    void Update()
    {
        transform.position += Vector3.right * speedValues[(int)CurrentSpeed] * Time.deltaTime;

        if (Input.GetMouseButton(0))
        {
            //jump
        }
    }

    bool OnGround()
    {
        return Physics2D.OverlapCircle(GroundCheckTransform.position, GroundCheckRadius, GroundMask);
    }
}
