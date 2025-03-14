using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleMgr
{
    private static MultipleMgr instance = new MultipleMgr();
    public static MultipleMgr Instance => instance;

    // �洢��ͼ��Ӧ�� Сͼ
    private Dictionary<string, Dictionary<string, Sprite>> dic = new Dictionary<string, Dictionary<string, Sprite>>();

    private MultipleMgr() 
    {
    }

    /// <summary>
    /// ��ȡMultiple��Sprite
    /// </summary>
    /// <param name="multioleName"></param>
    /// <param name="spriteName"></param>
    /// <returns></returns>
    public Sprite GetSprite(string multipleName, string spriteName)
    {
        // �ж��Ƿ���������ͼ
        if (dic.ContainsKey(multipleName))
        {
            // �ж��Ƿ�������Сͼ
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


    //���
    public void ClearInfo()
    {
        //���
        dic.Clear();
        //�ͷ��ڴ�
        Resources.UnloadUnusedAssets();
    }


}
