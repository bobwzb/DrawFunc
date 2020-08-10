using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class DrawLine : MonoBehaviour
{
    // Start is called before the first frame update
    public List<KeyValuePair<int, int>> lines;
    private LineRenderer lr;
    private int length;
    void Start()
    {
        lines = new List<KeyValuePair<int, int>>();
        lr = this.GetComponent<LineRenderer>();
        addPoint(0, 0);
        addPoint(1, 1);
        addPoint(3, 4);
        length = lines.Count;
        int idx = 0;
        while (idx < length)
        {
            lr.SetPosition(idx, new Vector3(lines[idx].Key, lines[idx].Value, 0));
            idx++;
        }
    }
    public void addPoint(int a,int b)
    {
        lines.Add(new KeyValuePair<int, int>(a, b));
    }
    [MenuItem("GameObject/DrawLine")]
    static void drawLine()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
