using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject Effect;

    private Score sc;

    private void Start()
    {
        sc = GameObject.FindObjectOfType<Score>().GetComponent<Score>();
  
    }
    private void OnMouseDown()
    {
        sc.score += 1000;
        Destroy(gameObject);

        Instantiate(Effect, transform.position, Quaternion.identity);
    }
}
