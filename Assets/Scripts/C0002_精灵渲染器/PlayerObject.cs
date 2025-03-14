using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObject : MonoBehaviour
{
    public float moveSpeed = 5f;
    private float h;

    private SpriteRenderer sr;

    private Rigidbody2D rb;

    void Start()
    {
        sr = this.GetComponent<SpriteRenderer>();
        rb = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        h = Input.GetAxis("Horizontal");
        //transform.Translate(Vector3.right * h * moveSpeed * Time.deltaTime);

        rb.velocity = new Vector2(h * moveSpeed, rb.velocity.y);

        if (h > 0)
        {
            sr.flipX = false;   
        }
        else if (h < 0)
        {
            sr.flipX = true;
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            // 1.创建子弹
            GameObject bullet = Instantiate(Resources.Load("Prefabs/BulletObj") as GameObject, this.transform.position + new Vector3(sr.flipX ? -0.3f : 0.3f, 0.5f, 0), Quaternion.identity);
            bullet.GetComponent<BulletObj>().ChangeMoveDir(sr.flipX ? Vector3.left : Vector3.right);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * 300);
        }
    }


}
