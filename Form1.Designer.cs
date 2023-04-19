namespace Microprocessor_Simulator
{
    partial class Mikroprocesor
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mikroprocesor));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CBinstruction = new System.Windows.Forms.ComboBox();
            this.CBregisterInput = new System.Windows.Forms.ComboBox();
            this.TBargument = new System.Windows.Forms.TextBox();
            this.BTNaddInstrution = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CBregisterArgument = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BTNstep = new System.Windows.Forms.Button();
            this.BTNexecute = new System.Windows.Forms.Button();
            this.RTBprogram = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TBAval = new System.Windows.Forms.TextBox();
            this.TBAbin = new System.Windows.Forms.TextBox();
            this.TBBval = new System.Windows.Forms.TextBox();
            this.TBBbin = new System.Windows.Forms.TextBox();
            this.TBCval = new System.Windows.Forms.TextBox();
            this.TBCbin = new System.Windows.Forms.TextBox();
            this.TBDval = new System.Windows.Forms.TextBox();
            this.TBDbin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.BTNload = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.RBregisterMode = new System.Windows.Forms.RadioButton();
            this.RBimmediateMode = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tryb adresowania ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(31, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Przerwanie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(40, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rozkaz";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(127, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(234, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // CBinstruction
            // 
            this.CBinstruction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBinstruction.Enabled = false;
            this.CBinstruction.FormattingEnabled = true;
            this.CBinstruction.Items.AddRange(new object[] {
            "ADD",
            "SUB",
            "MOV"});
            this.CBinstruction.Location = new System.Drawing.Point(127, 118);
            this.CBinstruction.Name = "CBinstruction";
            this.CBinstruction.Size = new System.Drawing.Size(121, 21);
            this.CBinstruction.TabIndex = 6;
            // 
            // CBregisterInput
            // 
            this.CBregisterInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBregisterInput.Enabled = false;
            this.CBregisterInput.FormattingEnabled = true;
            this.CBregisterInput.Items.AddRange(new object[] {
            "AX",
            "BX",
            "CX",
            "DX"});
            this.CBregisterInput.Location = new System.Drawing.Point(127, 155);
            this.CBregisterInput.Name = "CBregisterInput";
            this.CBregisterInput.Size = new System.Drawing.Size(74, 21);
            this.CBregisterInput.TabIndex = 7;
            // 
            // TBargument
            // 
            this.TBargument.Enabled = false;
            this.TBargument.Location = new System.Drawing.Point(287, 156);
            this.TBargument.Name = "TBargument";
            this.TBargument.Size = new System.Drawing.Size(74, 20);
            this.TBargument.TabIndex = 9;
            // 
            // BTNaddInstrution
            // 
            this.BTNaddInstrution.Location = new System.Drawing.Point(127, 215);
            this.BTNaddInstrution.Name = "BTNaddInstrution";
            this.BTNaddInstrution.Size = new System.Drawing.Size(234, 35);
            this.BTNaddInstrution.TabIndex = 10;
            this.BTNaddInstrution.Text = "dodaj";
            this.BTNaddInstrution.UseVisualStyleBackColor = true;
            this.BTNaddInstrution.Click += new System.EventHandler(this.BTNaddInstrution_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(40, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Rejestr";
            // 
            // CBregisterArgument
            // 
            this.CBregisterArgument.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBregisterArgument.Enabled = false;
            this.CBregisterArgument.FormattingEnabled = true;
            this.CBregisterArgument.Items.AddRange(new object[] {
            "AX",
            "BX",
            "CX",
            "DX"});
            this.CBregisterArgument.Location = new System.Drawing.Point(207, 155);
            this.CBregisterArgument.Name = "CBregisterArgument";
            this.CBregisterArgument.Size = new System.Drawing.Size(74, 21);
            this.CBregisterArgument.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(136, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "docelowy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(257, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "zawartość";
            // 
            // BTNstep
            // 
            this.BTNstep.Location = new System.Drawing.Point(407, 39);
            this.BTNstep.Name = "BTNstep";
            this.BTNstep.Size = new System.Drawing.Size(110, 43);
            this.BTNstep.TabIndex = 15;
            this.BTNstep.Text = "Wykonaj skok";
            this.BTNstep.UseVisualStyleBackColor = true;
            this.BTNstep.Click += new System.EventHandler(this.BTNstep_Click);
            // 
            // BTNexecute
            // 
            this.BTNexecute.Location = new System.Drawing.Point(407, 96);
            this.BTNexecute.Name = "BTNexecute";
            this.BTNexecute.Size = new System.Drawing.Size(110, 43);
            this.BTNexecute.TabIndex = 16;
            this.BTNexecute.Text = "Wykonaj wszystko";
            this.BTNexecute.UseVisualStyleBackColor = true;
            this.BTNexecute.Click += new System.EventHandler(this.BTNexecute_Click);
            // 
            // RTBprogram
            // 
            this.RTBprogram.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RTBprogram.Location = new System.Drawing.Point(534, 39);
            this.RTBprogram.Name = "RTBprogram";
            this.RTBprogram.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.RTBprogram.Size = new System.Drawing.Size(368, 337);
            this.RTBprogram.TabIndex = 18;
            this.RTBprogram.Text = "";
            this.RTBprogram.Leave += new System.EventHandler(this.RTBprogram_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(15, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Rejestry";
            // 
            // TBAval
            // 
            this.TBAval.Location = new System.Drawing.Point(173, 278);
            this.TBAval.Name = "TBAval";
            this.TBAval.ReadOnly = true;
            this.TBAval.Size = new System.Drawing.Size(64, 20);
            this.TBAval.TabIndex = 20;
            // 
            // TBAbin
            // 
            this.TBAbin.Location = new System.Drawing.Point(243, 278);
            this.TBAbin.Name = "TBAbin";
            this.TBAbin.ReadOnly = true;
            this.TBAbin.Size = new System.Drawing.Size(118, 20);
            this.TBAbin.TabIndex = 21;
            // 
            // TBBval
            // 
            this.TBBval.Location = new System.Drawing.Point(173, 304);
            this.TBBval.Name = "TBBval";
            this.TBBval.ReadOnly = true;
            this.TBBval.Size = new System.Drawing.Size(64, 20);
            this.TBBval.TabIndex = 22;
            // 
            // TBBbin
            // 
            this.TBBbin.Location = new System.Drawing.Point(243, 304);
            this.TBBbin.Name = "TBBbin";
            this.TBBbin.ReadOnly = true;
            this.TBBbin.Size = new System.Drawing.Size(118, 20);
            this.TBBbin.TabIndex = 23;
            // 
            // TBCval
            // 
            this.TBCval.Location = new System.Drawing.Point(173, 330);
            this.TBCval.Name = "TBCval";
            this.TBCval.ReadOnly = true;
            this.TBCval.Size = new System.Drawing.Size(64, 20);
            this.TBCval.TabIndex = 24;
            // 
            // TBCbin
            // 
            this.TBCbin.Location = new System.Drawing.Point(243, 330);
            this.TBCbin.Name = "TBCbin";
            this.TBCbin.ReadOnly = true;
            this.TBCbin.Size = new System.Drawing.Size(118, 20);
            this.TBCbin.TabIndex = 25;
            // 
            // TBDval
            // 
            this.TBDval.Location = new System.Drawing.Point(173, 356);
            this.TBDval.Name = "TBDval";
            this.TBDval.ReadOnly = true;
            this.TBDval.Size = new System.Drawing.Size(64, 20);
            this.TBDval.TabIndex = 26;
            // 
            // TBDbin
            // 
            this.TBDbin.Location = new System.Drawing.Point(243, 356);
            this.TBDbin.Name = "TBDbin";
            this.TBDbin.ReadOnly = true;
            this.TBDbin.Size = new System.Drawing.Size(118, 20);
            this.TBDbin.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(134, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "AX";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(134, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "BX";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(134, 333);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "CX";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(134, 359);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "DX";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(908, 38);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 32;
            this.Save.Text = "Zapisz";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // BTNload
            // 
            this.BTNload.Location = new System.Drawing.Point(908, 71);
            this.BTNload.Name = "BTNload";
            this.BTNload.Size = new System.Drawing.Size(75, 23);
            this.BTNload.TabIndex = 33;
            this.BTNload.Text = "Wczytaj";
            this.BTNload.UseVisualStyleBackColor = true;
            this.BTNload.Click += new System.EventHandler(this.BTNload_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(908, 353);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 34;
            this.Clear.Text = "Wyczyść";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // RBregisterMode
            // 
            this.RBregisterMode.AutoSize = true;
            this.RBregisterMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RBregisterMode.Location = new System.Drawing.Point(139, 37);
            this.RBregisterMode.Name = "RBregisterMode";
            this.RBregisterMode.Size = new System.Drawing.Size(87, 17);
            this.RBregisterMode.TabIndex = 35;
            this.RBregisterMode.TabStop = true;
            this.RBregisterMode.Text = "Rejestrowy";
            this.RBregisterMode.UseVisualStyleBackColor = true;
            this.RBregisterMode.CheckedChanged += new System.EventHandler(this.RBregisterMode_CheckedChanged);
            // 
            // RBimmediateMode
            // 
            this.RBimmediateMode.AutoSize = true;
            this.RBimmediateMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RBimmediateMode.Location = new System.Drawing.Point(232, 37);
            this.RBimmediateMode.Name = "RBimmediateMode";
            this.RBimmediateMode.Size = new System.Drawing.Size(116, 17);
            this.RBimmediateMode.TabIndex = 36;
            this.RBimmediateMode.TabStop = true;
            this.RBimmediateMode.Text = "Natychmiastowy";
            this.RBimmediateMode.UseVisualStyleBackColor = true;
            this.RBimmediateMode.CheckedChanged += new System.EventHandler(this.RBimmediateMode_CheckedChanged);
            // 
            // Mikroprocesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1007, 417);
            this.Controls.Add(this.RBimmediateMode);
            this.Controls.Add(this.RBregisterMode);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.BTNload);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TBDbin);
            this.Controls.Add(this.TBDval);
            this.Controls.Add(this.TBCbin);
            this.Controls.Add(this.TBCval);
            this.Controls.Add(this.TBBbin);
            this.Controls.Add(this.TBBval);
            this.Controls.Add(this.TBAbin);
            this.Controls.Add(this.TBAval);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RTBprogram);
            this.Controls.Add(this.BTNexecute);
            this.Controls.Add(this.BTNstep);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CBregisterArgument);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BTNaddInstrution);
            this.Controls.Add(this.TBargument);
            this.Controls.Add(this.CBregisterInput);
            this.Controls.Add(this.CBinstruction);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Mikroprocesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mikroprocesor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox CBinstruction;
        private System.Windows.Forms.ComboBox CBregisterInput;
        private System.Windows.Forms.TextBox TBargument;
        private System.Windows.Forms.Button BTNaddInstrution;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBregisterArgument;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTNstep;
        private System.Windows.Forms.Button BTNexecute;
        private System.Windows.Forms.RichTextBox RTBprogram;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBAval;
        private System.Windows.Forms.TextBox TBAbin;
        private System.Windows.Forms.TextBox TBBval;
        private System.Windows.Forms.TextBox TBBbin;
        private System.Windows.Forms.TextBox TBCval;
        private System.Windows.Forms.TextBox TBCbin;
        private System.Windows.Forms.TextBox TBDval;
        private System.Windows.Forms.TextBox TBDbin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button BTNload;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.RadioButton RBregisterMode;
        private System.Windows.Forms.RadioButton RBimmediateMode;
    }
}

