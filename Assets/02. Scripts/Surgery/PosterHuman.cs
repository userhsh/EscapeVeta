using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosterHuman : MonoBehaviour, IInteractable
{
    // SlidePuzzle ���� ���� ����
    SlidePuzzle slidePuzzle = null;

    private void Awake()
    {
        PosterHumanInit();
    }

    private void Update()
    {
        PuzzleClear();
    }

    // ��ü������ Init �޼���
    private void PosterHumanInit()
    {
        // �����̵� ���� ��������
        slidePuzzle = GetComponentInChildren<SlidePuzzle>();
        // �����̵� ���� ���α�
        slidePuzzle.gameObject.SetActive(false);
    }

    public void Interact()
    {
        // Slide Puzzle �ѱ�
        slidePuzzle.gameObject.SetActive(true);
    }

    // ���� �Ϸ� �� ��ü������ ���� �޼���
    private void PuzzleClear()
    {
        // ������ Ŭ���� �Ǿ��ٸ�
        if (slidePuzzle.Board.IsPuzzleClear) 
        {
            // ��ü������, ���� ����
            Destroy(this.gameObject);
        }
    }

    // X ��ư���� �����̵� ���� off �޼���
    private void OffSlidePuzzle()
    {
        slidePuzzle?.gameObject.SetActive(false);
    }
}