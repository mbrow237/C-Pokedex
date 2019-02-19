namespace PokedexApplication
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
            this.pokemonListComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // pokemonListComboBox
            // 
            this.pokemonListComboBox.FormattingEnabled = true;
            this.pokemonListComboBox.Location = new System.Drawing.Point(257, 12);
            this.pokemonListComboBox.Name = "pokemonListComboBox";
            this.pokemonListComboBox.Size = new System.Drawing.Size(156, 24);
            this.pokemonListComboBox.TabIndex = 0;
            this.pokemonListComboBox.Text = "Select a Pokemon";
            this.pokemonListComboBox.SelectedIndexChanged += new System.EventHandler(this.pokemonListComboBox_SelectedIndexChanged);
            // 
            // pokedexMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pokemonListComboBox);
            this.Name = "pokedexMainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox pokemonListComboBox;
    }
}

