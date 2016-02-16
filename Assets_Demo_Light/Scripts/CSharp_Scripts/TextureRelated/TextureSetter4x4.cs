using UnityEngine;
using System.Collections;

public class TextureSetter4x4 : MonoBehaviour {


    /*
    *
    * %%%%%%%%%%%%%%
    * Script ID Data
    * Script Name: TextureSetter4x4.cs
    * Script Version: 2016_02_10
    * Description: A texture setter for a 4x4 tiled texture implented in C# using Unity's API
    * Contributors: Kyle Brown {kb}
    * %%%%%%%%%%%%%%
    *
    *
    * 4x4 Grid goes like            Y
    * ----------------- 
    * 00 01 02 03        0.75    OFS_3
    * 04 05 06 07        0.5     OFS_2  
    * 08 09 10 11        0.25    OFS_1
    * 12 13 14 15        0.0     OFS_0
    *
    * X
    * 0
    * xx 0.25
    * xx xx 0.5
    * xx xx xx 0.75
    *
    * 0  1  2  3 
    *
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
    * IncreaseTexture   Moves the main texture offset by one tile in the positive direction
    * DecreaseTexture   Moves the main texture offset by one tile in the negative direction
    *
    * void return type, int parameter passed
    * Function Name      Description
    * --------------------------------------
    * SetTextureNum     Sets the texture to a specified tile spot (valid parameter ranges from 0 to 15)
    *
    *
    *
    */



    // The ofsets for a 4x4 grid on a 0 to 1 scale
    const float OFS_0 = 0.00f;
    const float OFS_1 = 0.25f;
    const float OFS_2 = 0.5f;
    const float OFS_3 = 0.75f;


    private Renderer _rend; // the renderer  of this particular object
    private Vector2 _texOfs = new Vector2(OFS_0, OFS_0); // the texture offsets

	// Called before start, to gather all renderer components
	void Awake () {
        _rend = GetComponent<Renderer>();
	}
	
    // Sets the texture to tle based off a number 0-15
    public void SetTextureNum(int num)
    {
        if(num == 0)
        {
            _texOfs.x = OFS_0;
            _texOfs.y = OFS_3;
        }
        else if (num == 1)
        {
            _texOfs.x = OFS_1;
            _texOfs.y = OFS_3;
        }
        else if (num == 2)
        {
            _texOfs.x = OFS_2;
            _texOfs.y = OFS_3;
        }
        else if (num == 3)
        {
            _texOfs.x = OFS_3;
            _texOfs.y = OFS_3;
        }
        else if (num == 4)
        {
            _texOfs.x = OFS_0;
            _texOfs.y = OFS_2;
        }
        else if (num == 5)
        {
            _texOfs.x = OFS_1;
            _texOfs.y = OFS_2;
        }
        else if (num == 6)
        {
            _texOfs.x = OFS_2;
            _texOfs.y = OFS_2;
        }
        else if (num == 7)
        {
            _texOfs.x = OFS_3;
            _texOfs.y = OFS_2;
        }
        else if (num == 8)
        {
            _texOfs.x = OFS_0;
            _texOfs.y = OFS_1;
        }
        else if (num == 9)
        {
            _texOfs.x = OFS_1;
            _texOfs.y = OFS_1;
        }
        else if (num == 10)
        {
            _texOfs.x = OFS_2;
            _texOfs.y = OFS_1;
        }
        else if (num == 11)
        {
            _texOfs.x = OFS_3;
            _texOfs.y = OFS_1;
        }
        else if (num == 12)
        {
            _texOfs.x = OFS_0;
            _texOfs.y = OFS_0;
        }
        else if (num == 13)
        {
            _texOfs.x = OFS_1;
            _texOfs.y = OFS_0;
        }
        else if (num == 14)
        {
            _texOfs.x = OFS_2;
            _texOfs.y = OFS_0;
        }
        else if (num == 15)
        {
            _texOfs.x = OFS_3;
            _texOfs.y = OFS_0;
        }
        else
        {
            Debug.Log("TextureSetter4x4:SetTextureNum() NOT VALID NUMBER 0 to 15");
        }

        _rend.material.SetTextureOffset("_MainTex", _texOfs);

    }

    // Increases the texture to the next tile spot
    public void IncreaseTexture()
    {
        if(_texOfs.x >= OFS_3)
        {
            _texOfs.x = OFS_0;          // it is at the right end of a row so check to see if it needs to reset to top, resets x to left end
            if (_texOfs.y <= OFS_0)
            {
                _texOfs.y = OFS_3;      // it is at the bottom end of a column so reset y to top
            }
            else
            {
                _texOfs.y -= OFS_1;     // it is not at the end of a column so decrease y by one tile
            }
        }
        else
        {
            _texOfs.x += OFS_1;         // it is not at the end of a row so increase x by one tile
        }

        _rend.material.SetTextureOffset("_MainTex", _texOfs);       // sets the offset of the main texture of the renderer material
    }


    // Decreases the texture to the next tile spot
    public void DecreaseTexture()
    {
        if (_texOfs.x <= OFS_0)
        {
            _texOfs.x = OFS_3;          // it is at the left end of a row so check to see if it needs to reset to bottom, resets x to right end
            if (_texOfs.y >= OFS_3)
            {
                _texOfs.y = OFS_0;      // it is at the top end of a column so reset y to bottom
            }
            else
            {
                _texOfs.y += OFS_1;     // it is not at the end of a column so increse y by one tile
            }
        }
        else
        {
            _texOfs.x -= OFS_1;         // it is not at the end of a row so decrease x by one tile
        }

        _rend.material.SetTextureOffset("_MainTex", _texOfs); // sets the offset of the main texture of the renderer material
    }

}
