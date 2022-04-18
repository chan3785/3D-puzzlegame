using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageData
{
    public int StageNum { set; get; }
    public string CategoryName { set; get; }
    public string ImageName { set; get; }
    public int DropColorCount { set; get; }
    public int EndingAnimationNum { set; get; }
    public StageData() { }
    public StageData(int stageNum, string categoryName, string imageName, int dropColorCount, int endingAnimationNum)
    {
        StageNum = stageNum;
        CategoryName = categoryName;
        ImageName = imageName;
        DropColorCount = dropColorCount;
        EndingAnimationNum = endingAnimationNum;
    }
}

/// <summary>
/// Resources 폴더의 csv 파일을 로드한다.
/// </summary>
public class CsvFileLoad
{
    public static void OnLoadCSV(string filename, List<StageData> stageDatas)
    {
        string file_path = "CSV/";
        file_path = string.Concat(file_path, filename);

        TextAsset ta = Resources.Load<TextAsset>(file_path);

        OnLoadTextAsset(ta.text, stageDatas);

        Resources.UnloadAsset(ta);
        ta = null;
    }

    static public void OnLoadTextAsset(string data, List<StageData> stagedatas)
    {
        string[] str_lines = data.Split('\n');

        for (int i = 1; i < str_lines.Length - 1; i++)
        {
            string[] values = str_lines[i].Split(',');

            StageData sd = new StageData();

            sd.StageNum = int.Parse(values[0]);
            sd.CategoryName = values[i];
            sd.ImageName = values[2];
            sd.DropColorCount = int.Parse(values[3]);
            sd.EndingAnimationNum = int.Parse(values[4]);

            stagedatas.Add(sd);
        }
    }
}
