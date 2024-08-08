using UnityEngine;

public class CharacterRotation : MonoBehaviour
{
    public float rotationSpeed = 100f; // ความเร็วในการหมุน

    void Update()
    {
        float rotation = 0f;

        if (Input.GetKey(KeyCode.A))
        {
            rotation = -rotationSpeed * Time.deltaTime; // หมุนทวนเข็มนาฬิกาเมื่อกดปุ่ม A
        }
        if (Input.GetKey(KeyCode.D))
        {
            rotation = rotationSpeed * Time.deltaTime; // หมุนตามเข็มนาฬิกาเมื่อกดปุ่ม D
        }

        transform.Rotate(0, rotation, 0); // หมุนตัวละครตามแกน Y
    }
}
