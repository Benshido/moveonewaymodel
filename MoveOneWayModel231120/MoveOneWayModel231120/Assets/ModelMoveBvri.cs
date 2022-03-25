using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelMoveBvri : MonoBehaviour
{
    int startX = -4;
    int endX = 4;
    int y = 0;
    int z = 3;

    private Vector3 pos1 = new Vector3(0, 0, 0);
    private Vector3 pos2 = new Vector3(0, 0, 0);
    public float speed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        pos1 = new Vector3(startX, y, z);
        pos2 = new Vector3(endX, y, z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong(Time.time, 1.0f));
    }
}
