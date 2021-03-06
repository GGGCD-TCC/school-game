using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentation_blockfall : MonoBehaviour
{
    private Vector2 targetPos;
    public float speed;

    void Start()
    {
        targetPos = new Vector2(0, -8);
    }

    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButton(0))
        {
            targetPos = new Vector2(mousePos.x, -8);
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPos, Time.deltaTime * speed);

    }

    void OnCollisionEnter2D()
    {
        speed = 14f;
        transform.position = Vector2.MoveTowards(transform.position, targetPos, Time.deltaTime * speed);
    }

    void OnCollisionExit2D()
    {
        speed = 14;
        transform.position = Vector2.MoveTowards(transform.position, targetPos, Time.deltaTime * speed);
    }
}
