/*****************************************************************************
// File Name :         Fruit.cs
// Author :            Lynette Fernandes
// Creation Date :     1/25/24
//
// Brief Description : Fruit class that contains info (name, weight and color)
                        of the fruit
*****************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit
{
    public string name;
    public string color;
    public float weight;

    /// <summary>
    /// Constructor for fruit class that takes 3 parameters
    /// </summary>
    /// <param name="name">name of fruit</param>
    /// <param name="c"></param>
    /// <param name="w"></param>
    public Fruit(string name, string c, float w)
    {
        this.name = name;
        color = c;
        weight = w;
    }

    public Fruit()
    {
        name = "banana";
        color = "blue";
        weight = 3.7f;
    }

    public Fruit(string name)
    {
        this.name = name;
        color = "red";
        weight = 1.0f;
    }

    public Fruit(float weight)
    {
        name = "watermelon";
        color = "white";
        this.weight = weight;
    }

    ~Fruit()
    {
        //write to a file
        name = "";
        weight = 0f;
        color = "clear";
    }
}
