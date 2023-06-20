using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;
    public float smothTime = 0.3f;
    private Vector3 velocity = Vector3.zero;

    private Camera _camera;
    private float _fixedX;
    private float _fixedY;

    // Start is called before the first frame update
    void Start()
    {
        _camera = GetComponent<Camera>();
        _fixedX = transform.position.x;
        _fixedY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if(target != null)
        {
            float depth = Vector3.Dot(target.position - transform.position, transform.forward);

            Vector3 viewportFocus = new Vector3(0.5f, 0.5f, depth);
            Vector3 worldFocus = _camera.ViewportToWorldPoint(viewportFocus);

            Vector3 delta = target.position - worldFocus;
            Vector3 destination = transform.position + delta;

            destination.x = _fixedX;
            destination.y = _fixedY;

            transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, smothTime);
        }
    }
}
