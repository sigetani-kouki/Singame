using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Rigidbody2D rigidbody2D;


    private GameObject bullet;


    public float speed = 3f;
    
    private float playerSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();

        //bullet = Resources.Load("shot") as GameObject;
    }
    
    // Update is called once per frame
    void Update()
    {

        // 左キーを押したら左方向へ進む
        if (Input.GetKey(KeyCode.A)) playerSpeed = -speed;
        // 右キーを押したら右方向へ進む
        else if (Input.GetKey(KeyCode.D)) playerSpeed = speed;
        // 何もおさなかったら止まる
        else playerSpeed = 0;


        // 弾のイ//ショット
       // if (Input.GetMouseButtonDown(0))
        //{
            //プレハブ召喚
        //    GameObject bullet = Resources.Load("shot") as GameObject;
        //    bullet.transform.position = this.transform.position;
        //}
        //Instantiate(
          //  bullet, // 生成するオブジェクトのプレハブ
            //this.transform.position, // 初期位置
            //Quaternion.identity); // 初期回転情報


       
        


        rigidbody2D.velocity = new Vector2(playerSpeed, rigidbody2D.velocity.y);

       
    }
}
