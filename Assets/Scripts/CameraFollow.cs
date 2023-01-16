using UnityEditor;
using UnityEngine;
using UnityEngine.Animations;

public class CameraFollow : MonoBehaviour
{
    /* Topun pozisyonunu bulmak için Transform değişkeni oluşturuyoruz.
    inspector ekranından topa referans veriyoruz. */
    [SerializeField] private Transform target;

    //Topla kamera arasındaki mesafeyi tanımlayacağımız bir Vector 3 değişkeni oluşturuyoruz.
    private Vector3 offSet;

    /* Yumuşak hareket olması için Vector3.Lerp kullanacağız. 2 Nokta arasında yumuşak hareket için kullanılır
     Vector3.Lerp(başlangıç konumuV3, varış noktasıV3, float türünden varış süresi f ) ister
    takip hızını ve süresini belirtmek için bir float değeri oluşturacağız */
    [SerializeField] private float followSpeed = 5f;

    void Start()
    {
        offSet = CalculateOffSet(target); //aradaki değer = kameranın konumu - player'ın konumu
    }
    void FixedUpdate() // Kamera kasmasını düzeltmek için fixed update kullandık
    {
        MoveTheCamera();
    }
        
    private void MoveTheCamera()
    {
        if (target != null)
        {
            //Kameranın hareket edeceği konumu tanımlıyoruz
            //hareket edeceği konum = kameranın o anki konumu + oyuncuyla arasındaki mesafe
            Vector3 targetToMove = target.position + offSet;
            //Kamerayı hareket ettir = Mevcut konumundan, hareket etmesi gereken konuma, hız değişkeni * Time.deltaTime
            transform.position = Vector3.Lerp(transform.position, targetToMove, followSpeed * Time.deltaTime);
            //Kameranın topa bakmasını sağlamak için
            transform.LookAt(target.transform.position);
        }
    }

    private Vector3 CalculateOffSet(Transform newTarget)
    {
        return transform.position - newTarget.position;
    }
}