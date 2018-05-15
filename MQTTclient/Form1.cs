using System;
using System.Text;
using System.Windows.Forms;
// including the M2Mqtt Library
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;


namespace MQTT_Client_
{
    public partial class Form1 : Form
    {  
        // *** Global Variable Declaration 

        MqttClient client;
        string clientId;
        bool status = true;
        
        public Form1()
        {
            InitializeComponent();
        }

        //*************** Connection/Disconnection to/from MQTT Broker *****************\\

        private void button1_Click(object sender, EventArgs e)
        {
            if (status)
            {
                try
            {  
                //string BrokerAddress = "test.mosquitto.org";
                string BrokerAddress = "127.0.0.1";

                // use a unique id as client id, each time we start the application
                client = new MqttClient(BrokerAddress); 
                clientId = Guid.NewGuid().ToString();
               
                client.Connect(clientId);
                label1.Text = "Connected";
                status = false;
                button1.Text = "Disconnection from MQTT";

                }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Exception Message: " + ex.Message);
            }
            }
            else
            {
                client.Disconnect();
                label1.Text = "Dis-Connected";
                status = true;
                button1.Text = "Connection to MQTT";
            }
        }

        //*************** Subscription option *****************\\

        private void bntsubs_Click(object sender, EventArgs e)
        {
            if (txtTopicSubscribe.Text != "")
            {
                // whole topic
                string Topic = txtTopicSubscribe.Text;
                label2.Text = "Subsribed ! on topic" + " \" " + Topic + "\"";
                label2.Visible = true;
                // subscribe to the topic with QoS 2
                client.Subscribe(new string[] { Topic }, new byte[] { 2 });   // we need arrays as parameters because we can subscribe to different topics with one call
                client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("You have to enter a topic to subscribe!");
            }
        }
        //*************** Publication option *****************\\
        private void button3_Click(object sender, EventArgs e)
        {   
            
            if (txtopic.Text != "")
            {
                // whole topic
                string Topic = txtopic.Text;
                label7.Text = "published ! on topic" + " \" " + Topic + "\"";
                label7.Visible = true;
                // Publish a topic with QoS 0 , 1 ,2
                client.Publish(Topic, Encoding.UTF8.GetBytes(msgpub.Text), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("You have to enter a topic to publish!");
            }

        }

        //*************** Handling Thread safe calls in Windows Forms Controls *****************\\

        public delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.txtReceived.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtReceived.Text = text;
            }
        }
        // this code runs when a message was received
        public void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            string ReceivedMessage = Encoding.UTF8.GetString(e.Message);
            SetText(ReceivedMessage);
        }

    }
}
