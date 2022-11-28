using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CanvasScript : MonoBehaviour
{
    public TextMeshProUGUI text;

    public void ShowScore(double score)
    {
        text.text = "" + score;
    }
}
