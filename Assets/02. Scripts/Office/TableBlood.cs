using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableBlood : MonoBehaviour, IInteractable
{
    PaperNone paperNone = null; //ȹ��� ������
    PaperName paperName = null; //�̸� ���� ����
    Pencil pencil = null; 
    SpriteRenderer nameElie = null; //�̸�

    private void Awake()
    {
        paperName = GetComponentInChildren<PaperName>();
        nameElie = GetComponentInChildren<SpriteRenderer>();
        nameElie.enabled = false; //�̸� ���� �����ͼ� ���� �Ŀ�
        paperName.gameObject.SetActive(false); 
    }

    private void OnTriggerEnter(Collider other)
    {

        paperNone = other.gameObject.GetComponent<PaperNone>();
        pencil = other.gameObject.GetComponent<Pencil>();

        Interact();

    }

    public void Interact()
    {


        if (paperNone != null)
        {
            Destroy(paperNone.gameObject); //�� ���� ����
            paperName.gameObject.SetActive(true); //�̸� ���� ����
        }

        if (paperName.enabled == true && pencil != null) //�̸� ���� ���� ���¿��� ���� ���
        {
            Destroy(pencil.gameObject); //���� ���� ��
            nameElie.enabled = true; //�̸� ����
        }
    }


}
