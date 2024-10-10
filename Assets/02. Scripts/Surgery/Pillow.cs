using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillow : MonoBehaviour, IInteractable
{
    public Fabric fabric;

    private void Awake()
    {
        fabric.gameObject.SetActive(false);
    }

    public void Interact()
    {
        // õ ����
        fabric.gameObject.SetActive(true);
        // ���� ����
        Destroy(gameObject);
    }
}