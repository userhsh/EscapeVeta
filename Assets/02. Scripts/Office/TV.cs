using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;

public class TV : MonoBehaviour, IInteractable
{
    TVPW tvPW = null; //TV�� ������� ���� ��й�ȣ �̹���(�ڽ� ������Ʈ)
    //Remocon remocon = null;

    private void Awake()
    {
        tvPW = GetComponentInChildren<TVPW>();
        tvPW.gameObject.SetActive(false);
    }

    public void Interact()
    {
        if (tvPW != null)
        {
            // tvPW ���������� ���� ���������� ��
            tvPW.gameObject.SetActive(!tvPW.gameObject.activeSelf);
        }
        else
        {
            Debug.Log("�ٸ� ���� ����غ���.");
        }
    }
}
