using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class counter_valum : MonoBehaviour
{
    private int counter = 0;
    [SerializeField] private TMPro.TextMeshPro counterText;
    public int reset_value = 9999;
    private bool is_counting = false;
    private float timer = 0f; // ������ ��� ������������ �������
    [SerializeField] private float interval = 3f; // �������� � ��������

    private void Update()
    {
        timer += Time.deltaTime; // ����������� ������ �� �����, ��������� � ���������� �����

        if (timer >= interval) // ���������, ������ �� ������ ��������� ���������
        {
            timer = 0f; // ���������� ������
            if (is_counting == true)              
                    counter++;            
            else            
                counter = 0;
            if (counter == reset_value)
                counter = 0;
            counterText.text = counter.ToString("D4"); // 0000    
        }        
    }

    public void STOP_COUNTING() => is_counting = false;
    public void START_COUNTING() => is_counting = true;
}
