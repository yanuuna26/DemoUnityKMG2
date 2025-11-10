using UnityEngine;

public class Contoh : MonoBehaviour
{
    Vector2 position1 = new Vector2(1, 1);
    int number1 = 5;
    int number2 = 7;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(position1.x + " , " + position1.y);
        Debug.Log("Awal");
        Debug.Log("Number 1 : " + number1);
        Debug.Log("Number 2 : " + number2);
        Debug.Log("SWAP");
        int temp = number1;
        number1 = number2;
        number2 = temp;
        Debug.Log("Number 1 : " + number1);
        Debug.Log("Number 2 : " + number2);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
