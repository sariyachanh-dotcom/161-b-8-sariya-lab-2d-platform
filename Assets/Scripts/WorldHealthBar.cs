/*using UnityEngine;
using UnityEngine.UI;

public class WorldHealthBar : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private Character target; //ตัวละครที่ Health Bar
    [SerializeField] private Vector3 offset = new Vector3(0, 2f, 0);

    private Camera mainCam;

    void Start()
    {
        mainCam = Camera.main;
        if (target != null)
        {
            slider.maxValue = target.Health;
            slider.value = target.Health;
        }
    }

    void Update()
    {
        if (target == null) return;

        //อัปเดตค่าเลือด
        slider.value = target.Health;

        //หมุนตามกล้องหันเข้าหน้าผู้เล่น
        transform.rotation = Quaternion.LookRotation(transform.position - mainCam.transform.position);

        //ติดหัวตัวละคร
        transform.position = target.transform.position + offset;
    }
}
*/