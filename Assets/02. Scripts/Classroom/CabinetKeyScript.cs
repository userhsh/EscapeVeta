using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CabinetKeyScript : MonoBehaviour
{
    private Animator animator;
    private XRGrabInteractable grabInteractable;
    private Rigidbody rb;

    void Start()
    {
        // Animator ������Ʈ�� XRGrabInteractable ������Ʈ�� ������
        animator = GetComponentInParent<Animator>();
        grabInteractable = GetComponent<XRGrabInteractable>();

        // ��ü�� ���� �� ȣ��Ǵ� �̺�Ʈ ����
        grabInteractable.selectEntered.AddListener(OnGrabbed);
        grabInteractable.selectExited.AddListener(OnRelease);

        rb = GetComponent<Rigidbody>();  
    }

    // ��ü�� ������ �� ȣ��Ǵ� �Լ�
    private void OnGrabbed(SelectEnterEventArgs args)
    {
        if (animator != null)
        {
            Debug.Log("������Ʈ�� �׷��Ǿ����ϴ�. �ִϸ��̼��� ��Ȱ��ȭ�մϴ�.");
            animator.enabled = false;  // Animator ��Ȱ��ȭ
        }
    }

    // ������Ʈ�� ������ �� ȣ��Ǵ� �Լ�
    private void OnRelease(SelectExitEventArgs args)
    {
        // �߷� Ȱ��ȭ
        rb.useGravity = true;
        rb.isKinematic = false;  // ������ �� �ٽ� ���� ��ȣ�ۿ� Ȱ��ȭ
    }
}
