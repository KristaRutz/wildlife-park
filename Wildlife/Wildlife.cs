using System;

namespace WildlifePark.Wildlife
{
  public class Animal
  {
    private string _name;
    private int _age;
    private int _id;
    private int _currentID = 0;

    public Animal(string name, int age)
    {
      _name = name;
      _age = age;
    }

    public void SetID()
    {
      _currentID ++;
      _id = _currentID;
    }

    public string GetName()
    {
      return _name;
    }

    public int GetAge()
    {
      return _age;
    }

    public int GetID()
    {
      return _id;
    }
  }
}