using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D.Animation;

public class C0007_1 : MonoBehaviour
{
    private SpriteResolver spriteResolver;

    private Dictionary<string, SpriteResolver> equipDict = new Dictionary<string, SpriteResolver>();

    private void Start()
    {
        spriteResolver = GetComponent<SpriteResolver>();
        //spriteResolver.SetCategoryAndLabel(); //设置换装的分类和标签


        //获取所有的换装
        SpriteResolver[] spriteResolvers = this.GetComponentInChildren<SpriteResolver>().GetComponentsInChildren<SpriteResolver>();

        for (int i = 0; i < spriteResolvers.Length; i++)
        {
            equipDict.Add(spriteResolvers[i].GetCategory(), spriteResolvers[i]);
        }


    }
}
