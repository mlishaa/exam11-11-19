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


namespace exam_01_11_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {
            if(fName.Text.Trim().Equals("") || lName.Text.Trim().Equals("") || teleph.Text.Trim().Equals(""))
            {
                String msg = "Please one of the filed id required to fill it out";
                MessageBox.Show(msg, "Required", MessageBoxButtons.OKCancel);
                
            }
           String fisrtName = fName.Text;
            String lastname = lName.Text;
            String telephone = teleph.Text;
            User user = new User(fisrtName, lastname, telephone);
          

            using (StreamWriter writeTo = new StreamWriter("users.txt",true))
            {
                writeTo.WriteLine("First Name {0} Last Name {1} Telephone {2}", fisrtName, lastname, telephone);

            }


        }

        private void clearForm_Click(object sender, EventArgs e)
        {
            fName.Text = String.Empty;
            lName.Text = String.Empty;
            telephone.Text = String.Empty;
        }

        private void deleteUsers_Click(object sender, EventArgs e)
        {

            string path = "users.txt";

            try
            {
                  
                if (File.Exists(Path.Combine(path)))
                {
                    // If file found, delete it    
                    File.Delete(Path.Combine(path));
                   
                }
                else Console.WriteLine("File not found");
            }
            catch (IOException ioExp)
            {
                Console.WriteLine(ioExp.Message);
            }



    }

        private void countOfUser_Click(object sender, EventArgs e)
        {
            int count = User.COUNT;
            String message = "There are " + count + " Users ";
            MessageBox.Show(message, "Counter",MessageBoxButtons.OK);
        }
    }
}
