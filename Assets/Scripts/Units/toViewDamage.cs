using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toViewDamage : MonoBehaviour
{
    public GameObject viewPanel;

    public void Init(int[] info, GameObject target)
    {
        viewPanel.GetComponent<ViewDamage>().toView(info,target);
    }
}
