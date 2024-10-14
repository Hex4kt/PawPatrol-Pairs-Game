using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using System.IO;

public class SoundManager
{
    private string _filePath;
    private SoundPlayer _wavPlayer;
    private SoundPlayer _mp3Player;
    private string _appPath = Application.StartupPath;

    public SoundManager(string filePath)
    {
        if (filePath == "Goal")
            _filePath = Path.Combine(_appPath, "Sounds", "goal.wav");
        if (filePath == "Win")
            _filePath = Path.Combine(_appPath, "Sounds", "levelWin.wav");
        if (filePath == "Wrong")
            _filePath = Path.Combine(_appPath, "Sounds", "wrong.wav");

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
