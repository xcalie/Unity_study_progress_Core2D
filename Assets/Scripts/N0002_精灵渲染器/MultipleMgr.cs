using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleMgr
{
    private static MultipleMgr instance;
    public static MultipleMgr Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new MultipleMgr();
            }
            return instance;
        }
    }

    private Dictionary<string, Dictionary<string, Sprite>> dic = new Dictionary<string, Dictionary<string, Sprite>>();

    private MultipleMgr() { }


    /// <summary>
    /// 获取Multiple图集中的一小张图片
    /// </summary>
    /// <param name="multipleName"></param>
    /// <param name="spriteName"></param>
    /// <returns></returns>
    public Sprite GetSprite(string multipleName, string spriteName)
    {
        //如果字典中有这个图集
        if (dic.ContainsKey(multipleName))
        {
            //如果这个图集中有这个图片
            if (dic[multipleName].ContainsKey(spriteName))
            {
                return dic[multipleName][spriteName];
            }
        }
        else
        {
            Sprite[] sprites = Resources.LoadAll<Sprite>(multipleName);
            for (int i = 0; i < sprites.Length; i++)
            {
                if (!dic.ContainsKey(multipleName))
                {
                    dic.Add(multipleName, new Dictionary<string, Sprite>());
                }
                dic[multipleName].Add(sprites[i].name, sprites[i]);
            }
        }
        return dic[multipleName][spriteName];
    }
}
