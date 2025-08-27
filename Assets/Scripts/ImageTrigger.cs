using UnityEngine;

public class ImageTrigger : MonoBehaviour
{
    [Tooltip("������ Image �� Canvas, ������� ����� ���������� � �����������.")]
    public GameObject fullScreenImage;

    private void OnTriggerEnter(Collider other)
    {
        // ���������, ��� � ������� ����� �����.
        if (other.CompareTag("Player"))
        {
            // �������� ��������.
            if (fullScreenImage != null)
            {
                fullScreenImage.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // ���������, ��� ����� ����� �� ��������.
        if (other.CompareTag("Player"))
        {
            // ��������� ��������.
            if (fullScreenImage != null)
            {
                fullScreenImage.SetActive(false);
            }
        }
    }
}