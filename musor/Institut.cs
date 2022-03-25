using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Institut : MonoBehaviour
{
    [SerializeField] List<Student> studentList=new List<Student>();
    private void Start()
    {
        foreach (Student s in studentList) 
        {
            Debug.Log( s.ShowInfo() );
        }
    }
}
[Serializable]
public class Student 
{
    public string name = "вася";
     
    public int age = 10;

    public string ShowInfo() 
    {
        return $"студент {name} возвраст {age}";
    }
}
