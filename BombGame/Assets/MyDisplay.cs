using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyDisplay {

    private string displayText;

    public void ShowRandonmOrder(int[] randomOrder, int size)
    {
        for (int i = 0; i < size; i++)
        {
            displayText += randomOrder[i].ToString();
        }
        GameObject.Find("Display/Text").GetComponent<TextMesh>().text = displayText;
    }
}
