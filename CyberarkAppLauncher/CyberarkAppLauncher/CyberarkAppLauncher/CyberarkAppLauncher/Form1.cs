using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using RestSharp;
using System.IO;
using System.Diagnostics;


namespace CyberarkAppLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UsernameBox.Text = Environment.UserName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LaunchAppBtn_Click(object sender, EventArgs e)
        {
            bool ValidationError = false;
            string tmpPath = Path.GetTempPath();
            string localDate = DateTime.Now.ToString("yyyy-MM-dd-hmmss");
            string rdpFullPath = tmpPath + "CyberArkRDP-" + localDate + ".rdp";

            //Console.WriteLine(rdpFullPath);


            if ((UsernameBox.Text == string.Empty) || (MFATokenBox.Text == string.Empty))
            {
                Statuslbl.Text = "Make sure username and MFA token is populated!\n";
                ValidationError = true;
            }
            
            if (ValidationError == false)
            {
                Statuslbl.Text = "";
                string username = UsernameBox.Text;
                string mfatoken = MFATokenBox.Text;


                if (Convert.ToString(Datacenterbox.SelectedItem) == "DataCenter1")
                {
                    if (Convert.ToString(ApplicationBox.SelectedItem) == "Chrome")
                    {
                        Statuslbl.Text += "Chrome in ORD\n";
                        string appDetails = $"{{\n\t\"Username\":\"{username}\", \n\t\"Secret\":\"xxxxx\", \n\t\"Address\":\"AppLauncherGUI\", \n\t\"PlatformID\":\"ORDPSM\", \n\t\"extraFields\": {{}}, \n\t\"PSMConnectPrerequisites\": {{\n\t\t\"ConnectionComponent\":\"PSM-Chrome\", \n\t\t\"ConnectionType\":\"RDPFile\" \n\t}}\n}}";
                        Console.WriteLine(appDetails);
                        CyberArkLaunchApp(username, mfatoken, appDetails);
                    }
                    else if (Convert.ToString(ApplicationBox.SelectedItem) == "InternetExplorer")
                    {
                        Statuslbl.Text += "Internet Explorer in ORD\n";
                        string appDetails = $"{{\n\t\"Username\":\"{username}\", \n\t\"Secret\":\"xxxxx\", \n\t\"Address\":\"AppLauncherGUI\", \n\t\"PlatformID\":\"ORDPSM\", \n\t\"extraFields\": {{}}, \n\t\"PSMConnectPrerequisites\": {{\n\t\t\"ConnectionComponent\":\"PSM-IE\", \n\t\t\"ConnectionType\":\"RDPFile\" \n\t}}\n}}";
                        Console.WriteLine(appDetails);
                        CyberArkLaunchApp(username, mfatoken, appDetails);
                    }
                    else if (Convert.ToString(ApplicationBox.SelectedItem) == "Firefox")
                    {
                        Statuslbl.Text += "Firefox in ORD\n";
                        string appDetails = $"{{\n\t\"Username\":\"{username}\", \n\t\"Secret\":\"xxxxx\", \n\t\"Address\":\"AppLauncherGUI\", \n\t\"PlatformID\":\"ORDPSM\", \n\t\"extraFields\": {{}}, \n\t\"PSMConnectPrerequisites\": {{\n\t\t\"ConnectionComponent\":\"PSM-Firefox\", \n\t\t\"ConnectionType\":\"RDPFile\" \n\t}}\n}}";
                        Console.WriteLine(appDetails);
                        CyberArkLaunchApp(username, mfatoken, appDetails);
                    }
                    else
                    {
                        Statuslbl.Text += "Please Select Application!!!!\n";
                    }
                }
                else if (Convert.ToString(Datacenterbox.SelectedItem) == "Datacenter2")
                {
                    if (Convert.ToString(ApplicationBox.SelectedItem) == "Chrome")
                    {
                        Statuslbl.Text += "Chrome in M2P\n";
                        string appDetails = $"{{\n\t\"Username\":\"{username}\", \n\t\"Secret\":\"xxxxx\", \n\t\"Address\":\"AppLauncherGUI\", \n\t\"PlatformID\":\"M2PPSM\", \n\t\"extraFields\": {{}}, \n\t\"PSMConnectPrerequisites\": {{\n\t\t\"ConnectionComponent\":\"PSM-Chrome\", \n\t\t\"ConnectionType\":\"RDPFile\" \n\t}}\n}}";
                        Console.WriteLine(appDetails);
                        CyberArkLaunchApp(username, mfatoken, appDetails);
                    }
                    else if (Convert.ToString(ApplicationBox.SelectedItem) == "InternetExplorer")
                    {
                        Statuslbl.Text += "Internet Explorer in M2P\n";
                        string appDetails = $"{{\n\t\"Username\":\"{username}\", \n\t\"Secret\":\"xxxxx\", \n\t\"Address\":\"AppLauncherGUI\", \n\t\"PlatformID\":\"M2PPSM\", \n\t\"extraFields\": {{}}, \n\t\"PSMConnectPrerequisites\": {{\n\t\t\"ConnectionComponent\":\"PSM-IE\", \n\t\t\"ConnectionType\":\"RDPFile\" \n\t}}\n}}";
                        Console.WriteLine(appDetails);
                        CyberArkLaunchApp(username, mfatoken, appDetails);
                    }
                    else if (Convert.ToString(ApplicationBox.SelectedItem) == "Firefox")
                    {
                        Statuslbl.Text += "Firefox in M2P\n";
                        string appDetails = $"{{\n\t\"Username\":\"{username}\", \n\t\"Secret\":\"xxxxx\", \n\t\"Address\":\"AppLauncherGUI\", \n\t\"PlatformID\":\"M2PPSM\", \n\t\"extraFields\": {{}}, \n\t\"PSMConnectPrerequisites\": {{\n\t\t\"ConnectionComponent\":\"PSM-Firefox\", \n\t\t\"ConnectionType\":\"RDPFile\" \n\t}}\n}}";
                        Console.WriteLine(appDetails);
                        CyberArkLaunchApp(username, mfatoken, appDetails);
                    }
                    else
                    {
                        Statuslbl.Text += "Please Select Application!!!!\n";
                    }
                }
                else if (Convert.ToString(Datacenterbox.SelectedItem) == "Datacenter3")
                {
                    if (Convert.ToString(ApplicationBox.SelectedItem) == "Chrome")
                    {
                        Statuslbl.Text += "Chrome in B5P\n";
                        string appDetails = $"{{\n\t\"Username\":\"{username}\", \n\t\"Secret\":\"xxxxx\", \n\t\"Address\":\"AppLauncherGUI\", \n\t\"PlatformID\":\"B5PPSM\", \n\t\"extraFields\": {{}}, \n\t\"PSMConnectPrerequisites\": {{\n\t\t\"ConnectionComponent\":\"PSM-Chrome\", \n\t\t\"ConnectionType\":\"RDPFile\" \n\t}}\n}}";
                        Console.WriteLine(appDetails);
                        CyberArkLaunchApp(username, mfatoken, appDetails);
                    }
                    else if (Convert.ToString(ApplicationBox.SelectedItem) == "InternetExplorer")
                    {
                        Statuslbl.Text += "Internet Explorer in B5P\n";
                        string appDetails = $"{{\n\t\"Username\":\"{username}\", \n\t\"Secret\":\"xxxxx\", \n\t\"Address\":\"AppLauncherGUI\", \n\t\"PlatformID\":\"B5PPSM\", \n\t\"extraFields\": {{}}, \n\t\"PSMConnectPrerequisites\": {{\n\t\t\"ConnectionComponent\":\"PSM-IE\", \n\t\t\"ConnectionType\":\"RDPFile\" \n\t}}\n}}";
                        Console.WriteLine(appDetails);
                        CyberArkLaunchApp(username, mfatoken, appDetails);
                    }
                    else if (Convert.ToString(ApplicationBox.SelectedItem) == "Firefox")
                    {
                        Statuslbl.Text += "Firefox in B5P\n";
                        string appDetails = $"{{\n\t\"Username\":\"{username}\", \n\t\"Secret\":\"xxxxx\", \n\t\"Address\":\"AppLauncherGUI\", \n\t\"PlatformID\":\"B5PPSM\", \n\t\"extraFields\": {{}}, \n\t\"PSMConnectPrerequisites\": {{\n\t\t\"ConnectionComponent\":\"PSM-Firefox\", \n\t\t\"ConnectionType\":\"RDPFile\" \n\t}}\n}}";
                        Console.WriteLine(appDetails);
                        CyberArkLaunchApp(username, mfatoken, appDetails);
                    }
                    else
                    {
                        Statuslbl.Text += "Please Select Application!!!!\n";
                    }
                }
                else if (Convert.ToString(Datacenterbox.SelectedItem) == "Datacenter4")
                {
                    if (Convert.ToString(ApplicationBox.SelectedItem) == "Chrome")
                    {
                        Statuslbl.Text += "Chrome in AT\n";
                        string appDetails = $"{{\n\t\"Username\":\"{username}\", \n\t\"Secret\":\"xxxxx\", \n\t\"Address\":\"AppLauncherGUI\", \n\t\"PlatformID\":\"ATPSM\", \n\t\"extraFields\": {{}}, \n\t\"PSMConnectPrerequisites\": {{\n\t\t\"ConnectionComponent\":\"PSM-Chrome\", \n\t\t\"ConnectionType\":\"RDPFile\" \n\t}}\n}}";
                        Console.WriteLine(appDetails);
                        CyberArkLaunchApp(username, mfatoken, appDetails);
                    }
                    else if (Convert.ToString(ApplicationBox.SelectedItem) == "InternetExplorer")
                    {
                        Statuslbl.Text += "Internet Explorer in AT\n";
                        string appDetails = $"{{\n\t\"Username\":\"{username}\", \n\t\"Secret\":\"xxxxx\", \n\t\"Address\":\"AppLauncherGUI\", \n\t\"PlatformID\":\"ATPSM\", \n\t\"extraFields\": {{}}, \n\t\"PSMConnectPrerequisites\": {{\n\t\t\"ConnectionComponent\":\"PSM-IE\", \n\t\t\"ConnectionType\":\"RDPFile\" \n\t}}\n}}";
                        Console.WriteLine(appDetails);
                        CyberArkLaunchApp(username, mfatoken, appDetails);
                    }
                    else if (Convert.ToString(ApplicationBox.SelectedItem) == "Firefox")
                    {
                        Statuslbl.Text += "Firefox in AT\n";
                        string appDetails = $"{{\n\t\"Username\":\"{username}\", \n\t\"Secret\":\"xxxxx\", \n\t\"Address\":\"AppLauncherGUI\", \n\t\"PlatformID\":\"ATPSM\", \n\t\"extraFields\": {{}}, \n\t\"PSMConnectPrerequisites\": {{\n\t\t\"ConnectionComponent\":\"PSM-Firefox\", \n\t\t\"ConnectionType\":\"RDPFile\" \n\t}}\n}}";
                        Console.WriteLine(appDetails);
                        CyberArkLaunchApp(username, mfatoken, appDetails);
                    }
                    else
                    {
                        Statuslbl.Text += "Please Select Application!!!!\n";
                    }
                }
                else
                {
                    Statuslbl.Text += "Invalid Datacenter Select!!!!\n";
                }
            }
        }
        static void CyberArkLaunchApp(string user, string mfatoken, string appDetails)
        {
            Console.WriteLine("Authenticating to CyberArk....");
            var client = new RestClient("https://cyberark.domain.com/PasswordVault/API/Auth/radius/Logon");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            string param = $"{{\n\t\"Username\": \"{user}\", \n\t\"Password\": \"{mfatoken}\", \n\t\"concurrentSessions\": \"false\"\n}}";
            request.AddParameter("application/json",param, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
           
            string userToken0 = response.Content;
            char[] charstotrim = { '"' };
            string userToken = userToken0.Trim(charstotrim);
            string statusCode = response.StatusDescription;

            Console.WriteLine("End of Authentication....");

            if (statusCode == "OK")
            {
                //
                //Download and lauch RDP file
                //
                Console.WriteLine(userToken);
                var client0 = new RestClient("https://cyberark.domain.com/PasswordVault/api/Accounts/AdHocConnect");
                client0.ClearHandlers(); 
                client0.Timeout = -1;
                var request0 = new RestRequest(Method.POST);
                request0.AddHeader("Authorization", userToken);
                request0.AddHeader("Content-Type", "application/json");
                request0.AddParameter("application/json", appDetails, ParameterType.RequestBody);
                IRestResponse response0 = client0.Execute(request0);
                String RDPBody = response0.Content; 
                String tmpPath = Path.GetTempPath();
                String RDPFileName = "CyberarkAppLauncher-";
                String myExtension = ".rdp";
                String curDate = DateTime.Now.ToString("yyyy'-'MM'-'dd'-'hhmmss");
                string fullfilepath = tmpPath + RDPFileName + curDate + myExtension;
                Console.WriteLine(fullfilepath);
                
                File.WriteAllText(fullfilepath, RDPBody);
                //Console.WriteLine(RDPBody);

                Process myProcess = new Process();
                myProcess.StartInfo.FileName = fullfilepath;
                myProcess.Start(); 
           


            }
            else {
                Console.WriteLine("Authentication Failure!!!!!!!!!");
            
            }

        }

               
        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void MFATokenBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
