using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wolf : MonoBehaviour
{
    private Vector2 pos;
    public int num = 1;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;

        // （ポイント）マイナスをかけることで逆方向に移動する。
        transform.Translate(transform.right * Time.deltaTime * 3 * num);

        if (pos.x > -2)
        {
            num = -1;
        }
        if (pos.x < -11)
        {
            num = 1;
        }
    }
}
