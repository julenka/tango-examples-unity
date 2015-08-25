using UnityEngine;
using System.Collections;

public class LaserReceiverHead : MonoBehaviour
{
    private GameObject m_winLevelParticles;
    private GameObject m_headParticles;

    // Use this for initialization
    void Start()
    {
        m_winLevelParticles = GameObject.Find("WinLevelParticles");
        m_winLevelParticles.SetActive(false);

        m_headParticles = GameObject.Find("HeadParticles");
        m_headParticles.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter()
    {
        m_winLevelParticles.SetActive(true);
        m_headParticles.SetActive(true);
    }
}
