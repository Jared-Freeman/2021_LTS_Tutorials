using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// VERY BAD GUI built for tutorial purposes ONLY
/// </summary>
/// <remarks>
/// DO NOT use the OnGUI() method in your game! 
/// This method is deprecated and can be called multiple times per frame.
/// On top of that, the visuals are inadequate.
/// </remarks>
public class EDP_Debug_GUI : MonoBehaviour
{
    const float ELEMENT_HEIGHT = 32, ELEMENT_WIDTH = 32 * 6;

    private void OnGUI()
    {
        // Text prompt
        GUI.TextArea(
            new Rect(new Vector2(Screen.width * 0.5f - ELEMENT_WIDTH * 0.5f, Screen.height * .75f), new Vector2(ELEMENT_WIDTH, ELEMENT_HEIGHT))
            , "Event-Driven Programming :)"
            );

        // Very basic debug button
        if (GUI.Button(new Rect(new Vector2(4, 4), new Vector2(ELEMENT_WIDTH, ELEMENT_HEIGHT)), "Invoke Button Event"))
        {
            // Button pressed invokes this logic
        }
    }
}
