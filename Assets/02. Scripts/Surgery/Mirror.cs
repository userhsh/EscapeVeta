using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour, IInteractable
{
    // �ſ� �� ������ ���� ����
    MirrorStain mirrorStain = null;
    // �ſ� �� �����ϴ� �ִϸ����� ������ ���� ����
    Animator stainAnimator = null;

    private void Awake()
    {
        MirrorInit();
    }

    // Mirror Init �޼���
    private void MirrorInit()
    {
        mirrorStain = GetComponentInChildren<MirrorStain>();
        stainAnimator = mirrorStain.gameObject.GetComponent<Animator>();
    }

    public void Interact()
    {
        // �ſ� �� ���� �ڷ�ƾ ����
        StartCoroutine(RemoveStain());
    }

    IEnumerator RemoveStain()
    {
        // �� ���� �ִϸ��̼� ����
        stainAnimator.SetTrigger("IsRemoveStain");
        // �ִϸ��̼� ��� �ð� ����
        yield return new WaitForSeconds(1f);
        // �� ����
        Destroy(mirrorStain.gameObject);
    }
}