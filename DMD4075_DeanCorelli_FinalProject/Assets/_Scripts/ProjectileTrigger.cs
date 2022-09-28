using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileTrigger : MonoBehaviour
{

    public GameObject m_Projectile;
    public Transform m_SpawnTransform;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) ;
        {
            Instantiate(m_Projectile, m_SpawnTransform.position, m_SpawnTransform.rotation);
        }
    }



}
