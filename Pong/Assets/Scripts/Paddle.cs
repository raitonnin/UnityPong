using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
public Rigidbody2D rb { get; private set; }

public float speed =10.0f;

private void Awake()
{
 rb = GetComponent<Rigidbody2D>();
}

}
