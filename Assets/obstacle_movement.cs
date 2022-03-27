using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle_movement : MonoBehaviour
{
    float time;
    float posY = 0;
    void Start()
    {
        
    }

    void Update()
    {
        time += Time.deltaTime;
        posY = Mathf.Sin(time)*4.5f;
        if (time > 6.2831f)
        {
            time -= 6.2831f;
        }
        transform.position = new Vector3(10, posY, 0);
    }
}
