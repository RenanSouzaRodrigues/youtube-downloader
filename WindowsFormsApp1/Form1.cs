using MediaToolkit;
using MediaToolkit.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void OpenFolderDialogueButton_Click(object sender, EventArgs e)
        {
            string folder = GetFolderFromDialogue();
            if (string.IsNullOrEmpty(folder))
            {
                ShowWarning("Select a folder to save your downloaded file", "Error");
                return;
            }
            SavePathTextInput.Text = folder;
        }

        private async void DowloadMp3Button_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateYoutubeLink();
                ValidateFileName();
                ShowProgressDescriptionAndProgressBar();
                await DownloadYouTubeMP3();
                UpdateProgressBar(100);
                UpdateProgressLabel("Done!");
            }
            catch (Exception ex)
            {
                HideProgressDescriptionAndProgressBar();
                ShowWarning(ex.Message, "Error");
            }
        }

        private async void DownloadVideoButton_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateYoutubeLink();
                ValidateFileName();
                ShowProgressDescriptionAndProgressBar();
                await DownloadYouTubeVideo();
                UpdateProgressBar(100);
                UpdateProgressLabel("Done!");
            }
            catch (Exception ex)
            {
                HideProgressDescriptionAndProgressBar();
                ShowWarning(ex.Message, "Error");
            }
        }

        private string GetFolderFromDialogue()
        {
            if (FolderBrowser.ShowDialog() == DialogResult.OK)
            {
                return FolderBrowser.SelectedPath;
            }
            return string.Empty;
        }

        private void ValidateYoutubeLink()
        {
            if (string.IsNullOrEmpty(YoutubeLinkTextInput.Text))
                throw new Exception("Youtube link cannot be empty!");
        }

        private void ValidateFileName()
        {
            if (string.IsNullOrEmpty(FileNameTextInput.Text))
                throw new Exception("File name cannot be empty!");
        }

        private void ShowWarning(string message, string caption) => 
            MessageBox.Show($"Warning: {message}", caption, MessageBoxButtons.OK);

        private void ShowProgressDescriptionAndProgressBar()
        {
            ProcessLabel.Visible = true;
            ProcessProgressBar.Visible = true;
        }

        private void HideProgressDescriptionAndProgressBar()
        {
            ProcessProgressBar.Visible = false;
            ProcessLabel.Visible = false;
        }

        private void UpdateProgressBar(int percentage) => ProcessProgressBar.Value = percentage;

        private void UpdateProgressLabel(string process) => ProcessLabel.Text = process;

        private async Task<string> DownloadYouTubeVideo()
        {
            var videoUrl = YoutubeLinkTextInput.Text;

            UpdateProgressLabel("Building the client");
            UpdateProgressBar(5);

            var youtube = new YoutubeClient();

            UpdateProgressLabel("Locating video");
            UpdateProgressBar(15);
            var video = await youtube.Videos.GetAsync(videoUrl);

            UpdateProgressLabel("Searching for available streams");
            UpdateProgressBar(25);
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(video.Id);
            var muxedStreams = streamManifest.GetMuxedStreams().OrderByDescending(s => s.VideoQuality).ToList();

            UpdateProgressLabel("Validating Stream");
            UpdateProgressBar(35);

            if (muxedStreams.Count <= 0) 
                throw new Exception($"No suitable video stream found for {video.Title}.");

            var streamInfo = muxedStreams.First();

            UpdateProgressLabel("Downloading stream content");
            UpdateProgressBar(50);

            var httpClient = new HttpClient();
            var stream = await httpClient.GetStreamAsync(streamInfo.Url);

            var outputDirectory = SavePathTextInput.Text;
            var videoTitle = FileNameTextInput.Text;

            UpdateProgressLabel("Building file");
            UpdateProgressBar(80);

            string outputFilePath = Path.Combine(outputDirectory, $"{videoTitle}.{streamInfo.Container}");
            var outputStream = File.Create(outputFilePath);
            await stream.CopyToAsync(outputStream);

            UpdateProgressLabel("Cleaning process memory");
            UpdateProgressBar(90);

            httpClient.Dispose();
            outputStream.Close();

            return outputFilePath;
        }

        private async Task DownloadYouTubeMP3()
        {
            var outputDirectory = SavePathTextInput.Text;
            var fileName = FileNameTextInput.Text;

            string outputVideo = await DownloadYouTubeVideo();

            var inputFile = new MediaFile { Filename = outputVideo };
            var outputFile = new MediaFile { Filename = Path.Combine(outputDirectory, $"{fileName}.mp3") };

            using (var engine = new Engine())
            {
                UpdateProgressLabel("Converting file to MP3");
                UpdateProgressBar(95);

                engine.GetMetadata(inputFile);
                engine.Convert(inputFile, outputFile);
            }

            File.Delete(outputVideo);
        }
    }
}
