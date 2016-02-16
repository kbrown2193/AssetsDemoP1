using UnityEngine;
using System.Collections;

public class TextureSetter8x8 : MonoBehaviour {

    /* 
    *
    *
    * %%%%%%%%%%%%%%
    * Script ID Data
    * Script Name: TextureSetter8x8.cs
    * Script Version: 2016_02_10
    * Description: A texture setter for an 8x8 tiled texture implented in C# using Unity's API
    * Contributors: Kyle Brown {kb}
    * %%%%%%%%%%%%%%
    *
    * 8x8 Grid goes like            Y
    * ----------------- 
    * 00 01 02 03 16 17 18 19       0.875   OFS_7    
    * 04 05 06 07 20 21 22 23       0.75    OFS_3
    * 08 09 10 11 24 25 26 27       0.625   OFS_6
    * 12 13 14 15 28 29 30 31       0.5     OFS_2
    * 32 33 34 35 48 49 50 51       0.375   OFS_5
    * 36 37 38 39 52 53 54 55       0.25    OFS_1
    * 40 41 42 43 56 57 58 59       0.125   OFS_4
    * 44 45 46 47 60 61 62 63       0.0     OFS_0
    *
    * x
    * 0
    * xx 0.125
    * xx xx 0.25
    * xx xx xx 0.375
    * xx xx xx xx 0.5
    * xx xx xx xx xx 0.625
    * xx xx xx xx xx xx 0.75
    * xx xx xx xx xx xx xx 0.875
    * 0  4  1  5  2  6  3  7
    *
    *
    *
    * =========
    * Functions
    * =========
    * void return type, no parameters passed
    * Function Name     Description
    * --------------------------------------
    * Awake             Called before start, gets the renderer component of the object script is attached to
    *
    * void return type, int parameter passed
    * Function Name      Description
    * --------------------------------------
    * SetTextureNum     Sets the texture to a specified tile spot (valid parameter ranges from 0 to 63) {single conditional statment implementation}
    * SetTextureNumA    Sets the texture to a specified tile spot (valid parameter ranges from 0 to 63) {smalller multiple conditionals implementation}
    *
    */

    // The powers of 2 constants
    const int MAGIC_16 = 16;
    const int MAGIC_32 = 32;
    const int MAGIC_48 = 48;
    const int MAGIC_64 = 64;


    // The offsets for an 8x8 grid
    const float OFS_0 = 0.00f;
    const float OFS_1 = 0.25f;
    const float OFS_2 = 0.5f;
    const float OFS_3 = 0.75f;
    const float OFS_4 = 0.125f;
    const float OFS_5 = 0.375f;
    const float OFS_6 = 0.625f;
    const float OFS_7 = 0.875f;

    private Renderer _rend; // the renderer  of this particular object
    private Vector2 _texOfs = new Vector2(OFS_0, OFS_0); // the texture offsets

    // Called before start, to gather all renderer components
    void Awake()
    {
        _rend = GetComponent<Renderer>();
    }

    // LONG SINGULAR CONDITIONAL STATEMENT
    // Sets the texture based off a number 0 to 63
    public void SetTextureNum(int num)
    {
        // Tile 256 - 00
        if (num == 0)
        {
            _texOfs.x = OFS_0;
            _texOfs.y = OFS_7;
        }
        else if (num == 1)
        {
            _texOfs.x = OFS_4;
            _texOfs.y = OFS_7;
        }
        else if (num == 2)
        {
            _texOfs.x = OFS_1;
            _texOfs.y = OFS_7;
        }
        else if (num == 3)
        {
            _texOfs.x = OFS_5;
            _texOfs.y = OFS_7;
        }
        else if (num == 4)
        {
            _texOfs.x = OFS_0;
            _texOfs.y = OFS_3;
        }
        else if (num == 5)
        {
            _texOfs.x = OFS_4;
            _texOfs.y = OFS_3;
        }
        else if (num == 6)
        {
            _texOfs.x = OFS_1;
            _texOfs.y = OFS_3;
        }
        else if (num == 7)
        {
            _texOfs.x = OFS_5;
            _texOfs.y = OFS_3;
        }
        else if (num == 8)
        {
            _texOfs.x = OFS_0;
            _texOfs.y = OFS_6;
        }
        else if (num == 9)
        {
            _texOfs.x = OFS_4;
            _texOfs.y = OFS_6;
        }
        else if (num == 10)
        {
            _texOfs.x = OFS_1;
            _texOfs.y = OFS_6;
        }
        else if (num == 11)
        {
            _texOfs.x = OFS_5;
            _texOfs.y = OFS_6;
        }
        else if (num == 12)
        {
            _texOfs.x = OFS_0;
            _texOfs.y = OFS_2;
        }
        else if (num == 13)
        {
            _texOfs.x = OFS_4;
            _texOfs.y = OFS_2;
        }
        else if (num == 14)
        {
            _texOfs.x = OFS_1;
            _texOfs.y = OFS_2;
        }
        else if (num == 15)
        {
            _texOfs.x = OFS_5;
            _texOfs.y = OFS_2;
        }
        // Tile 256 - 01
        else if (num == 16)
        {
            _texOfs.x = OFS_2;
            _texOfs.y = OFS_7;
        }
        else if (num == 17)
        {
            _texOfs.x = OFS_6;
            _texOfs.y = OFS_7;
        }
        else if (num == 18)
        {
            _texOfs.x = OFS_3;
            _texOfs.y = OFS_7;
        }
        else if (num == 19)
        {
            _texOfs.x = OFS_7;
            _texOfs.y = OFS_7;
        }
        else if (num == 20)
        {
            _texOfs.x = OFS_2;
            _texOfs.y = OFS_3;
        }
        else if (num == 21)
        {
            _texOfs.x = OFS_6;
            _texOfs.y = OFS_3;
        }
        else if (num == 22)
        {
            _texOfs.x = OFS_3;
            _texOfs.y = OFS_3;
        }
        else if (num == 23)
        {
            _texOfs.x = OFS_7;
            _texOfs.y = OFS_3;
        }
        else if (num == 24)
        {
            _texOfs.x = OFS_2;
            _texOfs.y = OFS_6;
        }
        else if (num == 25)
        {
            _texOfs.x = OFS_6;
            _texOfs.y = OFS_6;
        }
        else if (num == 26)
        {
            _texOfs.x = OFS_3;
            _texOfs.y = OFS_6;
        }
        else if (num == 27)
        {
            _texOfs.x = OFS_7;
            _texOfs.y = OFS_6;
        }
        else if (num == 28)
        {
            _texOfs.x = OFS_2;
            _texOfs.y = OFS_2;
        }
        else if (num == 29)
        {
            _texOfs.x = OFS_6;
            _texOfs.y = OFS_2;
        }
        else if (num == 30)
        {
            _texOfs.x = OFS_3;
            _texOfs.y = OFS_2;
        }
        else if (num == 31)
        {
            _texOfs.x = OFS_7;
            _texOfs.y = OFS_2;
        }
        // Tile 256 - 02
        else if (num == 32)
        {
            _texOfs.x = OFS_0;
            _texOfs.y = OFS_5;
        }
        else if (num == 33)
        {
            _texOfs.x = OFS_4;
            _texOfs.y = OFS_5;
        }
        else if (num == 34)
        {
            _texOfs.x = OFS_1;
            _texOfs.y = OFS_5;
        }
        else if (num == 35)
        {
            _texOfs.x = OFS_5;
            _texOfs.y = OFS_5;
        }
        else if (num == 36)
        {
            _texOfs.x = OFS_0;
            _texOfs.y = OFS_1;
        }
        else if (num == 37)
        {
            _texOfs.x = OFS_4;
            _texOfs.y = OFS_1;
        }
        else if (num == 38)
        {
            _texOfs.x = OFS_1;
            _texOfs.y = OFS_1;
        }
        else if (num == 39)
        {
            _texOfs.x = OFS_5;
            _texOfs.y = OFS_1;
        }
        else if (num == 40)
        {
            _texOfs.x = OFS_0;
            _texOfs.y = OFS_4;
        }
        else if (num == 41)
        {
            _texOfs.x = OFS_4;
            _texOfs.y = OFS_4;
        }
        else if (num == 42)
        {
            _texOfs.x = OFS_1;
            _texOfs.y = OFS_4;
        }
        else if (num == 43)
        {
            _texOfs.x = OFS_5;
            _texOfs.y = OFS_4;
        }
        else if (num == 44)
        {
            _texOfs.x = OFS_0;
            _texOfs.y = OFS_0;
        }
        else if (num == 45)
        {
            _texOfs.x = OFS_4;
            _texOfs.y = OFS_0;
        }
        else if (num == 46)
        {
            _texOfs.x = OFS_1;
            _texOfs.y = OFS_0;
        }
        else if (num == 47)
        {
            _texOfs.x = OFS_5;
            _texOfs.y = OFS_0;
        }
        // Tile 256 - 03
        else if (num == 48)
        {
            _texOfs.x = OFS_2;
            _texOfs.y = OFS_5;
        }
        else if (num == 49)
        {
            _texOfs.x = OFS_6;
            _texOfs.y = OFS_5;
        }
        else if (num == 50)
        {
            _texOfs.x = OFS_3;
            _texOfs.y = OFS_5;
        }
        else if (num == 51)
        {
            _texOfs.x = OFS_7;
            _texOfs.y = OFS_1;
        }
        else if (num == 52)
        {
            _texOfs.x = OFS_2;
            _texOfs.y = OFS_4;
        }
        else if (num == 53)
        {
            _texOfs.x = OFS_6;
            _texOfs.y = OFS_1;
        }
        else if (num == 54)
        {
            _texOfs.x = OFS_3;
            _texOfs.y = OFS_1;
        }
        else if (num == 55)
        {
            _texOfs.x = OFS_7;
            _texOfs.y = OFS_1;
        }
        else if (num == 56)
        {
            _texOfs.x = OFS_2;
            _texOfs.y = OFS_4;
        }
        else if (num == 57)
        {
            _texOfs.x = OFS_6;
            _texOfs.y = OFS_4;
        }
        else if (num == 58)
        {
            _texOfs.x = OFS_3;
            _texOfs.y = OFS_4;
        }
        else if (num == 59)
        {
            _texOfs.x = OFS_7;
            _texOfs.y = OFS_4;
        }
        else if (num == 60)
        {
            _texOfs.x = OFS_2;
            _texOfs.y = OFS_0;
        }
        else if (num == 61)
        {
            _texOfs.x = OFS_6;
            _texOfs.y = OFS_0;
        }
        else if (num == 62)
        {
            _texOfs.x = OFS_3;
            _texOfs.y = OFS_0;
        }
        else if (num == 63)
        {
            _texOfs.x = OFS_7;
            _texOfs.y = OFS_0;
        }
        else
        {
            Debug.Log("TextureSetter8x8:SetTextureNum() NOT VALID NUMBER 0 to 63...: NUM: " + num );
        }

        _rend.material.SetTextureOffset("_MainTex", _texOfs);  // sets the offset of the main texture of the renderer material
    }

}

    // breaks conditional into 4 sections
    public void SetTextureNumA(int num)
    {
        if(num >= 0 && num < MAGIC_16)
        {
            // Tile 256 - 00
            if (num == 0)
            {
                _texOfs.x = OFS_0;
                _texOfs.y = OFS_7;
            }
            else if (num == 1)
            {
                _texOfs.x = OFS_4;
                _texOfs.y = OFS_7;
            }
            else if (num == 2)
            {
                _texOfs.x = OFS_1;
                _texOfs.y = OFS_7;
            }
            else if (num == 3)
            {
                _texOfs.x = OFS_5;
                _texOfs.y = OFS_7;
            }
            else if (num == 4)
            {
                _texOfs.x = OFS_0;
                _texOfs.y = OFS_3;
            }
            else if (num == 5)
            {
                _texOfs.x = OFS_4;
                _texOfs.y = OFS_3;
            }
            else if (num == 6)
            {
                _texOfs.x = OFS_1;
                _texOfs.y = OFS_3;
            }
            else if (num == 7)
            {
                _texOfs.x = OFS_5;
                _texOfs.y = OFS_3;
            }
            else if (num == 8)
            {
                _texOfs.x = OFS_0;
                _texOfs.y = OFS_6;
            }
            else if (num == 9)
            {
                _texOfs.x = OFS_4;
                _texOfs.y = OFS_6;
            }
            else if (num == 10)
            {
                _texOfs.x = OFS_1;
                _texOfs.y = OFS_6;
            }
            else if (num == 11)
            {
                _texOfs.x = OFS_5;
                _texOfs.y = OFS_6;
            }
            else if (num == 12)
            {
                _texOfs.x = OFS_0;
                _texOfs.y = OFS_2;
            }
            else if (num == 13)
            {
                _texOfs.x = OFS_4;
                _texOfs.y = OFS_2;
            }
            else if (num == 14)
            {
                _texOfs.x = OFS_1;
                _texOfs.y = OFS_2;
            }
            else if (num == 15)
            {
                _texOfs.x = OFS_5;
                _texOfs.y = OFS_2;
            }
        }
        else if (num >= MAGIC_16 && num < MAGIC_32)
        {
             // Tile 256 - 01
            if (num == 16)
            {
                _texOfs.x = OFS_2;
                _texOfs.y = OFS_7;
            }
            else if (num == 17)
            {
                _texOfs.x = OFS_6;
                _texOfs.y = OFS_7;
            }
            else if (num == 18)
            {
                _texOfs.x = OFS_3;
                _texOfs.y = OFS_7;
            }
            else if (num == 19)
            {
                _texOfs.x = OFS_7;
                _texOfs.y = OFS_7;
            }
            else if (num == 20)
            {
                _texOfs.x = OFS_2;
                _texOfs.y = OFS_3;
            }
            else if (num == 21)
            {
                _texOfs.x = OFS_6;
                _texOfs.y = OFS_3;
            }
            else if (num == 22)
            {
                _texOfs.x = OFS_3;
                _texOfs.y = OFS_3;
            }
            else if (num == 23)
            {
                _texOfs.x = OFS_7;
                _texOfs.y = OFS_3;
            }
            else if (num == 24)
            {
                _texOfs.x = OFS_2;
                _texOfs.y = OFS_6;
            }
            else if (num == 25)
            {
                _texOfs.x = OFS_6;
                _texOfs.y = OFS_6;
            }
            else if (num == 26)
            {
                _texOfs.x = OFS_3;
                _texOfs.y = OFS_6;
            }
            else if (num == 27)
            {
                _texOfs.x = OFS_7;
                _texOfs.y = OFS_6;
            }
            else if (num == 28)
            {
                _texOfs.x = OFS_2;
                _texOfs.y = OFS_2;
            }
            else if (num == 29)
            {
                _texOfs.x = OFS_6;
                _texOfs.y = OFS_2;
            }
            else if (num == 30)
            {
                _texOfs.x = OFS_3;
                _texOfs.y = OFS_2;
            }
            else if (num == 31)
            {
                _texOfs.x = OFS_7;
                _texOfs.y = OFS_2;
            }
        }
        else if (num >= MAGIC_32 && num < MAGIC_48)
        {
             // Tile 256 - 02
            if (num == 32)
            {
                _texOfs.x = OFS_0;
                _texOfs.y = OFS_5;
            }
            else if (num == 33)
            {
                _texOfs.x = OFS_4;
                _texOfs.y = OFS_5;
            }
            else if (num == 34)
            {
                _texOfs.x = OFS_1;
                _texOfs.y = OFS_5;
            }
            else if (num == 35)
            {
                _texOfs.x = OFS_5;
                _texOfs.y = OFS_5;
            }
            else if (num == 36)
            {
                _texOfs.x = OFS_0;
                _texOfs.y = OFS_1;
            }
            else if (num == 37)
            {
                _texOfs.x = OFS_4;
                _texOfs.y = OFS_1;
            }
            else if (num == 38)
            {
                _texOfs.x = OFS_1;
                _texOfs.y = OFS_1;
            }
            else if (num == 39)
            {
                _texOfs.x = OFS_5;
                _texOfs.y = OFS_1;
            }
            else if (num == 40)
            {
                _texOfs.x = OFS_0;
                _texOfs.y = OFS_4;
            }
            else if (num == 41)
            {
                _texOfs.x = OFS_4;
                _texOfs.y = OFS_4;
            }
            else if (num == 42)
            {
                _texOfs.x = OFS_1;
                _texOfs.y = OFS_4;
            }
            else if (num == 43)
            {
                _texOfs.x = OFS_5;
                _texOfs.y = OFS_4;
            }
            else if (num == 44)
            {
                _texOfs.x = OFS_0;
                _texOfs.y = OFS_0;
            }
            else if (num == 45)
            {
                _texOfs.x = OFS_4;
                _texOfs.y = OFS_0;
            }
            else if (num == 46)
            {
                _texOfs.x = OFS_1;
                _texOfs.y = OFS_0;
            }
            else if (num == 47)
            {
                _texOfs.x = OFS_5;
                _texOfs.y = OFS_0;
            }
        }
        else if (num >= MAGIC_48 && num < MAGIC_64)
        {
             // Tile 256 - 03
            if (num == 48)
            {
                _texOfs.x = OFS_2;
                _texOfs.y = OFS_5;
            }
            else if (num == 49)
            {
                _texOfs.x = OFS_6;
                _texOfs.y = OFS_5;
            }
            else if (num == 50)
            {
                _texOfs.x = OFS_3;
                _texOfs.y = OFS_5;
            }
            else if (num == 51)
            {
                _texOfs.x = OFS_7;
                _texOfs.y = OFS_5;
            }
            else if (num == 52)
            {
                _texOfs.x = OFS_2;
                _texOfs.y = OFS_1;
            }
            else if (num == 53)
            {
                _texOfs.x = OFS_6;
                _texOfs.y = OFS_1;
            }
            else if (num == 54)
            {
                _texOfs.x = OFS_3;
                _texOfs.y = OFS_1;
            }
            else if (num == 55)
            {
                _texOfs.x = OFS_7;
                _texOfs.y = OFS_1;
            }
            else if (num == 56)
            {
                _texOfs.x = OFS_2;
                _texOfs.y = OFS_4;
            }
            else if (num == 57)
            {
                _texOfs.x = OFS_6;
                _texOfs.y = OFS_4;
            }
            else if (num == 58)
            {
                _texOfs.x = OFS_3;
                _texOfs.y = OFS_4;
            }
            else if (num == 59)
            {
                _texOfs.x = OFS_7;
                _texOfs.y = OFS_4;
            }
            else if (num == 60)
            {
                _texOfs.x = OFS_2;
                _texOfs.y = OFS_0;
            }
            else if (num == 61)
            {
                _texOfs.x = OFS_6;
                _texOfs.y = OFS_0;
            }
            else if (num == 62)
            {
                _texOfs.x = OFS_3;
                _texOfs.y = OFS_0;
            }
            else if (num == 63)
            {
                _texOfs.x = OFS_7;
                _texOfs.y = OFS_0;
            }
        }
        else
        {
            Debug.Log("TextureSetter8x8:SetTextureNumA() NOT VALID NUMBER 0 to 63...: NUM: " + num);
        }

        _rend.material.SetTextureOffset("_MainTex", _texOfs);  // sets the offset of the main texture of the renderer material
    }

}
}
