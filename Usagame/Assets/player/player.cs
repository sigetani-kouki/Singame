using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;

    public float jumpForce = 200f;

    public int MaxJumpCount = 2;
    private int jumpCount = 0;

    private void Start()
    {
        // Rigidbody2Dコンポーネントの取得
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // スペースを押したらジャンプさせる
        // MaxJumpCountの数だけジャンプできる
        if (Input.GetKeyDown(KeyCode.Space) && this.jumpCount < MaxJumpCount)
        {
            this.rigidbody2D.AddForce(transform.up * jumpForce);
            jumpCount++;
        }

    }

    // 床に着地したら、jumpCountを0にする
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            jumpCount = 0;
        }
    }
}