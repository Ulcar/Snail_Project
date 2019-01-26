using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

[CreateAssetMenu(menuName = "GenericDataList")]
public  class GenericDataList:ScriptableObject
    {
   public List<GenericData> dataList = new List<GenericData>();
    }
