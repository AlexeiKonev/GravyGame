//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class School : MonoBehaviour
//{
//  public  Gopnik gop  = new Gopnik();
//  public  Botanik botan  = new Botanik();
   
//    void SetParametrs()
//    {
//        botan.name = "�������";
//        gop.name = "������";
//        botan.coursesCount = 4;
//        gop.coursesCount = 1;
        
//    }

//    private void Start()
//    {
//        SetParametrs();
//        Debug.Log(botan.ShowInfo());
//        Debug.Log(botan.ShowInfo());
//        Debug.Log( gop.ShowInfo(1));
//        Debug.Log(gop.ShowInfo());


//    }
//}
//[Serializable]
//public class Student
//{
//    public string name = "������";
//    public int age;
//    public int coursesCount;
//    public string ShowInfo( )
//    {
//        return $"� {name} ���������� ������ �����: {coursesCount }";
//    }
//    public string ShowInfo(int info)
//    {
//        return $"� {name} ���������� ������ �����: {coursesCount-info}";
//    }
//    public int Calculater(int curent)
//    {
//        return coursesCount-curent;
//    }
//}


////public class Gopnik: Student
////{
   
////}
////[Serializable]
////public class Botanik: Student
////{
    
////}

