﻿namespace PokedexApplication
{
    partial class pokedexMainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pokemonListComboBox = new System.Windows.Forms.ComboBox();
            this.pokemonNameLabel = new System.Windows.Forms.Label();
            this.hpLabel = new System.Windows.Forms.Label();
            this.attackLabel = new System.Windows.Forms.Label();
            this.defLabel = new System.Windows.Forms.Label();
            this.spattLabel = new System.Windows.Forms.Label();
            this.spdefLabel = new System.Windows.Forms.Label();
            this.spdLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pokemonTypeOneLabel = new System.Windows.Forms.Label();
            this.pokemonTypeTwoLabel = new System.Windows.Forms.Label();
            this.pokemonAbilityOneLabel = new System.Windows.Forms.Label();
            this.pokemonAbilityTwoLabel = new System.Windows.Forms.Label();
            this.pokemonAbilityThreeLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pokemonListComboBox
            // 
            this.pokemonListComboBox.FormattingEnabled = true;
            this.pokemonListComboBox.Location = new System.Drawing.Point(257, 12);
            this.pokemonListComboBox.Name = "pokemonListComboBox";
            this.pokemonListComboBox.Size = new System.Drawing.Size(240, 24);
            this.pokemonListComboBox.TabIndex = 0;
            this.pokemonListComboBox.Text = "Select a Pokemon";
            this.pokemonListComboBox.SelectedIndexChanged += new System.EventHandler(this.pokemonListComboBox_SelectedIndexChanged);
            // 
            // pokemonNameLabel
            // 
            this.pokemonNameLabel.AutoSize = true;
            this.pokemonNameLabel.Location = new System.Drawing.Point(349, 39);
            this.pokemonNameLabel.Name = "pokemonNameLabel";
            this.pokemonNameLabel.Size = new System.Drawing.Size(46, 17);
            this.pokemonNameLabel.TabIndex = 1;
            this.pokemonNameLabel.Text = "label1";
            this.pokemonNameLabel.Click += new System.EventHandler(this.pokemonNameLabel_Click);
            // 
            // hpLabel
            // 
            this.hpLabel.AutoSize = true;
            this.hpLabel.Location = new System.Drawing.Point(21, 20);
            this.hpLabel.Name = "hpLabel";
            this.hpLabel.Size = new System.Drawing.Size(46, 17);
            this.hpLabel.TabIndex = 2;
            this.hpLabel.Text = "label1";
            this.hpLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // attackLabel
            // 
            this.attackLabel.AutoSize = true;
            this.attackLabel.Location = new System.Drawing.Point(21, 57);
            this.attackLabel.Name = "attackLabel";
            this.attackLabel.Size = new System.Drawing.Size(46, 17);
            this.attackLabel.TabIndex = 3;
            this.attackLabel.Text = "label2";
            // 
            // defLabel
            // 
            this.defLabel.AutoSize = true;
            this.defLabel.Location = new System.Drawing.Point(21, 96);
            this.defLabel.Name = "defLabel";
            this.defLabel.Size = new System.Drawing.Size(46, 17);
            this.defLabel.TabIndex = 4;
            this.defLabel.Text = "label3";
            // 
            // spattLabel
            // 
            this.spattLabel.AutoSize = true;
            this.spattLabel.Location = new System.Drawing.Point(21, 133);
            this.spattLabel.Name = "spattLabel";
            this.spattLabel.Size = new System.Drawing.Size(46, 17);
            this.spattLabel.TabIndex = 5;
            this.spattLabel.Text = "label4";
            // 
            // spdefLabel
            // 
            this.spdefLabel.AutoSize = true;
            this.spdefLabel.Location = new System.Drawing.Point(21, 175);
            this.spdefLabel.Name = "spdefLabel";
            this.spdefLabel.Size = new System.Drawing.Size(46, 17);
            this.spdefLabel.TabIndex = 6;
            this.spdefLabel.Text = "label5";
            // 
            // spdLabel
            // 
            this.spdLabel.AutoSize = true;
            this.spdLabel.Location = new System.Drawing.Point(21, 220);
            this.spdLabel.Name = "spdLabel";
            this.spdLabel.Size = new System.Drawing.Size(46, 17);
            this.spdLabel.TabIndex = 7;
            this.spdLabel.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.hpLabel);
            this.panel1.Controls.Add(this.spdLabel);
            this.panel1.Controls.Add(this.attackLabel);
            this.panel1.Controls.Add(this.spdefLabel);
            this.panel1.Controls.Add(this.defLabel);
            this.panel1.Controls.Add(this.spattLabel);
            this.panel1.Location = new System.Drawing.Point(12, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 249);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pokemonTypeOneLabel
            // 
            this.pokemonTypeOneLabel.AutoSize = true;
            this.pokemonTypeOneLabel.Location = new System.Drawing.Point(680, 39);
            this.pokemonTypeOneLabel.Name = "pokemonTypeOneLabel";
            this.pokemonTypeOneLabel.Size = new System.Drawing.Size(46, 17);
            this.pokemonTypeOneLabel.TabIndex = 9;
            this.pokemonTypeOneLabel.Text = "label1";
            // 
            // pokemonTypeTwoLabel
            // 
            this.pokemonTypeTwoLabel.AutoSize = true;
            this.pokemonTypeTwoLabel.Location = new System.Drawing.Point(762, 39);
            this.pokemonTypeTwoLabel.Name = "pokemonTypeTwoLabel";
            this.pokemonTypeTwoLabel.Size = new System.Drawing.Size(46, 17);
            this.pokemonTypeTwoLabel.TabIndex = 10;
            this.pokemonTypeTwoLabel.Text = "label2";
            // 
            // pokemonAbilityOneLabel
            // 
            this.pokemonAbilityOneLabel.AutoSize = true;
            this.pokemonAbilityOneLabel.Location = new System.Drawing.Point(593, 118);
            this.pokemonAbilityOneLabel.Name = "pokemonAbilityOneLabel";
            this.pokemonAbilityOneLabel.Size = new System.Drawing.Size(57, 17);
            this.pokemonAbilityOneLabel.TabIndex = 11;
            this.pokemonAbilityOneLabel.Text = "Ability 1";
            // 
            // pokemonAbilityTwoLabel
            // 
            this.pokemonAbilityTwoLabel.AutoSize = true;
            this.pokemonAbilityTwoLabel.Location = new System.Drawing.Point(796, 118);
            this.pokemonAbilityTwoLabel.Name = "pokemonAbilityTwoLabel";
            this.pokemonAbilityTwoLabel.Size = new System.Drawing.Size(57, 17);
            this.pokemonAbilityTwoLabel.TabIndex = 12;
            this.pokemonAbilityTwoLabel.Text = "Ability 2";
            // 
            // pokemonAbilityThreeLabel
            // 
            this.pokemonAbilityThreeLabel.AutoSize = true;
            this.pokemonAbilityThreeLabel.Location = new System.Drawing.Point(691, 175);
            this.pokemonAbilityThreeLabel.Name = "pokemonAbilityThreeLabel";
            this.pokemonAbilityThreeLabel.Size = new System.Drawing.Size(53, 17);
            this.pokemonAbilityThreeLabel.TabIndex = 13;
            this.pokemonAbilityThreeLabel.Text = "Hidden";
            // 
            // pokedexMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 571);
            this.Controls.Add(this.pokemonAbilityThreeLabel);
            this.Controls.Add(this.pokemonAbilityTwoLabel);
            this.Controls.Add(this.pokemonAbilityOneLabel);
            this.Controls.Add(this.pokemonTypeTwoLabel);
            this.Controls.Add(this.pokemonTypeOneLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pokemonNameLabel);
            this.Controls.Add(this.pokemonListComboBox);
            this.Name = "pokedexMainWindow";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox pokemonListComboBox;
        private System.Windows.Forms.Label pokemonNameLabel;
        private System.Windows.Forms.Label hpLabel;
        private System.Windows.Forms.Label attackLabel;
        private System.Windows.Forms.Label defLabel;
        private System.Windows.Forms.Label spattLabel;
        private System.Windows.Forms.Label spdefLabel;
        private System.Windows.Forms.Label spdLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label pokemonTypeTwoLabel;
        private System.Windows.Forms.Label pokemonTypeOneLabel;
        private System.Windows.Forms.Label pokemonAbilityOneLabel;
        private System.Windows.Forms.Label pokemonAbilityTwoLabel;
        private System.Windows.Forms.Label pokemonAbilityThreeLabel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

