using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadController : PlayerPartBase 
{
    public void Rotate(Quaternion rotation)
    {
        transform.rotation = rotation;
    }
}

