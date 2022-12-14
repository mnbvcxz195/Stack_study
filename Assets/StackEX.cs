using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackEX
{
    //현 스택에 데이터 개수 확인
    public int Count;
    public int[] arr;

    public StackEX(int size)
    {
        //size : 크기 만큼 배열 생성
        //int[] 생성
        arr = new int[size];
    }


    public void Push(int data)
    {
        if (Count < arr.Length)
        {
            arr[Count++] = data;
        }
        else if (Count >= arr.Length)
        {
            Array.Resize(ref arr, arr.Length ^ 2);
        }
    }

    public int Pop()
    {
        int num = 0;
        if (Count > 0)
        {
            num = arr[--Count];
        }
        else if (Count <= 0)
        {
            Debug.Log("Stack is Empty");
        }
        return num;
    }

    public void Clear()
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = 0;
        }
        Count = 0;
    }
}