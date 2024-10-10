using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    private AudioSource audioSource;  // ����� �ҽ�
    public AudioClip openSound;      // �� ������ �Ҹ�
    public AudioClip closeSound;     // �� ������ �Ҹ�

    bool isOpen = false;
    Animator animator;

    private void Awake()
    {

        audioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
    }

    public void OpenCaseDoor()
    {
        if (isOpen == false)
        {
            animator.SetBool("isOpen", true);
            isOpen = true;
            // �� ������ �Ҹ� ���
            audioSource.PlayOneShot(openSound);
        }
        else
        {
            animator.SetBool("isOpen", false);
            isOpen = false;
            // �� ������ �Ҹ� ���
            audioSource.PlayOneShot(closeSound);
        }
    }
}