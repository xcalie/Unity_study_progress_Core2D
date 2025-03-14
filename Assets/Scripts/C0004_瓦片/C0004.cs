using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class C0004 : MonoBehaviour
{
    public Tilemap tilemap;

    public Grid grid;

    public TileBase tile;//挂载的瓦片

    // Start is called before the first frame update
    void Start()
    {
        #region API

        //清空瓦片
        //tilemap.ClearAllTiles();

        //获取瓦片
        TileBase tile = tilemap.GetTile(new Vector3Int(0, 0, 0));

        //设置瓦片
        tilemap.SetTile(new Vector3Int(0, 0, 0), tile);
        //删除瓦片
        tilemap.SetTile(new Vector3Int(0, 0, 0), null);

        //替换瓦片
        tilemap.SwapTile(this.tile, tile);


        //世界坐标转换为瓦片坐标
        grid.WorldToCell(new Vector3(0, 0, 0));

        //瓦片坐标转换为世界坐标
        grid.CellToWorld(new Vector3Int(0, 0, 0));

        #endregion
    }
}
