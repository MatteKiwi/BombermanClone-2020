using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGenerator : TileGenerator
{
    protected override void MakeTile(Vector3 offset, int y, int x)
    {
        if (x == 0)
        {
            base.MakeTile(offset, y, x);
        }
        else if (y == 0)
        {
            base.MakeTile(offset, y, x);
        }


    }
}
