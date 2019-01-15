using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;

public class TextFile : MonoBehaviour
{
    public TextAsset Textfile;
    public string[] textLine;
    public int amount;
    public void Start()
    {
        
        if(Textfile != null)
        {
            textLine = (Textfile.text.Split('\n'));
            
            
            
        }
        
    }
}