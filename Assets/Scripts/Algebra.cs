using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject Target1;
    public GameObject Target2;

    void Start()
    {

        Debug.Log("Esto se realiza 1 vez");
        Vector3 norm = Normalizar(Target1.transform.position);
        Debug.Log(norm);
        Debug.Log(ProductoPunto(Target1.transform.position, Target2.transform.position));
        Vector3 res = Cruz(Target1.transform.position, Target2.transform.position);
        Debug.Log(res);
    }
    void Update()
    {
        Distance(Target1.transform.position, Target2.transform.position);
    }

    public float Distance(Vector3 pos1, Vector3 pos2)
    {
        float x = pos1.x - pos2.x;
        float y = pos1.y - pos2.y;
        float z = pos1.z - pos2.z;

        float x2 = x * x;
        float y2 = y * y;
        float z2 = z * z;

        float sum = x2 + y2 + z2;
        float sqrt = Mathf.Sqrt(sum);

        return sqrt;

    }
    public Vector3 Normalizar(Vector3 pos)
    {

        float x = pos.x * pos.x;
        float y = pos.y * pos.y;
        float z = pos.z * pos.z;

        float sum = x + y + z;

        float sqrt = Mathf.Sqrt(sum);

        float xN = pos.x / sqrt;
        float yN = pos.y / sqrt;
        float zN = pos.z / sqrt;

        Vector3 norm = new Vector3(xN, yN, zN);
        return norm;
    }

    public float ProductoPunto(Vector3 pos1, Vector3 pos2)
    {
       float x = pos1.x * pos2.x;
       float y = pos1.y * pos2.y;  
       float z = pos1.z * pos2.z;

       float mult = x + y + z;
       return mult;
        
    }
    public Vector3 Cruz(Vector3 pos1, Vector3 pos2)
    {


        float prim  = (pos1.y * pos2.z) - (pos1.z * pos2.y);
        float segun = (pos1.z * pos2.x) - (pos1.x * pos2.z);
        float terce = (pos1.x * pos2.y) - (pos1.y * pos2.x);
        Vector3 res = new Vector3(prim, segun, terce);
        return res;
    }


    // Update is called once per frame

}
