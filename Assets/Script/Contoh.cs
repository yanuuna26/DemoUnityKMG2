using System;
using UnityEngine;

public class Contoh : MonoBehaviour
{
    Vector2 position1 = new Vector2(1, 1);
    int number1 = 5;
    int number2 = 7;
    int usia = 17;
    int money = 50000;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(Perkalian(54, 6, 34));
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Swap()
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

    void CinemaEntry()
    {
        Debug.Log("Usia : " + usia);
        Debug.Log("Uang : " + money);
        if (usia >= 18 || money >= 100000)
        {
            Debug.Log("Entry : ALLOWED ");
        }
        else
        {
            Debug.Log("Entry : PROHIBITED ");
        }
    }

    void Weapon(int id)
    {
        switch (id)
        {
            case 1:
                Debug.Log("Basic Sword");
                break;
            case 2:
                Debug.Log("Elektric Bow");
                break;
            case 3:
                Debug.Log("Fire Spell");
                break;
            default:
                Debug.Log("Undefined");
                break;
        }
    }
    
    int Perkalian(int a, int b, int c)
    {
        return a * b * c;
    }
}
