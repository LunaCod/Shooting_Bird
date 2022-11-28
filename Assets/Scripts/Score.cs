using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public double score;
    public CanvasScript cv;
    void Update()
    {

        cv.ShowScore(score);
    }
}
