using UnityEngine;

public class GunControl : MonoBehaviour
{
    public Transform gunTransform; // ใส่ Transform ของปืนที่ต้องการหมุน
    public float rotationSpeed = 50f; // ความเร็วในการหมุน
    public float maxRotationX = 45f; // มุมสูงสุดในการยกปืนขึ้น
    public float minRotationX = -45f; // มุมต่ำสุดในการลดปืนลง

    void Update()
    {
        float rotationX = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            rotationX = rotationSpeed * Time.deltaTime; // ยกปืนขึ้นเมื่อกด W
        }
        if (Input.GetKey(KeyCode.S))
        {
            rotationX = -rotationSpeed * Time.deltaTime; // ลดปืนลงเมื่อกด S
        }

        // คำนวณมุมการหมุนปัจจุบัน
        float currentXRotation = gunTransform.localEulerAngles.x;
        if (currentXRotation > 180f) currentXRotation -= 360f;

        // จำกัดมุมการหมุน
        float newRotationX = Mathf.Clamp(currentXRotation + rotationX, minRotationX, maxRotationX);

        // หมุนปืน
        gunTransform.localEulerAngles = new Vector3(newRotationX, gunTransform.localEulerAngles.y, gunTransform.localEulerAngles.z);
    }
}
