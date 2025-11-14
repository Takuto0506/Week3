using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class LineDrawer : MonoBehaviour
{
    private LineRenderer lineRenderer;
    private List<Vector3> points = new List<Vector3>();
    private bool isDrawing = false;

    void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = 0;
        lineRenderer.useWorldSpace = true;
    }

    void Update()
    {
        if (!GameManager.instance.hasStarted)
            return;

        if (Input.GetMouseButtonDown(0))
        {
            isDrawing = true;
            points.Clear();
            lineRenderer.positionCount = 0;
        }

        if (Input.GetMouseButtonUp(0))
        {
            isDrawing = false;
        }

        if (isDrawing)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;

            // “_‚ð’Ç‰Ái‚ ‚é’ö“x‚Ì‹——£‚ª‹ó‚¢‚½‚ç
            if (points.Count == 0 || Vector3.Distance(points[points.Count - 1], mousePos) > 0.05f)
            {
                points.Add(mousePos);
                lineRenderer.positionCount = points.Count;
                lineRenderer.SetPositions(points.ToArray());
            }
        }
    }
}
