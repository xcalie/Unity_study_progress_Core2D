using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C0005_execrcise : MonoBehaviour
{
    private Animation animation;

    // Start is called before the first frame update
    void Start()
    {
        animation = this.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animation.Stop();
            animation.Play("Run");
        }
        if (Input.GetKey(KeyCode.Space))
        {
            this.transform.Translate(Vector3.forward * Time.deltaTime * 5);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            animation.Stop();
            animation.Play("Idle");
        }
    }
}
