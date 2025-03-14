using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class Lesson14_exercises : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 练习题一

        GameObject obj = new GameObject();
        SpriteRenderer sr = obj.AddComponent<SpriteRenderer>();
        SpriteAtlas atlas = Resources.Load<SpriteAtlas>("PigAtlas");
        sr.sprite = atlas.GetSprite("dead1");

        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
