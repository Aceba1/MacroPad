using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
namespace MacroPad
{
    public partial class Form1 : Form
    {
        List<CMD> CMDList;
        List<Override> OverrideList;
        public static SerialPort arduino = null;
        public Form1()
        {
            InitializeComponent();
            CMDList = new List<CMD>();
            OverrideList = new List<Override>();
            pressedKey = new List<Keys>();
            stopwatch = new System.Diagnostics.Stopwatch();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Connect_Click(object sender, EventArgs e)
        {
            if (Form1.arduino != null)
            {
                labelSerialStatus.Text = "Disposing serial...";
                Form1.arduino.Dispose();
            }
            var ports = SerialPort.GetPortNames();
            bool isNull = true;
            for (int i = 0; i < ports.Length; i++)
            {
                Form1.arduino = new SerialPort(ports[i], 500000)
                {
                    ReadTimeout = 500
                };
                labelSerialStatus.Text = "Testing port " + ports[i];
                try
                {
                    Form1.arduino.Open();
                    Form1.arduino.Write("handle");
                    if (Form1.arduino.ReadLine() == "macropad_connect\r")
                    {
                        labelSerialStatus.Text = "Connected to port " + ports[i];
                        isNull = false;
                        break;
                    }
                }
                catch { }
                Form1.arduino.Dispose();
            }
            if (isNull)
            {
                labelSerialStatus.Text = "No serial (If connected to PC, reset)";
                return;
            }
            Form1.arduino.DataReceived += Arduino_DataReceived;
        }

        private void Arduino_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            MessageBox.Show(Form1.arduino.ReadLine());
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (listBoxAddWhere.SelectedIndex == 0)
            {
                CMDList.Insert(0, new CMD((CMDType)listBoxAddType.SelectedIndex));
                listBoxScript.Items.Insert(0, CMDList[0].ToString());
            }
            if (listBoxAddWhere.SelectedIndex == 1)
            {
                CMDList.Insert(listBoxScript.SelectedIndex, new CMD((CMDType)listBoxAddType.SelectedIndex));
                listBoxScript.Items.Insert(listBoxScript.SelectedIndex, CMDList[listBoxScript.SelectedIndex].ToString());
            }
            else if (listBoxAddWhere.SelectedIndex == 2)
            {
                CMDList.Insert(listBoxScript.SelectedIndex + 1, new CMD((CMDType)listBoxAddType.SelectedIndex));
                listBoxScript.Items.Insert(listBoxScript.SelectedIndex + 1, CMDList[listBoxScript.SelectedIndex + 1].ToString());
            }
            else
            {
                CMDList.Add(new CMD((CMDType)listBoxAddType.SelectedIndex));
                listBoxScript.Items.Add(CMDList.Last().ToString());
            }
        }
        private void Script_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBoxEditPinId.Focused || listBoxEditPinMode.Focused || textBoxEditDelayValue.Focused)
            {
                return;
            }
            if (listBoxScript.SelectedIndex != -1)
            {
                buttonEditMoveDown.Visible = true;
                buttonEditMoveUp.Visible = true;
                labelEditEmpty.Visible = false;
                if (((string)listBoxScript.SelectedItem)[0] == 'D')
                {
                    //show Delay options
                    textBoxEditDelayValue.Visible = true;
                    labelEditDelay.Visible = true;
                    //hide SetPin options
                    listBoxEditPinMode.Visible = false;
                    labelEditPinMode.Visible = false;
                    textBoxEditPinId.Visible = false;
                    labelEditPinId.Visible = false;
                }
                else
                {
                    //show SetPin options
                    listBoxEditPinMode.Visible = true;
                    labelEditPinMode.Visible = true;
                    textBoxEditPinId.Visible = true;
                    labelEditPinId.Visible = true;
                    //hide Delay options
                    textBoxEditDelayValue.Visible = false;
                    labelEditDelay.Visible = false;
                }
                textBoxEditPinId.Text = CMDList[listBoxScript.SelectedIndex].sPin.ToString();
                listBoxEditPinMode.SelectedIndex = (int)CMDList[listBoxScript.SelectedIndex].sMode;
                textBoxEditDelayValue.Text = CMDList[listBoxScript.SelectedIndex].value.ToString();

                buttonEditDelete.Visible = true;
            }
            else
            {
                labelEditEmpty.Visible = true;
                textBoxEditDelayValue.Visible = false;
                labelEditDelay.Visible = false;
                buttonEditMoveDown.Visible = false;
                buttonEditMoveUp.Visible = false;
                buttonEditDelete.Visible = false;
                listBoxEditPinMode.Visible = false;
                labelEditPinMode.Visible = false;
                textBoxEditPinId.Visible = false;
                labelEditPinId.Visible = false;
            }
        }

        private void EditPinId_TextChanged(object sender, EventArgs e)
        {
            if (textBoxEditPinId.Text == "")
                return;
            try
            {
                var cache = CMDList[listBoxScript.SelectedIndex];
                byte parse = byte.Parse(textBoxEditPinId.Text);
                if (cache.sPin == parse)
                    return;
                cache.SPin(parse);
                CMDList[listBoxScript.SelectedIndex] = cache;
                listBoxScript.Items[listBoxScript.SelectedIndex] = CMDList[listBoxScript.SelectedIndex].ToString();
            }
            catch
            {
                //textBoxEditPinId.Text = CMDList[listBoxScript.SelectedIndex].sPin.ToString();
            }
        }

        private void EditPinMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEditPinMode.SelectedIndex == -1)
                return;
            try
            {
                var cache = CMDList[listBoxScript.SelectedIndex];
                PinMode parse = (PinMode)listBoxEditPinMode.SelectedIndex;
                if (cache.sMode == parse)
                    return;
                cache.SMode(parse);
                CMDList[listBoxScript.SelectedIndex] = cache;
                listBoxScript.Items[listBoxScript.SelectedIndex] = CMDList[listBoxScript.SelectedIndex].ToString();
            }
            catch
            {
                //listBoxEditPinMode.SelectedIndex = (int)CMDList[listBoxScript.SelectedIndex].sMode;
            }

        }

        private void EditDelayValue_TextChanged(object sender, EventArgs e)
        {
            if (textBoxEditDelayValue.Text == "")
                return;
            try
            {
                var cache = CMDList.ElementAt(listBoxScript.SelectedIndex);
                int parse = int.Parse(textBoxEditDelayValue.Text);
                if (cache.value == parse || parse < 0)
                    return;
                cache.Value(parse);
                CMDList[listBoxScript.SelectedIndex] = cache;
                listBoxScript.Items[listBoxScript.SelectedIndex] = CMDList[listBoxScript.SelectedIndex].ToString();
            }
            catch
            {
                //textBoxEditDelayValue.Text = CMDList[listBoxScript.SelectedIndex].value.ToString();
            }

        }

        private void EditMoveUp(object sender, EventArgs e)
        {
            int index = listBoxScript.SelectedIndex;
            if (index <= 0/* || index >= listBoxScript.Items.Count-1*/) return;
            var cache = CMDList[index];
            CMDList[index] = CMDList[index - 1];
            CMDList[index - 1] = cache;
            string cache2 = (string)listBoxScript.Items[index];
            listBoxScript.Items[index] = (string)listBoxScript.Items[index - 1];
            listBoxScript.Items[index - 1] = cache2;
            listBoxScript.SelectedIndex--;
        }

        private void EditMoveDown(object sender, EventArgs e)
        {
            int index = listBoxScript.SelectedIndex;
            if (index >= listBoxScript.Items.Count - 1) return;
            var cache = CMDList[index];
            CMDList[index] = CMDList[index + 1];
            CMDList[index + 1] = cache;
            string cache2 = (string)listBoxScript.Items[index];
            listBoxScript.Items[index] = (string)listBoxScript.Items[index + 1];
            listBoxScript.Items[index + 1] = cache2;
            listBoxScript.SelectedIndex++;
        }

        private void EditDelete(object sender, EventArgs e)
        {
            CMDList.RemoveAt(listBoxScript.SelectedIndex);
            listBoxScript.Items.RemoveAt(listBoxScript.SelectedIndex);
        }

        private void Run_Click(object sender, EventArgs e)
        {
            Run();
        }

        private async Task Run()
        {
            loopserial:
            bool safeToLoop = false;
            foreach (CMD command in CMDList)
            {
                if (command.type == CMDType.Pause)
                {
                    await Task.Delay(command.value);
                    if (checkBoxOverrideRecord.Checked) return;
                    safeToLoop = true;
                }
                else
                {
                    Form1.arduino.Write(((char)command.sPin) + "" + ((char)command.sMode));
                }
            }
            if (checkBoxLoop.Checked && safeToLoop) goto loopserial;
        }
        private async Task RunOverride(Override command, bool Release)
        {
            Form1.arduino.Write(((char)command.sPin) + "" + (Release ? (char)command.sModeUp : (char)command.sModeDown));
        }
        List<Keys> pressedKey;
        private void OverrideKeyDown(object sender, KeyEventArgs e)
        {
            if (!checkBoxOverride.Checked || pressedKey.Contains(e.KeyCode))
                return;
            pressedKey.Add(e.KeyCode);
            var ii = OverrideList.FindAll(f => f.keyCode == e.KeyCode);
            foreach (var i in ii)
            {
                RunOverride(i, false);
                if (checkBoxOverrideRecord.Checked)
                {
                    if (!stopwatch.IsRunning)
                    {
                        stopwatch.Start();
                    }
                    else if (stopwatch.ElapsedMilliseconds - millisecinterval > 15)
                    {
                        CMDList.Add(new CMD() { type = CMDType.Pause, value = (int)(stopwatch.ElapsedMilliseconds - millisecinterval) });
                        listBoxScript.Items.Add(CMDList.Last().ToString());
                        millisecinterval = stopwatch.ElapsedMilliseconds;
                    }
                    CMDList.Add(new CMD() { type = CMDType.SetPin, sPin = i.sPin, sMode = i.sModeDown, value = 0 });
                    listBoxScript.Items.Add(CMDList.Last().ToString());
                }
            }
        }
        long millisecinterval;
        private void OverrideKeyUp(object sender, KeyEventArgs e)
        {
            if (!checkBoxOverride.Checked)
                return;
            pressedKey.Remove(e.KeyCode);
            var ii = OverrideList.FindAll(f => f.keyCode == e.KeyCode);
            foreach (var i in ii)
            {
                RunOverride(i, true);
                if (checkBoxOverrideRecord.Checked)
                {
                    if (!stopwatch.IsRunning)
                    {
                        stopwatch.Start();
                    }
                    else if (stopwatch.ElapsedMilliseconds - millisecinterval > 15)
                    {
                        CMDList.Add(new CMD() { type = CMDType.Pause, value = (int)(stopwatch.ElapsedMilliseconds - millisecinterval) });
                        listBoxScript.Items.Add(CMDList.Last().ToString());
                        millisecinterval = stopwatch.ElapsedMilliseconds;
                    }
                    CMDList.Add(new CMD() { type = CMDType.SetPin, sPin = i.sPin, sMode = i.sModeUp, value = 0 });
                    listBoxScript.Items.Add(CMDList.Last().ToString());
                }
            }
        }

        private void OverrideAdd_Click(object sender, EventArgs e)
        {
            OverrideList.Add(new Override() { keyCode = Keys.NumPad0, sModeDown = PinMode.Ground, sModeUp = PinMode.Lock, sPin = 13 });
            listBoxOverride.Items.Add(OverrideList.Last().ToString());
        }

        private void OverrideDelete_Click(object sender, EventArgs e)
        {
            OverrideList.RemoveAt(listBoxOverride.SelectedIndex);
            listBoxOverride.Items.RemoveAt(listBoxOverride.SelectedIndex);
        }

        private void Override_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBoxOverrideId.Focused || textBoxOverrideKey.Focused || listBoxOverridePModeDown.Focused || listBoxOverridePModeUp.Focused)
            {
                return;
            }
            int index = listBoxOverride.SelectedIndex;
            if (index == -1)
            {
                listBoxOverridePModeUp.Visible = false;
                labelOverridePModeUp.Visible = false;
                listBoxOverridePModeDown.Visible = false;
                labelOverridePModeDown.Visible = false;
                textBoxOverrideId.Visible = false;
                labelOverrideId.Visible = false;
                textBoxOverrideKey.Visible = false;
                labelOverrideKey.Visible = false;
                //hide stuff
            }
            else
            {
                textBoxOverrideKey.Text = OverrideList[index].keyCode.ToString();
                textBoxOverrideId.Text = OverrideList[index].sPin.ToString();
                listBoxOverridePModeDown.SelectedIndex = (int)OverrideList[index].sModeDown;
                listBoxOverridePModeUp.SelectedIndex = (int)OverrideList[index].sModeUp;
                //show stuff
                listBoxOverridePModeUp.Visible = true;
                labelOverridePModeUp.Visible = true;
                listBoxOverridePModeDown.Visible = true;
                labelOverridePModeDown.Visible = true;
                textBoxOverrideId.Visible = true;
                labelOverrideId.Visible = true;
                textBoxOverrideKey.Visible = true;
                labelOverrideKey.Visible = true;
            }
        }

        private void OverrideAssignKey(object sender, KeyEventArgs e)
        {
            int index = listBoxOverride.SelectedIndex;
            var cache = OverrideList[index];
            cache.keyCode = e.KeyCode;
            OverrideList[index] = cache;
            listBoxOverride.Items[index] = OverrideList[index].ToString();
            textBoxOverrideKey.Text = e.KeyCode.ToString();
        }

        private void OverrideId_TextChanged(object sender, EventArgs e)
        {
            if (textBoxOverrideId.Text == "")
                return;
            try
            {
                var cache = OverrideList[listBoxOverride.SelectedIndex];
                cache.SPin(byte.Parse(textBoxOverrideId.Text));
                OverrideList[listBoxOverride.SelectedIndex] = cache;
                listBoxOverride.Items[listBoxOverride.SelectedIndex] = OverrideList[listBoxOverride.SelectedIndex].ToString();
            }
            catch
            {
            }
        }

        private void OverridePModeDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var cache = OverrideList[listBoxOverride.SelectedIndex];
                cache.SModeDown((PinMode)listBoxOverridePModeDown.SelectedIndex);
                OverrideList[listBoxOverride.SelectedIndex] = cache;
                listBoxOverride.Items[listBoxOverride.SelectedIndex] = OverrideList[listBoxOverride.SelectedIndex].ToString();
            }
            catch
            {
            }
        }

        private void OverridePModeUp_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var cache = OverrideList[listBoxOverride.SelectedIndex];
                cache.SModeUp((PinMode)listBoxOverridePModeUp.SelectedIndex);
                OverrideList[listBoxOverride.SelectedIndex] = cache;
                listBoxOverride.Items[listBoxOverride.SelectedIndex] = OverrideList[listBoxOverride.SelectedIndex].ToString();
            }
            catch
            {
            }
        }

        private void CheckBoxOverride_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOverride.Checked)
            {
                checkBoxLoop.Checked = false;
                richTextBoxOverrideInput.BorderStyle = BorderStyle.Fixed3D;
            }
            else
            {
                richTextBoxOverrideInput.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void TabChanged(object sender, EventArgs e)
        {
            checkBoxOverride.Checked = false;
        }

        private void Loop_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOverride.Checked)
            {
                checkBoxLoop.Checked = false;
            }
        }

        private void ScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int max = CMDList.Count * CMD.sizeOf;
            int imax = CMDList.Count;
            var cache = new byte[max];
            for (int I = 0; I < imax; I++)
            {
                CMDList[I].SaveToByteArray().CopyTo(cache, I * CMD.sizeOf);
            }
            var file = new SaveFileDialog();
            file.DefaultExt = "mpscript";
            file.Filter = "MacroPad Script files (*.mpscript)|*.mpscript";
            if (file.ShowDialog() == DialogResult.OK)
            {
                System.IO.Stream fstream = file.OpenFile();
                fstream.Write(cache, 0, max);
                fstream.Close();
                fstream.Dispose();
            }
        }

        private void DirectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int max = OverrideList.Count * Override.sizeOf;
            int imax = OverrideList.Count;
            var cache = new byte[max];
            for (int I = 0; I < imax; I++)
            {
                OverrideList[I].SaveToByteArray().CopyTo(cache, I * Override.sizeOf);
            }
            var file = new SaveFileDialog();
            file.DefaultExt = "mpdirect";
            file.Filter = "MacroPad Direct files (*.mpdirect)|*.mpdirect";
            if (file.ShowDialog() == DialogResult.OK)
            {
                System.IO.Stream fstream = file.OpenFile();
                fstream.Write(cache, 0, max);
                fstream.Close();
                fstream.Dispose();
            }
        }

        private void ScriptToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var file = new OpenFileDialog();
            file.DefaultExt = "mpscript";
            file.Filter = "MacroPad Script files (*.mpscript)|*.mpscript";
            if (file.ShowDialog() == DialogResult.OK)
            {
                listBoxScript.Items.Clear();
                CMDList.Clear();
                System.IO.Stream fstream = file.OpenFile();
                byte[] cache = new byte[CMD.sizeOf];
                long count = fstream.Length / CMD.sizeOf;
                for (int i = 0; i < count; i++)
                {
                    fstream.Read(cache, 0, CMD.sizeOf);
                    CMDList.Add(new CMD(cache));
                    listBoxScript.Items.Add(CMDList.Last().ToString());
                }
                fstream.Close();
                fstream.Dispose();
            }
        }

        private void DirectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var file = new OpenFileDialog();
            file.DefaultExt = "mpdirect";
            file.Filter = "MacroPad Direct files (*.mpdirect)|*.mpdirect";
            if (file.ShowDialog() == DialogResult.OK)
            {
                listBoxOverride.Items.Clear();
                OverrideList.Clear();
                System.IO.Stream fstream = file.OpenFile();
                byte[] cache = new byte[Override.sizeOf];
                long count = fstream.Length / Override.sizeOf;
                for (int i = 0; i < count; i++)
                {
                    fstream.Read(cache, 0, Override.sizeOf);
                    OverrideList.Add(new Override(cache));
                    listBoxOverride.Items.Add(OverrideList.Last().ToString());
                }
                fstream.Close();
                fstream.Dispose();
            }
        }
        System.Diagnostics.Stopwatch stopwatch;
        private void checkBoxOverrideRecord_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOverrideRecord.Checked)
            {
                millisecinterval = 0;
                buttonRun.Enabled = false;
            }
            else
            {
                stopwatch.Reset();
                buttonRun.Enabled = true;
            }

        }
    }
    public struct CMD
    {
        public const int sizeOf = 7;
        public byte[] SaveToByteArray()
        {
            var cache = BitConverter.GetBytes(value);
            return new byte[7]
            {
            (byte)type,
            sPin,
            (byte)sMode,
            cache[0],
            cache[1],
            cache[2],
            cache[3]
            };
        }
        public CMD(byte[] byteArray)
        {
            type = (CMDType)byteArray[0];
            sPin = byteArray[1];
            sMode = (PinMode)byteArray[2];
            value = BitConverter.ToInt32(byteArray, 3);
        }
        public override string ToString()
        {
            return (type == CMDType.SetPin ? ("SetPin(" + sPin.ToString() + ", " + Enum.GetName(typeof(PinMode), sMode) + ")") : ("Delay(" + value.ToString() + "ms)"));
        }
        public CMD(CMDType Type)
        {
            type = Type;
            sPin = 0;
            sMode = PinMode.Lock;
            if (Type == CMDType.Pause)
                value = 1000;
            else
                value = 0;
        }
        public CMDType type;
        public byte sPin;
        public PinMode sMode;
        public int value;
        public void SPin(byte value)
        {
            this.sPin = value;
        }
        public void Value(int value)
        {
            this.value = value;
        }
        public void SMode(PinMode value)
        {
            this.sMode = value;
        }
    }
    public enum CMDType : byte
    {
        SetPin,
        Pause
    }
    public enum PinMode : byte
    {
        Lock,
        Ground,
        Power
    }
    public struct Override
    {
        public const int sizeOf = 4;
        public byte[] SaveToByteArray()
        {
            byte[] result = new byte[4]
            {
                sPin,
                (byte)sModeDown,
                (byte)sModeUp,
                (byte)keyCode
            };
            return result;
        }
        public Override(byte[] byteArray)
        {
            sPin = byteArray[0];
            sModeDown = (PinMode)byteArray[1];
            sModeUp = (PinMode)byteArray[2];
            keyCode = (Keys)(int)byteArray[3];
        }
        public override string ToString()
        {
            return keyCode.ToString() + " >> SetPin(" + sPin.ToString() + ", " + sModeDown.ToString() + ", " + sModeUp.ToString() + ")";
        }
        public byte sPin;
        public PinMode sModeDown, sModeUp;
        public Keys keyCode;
        public void SPin(byte value)
        {
            this.sPin = value;
        }
        public void SModeDown(PinMode value)
        {
            this.sModeDown = value;
        }
        public void SModeUp(PinMode value)
        {
            this.sModeUp = value;
        }
        public void KeyCode(Keys value)
        {
            this.keyCode = value;
        }
    }
}