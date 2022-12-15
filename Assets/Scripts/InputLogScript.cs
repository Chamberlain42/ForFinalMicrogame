using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InputLogScript : MonoBehaviour
{
    public string ToRecord = "";
    public TMP_Text InputRecord;

    private void Update()
    {
        InputRecord.text = ToRecord;
    }

}
