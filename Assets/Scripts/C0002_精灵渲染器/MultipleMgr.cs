using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleMgr
{
    private static MultipleMgr instance = new MultipleMgr();
    public static MultipleMgr Instance => instance;

    // 存储大图对应的 小图
    private Dictionary<string, Dictionary<string, Sprite>> dic = new Dictionary<string, Dictionary<string, Sprite>>();

    private MultipleMgr() 
    {
    }

    /// <summary>
    /// 获取Multiple的Sprite
    /// </summary>
    /// <param name="multioleName"></param>
    /// <param name="spriteName"></param>
    /// <returns></returns>
    public Sprite GetSprite(string multipleName, string spriteName)
    {
        // 判断是否包含这个大图
        if (dic.ContainsKey(multipleName))
        {
            // 判断是否包含这个小图
            if (dic[multipleName].ContainsKey(spriteName))
            {
                return dic[multipleName][spriteName];
            }
        }
        else
        {
            Dictionary<string, Sprite> dicTemp = new Dictionary<string, Sprite>();
            Sprite[] sprites = Resources.LoadAll<Sprite>(multipleName);
            for (int i = 0; i < sprites.Length; i++)
            {
                dicTemp.Add(sprites[i].name, sprites[i]);
            }

            dic.Add(multipleName, dicTemp);

            if (dic[multipleName].ContainsKey(spriteName))
            {
                return dic[multipleName][spriteName];
            }
        }

        return null;
    }


    //清空
    public void ClearInfo()
    {
        //清空
        dic.Clear();
        //释放内存
        Resources.UnloadUnusedAssets();
    }


}
