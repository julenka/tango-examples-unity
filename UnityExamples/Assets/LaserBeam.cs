using UnityEngine;
using System.Collections;

public class LaserBeam : MonoBehaviour
{
    public GameObject m_Emitter;

    private LineRenderer m_lineRenderer;

    // Use this for initialization
    void Start()
    {
        m_lineRenderer = GetComponent<LineRenderer>();

    }

    private void _UpdateLaser()
    {
        m_lineRenderer.SetPosition(0, m_Emitter.transform.position);
        RaycastHit raycastHit;
        if (Physics.Raycast(m_Emitter.transform.position, m_Emitter.transform.forward, out raycastHit))
        {
            GameObject colliderObject = raycastHit.collider.gameObject;
            if (colliderObject)
            {
                colliderObject.SendMessage("OnTriggerEnter", options: SendMessageOptions.DontRequireReceiver);
            }
            m_lineRenderer.SetPosition(1, raycastHit.point);
        }
        else
        {
            Ray unboundedRay = new Ray(m_Emitter.transform.position, m_Emitter.transform.forward);
            m_lineRenderer.SetPosition(1, unboundedRay.GetPoint(100));
        }
        // Cast the ray out until you hit a wall
        // Get the position of that wall
    }

    // Update is called once per frame
    void Update()
    {
        _UpdateLaser();
    }
}
