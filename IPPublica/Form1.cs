using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPPublica
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//GetIP();
		}

		public void GetIP()
		{
			TbIP01.Text = GetIpPublica1();
			TbIP02.Text = GetIpPublica2();
			TbIP03.Text = GetIpPublica3();
		}
		public string GetIpPublica1()
		{
			string publicIPAddress = "";
		
			try
			{
				var request = (HttpWebRequest)WebRequest.Create("https://api.ipify.org/");
				request.UserAgent = "curl";

				request.Method = "GET";
				using (WebResponse response = request.GetResponse())
				{
					using (var reader = new StreamReader(response.GetResponseStream()))
					{
						publicIPAddress = reader.ReadToEnd();
					}
				}
			} catch( Exception Ex) { }
			return publicIPAddress.Replace("\n", "");
		}
		public string GetIpPublica2()
		{
			string publicIPAddress = "";
			try
			{
				var request = (HttpWebRequest)WebRequest.Create("http://ifconfig.me");
				request.UserAgent = "curl";
				request.Method = "GET";
				using (WebResponse response = request.GetResponse())
				{
					using (var reader = new StreamReader(response.GetResponseStream()))
					{
						publicIPAddress = reader.ReadToEnd();
					}
				}
			} catch( Exception Ex) { }
			return publicIPAddress.Replace("\n", "");
		}
		public string GetIpPublica3()
		{
			string publicIPAddress = "";
			try
			{
				WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
				using (WebResponse response = request.GetResponse())
				using (StreamReader sr = new StreamReader(response.GetResponseStream()))
				{
					publicIPAddress = sr.ReadToEnd();
				}
				//scrape ip from the html
				int i1 = publicIPAddress.IndexOf("Address: ") + 9;
				int i2 = publicIPAddress.LastIndexOf("</body>");
				publicIPAddress = publicIPAddress.Substring(i1, i2 - i1);
			} catch( Exception Ex) { }
			return publicIPAddress.Replace("\n", "");
		}

		private void Actualizar_Click(object sender, EventArgs e)
		{
			GetIP();
		}

		public void GetMacs()
		{
			//get mac address
			NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
			String sMacAddress = string.Empty;
			foreach (NetworkInterface adapter in nics)
			{
				if (sMacAddress == String.Empty)// only return MAC Address from first card  
				{
					IPInterfaceProperties properties = adapter.GetIPProperties();
					sMacAddress = adapter.GetPhysicalAddress().ToString();
				}
			}
		}

		public void GetLocalIp()
		{
			// To Get IP Address
			string IPHost = Dns.GetHostName();
			string IP = Dns.GetHostByName(IPHost).AddressList[0].ToString();
		}

		private void BtnCopiarIP01_Click(object sender, EventArgs e)
		{
			TbIP01.SelectAll();
			TbIP01.Copy();
		}

		private void BtnCopiarIP02_Click(object sender, EventArgs e)
		{
			TbIP02.SelectAll();
			TbIP03.Copy();
		}

		private void BtnCopiarIP03_Click(object sender, EventArgs e)
		{
			TbIP03.SelectAll();
			TbIP03.Copy();
		}
	}
}
