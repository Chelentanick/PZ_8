using Doodle.core;
using UnityEngine;

public class ChangeBackgroundColor : MonoBehaviour
{
    public Color[] availableColors;
    private int randomColor;
    private void Update()
    {

        if (InputController.IsJumped)
        {
            randomColor = Random.Range(0, availableColors.Length);
            Camera.main.backgroundColor = availableColors[randomColor];
        }

    }
}
