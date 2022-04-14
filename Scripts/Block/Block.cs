using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] private GameObject _sEdge;
    [SerializeField] private TextMesh _sNumberText;

    public Color OriginColor { set; get; }
    public int BlockNumber { set; get; }
    public int col { set; get; }
    public int row { set; get; }

    public Vector3 OriginPosition { set; get; }
    public Vector3 OriginScale { set; get; }

    private const float CHECKPOSITIONRANGE = 0.1f;

    public string NumberText
    {
        set
        {
            BlockNumber = int.Parse(value);
            _sNumberText.text = value;
        }
        get
        {
            return _sNumberText.text;
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    public bool CheckMatchPosition(GameObject target)
    {
        if ((OriginPosition.x - CHECKPOSITIONRANGE) < target.transform.position.x &&
            (OriginPosition.x + CHECKPOSITIONRANGE) > target.transform.position.x &&
            (OriginPosition.y - CHECKPOSITIONRANGE) < target.transform.position.y &&
            (OriginPosition.y + CHECKPOSITIONRANGE) > target.transform.position.y)
        {
            return true;
        }
        return false;
    }


    public bool CheckMatchColor(GameObject target)
    {
        if (OriginColor == target.GetComponent<Block>().OriginColor)
        {
            return true;
        }
        return false;
    }

    public void ShowOnOffNumberText(bool onOff)
    {
        _sNumberText.gameObject.SetActive(onOff);
        _sEdge.SetActive(false);
    }

    public void SetNumberTextColor(Color color)
    {
        _sNumberText.color = color;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
