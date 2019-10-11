namespace CharacterCreator.Winforms
{
    partial class CharacterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this._boxProfession = new System.Windows.Forms.ComboBox();
            this._boxRace = new System.Windows.Forms.ComboBox();
            this._txtName = new System.Windows.Forms.TextBox();
            this._txtDesctription = new System.Windows.Forms.TextBox();
            this._txtStrength = new System.Windows.Forms.TextBox();
            this._txtDexterity = new System.Windows.Forms.TextBox();
            this._txtConstitution = new System.Windows.Forms.TextBox();
            this._txtIntelligence = new System.Windows.Forms.TextBox();
            this._txtWisdom = new System.Windows.Forms.TextBox();
            this._txtCharisma = new System.Windows.Forms.TextBox();
            this._buttonSave = new System.Windows.Forms.Button();
            this._buttonCancel = new System.Windows.Forms.Button();
            this._errors = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._errors)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Profession";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Race";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Strength";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Dexterity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Constitution";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(285, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Intelligence";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(285, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Wisdom";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(285, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Charisma";
            // 
            // _boxProfession
            // 
            this._boxProfession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._boxProfession.FormattingEnabled = true;
            this._boxProfession.Items.AddRange(new object[] {
            "Barbarian",
            "Bard",
            "Cleric",
            "Druid",
            "Fighter",
            "Monk",
            "Paladin",
            "Ranger",
            "Rogue",
            "Sorcerer",
            "Warlock",
            "Wizard"});
            this._boxProfession.Location = new System.Drawing.Point(95, 51);
            this._boxProfession.Name = "_boxProfession";
            this._boxProfession.Size = new System.Drawing.Size(121, 21);
            this._boxProfession.Sorted = true;
            this._boxProfession.TabIndex = 3;
            this._boxProfession.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingProfession);
            // 
            // _boxRace
            // 
            this._boxRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._boxRace.FormattingEnabled = true;
            this._boxRace.Items.AddRange(new object[] {
            "Dragonborn",
            "Dwarf",
            "Elf",
            "Gnome",
            "Half-Elf",
            "Halfling",
            "Half-Orc",
            "Human",
            "Tiefling"});
            this._boxRace.Location = new System.Drawing.Point(95, 91);
            this._boxRace.Name = "_boxRace";
            this._boxRace.Size = new System.Drawing.Size(121, 21);
            this._boxRace.TabIndex = 5;
            this._boxRace.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingRace);
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(95, 12);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(121, 20);
            this._txtName.TabIndex = 1;
            this._txtName.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingName);
            // 
            // _txtDesctription
            // 
            this._txtDesctription.Location = new System.Drawing.Point(12, 229);
            this._txtDesctription.Multiline = true;
            this._txtDesctription.Name = "_txtDesctription";
            this._txtDesctription.Size = new System.Drawing.Size(462, 136);
            this._txtDesctription.TabIndex = 19;
            // 
            // _txtStrength
            // 
            this._txtStrength.Location = new System.Drawing.Point(367, 17);
            this._txtStrength.Name = "_txtStrength";
            this._txtStrength.Size = new System.Drawing.Size(37, 20);
            this._txtStrength.TabIndex = 7;
            this._txtStrength.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingAttribute);
            // 
            // _txtDexterity
            // 
            this._txtDexterity.Location = new System.Drawing.Point(367, 51);
            this._txtDexterity.Name = "_txtDexterity";
            this._txtDexterity.Size = new System.Drawing.Size(37, 20);
            this._txtDexterity.TabIndex = 9;
            this._txtDexterity.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingAttribute);
            // 
            // _txtConstitution
            // 
            this._txtConstitution.Location = new System.Drawing.Point(367, 88);
            this._txtConstitution.Name = "_txtConstitution";
            this._txtConstitution.Size = new System.Drawing.Size(37, 20);
            this._txtConstitution.TabIndex = 11;
            this._txtConstitution.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingAttribute);
            // 
            // _txtIntelligence
            // 
            this._txtIntelligence.Location = new System.Drawing.Point(367, 126);
            this._txtIntelligence.Name = "_txtIntelligence";
            this._txtIntelligence.Size = new System.Drawing.Size(37, 20);
            this._txtIntelligence.TabIndex = 13;
            this._txtIntelligence.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingAttribute);
            // 
            // _txtWisdom
            // 
            this._txtWisdom.Location = new System.Drawing.Point(367, 157);
            this._txtWisdom.Name = "_txtWisdom";
            this._txtWisdom.Size = new System.Drawing.Size(37, 20);
            this._txtWisdom.TabIndex = 15;
            this._txtWisdom.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingAttribute);
            // 
            // _txtCharisma
            // 
            this._txtCharisma.Location = new System.Drawing.Point(367, 192);
            this._txtCharisma.Name = "_txtCharisma";
            this._txtCharisma.Size = new System.Drawing.Size(37, 20);
            this._txtCharisma.TabIndex = 17;
            this._txtCharisma.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingAttribute);
            // 
            // _buttonSave
            // 
            this._buttonSave.Location = new System.Drawing.Point(302, 373);
            this._buttonSave.Name = "_buttonSave";
            this._buttonSave.Size = new System.Drawing.Size(75, 23);
            this._buttonSave.TabIndex = 20;
            this._buttonSave.Text = "Save";
            this._buttonSave.UseVisualStyleBackColor = true;
            this._buttonSave.Click += new System.EventHandler(this.OnSave);
            // 
            // _buttonCancel
            // 
            this._buttonCancel.Location = new System.Drawing.Point(399, 373);
            this._buttonCancel.Name = "_buttonCancel";
            this._buttonCancel.Size = new System.Drawing.Size(75, 23);
            this._buttonCancel.TabIndex = 21;
            this._buttonCancel.Text = "Cancel";
            this._buttonCancel.UseVisualStyleBackColor = true;
            this._buttonCancel.Click += new System.EventHandler(this.OnCancel);
            // 
            // _errors
            // 
            this._errors.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this._errors.ContainerControl = this;
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(486, 408);
            this.Controls.Add(this._buttonCancel);
            this.Controls.Add(this._buttonSave);
            this.Controls.Add(this._txtCharisma);
            this.Controls.Add(this._txtWisdom);
            this.Controls.Add(this._txtIntelligence);
            this.Controls.Add(this._txtConstitution);
            this.Controls.Add(this._txtDexterity);
            this.Controls.Add(this._txtStrength);
            this.Controls.Add(this._txtDesctription);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this._boxRace);
            this.Controls.Add(this._boxProfession);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(502, 447);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(502, 447);
            this.Name = "CharacterForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Character";
            ((System.ComponentModel.ISupportInitialize)(this._errors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox _boxProfession;
        private System.Windows.Forms.ComboBox _boxRace;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.TextBox _txtDesctription;
        private System.Windows.Forms.TextBox _txtStrength;
        private System.Windows.Forms.TextBox _txtDexterity;
        private System.Windows.Forms.TextBox _txtConstitution;
        private System.Windows.Forms.TextBox _txtIntelligence;
        private System.Windows.Forms.TextBox _txtWisdom;
        private System.Windows.Forms.TextBox _txtCharisma;
        private System.Windows.Forms.Button _buttonSave;
        private System.Windows.Forms.Button _buttonCancel;
        private System.Windows.Forms.ErrorProvider _errors;
    }
}