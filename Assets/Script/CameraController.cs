using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CameraController : MonoBehaviour
{

    public Transform clampXmin;
    public Transform clampXmax;

    public GameObject player;

    private float camHeight;
    private float camWidth;
    private float camHalfHeight;
    private float camHalfWidth;


    void Start()
    {
        camHeight = Camera.main.orthographicSize;
        camWidth = camHeight * Camera.main.aspect;
        camHalfWidth = camWidth / 2;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
        float posX = Mathf.Clamp(transform.position.x, clampXmin.position.x, clampXmax.position.x);
        transform.position = new Vector3(posX, transform.position.y, transform.position.z);
        
    }

    private void OnDrawGizmos()
    {
        camHeight = Camera.main.orthographicSize;
        camWidth = camHeight * Camera.main.aspect;
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(clampXmin.position + new Vector3(-camWidth, -10f, 0f), clampXmin.position + new Vector3(-camWidth, 10f, 0f));
        Gizmos.DrawLine(clampXmax.position + new Vector3(camWidth, -10f, 0f), clampXmax.position + new Vector3(camWidth, 10f, 0f));
    }
}
