using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class CharacterBullet : MonoBehaviour
{

    public float m_Speed = 10f;
    public float m_Lifespan = 5f;

    private Rigidbody2D m_Rigidbody;

    void Awake()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        m_Rigidbody.AddForce(transform.forward * m_Speed);
        Destroy(gameObject, m_Lifespan);
    }


}
