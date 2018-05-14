using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BodyController : PlayerPartBase
{
    private float term = 0.2f;
    private float offset = 0.0f;

    protected void Update()
    {
        offset += Time.deltaTime;
        if (offset >= term)
        {
            offset = 0.0f;
            ShakeBody();
        }
	}

    private void ShakeBody()
    {
        transform.rotation = Quaternion.Euler(new Vector3(0.0f, transform.rotation.eulerAngles.y + 180.0f, 0.0f));
    }
}