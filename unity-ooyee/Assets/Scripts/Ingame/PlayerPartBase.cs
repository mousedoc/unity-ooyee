using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerPartBase : MonoBehaviour
{
    public SpriteRenderer SpriteRenderer { get; private set; }

    protected virtual void Awake()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    public virtual void ChangeSprite(Sprite sprite)
    {
        SpriteRenderer.sprite = sprite;
    }
}