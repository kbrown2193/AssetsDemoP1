using UnityEngine;
using System.Collections;

public class BitTimer32Bits : MonoBehaviour {

  /* 
   *
   *
   * %%%%%%%%%%%%%%
   * Script ID Data
   * Script Name: BitTimer32bits.cs
   * Script Version: 2016_02_10
   * Description: A 32 bit timer that increments the lowest bit every second and the bits are held as integers that represent 4 bits in Unity's engine
   * Contributors: Kyle Brown {kb}
   * %%%%%%%%%%%%%%
   *
   *
   * =========
   * Functions
   * =========
   * void return type, no parameters passed
   * Function Name     Description
   * --------------------------------------
   * Update                     Called every frame, updates a timer value that keeps track of time passed
   * IncrementLowestBit         Incrmenets bit 0, increments additional bits if necessary (16 to 1)
   * IncrementSecondFourBits    Increments bit  16, increments additional bits if necessary (31 to 17)
   * SetAllBitsToZero           Sets all bits to 0 value
   *
   *
   */

    private float _timer;       // the float that holds the timer that is incremented each frame

    private bool _timerOn = true;   // boolean to control if the timer is on or not

    const float COUNTER_TICK = 1f; // tick every one second
    const int MAX_BITS4_VAL = 15; // 16 - 1, ( n -1), 0 based
    // Integer implementation (try a boolean only implementation?)
    private int bits4_0;        // bits 0 to 3, 0 least significant bit
    private int bits4_1;        // bits 4 to 7
    private int bits4_2;        // bits 8 to 11
    private int bits4_3;        // bits 12 to 15
    private int bits4_4;        // bits 16 to 19
    private int bits4_5;        // bits 20 to 23
    private int bits4_6;        // bits 24 to 27
    private int bits4_7;        // bits 28 to 31, 31 most signnificant bit

	

	// Update is called once per frame
	void Update () {
        if (_timerOn)
        {
            _timer += Time.deltaTime; // increment timer each frame

            // Check if past tick value;
            if (_timer >= COUNTER_TICK)
            {
                IncrementLowestBit();
                //Debug.Log("Bit Values(7-0): " + bits4_7 + "-" + bits4_6 + "-" + bits4_5 + "-" + bits4_4 + "-" + bits4_3 + "-" + bits4_2 + "-" + bits4_1 + "-" + bits4_0);
                _timer = 0; // reset timer back to 0
            }
        }
	
	}

    // Sets all the bits to 0
    private void SetAllBitsToZero()
    {
        bits4_0 = 0;
        bits4_1 = 0;
        bits4_2 = 0;
        bits4_3 = 0;
        bits4_4 = 0;
        bits4_5 = 0;
        bits4_6 = 0;
        bits4_7 = 0;
    }

    private void IncrementLowestBit()
    {
        if (bits4_0 < MAX_BITS4_VAL)
        {
            bits4_0++;      // increment lowest bit
        }
        else
        {
            bits4_0 = 0; // max limit for bits4_0 reached so reset to 0, and increment next lowest bit
            if (bits4_1 < MAX_BITS4_VAL)
            {
                bits4_1++; // increment second lowest bit
            }
            else
            {
                bits4_1 = 0; // max limit for bits4_1 reached so reset to 0 and increment next lowest bit
                if (bits4_2 < MAX_BITS4_VAL)
                {
                    bits4_2++; // increment third lowest bit
                }
                else
                {
                    bits4_2 = 0; // max limit for bits4_2 reached so reset to 0 and increment next lowest bit
                    if (bits4_3 < MAX_BITS4_VAL)
                    {
                        bits4_3++; // increment fourth lowest bit
                    }
                    else
                    {
                        bits4_3 = 0; // max limit for bits4_3 reached so reset to 0 and increment next lowest bit
                        // for sanity's sake, call to next four bits instead of continuing if else statements
                        IncrementSecondFourBits();
                    }
                }
            }
        }
    }

    private void IncrementSecondFourBits()
    {
        if (bits4_4 < MAX_BITS4_VAL)
        {
            bits4_4++;      // increment (secondary) lowest bit
        }
        else
        {
            bits4_4 = 0; // max limit for bits4_4 reached so reset to 0, and increment next lowest bit
            if (bits4_5 < MAX_BITS4_VAL)
            {
                bits4_5++; // increment (secondary) second lowest bit
            }
            else
            {
                bits4_5 = 0; // max limit for bits4_5 reached so reset to 0 and increment next lowest bit
                if (bits4_6 < MAX_BITS4_VAL)
                {
                    bits4_6++; // increment (secondary) third lowest bit
                }
                else
                {
                    bits4_6 = 0; // max limit for bits4_6 reached so reset to 0 and increment next lowest bit
                    if (bits4_7 < MAX_BITS4_VAL)
                    {
                        bits4_7++; // increment (secondary) fourth lowest bit
                    }
                    else
                    {
                        bits4_7 = 0; // max limit for bits4_7 reached so reset to 0 and increment next lowest bit
                        // MAX COUNTER LIMIT REACHED 
                        // Justs resets back to 0
                        SetAllBitsToZero();
                    }
                }
            }
        }
    }


}
 