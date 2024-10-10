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
        // 천 생성
        fabric.gameObject.SetActive(true);
        // 베개 제거
        Destroy(gameObject);
    }
}