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
			TRIXX_Binary = File.ReadAllBytes(installDirectory);
			trixxConfigurator.loadTrixx(TRIXX_Binary);
		}

		public void updateFields()
		{
			TextBox_MaxOffset.Text = trixxConfigurator.values["VDDCOffsetMax"].ToString();
			TextBox_MinOffset.Text = trixxConfigurator.values["VDDCOffsetMin"].ToString();
			TextBox_MaxGPUClock.Text = trixxConfigurator.values["GPUClockSliderRangeMax"].ToString();
			TextBox_MaxMemClock.Text = trixxConfigurator.values["MemoryClockSliderRangeMax"].ToString();
			TextBox_MVVDCDisable.Text = trixxConfigurator.values["MVDDCDisable"].ToString();
			TextBox_VDDCIDisable.Text = trixxConfigurator.values["VDDCIDisable"].ToString();
		}

		private void TextBox_MaxOffset_TextChanged(object sender, EventArgs e)
		{
			trixxConfigurator.values["VDDCOffsetMax"] = float.Parse(TextBox_MaxOffset.Text);
		}

		private void TextBox_MinOffset_TextChanged(object sender, EventArgs e)
		{
			trixxConfigurator.values["VDDCOffsetMin"] = float.Parse(TextBox_MinOffset.Text);
		}

		private void TextBox_MaxMemClock_TextChanged(object sender, EventArgs e)
		{
			trixxConfigurator.values["MemoryClockSliderRangeMax"] = float.Parse(TextBox_MaxMemClock.Text);
		}

		private void TextBox_MaxGPUClock_TextChanged(object sender, EventArgs e)
		{
			trixxConfigurator.values["GPUClockSliderRangeMax"] = float.Parse(TextBox_MaxGPUClock.Text);
		}

		private void TextBox_MVVDCDisable_TextChanged(object sender, EventArgs e)
		{
			trixxConfigurator.values["MVDDCDisable"] = float.Parse(TextBox_MVVDCDisable.Text);
		}

		private void TextBox_VDDCIDisable_TextChanged(object sender, EventArgs e)
		{
			trixxConfigurator.values["VDDCIDisable"] = float.Parse(TextBox_VDDCIDisable.Text);
		}

		private void Button_Save_Click(object sender, EventArgs e)
		{
			trixxConfigurator.saveTrixx(installDirectory);
		}
	}
}
