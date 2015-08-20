using UnityEngine;
using System.Collections;

public class Portal : MonoBehaviour
{
    public GameObject m_laserEmitterPrototype;
    public GameObject m_otherPortalGameObject;
    private Portal m_otherPortal;



    // Use this for initialization
    void Start()
    {
        m_otherPortal = m_otherPortalGameObject.GetComponent<Portal>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter()
    {
        if (m_otherPortalGameObject.activeSelf)
        {
            m_otherPortal.EmitLaser();
        }
    }

    private bool once = false;
    public void EmitLaser()
    {
        if (once)
        {
            return;
        }
        once = true;
        GameObject laserEmitter = (GameObject)Instantiate(m_laserEmitterPrototype, transform.position, transform.rotation * Quaternion.Euler(0, 180f, 0));
        laserEmitter.transform.parent = transform;
    }
}
