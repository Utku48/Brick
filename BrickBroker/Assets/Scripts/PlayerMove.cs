using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float speed;

    void Update()
    {
        float Yon = speed * Input.GetAxis("Horizontal");
        transform.Translate(Yon * Time.deltaTime, 0f, 0f);

    }
}
