using UnityEngine;
using System.Collections;


public class Float : MonoBehaviour
{


    public float radian = 0; // 弧度  
    public float perRadian = 1.2f; // 每次变化的弧度  
    public float radius = 2f; // 半径  
    public bool _x轴变化 = true;
    Vector3 oldPos; // 开始时候的坐标  


    void Start()
    {
        oldPos = transform.localPosition; // 将最初的位置保存到oldPos  
    }


    void Update()
    {
        radian += perRadian; // 弧度每次加0.03 
        float dx = Mathf.Sin(radian) * radius;
        float dy = Mathf.Cos(radian) * radius; // dy定义的是针对y轴的变量，也可以使用sin，找到一个适合的值就可以
        if (_x轴变化)
        {
            transform.localPosition = oldPos + new Vector3(dx, dy, 0);
        }
        else
        {
            transform.localPosition = oldPos + new Vector3(0, dy, 0);
        }
    }
}