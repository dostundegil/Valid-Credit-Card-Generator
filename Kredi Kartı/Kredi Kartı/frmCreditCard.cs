using CreditCardValidator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kredi_Kartı
{
    public partial class frmCreditCard : Form
    {
        public frmCreditCard()
        {
            InitializeComponent();
        }
       

        static bool checkLuhn(String cardNo)
        {
            int nDigits = cardNo.Length;

            int nSum = 0;
            bool isSecond = false;
            for (int i = nDigits - 1; i >= 0; i--)
            {
                int d = cardNo[i] - '0';
                if (isSecond == true)
                    d = d * 2;
                nSum += d / 10;
                nSum += d % 10;
                isSecond = !isSecond;
            }
            return (nSum % 10 == 0);
        }



        private void button1_Click(object sender, EventArgs e)
        {

            CardFactory factory = null;
            if (comboBox1.SelectedIndex == 0)
            {
                while (true) {
                    
                    
                    Random rnd = new Random();
                    int cardNumber1 = rnd.Next(4000, 4999);
                    int cardNumber2 = rnd.Next(1000, 9999);
                    int cardNumber3 = rnd.Next(1000, 9999);
                    int cardNumber4 = rnd.Next(1000, 9999);
                    int cvv = rnd.Next(100, 999);
                    int expMonth = rnd.Next(1, 12);
                    int expYear = rnd.Next(2022, 2032);
                    string date = expMonth.ToString() + "/" + expYear.ToString();
                    string y = cardNumber1.ToString() + cardNumber2.ToString() + cardNumber3.ToString() + cardNumber4.ToString();
                    if (checkLuhn(y))
                    {
                       
                        factory = new VisaCardFactory(Convert.ToInt32(txtlimit.Text), 5, cvv, y.ToString(), date, textBox1.Text);
                        string c = cardNumber1.ToString() +"-"+ cardNumber2.ToString() + "-" + cardNumber3.ToString() + "-" + cardNumber4.ToString();
                        
                        lblnumara.Text = c;
                        lblkartnumara.Text = c;
                        pictureBox1.Show();
                        lblkartnumara.Show();
                        lbldatee.Text = date;
                        lbldatee.Show();
                        lbladd.Text = textBox1.Text;
                        lbladd.Show();
                        Size size = new Size(80, 60);
                        pictureBox2.Size = size;
                        pictureBox2.Image = imageList2.Images[2];
                        pictureBox2.Show();
                        break;
                    }
                }
            }

            if (comboBox1.SelectedIndex == 1)
            {
                while (true)
                {
                    Random rnd = new Random();
                    int cardNumber1 = rnd.Next(5100, 5599);
                    int cardNumber2 = rnd.Next(1000, 9999);
                    int cardNumber3 = rnd.Next(1000, 9999);
                    int cardNumber4 = rnd.Next(1000, 9999);
                    int cvv = rnd.Next(100, 999);
                    int expMonth = rnd.Next(1, 12);
                    int expYear = rnd.Next(2022, 2032);
                    string date = expMonth.ToString() + "/" + expYear.ToString();
                    string y = cardNumber1.ToString() + cardNumber2.ToString() + cardNumber3.ToString() + cardNumber4.ToString();
                    if (checkLuhn(y))
                    {
                        factory = new MasterCardFactory(Convert.ToInt32(txtlimit.Text), 5, cvv, y.ToString(), date, textBox1.Text);
                        string c = cardNumber1.ToString() + "-" + cardNumber2.ToString() + "-" + cardNumber3.ToString() + "-" + cardNumber4.ToString();
                        
                        lblnumara.Text = c;
                        lblkartnumara.Text = c;
                        lblkartnumara.Text = c;
                        pictureBox1.Show();
                        lblkartnumara.Show();
                        lbldatee.Text = date;
                        lbldatee.Show();
                        lbladd.Text = textBox1.Text;
                        lbladd.Show();
                        pictureBox2.Image = imageList2.Images[0];
                        pictureBox2.Show();
                        break;
                        
                    }
                }
            }
            if (comboBox1.SelectedIndex == 2)
            {
                while (true)
                {
                    
                    Random rnd = new Random();
                    List<int> list = new List<int>(new int[] { 34, 37 });
                    int index = rnd.Next(list.Count);
                    int cardNumberx = rnd.Next(10, 99);
                    int cardNumber1 = rnd.Next(100000, 999999);
                    int cardNumber2 = rnd.Next(10000, 99999);
                    int cvv = rnd.Next(1000, 9999);
                    int expMonth = rnd.Next(1, 12);
                    int expYear = rnd.Next(2022, 2032);
                    string date = expMonth.ToString() + "/" + expYear.ToString();
                    string y = index.ToString()+cardNumberx.ToString()+ cardNumber1.ToString() + cardNumber2.ToString();
                    if (checkLuhn(y))
                    {
                        factory = new AmericanExpressCardFactory(Convert.ToInt32(txtlimit.Text), 0, cvv, y.ToString(), date, textBox1.Text);
                        string c = list[index].ToString() +cardNumberx.ToString() + "-" + cardNumber1.ToString() + "-" + cardNumber2.ToString();
                        
                        lblnumara.Text = c;
                        lblkartnumara.Text = c;
                        pictureBox1.Show();
                        lblkartnumara.Show();
                        lbldatee.Text = date;
                        lbldatee.Show();
                        Size size = new Size(65,65);
                        pictureBox2.Size = size;
                        lbladd.Text = textBox1.Text;
                        lbladd.Show();
                        pictureBox2.Image = imageList2.Images[1];
                        pictureBox2.Show();
                        break;
                    }
                }
            }

            krediKartı card = factory.GetCreditCard();
            lbllimit.Text = card.CreditLimit.ToString();
            lblcvv.Text = card.cvv.ToString();
            lbltarih.Text = card.date;
            lblpuan.Text = card.Point.ToString();
            lblisim.Text = textBox1.Text;
            
            
        }

        private void frmCreditCard_Load(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            lblkartnumara.Hide();
            lbldatee.Hide();
            lbladd.Hide();
            pictureBox2.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CardFactory factory = null;
            int puan=Convert.ToInt32(lblpuan.Text);
            factory = new AmericanExpressCardFactory(Convert.ToInt32(lbllimit.Text), puan,Convert.ToInt32(lblcvv.Text), lblnumara.Text, lbltarih.Text, textBox1.Text);
            
            krediKartı card = factory.GetCreditCard();
            if (txtharca.Text != "") {
                card.CreditLimit= card.harca(Convert.ToInt32(txtharca.Text), ref puan);
                lbllimit.Text = card.CreditLimit.ToString();
                int borc = (Convert.ToInt32(txtlimit.Text)) - (Convert.ToInt32(lbllimit.Text));
                lblborc.Text = borc.ToString();
            }
            card.Point += puan;
            lblpuan.Text = card.Point.ToString();
            

        }

        private void borcode_Click(object sender, EventArgs e)
        {
            CardFactory factory = null;

            factory = new AmericanExpressCardFactory(Convert.ToInt32(lbllimit.Text), 5, Convert.ToInt32(lblcvv.Text), lblnumara.Text, lbltarih.Text, textBox1.Text);

            krediKartı card = factory.GetCreditCard();
            if (txtborcode.Text != "")
            {
                card.CreditLimit = card.borc_ode(Convert.ToInt32(txtborcode.Text));

            }
            lbllimit.Text = card.CreditLimit.ToString();
            int borc = (Convert.ToInt32(txtlimit.Text)) - (Convert.ToInt32(lbllimit.Text));
            lblborc.Text = borc.ToString();
        }

        private void puanileode_Click(object sender, EventArgs e)
        {
            CardFactory factory = null;
            int x;
            factory = new AmericanExpressCardFactory(Convert.ToInt32(lbllimit.Text),Convert.ToInt32(lblpuan.Text), Convert.ToInt32(lblcvv.Text), lblnumara.Text, lbltarih.Text, textBox1.Text);

            krediKartı card = factory.GetCreditCard();
            if (lblpuan.Text != "")
            {
                    card.CreditLimit = card.borc_ode(Convert.ToInt32(lblpuan.Text));
                lblpuan.Text = "0";
            }
            lbllimit.Text = card.CreditLimit.ToString();
            int borc = (Convert.ToInt32(txtlimit.Text)) - (Convert.ToInt32(lbllimit.Text));
            lblborc.Text = borc.ToString();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
                    }

        private void lbldatee_Click(object sender, EventArgs e)
        {

        }
    }
    }

