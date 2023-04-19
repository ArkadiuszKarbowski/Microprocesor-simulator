using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Microprocessor_Simulator
{
    public partial class Mikroprocesor : Form
    {
        public int AX; public int AXL; public int AXH;
        public int BX; public int BXL; public int BXH;
        public int CX; public int CXL; public int CXH;
        public int DX; public int DXL; public int DXH;
                
        public int instructionNumber = 0;

       
        //PROGRAM
        List<String> program = new List<String>();
        List<String> input = new List<String>();
        List<String> argument = new List<String>();

        public Mikroprocesor()
        {
            InitializeComponent();
            insert();
        }
        
        private void bin(int dec, TextBox text) //DEC TO BIN
        {
            text.Clear();
            for (int i = 15; i >= 0; i--)
            {
                if (i == 7) text.Text += " ";
                text.Text += Convert.ToString((dec >> i) % 2);
            }
        }

        private void insert() //FILL REGISTERS TEXTBOXES 
        {
            TBAval.Text = AX.ToString(); bin(AX, TBAbin);
            TBBval.Text = BX.ToString(); bin(BX, TBBbin);
            TBCval.Text = CX.ToString(); bin(CX, TBCbin);
            TBDval.Text = DX.ToString(); bin(DX, TBDbin);
        }


        //INSTRUCTIONS
        public void ADD(String input, String argument)
        {
            switch (input)
            {
                case "AX": AX = AX + Convert.ToInt32(GetValue(argument)); bin(AX, TBAbin); TBAval.Text = AX.ToString(); break;
                case "BX": BX = BX + Convert.ToInt32(GetValue(argument)); bin(BX, TBBbin); TBBval.Text = BX.ToString(); break;
                case "CX": CX = CX + Convert.ToInt32(GetValue(argument)); bin(CX, TBCbin); TBCval.Text = CX.ToString(); break;
                case "DX": DX = DX + Convert.ToInt32(GetValue(argument)); bin(DX, TBDbin); TBDval.Text = DX.ToString(); break;
            }
        }

        public void SUB(String input, String argument)
        {
            switch (input)
            {
                case "AX": AX = AX - Convert.ToInt32(GetValue(argument)); bin(AX, TBAbin); TBAval.Text = AX.ToString(); break; 
                case "BX": BX = BX - Convert.ToInt32(GetValue(argument)); bin(BX, TBBbin); TBBval.Text = BX.ToString(); break;
                case "CX": CX = CX - Convert.ToInt32(GetValue(argument)); bin(CX, TBCbin); TBCval.Text = CX.ToString(); break;
                case "DX": DX = DX - Convert.ToInt32(GetValue(argument)); bin(DX, TBDbin); TBDval.Text = DX.ToString(); break;
            }
        }
        
        public void MOV(String input, String argument)
        {
            {
                switch (input)
                {
                    case "AX": AX = Convert.ToInt32(GetValue(argument)); ClearRegister(argument); bin(AX, TBAbin); TBAval.Text = AX.ToString(); break;
                    case "BX": BX = Convert.ToInt32(GetValue(argument)); ClearRegister(argument); bin(BX, TBBbin); TBBval.Text = BX.ToString(); break;
                    case "CX": CX = Convert.ToInt32(GetValue(argument)); ClearRegister(argument); bin(CX, TBCbin); TBCval.Text = CX.ToString(); break;
                    case "DX": DX = Convert.ToInt32(GetValue(argument)); ClearRegister(argument); bin(DX, TBDbin); TBDval.Text = DX.ToString(); break;
                }
            }
            
        }

        private void ClearRegister(String argument) 
        {
            switch (argument)
            {
                case "AX": AX = 0; bin(AX, TBAbin); TBAval.Text = AX.ToString(); break;
                case "BX": BX = 0; bin(BX, TBBbin); TBBval.Text = BX.ToString(); break;
                case "CX": CX = 0; bin(CX, TBCbin); TBCval.Text = CX.ToString(); break;
                case "DX": DX = 0; bin(DX, TBDbin); TBDval.Text = DX.ToString(); break;
            }
        }


        //INSTRUCTIONS END

        private string GetValue(String argument)
        {
            string mo;
            switch (argument)
                { 
                case "AX": mo = TBAval.Text.ToString(); break; 
                case "BX": mo = TBBval.Text.ToString(); break;
                case "CX": mo = TBCval.Text.ToString(); break;
                case "DX": mo = TBDval.Text.ToString(); break;
                default:   mo = argument; break;
            }
            return mo;
        }

        private void RBregisterMode_CheckedChanged(object sender, EventArgs e)
        {
            CBinstruction.Enabled = true;
            CBregisterInput.Enabled = true;
            CBregisterArgument.Enabled = true;
            TBargument.Enabled = false;
            TBargument.Clear();
        }

        private void RBimmediateMode_CheckedChanged(object sender, EventArgs e)
        {
            CBinstruction.Enabled = true;
            CBregisterInput.Enabled = true;
            CBregisterArgument.Enabled = false;
            CBregisterArgument.SelectedIndex = -1; 
            TBargument.Enabled = true;
        }

        private void BTNaddInstrution_Click(object sender, EventArgs e)
        {
            if (RBimmediateMode.Checked || RBregisterMode.Checked)
            {
                try
                {
                    program.Add(CBinstruction.SelectedItem.ToString());
                    input.Add(CBregisterInput.SelectedItem.ToString());
                    
                    if (RBimmediateMode.Checked)
                    {
                        int parsedValue;
                        bool isInt = int.TryParse(TBargument.Text, out parsedValue);
                        
                        if (isInt)
                        {
                            argument.Add(TBargument.Text.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Nieprawidłowa wartość argumentu!");
                                
                        }
                    }
                     
                    else if (RBregisterMode.Checked) argument.Add(CBregisterArgument.Text.ToString());
                    
                    int i = program.Count - 1;

                    RTBprogram.AppendText( i+1 + ". " + program[i] + " " + input[i] + " " + argument[i] + Environment.NewLine);
                }
                catch { MessageBox.Show("Nie wybrano rejestru!"); }
            }
            else MessageBox.Show("Nie wybrano trybu!");
        }

        private void BTNexecute_Click(object sender, EventArgs e)
        {
            Type type = typeof(Mikroprocesor);
            int instructionNumber = 0;

            Timer timer = new Timer();
            timer.Interval = 2000;
            timer.Tick += (s, args) =>
            {
                if (instructionNumber >= program.Count)
                {
                    timer.Stop();
                    return;
                }

                string methodName = program[instructionNumber];
                MethodInfo method = type.GetMethod(methodName);
                if (method != null)
                {
                    String[] parameters = new string[] { input[instructionNumber], argument[instructionNumber] };
                    method.Invoke(this, parameters);
                    updateCurrentLine(instructionNumber);
                    instructionNumber++;
                }
            };

            timer.Start();
        }

        private void BTNstep_Click(object sender, EventArgs e)
        {
            Type type = typeof(Mikroprocesor);
            if (instructionNumber < program.Count)
            {
                MethodInfo method = type.GetMethod(program[instructionNumber]);
                if (method != null)
                {
                    String[] parameters = new string[] { input[instructionNumber], argument[instructionNumber] };

                    method.Invoke(this, parameters);
                    updateCurrentLine(instructionNumber);
                    instructionNumber++;

                }
            }
        }

        private void BTNload_Click(object sender, EventArgs e)
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"Resources\file.txt");
            if (File.Exists(filePath))
            {
                RTBprogram.Text = File.ReadAllText(filePath);
                Refresh();
               
            }
            else
            {
                MessageBox.Show("Plik nie został znaleziony.");
            }
            
        }
        private void Refresh()
        {
            program.Clear();
            input.Clear();
            argument.Clear();
           
            string[] lines = RTBprogram.Lines;

            foreach (string line in lines)
            {
                string[] elements = line.Split(' ');
                if (elements.Length >= 4)
                {
                    program.Add(elements[1]);
                    input.Add(elements[2]);
                    argument.Add(elements[3]);
                    instructionNumber = 0;
                }
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"Resources\file.txt");
            File.WriteAllText(filePath, RTBprogram.Text);
        }

        private void updateCurrentLine(int instructionNumber)
        {
            RTBprogram.Select(RTBprogram.GetFirstCharIndexFromLine(instructionNumber), RTBprogram.Lines[instructionNumber].Length);
            RTBprogram.SelectionColor = Color.Gray;
            RTBprogram.DeselectAll();

            if (instructionNumber > 0)
            {
                RTBprogram.Select(RTBprogram.GetFirstCharIndexFromLine(instructionNumber - 1), RTBprogram.Lines[instructionNumber - 1].Length);
                RTBprogram.SelectionColor = Color.Black;
                RTBprogram.SelectedText = RTBprogram.SelectedText.Replace("⇨ ", "");
                RTBprogram.DeselectAll();
            }

            RTBprogram.Select(RTBprogram.GetFirstCharIndexFromLine(instructionNumber), RTBprogram.Lines[instructionNumber   ].Length);
            RTBprogram.SelectionColor = Color.DimGray;
            RTBprogram.SelectedText = "⇨ " + RTBprogram.SelectedText;
            RTBprogram.DeselectAll();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            RTBprogram.Clear();
            instructionNumber = 0;
            program.Clear();
            input.Clear();
            argument.Clear();
            foreach(String reg in CBregisterInput.Items)
            {
                ClearRegister(reg);
            }

        }

        private void RTBprogram_Leave(object sender, EventArgs e)
        {
            Refresh();
        }
    }
    
}
