using System;

public class Solution {
    public string solution(string video_len, string pos, string op_start, string op_end, string[] commands) {
            Video video = new Video(video_len, pos, op_start, op_end, commands);
            video.PlayCommand();
            return video.Result;
}
public class Video
{
    private MyTime video_len;
    private MyTime pos;
    private MyTime op_start;
    private MyTime op_end;
    private string[] commands;
    public string Result { get => pos.Result; }
    public Video(string video_len, string pos, string op_start, string op_end, string[] commands)
    {
        this.video_len = MyTime.SplitTime(video_len);
        this.pos = MyTime.SplitTime(pos);
        this.op_start = MyTime.SplitTime(op_start);
        this.op_end = MyTime.SplitTime(op_end);
        this.commands = commands;
    }
    public void PlayCommand()
    {
        foreach (string command in commands)
        {
            CheckOpening();
            switch (command)
            {
                case "next":
                    ApplyTime(10);
                    break;
                case "prev":
                    ApplyTime(-10);
                    break;
            }
            CheckOpening();
        }
    }
    public void CheckOpening()
    {
        if(op_start.TotalSeconds <= pos.TotalSeconds && pos.TotalSeconds <= op_end.TotalSeconds)
        {
            pos.SetMS(op_end.m, op_end.s);
        }
    }
    public void ApplyTime(int seconds)
    {
        pos.AddTime(seconds);
        if (pos.TotalSeconds < 0)
            pos.SetMS(0, 0);
        else if (pos.TotalSeconds > video_len.TotalSeconds)
            pos.SetMS(video_len.m, video_len.s);
    }
}
public class MyTime
{
    public int m;
    public int s;
    private int totalSeconds;
    public int TotalSeconds { get => totalSeconds; }
    public string Result { get => new string($"{m:D2}:{s:D2}");}
    public MyTime(int m, int s)
    {
        SetMS(m, s);
    }
    public static MyTime SplitTime(string time)
    {
        string[] arr = time.Split(new char[] { ':' }, StringSplitOptions.None);
        int m = int.Parse(arr[0]);
        int s = int.Parse(arr[1]);
        return new MyTime(m, s);
    }
    public void SetMS(int m, int s)
    {
        this.m = m;
        this.s = s;
        this.totalSeconds = m * 60 + s;
    }
    public void AddTime(int seconds)
    {
        totalSeconds += seconds;
        SetMS(totalSeconds / 60, totalSeconds % 60);
    }
}
}