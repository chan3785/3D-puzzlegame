using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageCell : MonoBehaviour
{
    [SerializeField] private Image sStageImage;

    [HideInInspector]
    public GameObject stageView;
    [HideInInspector]
    public Convert3D convert3D;

    [HideInInspector]
    public string categoryname;
    [HideInInspector]
    public string imagename;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void SetImage(Sprite sprite)
    {
        sStageImage.sprite = sprite;
    }

    public void OnClickCell()
    {
        /*
        convert3D.enabled = true;
        convert3D.PlayGame(categoryname,imagename);
        */
    }
}
