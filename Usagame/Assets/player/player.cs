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
        // Rigidbody2D�R���|�[�l���g�̎擾
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // �X�y�[�X����������W�����v������
        // MaxJumpCount�̐������W�����v�ł���
        if (Input.GetKeyDown(KeyCode.Space) && this.jumpCount < MaxJumpCount)
        {
            this.rigidbody2D.AddForce(transform.up * jumpForce);
            jumpCount++;
        }

    }

    // ���ɒ��n������AjumpCount��0�ɂ���
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            jumpCount = 0;
        }
    }
}