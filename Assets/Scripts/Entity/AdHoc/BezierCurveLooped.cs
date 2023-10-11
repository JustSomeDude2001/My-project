using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BezierCurveLooped : MonoBehaviour
{
    [SerializeField] private Transform[] controlPoints;
    [SerializeField] private float speed = 5f;
    private float _t = 0f;
    private bool _flip = false;
    private int _lastIndex = 0;
    
    private Vector3 BezierCurve(Transform[] controlP, float t)
    {
        int numSegments = controlP.Length;
        float segmentSize = 1f / numSegments;
        
        int currentIndex = ((Mathf.FloorToInt(t / segmentSize) * 3) % numSegments);
        int prevIndex = ((currentIndex - 1) + numSegments) % numSegments;
        int nextIndex = (currentIndex + 1) % numSegments;
        int nnIndex = (currentIndex + 2) % numSegments;
        float segmentT = (t % segmentSize) / segmentSize;

        Vector3 p0 = controlP[prevIndex].position;
        Vector3 p1 = controlP[currentIndex].position;
        Vector3 p2 = controlP[nextIndex].position;
        Vector3 p3 = controlP[nnIndex].position;

        float u = 1f - segmentT;
        float tt = segmentT * segmentT;
        float uu = u * u;
        float uuu = uu * u;
        float ttt = tt * segmentT;

        Vector3 p = uuu * p0;
        p += 3f * uu * segmentT * p1;
        p += 3f * u * tt * p2;
        p += ttt * p3;

        return p;
    }
    
    
    void Update()
    {
        transform.position = BezierCurve(controlPoints, _t);

        _t += speed * Time.deltaTime / controlPoints.Length;

        if (_t > 1f)
        {
            _t -= 1f;
        }
    }
}
