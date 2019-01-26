using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public abstract class GenericData<F> : GenericData
{
    public GenericData()
    {
        type = typeof(F);
    }



    public override void DoEffect<T>(T value, T value2)
    {
        base.DoEffect(value, value2);

    }







}



public abstract class GenericData : ScriptableObject
{
   public Type type;

    public virtual void DoEffect<T>()
    {

    }

    public virtual void DoEffect<T>(T value, T value2)
    {

    }


    public GenericData() { }



}


public interface  iGenericData<T>
{
    void DoEffect(ref T value);



}



