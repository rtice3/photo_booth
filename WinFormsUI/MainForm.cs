using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Text;
using System.Collections.Generic;
using EDSDKLib;

namespace WinFormsUI
{
    public partial class MainForm : Form
    {
        #region Variables

        SDKHandler CameraHandler;
        List<int> AvList;
        List<int> TvList;
        List<int> ISOList;
        List<Camera> CamList;
        Bitmap Evf_Bmp;
        int LVBw, LVBh, w, h;
        float LVBratio, LVration;

        int ErrCount;
        object ErrLock = new object();

        bool live_view;
        bool camera_connected;
        Color color_saver;

        #endregion

        public MainForm()
        {
            try
            {
                InitializeComponent();
                this.accept_btn.Enabled = false;
                this.reject_btn.Enabled = false;
                this.TakePhotoButton.Enabled = false;
                this.RecordVideoButton.Enabled = false;
                CameraHandler = new SDKHandler();
                CameraHandler.CameraAdded += new SDKHandler.CameraAddedHandler(SDK_CameraAdded);
                CameraHandler.LiveViewUpdated += new SDKHandler.StreamUpdate(SDK_LiveViewUpdated);
                CameraHandler.ProgressChanged += new SDKHandler.ProgressHandler(SDK_ProgressChanged);
                CameraHandler.ImageDownloaded += new SDKHandler.BitmapUpdate(SDK_ImageDownloaded);
                CameraHandler.CameraHasShutdown += SDK_CameraHasShutdown;
                SavePathTextBox.Text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "RemotePhoto");
                LVBw = LiveViewPicBox.Width;
                LVBh = LiveViewPicBox.Height;
                RefreshCamera();
                camera_connected = false;
            }
            catch (DllNotFoundException) { ReportError("Canon DLLs not found!", true); }
            catch (Exception ex) { ReportError(ex.Message, true); }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try { if (CameraHandler != null) CameraHandler.Dispose(); }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        #region SDK Events

        private void SDK_ProgressChanged(int Progress)
        {
            try
            {
                if (Progress == 100) Progress = 0;
                this.Invoke((Action)delegate { MainProgressBar.Value = Progress; });
            }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        private void SDK_LiveViewUpdated(Stream img)
        {
            try
            {
                Evf_Bmp = new Bitmap(img);
                using (Graphics g = LiveViewPicBox.CreateGraphics())
                {
                    LVBratio = LVBw / (float)LVBh;
                    LVration = Evf_Bmp.Width / (float)Evf_Bmp.Height;
                    if (LVBratio < LVration)
                    {
                        w = LVBw;
                        h = (int)(LVBw / LVration);
                    }
                    else
                    {
                        w = (int)(LVBh * LVration);
                        h = LVBh;
                    }
                    g.DrawImage(Evf_Bmp, 0, 0, w, h);
                }
                Evf_Bmp.Dispose();
            }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        private void SDK_ImageDownloaded(Bitmap bmp)
        {
            try
            {
                if (this.text_length(this.serial_number) == 12)
                {
                    if (CameraHandler.IsLiveViewOn)
                    {
                        CameraHandler.StopLiveView();
                    }

                    control_enable(this.LiveViewButton, false);
                    control_enable(this.accept_btn, true);
                    control_enable(this.reject_btn, true);

                    this.LiveViewPicBox.Image = bmp;
                }
            }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        private void SDK_CameraAdded()
        {
            try { RefreshCamera(); }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        private void SDK_CameraHasShutdown(object sender, EventArgs e)
        {
            try { CloseSession(); }
            catch (Exception ex) { ReportError(ex.Message, false); }

        }

        #endregion

        #region Session

        private void SessionButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CameraHandler.CameraSessionOpen)
                {
                    CloseSession();
          //          this.TakePhotoButton.Enabled = false;
                }
                else
                {
                    OpenSession();
         //           this.TakePhotoButton.Enabled = true;
                }
            }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            try { RefreshCamera(); }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        #endregion

        #region Settings

        private void TakePhotoButton_Click(object sender, EventArgs e)
        {
            if (camera_connected)
            {
                try
                {
                    if ((string)TvCoBox.SelectedItem == "Bulb")
                        CameraHandler.TakePhoto((uint)BulbUpDo.Value);
                    else
                        CameraHandler.TakePhoto();
                }
                catch (Exception ex) { ReportError(ex.Message, false); }
            }     
        }

        private void RecordVideoButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CameraHandler.IsFilming)
                {
                    if (STComputerButton.Checked || STBothButton.Checked)
                    {
                        Directory.CreateDirectory(SavePathTextBox.Text);
                        CameraHandler.StartFilming(SavePathTextBox.Text);
                    }
                    else CameraHandler.StartFilming();
                    RecordVideoButton.Text = "Stop Video";
                }
                else
                {
                    CameraHandler.StopFilming();
                    RecordVideoButton.Text = "Record Video";
                }
            }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(SavePathTextBox.Text)) SaveFolderBrowser.SelectedPath = SavePathTextBox.Text;
                if (SaveFolderBrowser.ShowDialog() == DialogResult.OK)
                {
                    SavePathTextBox.Text = SaveFolderBrowser.SelectedPath;
                    CameraHandler.ImageSaveDirectory = SavePathTextBox.Text;
                }
            }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        private void AvCoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try 
            { 
                CameraHandler.SetSetting(EDSDK.PropID_Av, CameraValues.AV((string)AvCoBox.SelectedItem)); 
            }
            catch (Exception ex) 
            { 
                ReportError(ex.Message, false); 
            }
            this.serial_lost_focus(this.serial_number, EventArgs.Empty);
        }

        private void TvCoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CameraHandler.SetSetting(EDSDK.PropID_Tv, CameraValues.TV((string)TvCoBox.SelectedItem));
                if ((string)TvCoBox.SelectedItem == "Bulb") BulbUpDo.Enabled = true;
                else BulbUpDo.Enabled = false;
            }
            catch (Exception ex) 
            { 
                ReportError(ex.Message, false); 
            }
            this.serial_lost_focus(this.serial_number, EventArgs.Empty);
        }

        private void ISOCoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { CameraHandler.SetSetting(EDSDK.PropID_ISOSpeed, CameraValues.ISO((string)ISOCoBox.SelectedItem)); }
            catch (Exception ex) { ReportError(ex.Message, false); }
            this.serial_lost_focus(this.serial_number, EventArgs.Empty);
        }

        private void WBCoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (WBCoBox.SelectedIndex)
                {
                    case 0: CameraHandler.SetSetting(EDSDK.PropID_WhiteBalance, EDSDK.WhiteBalance_Auto); break;
                    case 1: CameraHandler.SetSetting(EDSDK.PropID_WhiteBalance, EDSDK.WhiteBalance_Daylight); break;
                    case 2: CameraHandler.SetSetting(EDSDK.PropID_WhiteBalance, EDSDK.WhiteBalance_Cloudy); break;
                    case 3: CameraHandler.SetSetting(EDSDK.PropID_WhiteBalance, EDSDK.WhiteBalance_Tangsten); break;
                    case 4: CameraHandler.SetSetting(EDSDK.PropID_WhiteBalance, EDSDK.WhiteBalance_Fluorescent); break;
                    case 5: CameraHandler.SetSetting(EDSDK.PropID_WhiteBalance, EDSDK.WhiteBalance_Strobe); break;
                    case 6: CameraHandler.SetSetting(EDSDK.PropID_WhiteBalance, EDSDK.WhiteBalance_WhitePaper); break;
                    case 7: CameraHandler.SetSetting(EDSDK.PropID_WhiteBalance, EDSDK.WhiteBalance_Shade); break;
                }
            }
            catch (Exception ex) { ReportError(ex.Message, false); }
            this.serial_lost_focus(this.serial_number, EventArgs.Empty);
        }

        private void SaveToButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (STCameraButton.Checked)
                {
                    CameraHandler.SetSetting(EDSDK.PropID_SaveTo, (uint)EDSDK.EdsSaveTo.Camera);
                    BrowseButton.Enabled = false;
                    SavePathTextBox.Enabled = false;
                }
                else
                {
                    if (STComputerButton.Checked) CameraHandler.SetSetting(EDSDK.PropID_SaveTo, (uint)EDSDK.EdsSaveTo.Host);
                    else if (STBothButton.Checked) CameraHandler.SetSetting(EDSDK.PropID_SaveTo, (uint)EDSDK.EdsSaveTo.Both);
                    CameraHandler.SetCapacity();
                    BrowseButton.Enabled = true;
                    SavePathTextBox.Enabled = true;
                    Directory.CreateDirectory(SavePathTextBox.Text);
                    CameraHandler.ImageSaveDirectory = SavePathTextBox.Text;
                }
            }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        #endregion

        #region Live view

        private void LiveViewButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CameraHandler.IsLiveViewOn) 
                { 
                    CameraHandler.StartLiveView(); 
                    LiveViewButton.Text = "Stop LV";
                    this.live_view = true;
                }
                else 
                { 
                    CameraHandler.StopLiveView(); 
                    LiveViewButton.Text = "Start LV";
                    this.LiveViewPicBox.Image = null;
                  //  this.LiveViewPicBox.Invalidate();
                    live_view = false;
                }
            }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        private void LiveViewPicBox_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (CameraHandler.IsLiveViewOn && CameraHandler.IsCoordSystemSet)
                {
                    ushort x = (ushort)((e.X / (double)LiveViewPicBox.Width) * CameraHandler.Evf_CoordinateSystem.width);
                    ushort y = (ushort)((e.Y / (double)LiveViewPicBox.Height) * CameraHandler.Evf_CoordinateSystem.height);
                    CameraHandler.SetManualWBEvf(x, y);
                }
            }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        private void LiveViewPicBox_SizeChanged(object sender, EventArgs e)
        {
            try
            {
                LVBw = LiveViewPicBox.Width;
                LVBh = LiveViewPicBox.Height;
            }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        private void FocusNear3Button_Click(object sender, EventArgs e)
        {
            try { CameraHandler.SetFocus(EDSDK.EvfDriveLens_Near3); }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        private void FocusNear2Button_Click(object sender, EventArgs e)
        {
            try { CameraHandler.SetFocus(EDSDK.EvfDriveLens_Near2); }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        private void FocusNear1Button_Click(object sender, EventArgs e)
        {
            try { CameraHandler.SetFocus(EDSDK.EvfDriveLens_Near1); }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        private void FocusFar1Button_Click(object sender, EventArgs e)
        {
            try { CameraHandler.SetFocus(EDSDK.EvfDriveLens_Far1); }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        private void FocusFar2Button_Click(object sender, EventArgs e)
        {
            try { CameraHandler.SetFocus(EDSDK.EvfDriveLens_Far2); }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        private void FocusFar3Button_Click(object sender, EventArgs e)
        {
            try { CameraHandler.SetFocus(EDSDK.EvfDriveLens_Far3); }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        #endregion

        #region Subroutines

        private void CloseSession()
        {
            CameraHandler.CloseSession();
            AvCoBox.Items.Clear();
            TvCoBox.Items.Clear();
            ISOCoBox.Items.Clear();
            SettingsGroupBox.Enabled = false;
            LiveViewGroupBox.Enabled = false;
            SessionButton.Text = "Open Session";
            SessionLabel.Text = "No open session";
            RefreshCamera();//Closing the session invalidates the current camera pointer
            camera_connected = false;
        }

        private void RefreshCamera()
        {
            CameraListBox.Items.Clear();
            CamList = CameraHandler.GetCameraList();
            foreach (Camera cam in CamList) CameraListBox.Items.Add(cam.Info.szDeviceDescription);
            if (CameraHandler.CameraSessionOpen) CameraListBox.SelectedIndex = CamList.FindIndex(t => t.Ref == CameraHandler.MainCamera.Ref);
            else if (CamList.Count > 0) CameraListBox.SelectedIndex = 0;
        }

        private void OpenSession()
        {
            if (CameraListBox.SelectedIndex >= 0)
            {
                camera_connected = true;
                CameraHandler.OpenSession(CamList[CameraListBox.SelectedIndex]);
                SessionButton.Text = "Close Session";
                string cameraname = CameraHandler.MainCamera.Info.szDeviceDescription;
                SessionLabel.Text = cameraname;
                if (CameraHandler.GetSetting(EDSDK.PropID_AEMode) != EDSDK.AEMode_Manual) MessageBox.Show("Camera is not in manual mode. Some features might not work!");
                AvList = CameraHandler.GetSettingsList((uint)EDSDK.PropID_Av);
                TvList = CameraHandler.GetSettingsList((uint)EDSDK.PropID_Tv);
                ISOList = CameraHandler.GetSettingsList((uint)EDSDK.PropID_ISOSpeed);
                foreach (int Av in AvList) 
                    AvCoBox.Items.Add(CameraValues.AV((uint)Av));
                foreach (int Tv in TvList) 
                    TvCoBox.Items.Add(CameraValues.TV((uint)Tv));
                foreach (int ISO in ISOList) 
                    ISOCoBox.Items.Add(CameraValues.ISO((uint)ISO));
                AvCoBox.SelectedIndex = AvCoBox.Items.IndexOf(CameraValues.AV((uint)CameraHandler.GetSetting((uint)EDSDK.PropID_Av)));
                TvCoBox.SelectedIndex = TvCoBox.Items.IndexOf(CameraValues.TV((uint)CameraHandler.GetSetting((uint)EDSDK.PropID_Tv)));
                ISOCoBox.SelectedIndex = ISOCoBox.Items.IndexOf(CameraValues.ISO((uint)CameraHandler.GetSetting((uint)EDSDK.PropID_ISOSpeed)));
                int wbidx = (int)CameraHandler.GetSetting((uint)EDSDK.PropID_WhiteBalance);
                switch (wbidx)
                {
                    case EDSDK.WhiteBalance_Auto: WBCoBox.SelectedIndex = 0; break;
                    case EDSDK.WhiteBalance_Daylight: WBCoBox.SelectedIndex = 1; break;
                    case EDSDK.WhiteBalance_Cloudy: WBCoBox.SelectedIndex = 2; break;
                    case EDSDK.WhiteBalance_Tangsten: WBCoBox.SelectedIndex = 3; break;
                    case EDSDK.WhiteBalance_Fluorescent: WBCoBox.SelectedIndex = 4; break;
                    case EDSDK.WhiteBalance_Strobe: WBCoBox.SelectedIndex = 5; break;
                    case EDSDK.WhiteBalance_WhitePaper: WBCoBox.SelectedIndex = 6; break;
                    case EDSDK.WhiteBalance_Shade: WBCoBox.SelectedIndex = 7; break;
                    default: WBCoBox.SelectedIndex = -1; break;
                }
                SettingsGroupBox.Enabled = true;
                LiveViewGroupBox.Enabled = true;
                this.STComputerButton.Select();
            }
        }

        private void ReportError(string message, bool lockdown)
        {
            int errc;
            lock (ErrLock) { errc = ++ErrCount; }

            if (lockdown) EnableUI(false);

            if (errc < 4) MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (errc == 4) MessageBox.Show("Many errors happened!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            lock (ErrLock) { ErrCount--; }
        }

        private void EnableUI(bool enable)
        {
            if (InvokeRequired) Invoke((Action)delegate { EnableUI(enable); });
            else
            {
                SettingsGroupBox.Enabled = enable;
                InitGroupBox.Enabled = enable;
                LiveViewGroupBox.Enabled = enable;
            }
        }

        #endregion

        private string get_date()
        {
            DateTime cur = DateTime.Now;
            TimeSpan five = new TimeSpan(05, 0, 0);
            TimeSpan now = DateTime.Now.TimeOfDay;
            if (now < five)
                return cur.AddDays(-1).ToString("MM_dd_yyyy");
            return cur.ToString("MM_dd_yyyy");
        }

        private string get_actual_date()
        {
            DateTime cur = DateTime.Now;
            return cur.ToString("MM_dd_yyyy");
        }

        private string get_time()
        {
            DateTime cur = DateTime.Now;
            return cur.ToString("h:mm:ss tt");
        }

        void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)32:        // space
                    if (!this.accept_btn.Enabled && this.serial_number.TextLength == 12)
                        this.TakePhotoButton_Click(this.TakePhotoButton, EventArgs.Empty);
                    else if (this.serial_number.TextLength == 12)
                        this.accept_btn_Click(this.accept_btn, EventArgs.Empty);
                    e.Handled = true;
                    break;
                case (char)8:           // backspace
                case (char)127:       // delete
                    if (this.reject_btn.Enabled && this.serial_number.TextLength == 12)
                    {
                        this.reject_btn_Click(this.reject_btn, EventArgs.Empty);
                        e.Handled = true;
                    }
                    break;
                default:
                    if (this.serial_number.TextLength == 12)
                    {
                        if (this.LiveViewPicBox.Image != null)
                        {
                            this.accept_btn_Click(this.accept_btn, EventArgs.Empty);
                        }
                    }
                    if (this.serial_number.Focused == false)
                    {
                        this.serial_number.Text += e.KeyChar.ToString();
                        this.serial_number.SelectionStart = this.serial_number.Text.Length;
                        this.serial_number.Focus();
                    }
                    break;
            }
        }

        private void serial_lost_focus(object sender, EventArgs e)
        {
            Control ctl = this.ActiveControl;
         /*   if (!(ctl is ComboBox))
            {
                this.serial_number.Focus();
            }  */
        }

        private ImageCodecInfo GetEncoder(ImageFormat format)
        {

            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();

            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        private void accept_btn_Click(object sender, EventArgs e)
        {
            string dir = this.SavePathTextBox.Text + "\\" + get_date() + "\\Pre";
            string fn = this.serial_number.Text + ".jpg";
            if (check_valid(dir, fn))
            {
                Bitmap bm = new Bitmap(this.LiveViewPicBox.Image);
                ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);

                // Create an Encoder object based on the GUID 
                // for the Quality parameter category.
                System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;

                // Create an EncoderParameters object. 
                // An EncoderParameters object has an array of EncoderParameter 
                // objects. In this case, there is only one 
                // EncoderParameter object in the array.
                EncoderParameters myEncoderParameters = new EncoderParameters(1);

                EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, 75L);
                myEncoderParameters.Param[0] = myEncoderParameter;
                bm.Save(dir + "\\" + fn, jpgEncoder, myEncoderParameters);
                this.color_saver = this.action_panel.BackColor;
                this.action_panel.BackColor = Color.Green;
                this.keypress_timer.Start();
            }
            else
            {
                MessageBox.Show("This serial number has already been used on this date. Please select another card with a unique serial number.", "Duplicate Serial Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            this.serial_number.Text = "";
            this.TakePhotoButton.Enabled = false;
            recover_from_photo();
        }

        private bool check_valid(string dir, string file)
        {
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
                return true;
            }
            else
            {
                return !File.Exists(dir + "\\" + file);
            }
        }

        private void reject_btn_Click(object sender, EventArgs e)
        {
            this.color_saver = this.action_panel.BackColor;
            this.action_panel.BackColor = Color.Red;
            this.keypress_timer.Start();
            recover_from_photo();
        }

        private void recover_from_photo()
        {
            this.LiveViewPicBox.Image = null;
            if (live_view)
            {
                CameraHandler.StartLiveView();
            }
            control_enable(this.accept_btn, false);
            control_enable(this.reject_btn, false);
            control_enable(this.LiveViewButton, true);
        }

        delegate int text_length_callback(System.Windows.Forms.TextBox box);

        private int text_length(System.Windows.Forms.TextBox box)
        {
            int ret;
            if (box.InvokeRequired)
            {
                text_length_callback c = new text_length_callback(text_length);
                ret = (int)this.Invoke(c, new object[] { box });
            }
            else
            {
                ret = box.TextLength;
            }
            return ret;
        }

        delegate void control_enable_callback(System.Windows.Forms.Button btn, bool enable);

        private void control_enable(System.Windows.Forms.Button btn, bool enable)
        {
            if (btn.InvokeRequired)
            {
                control_enable_callback c = new control_enable_callback(control_enable);
                this.Invoke(c, new object[] { btn, enable });
            }
            else
            {
                btn.Enabled = enable;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Please confirm the current date and time: " + this.get_actual_date() + " " + this.get_time(), "Confirm Date Time", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.No)
            {
                MessageBox.Show("Please fix system clock and re-run PhotoBooth.", "Fix System Clock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Environment.Exit(0);
            }
        }
        private void MainForm_Shown(object sender, EventArgs e)
        {
            this.serial_lost_focus(this.serial_number, EventArgs.Empty);
        }
        private void serial_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void serial_number_TextChanged(object sender, EventArgs e)
        {
            if (this.serial_number.TextLength != 12)
            {
                this.accept_btn.Enabled = false;
                this.reject_btn.Enabled = false;
                this.TakePhotoButton.Enabled = false;
            }
            else
            {
                this.TakePhotoButton.Enabled = true;
            }        
        }

        private void keypress_timer_Tick(object sender, EventArgs e)
        {
            this.action_panel.BackColor = this.color_saver;
            this.action_panel.Refresh();
            this.keypress_timer.Stop();

        }

        private void MainProgressBar_Click(object sender, EventArgs e)
        {

        }

        private void BulbUpDo_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
