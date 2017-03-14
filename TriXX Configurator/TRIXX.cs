using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TriXX_Configurator
{
	class TRIXX
	{
		private byte[] file;

		//Name, <Location, Length>
		public Dictionary<string, int[]> reference;
		public Dictionary<string, float> values;

		public string Test = "";
		TRIXXConf configurator;

		public TRIXX(TRIXXConf conf)
		{
			configurator = conf;

			reference = new Dictionary<string, int[]>();
			values = new Dictionary<string, float>();

			reference.Add(
				"VDDCOffsetMax",
				new int[] { 0x002f86e0 + 0x5, 0x002f86e0 + 0xa });
			reference.Add(
				"VDDCOffsetMin",
				new int[] { 0x002f86c0 + 0xf, 0x002f86d0 + 0x5 });
			reference.Add(
				"MemoryClockSliderRangeMax",
				new int[] { 0x002f8520 + 0x1, 0x002f8520 + 0x4 });
			reference.Add(
				"GPUClockSliderRangeMax",
				new int[] { 0x002f8500 + 0x2, 0x002f8500 + 0x5 });
			reference.Add(
				"MVDDCDisable",
				new int[] { 0x002f8490 + 0x0, 0x002f8490 + 0x1 });
			reference.Add(
				"VDDCIDisable",
				new int[] { 0x002f84a0 + 0x0, 0x002f84a0 + 0x1 });
		}

		public void loadTrixx(byte[] t)
		{
			file = t;

			foreach(var key in reference.Keys)
			{
				string value = "";
				for(int fileRef = reference[key][0]; fileRef < reference[key][1]; fileRef++)
				{
					value += Encoding.ASCII.GetString(new byte[] { file[fileRef] });
				}

				values.Add(key, float.Parse(value));

			}

			configurator.updateFields();
		}

		public void saveTrixx(string path)
		{
			foreach(var key in values.Keys)
			{
				//Get number information from Trixx File -
				//we don't want to risk destroying the file (someone might have to download a whole 5mb again :( )
				int numberLength = reference[key][1] - reference[key][0]; //End offset - Start offset

				//Create mask:
				string numberMask = "";
				if (numberLength == 1)
					numberMask = "0";
				else
				{
					if(values[key] < 0)
						numberMask = "0." + new string('0', numberLength - 3);
					else
						numberMask = "0." + new string('0', numberLength - 2);

				}

				//Push new numbers to file
				string preparedNumber = values[key].ToString(numberMask);
				byte[] byteData = Encoding.ASCII.GetBytes(preparedNumber);
				int byteOffset = 0x0;
				for (int fileRef = reference[key][0]; fileRef < reference[key][1]; fileRef++)
				{
					file[fileRef] = byteData[byteOffset];
					byteOffset += 0x1;
				}
			}

			//Save File:
			File.WriteAllBytes(path, file);
		}
	}
}
