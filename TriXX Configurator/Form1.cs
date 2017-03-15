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

namespace TriXX_Configurator
{
	public partial class TRIXXConf : Form
	{
		private string installDirectory = "";
		private byte[] TRIXX_Binary;
		private TRIXX trixxConfigurator;

		public TRIXXConf()
		{
			InitializeComponent();

			//Check if TRIXX is in the typical destination:
			var trixx = Environment.ExpandEnvironmentVariables("%ProgramFiles(x86)%") + @"\Sapphire TRIXX\TRIXX.exe";

			if (File.Exists(trixx))
				installDirectory = trixx;
			else
				MessageBox.Show("Please browse to and select your TRIXX.exe");

			Label_TRIXXPath.Text = installDirectory;
			trixxConfigurator = new TRIXX(this);
		}

		private void Button_BrowseDialog_Click(object sender, EventArgs e)
		{
			OpenFileDialog findFile = new OpenFileDialog();
			if(findFile.ShowDialog() == DialogResult.OK)
			{
				installDirectory = findFile.FileName;
			}
		}

		private void Button_Load_Click(object sender, EventArgs e)
		{
			if(!File.Exists(installDirectory))
			{
				MessageBox.Show("File Does Not Exist");
				return;
			}
			if((new FileInfo(installDirectory)).Length != 4363416)
			{
				MessageBox.Show("Wrong File Selected!");
				return;
			}
			if((new FileInfo(installDirectory)).IsReadOnly)
			{
				MessageBox.Show("File in use or no permissions!");
				return;
			}
			TRIXX_Binary = File.ReadAllBytes(installDirectory);
			trixxConfigurator.loadTrixx(TRIXX_Binary);
		}

		public void updateFields()
		{
			Button_Load.Enabled = false;
			Panel_Values.Enabled = true;
			TextBox_MaxOffset.Text = trixxConfigurator.values["VDDCOffsetMax"].ToString();
			TextBox_MinOffset.Text = trixxConfigurator.values["VDDCOffsetMin"].ToString();
			TextBox_MaxGPUClock.Text = trixxConfigurator.values["GPUClockSliderRangeMax"].ToString();
			TextBox_MaxMemClock.Text = trixxConfigurator.values["MemoryClockSliderRangeMax"].ToString();
			TextBox_MVVDCDisable.Text = trixxConfigurator.values["MVDDCDisable"].ToString();
			TextBox_VDDCIDisable.Text = trixxConfigurator.values["VDDCIDisable"].ToString();
		}

		public bool isFloat(string str)
		{
			try
			{
				float.Parse(str);
			}
			catch
			{
				return false;
			}
			return true;
		}

		private void TextBox_MaxOffset_TextChanged(object sender, EventArgs e)
		{
			if (TextBox_MaxOffset.Text == "")
				TextBox_MaxOffset.Text = "0";
			trixxConfigurator.values["VDDCOffsetMax"] = float.Parse(TextBox_MaxOffset.Text);
		}

		private void TextBox_MinOffset_TextChanged(object sender, EventArgs e)
		{
			if (TextBox_MinOffset.Text == "")
				TextBox_MinOffset.Text = "0";
			trixxConfigurator.values["VDDCOffsetMin"] = float.Parse(TextBox_MinOffset.Text);
		}

		private void TextBox_MaxMemClock_TextChanged(object sender, EventArgs e)
		{
			if (TextBox_MaxMemClock.Text == "")
				TextBox_MaxMemClock.Text = "0";
			trixxConfigurator.values["MemoryClockSliderRangeMax"] = float.Parse(TextBox_MaxMemClock.Text);
		}

		private void TextBox_MaxGPUClock_TextChanged(object sender, EventArgs e)
		{
			if (TextBox_MaxGPUClock.Text == "")
				TextBox_MaxGPUClock.Text = "0";
			trixxConfigurator.values["GPUClockSliderRangeMax"] = float.Parse(TextBox_MaxGPUClock.Text);
		}

		private void TextBox_MVVDCDisable_TextChanged(object sender, EventArgs e)
		{
			if (TextBox_MVVDCDisable.Text == "")
				TextBox_MVVDCDisable.Text = "0";
			trixxConfigurator.values["MVDDCDisable"] = float.Parse(TextBox_MVVDCDisable.Text);
		}

		private void TextBox_VDDCIDisable_TextChanged(object sender, EventArgs e)
		{
			if (TextBox_VDDCIDisable.Text == "")
				TextBox_VDDCIDisable.Text = "0";
			trixxConfigurator.values["VDDCIDisable"] = float.Parse(TextBox_VDDCIDisable.Text);
		}

		private void Button_Save_Click(object sender, EventArgs e)
		{
			if ((new FileInfo(installDirectory)).IsReadOnly)
			{
				MessageBox.Show("File in use or no permissions!");
				return;
			}
			trixxConfigurator.saveTrixx(installDirectory);
			MessageBox.Show("File Saved!");
		}

		private void TextBox_MaxOffset_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !isFloat(TextBox_MaxOffset.Text + e.KeyChar))
			{
					e.Handled = true;
			}
		}

		private void TextBox_MinOffset_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !isFloat(TextBox_MinOffset.Text + e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void TextBox_MaxMemClock_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !isFloat(TextBox_MaxMemClock.Text + e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void TextBox_MaxGPUClock_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !isFloat(TextBox_MaxGPUClock.Text + e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void TextBox_MVVDCDisable_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !isFloat(TextBox_MVVDCDisable.Text + e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void TextBox_VDDCIDisable_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !isFloat(TextBox_VDDCIDisable.Text + e.KeyChar))
			{
				e.Handled = true;
			}
			
		}
	}
}
