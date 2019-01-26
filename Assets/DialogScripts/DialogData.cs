using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
[CreateAssetMenu(menuName ="DialogData")]
public class DialogData:GenericData<TMP_Text>
    {
    public string dialogLine;
    public string speaker;
    public AudioClip audio;

    public override void DoEffect<T>(T value, T value2)
    {
        TMP_Text textValue = value as TMP_Text;
       TMP_Text speakerValue = value2 as TMP_Text;
        textValue.text = dialogLine;
        speakerValue.text = speaker;
      //  value2.PlayOneShot(audio);
    }


}
