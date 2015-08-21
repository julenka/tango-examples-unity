using UnityEngine;
using System.Collections;

public class MyFPSController : MonoBehaviour
{
    private GameObject m_orangePortal;
    private GameObject m_bluePortal;

    // Use this for initialization
    void Start()
    {
        m_orangePortal = GameObject.Find("OrangePortal");
        m_bluePortal = GameObject.Find("BluePortal");

        m_orangePortal.SetActive(false);
        m_bluePortal.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
#if MOBILE_INPUT

#else
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Fire Orange");
            _PlacePortal(m_orangePortal);
        }
        if (Input.GetButtonDown("Fire2"))
        {
            Debug.Log("Fire Blue");
            _PlacePortal(m_bluePortal);
        }
#endif

    }

    public void FireBlue()
    {
        _PlacePortal(m_bluePortal);
    }


    public void FireOrange()
    {
        _PlacePortal(m_orangePortal);
    }

    private void _PlacePortal(GameObject portal)
    {
        // Fire a ray, if it intersects, place the portal there
        RaycastHit raycastHitInfo;
        Ray rayToFire = new Ray(transform.position, transform.forward);
        if (Physics.Raycast(rayToFire, out raycastHitInfo))
        {
            Vector3 normal = raycastHitInfo.normal;
            Vector3 position = raycastHitInfo.point;
            portal.transform.position = position;
            portal.transform.rotation = Quaternion.LookRotation(normal) * Quaternion.Euler(0, 180f, 0);
            portal.SetActive(true);
        }
    }
}
