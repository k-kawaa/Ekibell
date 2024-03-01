using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NAudio;
using NAudio.Wave;
using System.Net.Http.Headers;
using NAudio.Wave.SampleProviders;


namespace Dokobell
{
    public partial class Form1 : Form
    {
        private bool button = false;
        private bool tatikawa_announce = false;
        private string exepath;
        private string melodysettingpath = "";
        private string doorsettingpath = "";

        private int starttime_melody;
        private int endtime_melody;

        AudioFileReader reader;
        WaveOut waveout;
        WaveOut waveout_door;
        private ISampleProvider trimmed;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_off.Enabled = false;
            button_on.Enabled = true;
        }

        private void OpenSettingFileFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "設定ファイル(door.ini およびmelody.ini)が格納されているフォルダーを選択してください。" +
                "\n※どこベルご使用の方はどこべるのアプリケーションが格納されているフォルダー.。";
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                if(!File.Exists(fbd.SelectedPath + "\\melody.ini") || !File.Exists(fbd.SelectedPath + "\\door.ini"))
                {
                    MessageBox.Show("このフォルダーには設定ファイルが存在しません。", "エラー");
                    return;

                }
                exepath = fbd.SelectedPath;
                melodysettingpath = fbd.SelectedPath + "\\melody.ini";
                doorsettingpath = fbd.SelectedPath + "\\door.ini";

                Ini melo = new Ini(melodysettingpath);
                string[] sections_melody = melo.GetSections();
                bell_mero.Items.AddRange(sections_melody);

                Ini door = new Ini(doorsettingpath);
                string[] sections_door = door.GetSections();
                bell_door.Items.AddRange(sections_door);
                StatusText.Text = "";
            }
            else
            {
                MessageBox.Show("フォルダーの読み込みに失敗しました。","エラー");
            }
        }

        private void button_off_Click(object sender, EventArgs e)
        {
            if (button && doorsettingpath != "" & bell_door.Text != "")
            {
                Ini door = new Ini(doorsettingpath);
                string doorpath = door.GetValue("door_file", bell_door.Text);
                int.TryParse(door.GetValue("time_play_door", bell_door.Text), out int starttime_door);
                int.TryParse(door.GetValue("time_stop_door", bell_door.Text), out int endtime_door);
                var reader_door = new AudioFileReader(exepath + "\\" + doorpath);
                reader_door.CurrentTime = TimeSpan.FromMilliseconds(starttime_door);
                var trimmed_door = reader_door.Take(TimeSpan.FromMilliseconds(endtime_door - starttime_door));
                button = false;
                GC.Collect();

                //立川式放送モード
                if (radioButton_tatikawa.Checked)
                {
                    if (waveout_door == null)
                    {
                        waveout_door = new WaveOut();
                        waveout_door.Init(trimmed_door);
                        waveout_door.Play();
                    }
                    else
                    {
                        waveout_door.Stop();
                        waveout_door.Dispose();
                        waveout_door = new WaveOut();
                        waveout_door.Init(trimmed_door);
                        waveout_door.Play();
                    }
                    button_off.Enabled = false;
                    button_on.Enabled = true;
                    tatikawa_announce = true;
                }
                else
                {
                    waveout.Stop();
                    waveout.Dispose();
                    waveout = null;
                    reader.Dispose();
                    reader = null;
                    button = false;
                    button_off.Enabled = false;
                    button_on.Enabled = true;

                    if (waveout_door == null)
                    {
                        waveout_door = new WaveOut();
                        waveout_door.Init(trimmed_door);
                        waveout_door.Play();
                    }
                    else
                    {
                        waveout_door.Stop();
                        waveout_door.Dispose();
                        waveout_door = new WaveOut();
                        waveout_door.Init(trimmed_door);
                        waveout_door.Play();
                    }
                }

            }

        }

        private void button_on_Click(object sender, EventArgs e)
        {
            if (!button && melodysettingpath != "" & bell_mero.Text != "")
            {

                Ini melo = new Ini(melodysettingpath);
                string musicpath = melo.GetValue("melody_file", bell_mero.Text);
                int.TryParse(melo.GetValue("time_play_melody", bell_mero.Text), out starttime_melody);
                int.TryParse(melo.GetValue("time_stop_melody", bell_mero.Text), out endtime_melody);
                reader = new AudioFileReader(exepath + "\\" + musicpath);
                reader.CurrentTime= TimeSpan.FromMilliseconds(starttime_melody);
                trimmed = reader.Take(TimeSpan.FromMilliseconds(endtime_melody - starttime_melody));
                waveout = new WaveOut();
                waveout.Init(trimmed);
                waveout.PlaybackStopped += StopMelodyEvent;
                waveout.Play();
                button = true;
                button_off.Enabled = true;
                button_on.Enabled = false;
            }
        }

        private void StopMelodyEvent(object sender ,EventArgs e)
        {
            if (tatikawa_announce && !button)
            {
                waveout.Dispose();
                waveout = null;
                reader.Dispose();
                reader = null;
                tatikawa_announce = false;
                return;
            }
            waveout.Dispose();
            waveout = null;
            reader.Dispose();
            reader = null;
            Ini melo = new Ini(melodysettingpath);
            Ini door = new Ini(doorsettingpath);
            string musicpath = melo.GetValue("melody_file", bell_mero.Text);
            int.TryParse(melo.GetValue("time_play_melody", bell_mero.Text), out starttime_melody);
            int.TryParse(melo.GetValue("time_stop_melody", bell_mero.Text), out endtime_melody);
            reader = new AudioFileReader(exepath + "\\" + musicpath);
            reader.CurrentTime = TimeSpan.FromMilliseconds(starttime_melody);
            trimmed = reader.Take(TimeSpan.FromMilliseconds(endtime_melody - starttime_melody));
            waveout = new WaveOut();
            waveout.Init(trimmed);
            waveout.PlaybackStopped += StopMelodyEvent;
            waveout.Play();
        }

        void PlayDoorMelody()
        {
            Ini door = new Ini(doorsettingpath);
            string doorpath = door.GetValue("door_file", bell_door.Text);
            int.TryParse(door.GetValue("time_play_door", bell_door.Text), out int starttime_door);
            int.TryParse(door.GetValue("time_stop_door", bell_door.Text), out int endtime_door);
            var reader_door = new AudioFileReader(exepath + "\\" + doorpath);
            reader_door.CurrentTime = TimeSpan.FromMilliseconds(starttime_door);
            var trimmed_door = reader_door.Take(TimeSpan.FromMilliseconds(endtime_door - starttime_door));
            if (waveout_door == null)
            {
                if (radioButton_tatikawa.Checked) return;
                waveout_door = new WaveOut();
                waveout_door.Init(trimmed_door);
                waveout_door.Play();
            }
            else
            {
                waveout_door.Stop();
                waveout_door.Dispose();
                waveout_door = new WaveOut();
                waveout_door.Init(trimmed_door);
                waveout_door.Play();
            }
        }
    }
}
