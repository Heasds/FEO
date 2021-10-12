using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPositions : MonoBehaviour
{
    public int tilesNumer;

    public GameObject tile;
    public GameObject tileSlot;

    private void Start()
    {
        tileSlot = Instantiate(tile, tile.transform.position, tile.transform.rotation);

        for (int i = 0; i < tilesNumer; i++)
        {
            Vector2 pos = (GetTileSize(tileSlot) * Random.Range(-i, i));
            tileSlot = Instantiate(tile, pos, tile.transform.rotation);
            
        }
    }

    //public Vector3 GetTilePosition()
    //{
    //}

    public Vector2 GetTileSize(GameObject tile)
    {
        var _renderer = tile.GetComponent<Renderer>();

        float x = _renderer.bounds.size.x;
        float y = _renderer.bounds.size.y;

        return new Vector2(x, y);
    }
}
