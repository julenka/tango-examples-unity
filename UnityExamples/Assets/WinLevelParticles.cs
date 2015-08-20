using UnityEngine;
using System.Collections;

public class WinLevelParticles : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Application.Quit();
    }
}
