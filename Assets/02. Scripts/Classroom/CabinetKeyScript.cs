using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CabinetKeyScript : MonoBehaviour
{
    private Animator animator;
    private XRGrabInteractable grabInteractable;

    void Start()
    {
        // Animator ������Ʈ�� XRGrabInteractable ������Ʈ�� ������
        animator = GetComponentInParent<Animator>();
        grabInteractable = GetComponent<XRGrabInteractable>();

        // ��ü�� ���� �� ȣ��Ǵ� �̺�Ʈ ����
        grabInteractable.selectEntered.AddListener(OnGrabbed);
    }

    // ��ü�� ������ �� ȣ��Ǵ� �Լ�
    private void OnGrabbed(SelectEnterEventArgs args)
    {
        if (animator != null)
        {
            animator.enabled = false;  // Animator ��Ȱ��ȭ
            Debug.Log("������Ʈ�� �׷��Ǿ����ϴ�. �ִϸ��̼��� ��Ȱ��ȭ�մϴ�.");
        }
    }
}
