using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucket : MonoBehaviour
{
    public float movementSpeed = 10f;
    private Rigidbody2D rigid;
    private Renderer[] renderers;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        renderers = GetComponentsInChildren<Renderer>();
    }

    void Update()
    {
        HandlePosition();
        HandleBoundary();
    }

    void HandlePosition()
    {
        rigid.velocity = Vector3.left * movementSpeed;
    }

    void HandleBoundary()
    {
        Vector3 transformPos = transform.position;
        Vector3 viewportPos = Camera.main.WorldToScreenPoint(transformPos);
        if (IsVisible() == false && viewportPos.x < 0)
        {
            Destroy(gameObject);
        }
    }

    bool IsVisible()
    {
        foreach (var renderer in renderers)
        {
            if (renderer.isVisible)
            {
                return true;
            }
        }
        return false;
    }
}
