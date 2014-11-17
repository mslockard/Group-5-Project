using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Quit IDE", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                Application.Exit();

            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
            {

                textBox1.Copy();

            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.CanUndo == true)
            {

                textBox1.Undo();
                textBox1.ClearUndo();
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void inputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("INPUT ");
        }

        private void outputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("OUTPUT ");
        }

        private void ifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("IF ");
        }

        private void elseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("ELSE ");
        }

        private void whileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("FOR ");
        }

        private void whileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("WHILE ");
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("CALCULATE ");
        }

        private void assignmentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("ASSIGNMENT ");
            //MessageBox.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void openProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Project File (.yolo)|*.yolo|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = false;
            openFileDialog1.ShowDialog();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to save your current program?", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (dialogResult == DialogResult.Yes)
                {
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                    saveFileDialog1.Filter = "Project File (.yolo)|*.yolo|All Files (*.*)|*.*";
                    saveFileDialog1.FilterIndex = 1;

                    saveFileDialog1.ShowDialog();
                }
                else if (dialogResult == DialogResult.No)
                {
                    textBox1.Clear();
                }
                else
                {
                    //
                } 
            }
        }

        private void openTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Project File (.tmpl)|*.tmpl|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = false;
            openFileDialog1.ShowDialog();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aboutGraphicalIDEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Graphical IDE.\n Developed by: \n Corey Fischels \n April Kroll \n Matt Lockard \n Blake Mackey \n Joshua Marlow"+
                "\n\n (c) Copyright 2014. All rights reserved.", "About", MessageBoxButtons.OK);
        }

    }
}
