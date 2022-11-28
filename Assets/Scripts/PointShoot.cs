using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointShoot : MonoBehaviour
{
    [SerializeField] private GameObject viewfinder;
    private Vector3 target;
    public AudioSource audio;
    public AudioClip shoot;

    private void Start()
    {
        Cursor.visible = false;
    }
    private void Update()
    {
        target = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
        viewfinder.transform.position = new Vector2(target.x, target.y);
        if (Input.GetMouseButtonDown(0))
        {
            audio.PlayOneShot(shoot);
        }
    }
}
