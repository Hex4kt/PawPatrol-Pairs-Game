using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

public class SoundManager
{
    private string _filePath;
    private SoundPlayer _wavPlayer;
    private SoundPlayer _mp3Player;

    public SoundManager(string filePath)
    {
        if (filePath == "Goal")
            _filePath = "D:\\Repos\\Tutorials\\VergleichsSpiel\\Sounds\\goal.wav";
        if (filePath == "Win")
            _filePath = "D:\\Repos\\Tutorials\\VergleichsSpiel\\Sounds\\levelWin.wav";
        if (filePath == "Wrong")
            _filePath = "D:\\Repos\\Tutorials\\VergleichsSpiel\\Sounds\\wrong.wav";

        try
        {
            _wavPlayer = new SoundPlayer(_filePath);
        }
        catch (Exception)
        {
            throw new ArgumentException("Dateityp wird nicht unterstützt. Nur .wav Dateiformat.");
        }
    }

    public void Play()
    {
        _wavPlayer.Play();
    }
}
