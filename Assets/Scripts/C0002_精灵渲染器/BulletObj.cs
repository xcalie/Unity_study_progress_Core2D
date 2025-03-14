using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class BulletObj : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Vector3 nowDir;

    void Start()
    {
        Destroy(this.gameObject, 2f);
    }

    public void ChangeMoveDir(Vector3 dir)
    {
        nowDir = dir;
    }

    void Update()
    {
        transform.Translate(nowDir * moveSpeed * Time.deltaTime);
    }
}
