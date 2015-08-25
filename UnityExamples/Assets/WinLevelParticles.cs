using UnityEngine;
using System.Collections;

public class WinLevelParticles : MonoBehaviour
{
    public GameObject m_winText;
    public GameObject m_reticle;
    public GameObject m_redButton;
    public GameObject m_blueButton;

    public void OnTriggerEnter(Collider other)
    {
        m_winText.SetActive(true);
        m_reticle.SetActive(false);
        m_redButton.SetActive(false);
        m_blueButton.SetActive(false);
        gameObject.SetActive(false);
    }
}
