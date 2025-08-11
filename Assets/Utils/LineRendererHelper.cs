using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererHelper : MonoBehaviour
{
    
    public LineRenderer lineRenderer;

    public List<Transform> postions;
    void Start()
    {
        lineRenderer.positionCount = postions.Count;
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < postions.Count; i++)
        {
            lineRenderer.SetPosition(i, postions[i].position);
        }
    }
}
