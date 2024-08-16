using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using Unity.VisualScripting;
using UnityEditor.PackageManager;
using UnityEngine;
using static UnityEditor.VersionControl.Message;
using static UnityEngine.ParticleSystem;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class JumpPlatform : MonoBehaviour
{
    public float forwardForce = 100f; // Сила толчка вперед

    private void OnTriggerEnter(Collider other)
    {
        // Проверяем, есть ли у объекта компонент Rigidbody
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null)
        {
            // Применяем силу вперед относительно мировых координат
            rb.AddForce(transform.forward * forwardForce, ForceMode.Impulse);
        }
    }
}



    
