
namespace Rail_Fence
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.Plain_text = new System.Windows.Forms.TextBox();
      this.Cipher_text = new System.Windows.Forms.TextBox();
      this.Key = new System.Windows.Forms.TextBox();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.Reverse = new System.Windows.Forms.CheckBox();
      this.Remove_spaces = new System.Windows.Forms.CheckBox();
      this.Remove_punctuation = new System.Windows.Forms.CheckBox();
      this.Convert = new System.Windows.Forms.Button();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.Convert_cipher = new System.Windows.Forms.Button();
      this.Plain_text_org = new System.Windows.Forms.TextBox();
      this.Ciphered_text = new System.Windows.Forms.TextBox();
      this.Key_cipher = new System.Windows.Forms.TextBox();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.SuspendLayout();
      // 
      // Plain_text
      // 
      this.Plain_text.Location = new System.Drawing.Point(5, 4);
      this.Plain_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Plain_text.Multiline = true;
      this.Plain_text.Name = "Plain_text";
      this.Plain_text.PlaceholderText = "Plain Text here...";
      this.Plain_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.Plain_text.Size = new System.Drawing.Size(646, 163);
      this.Plain_text.TabIndex = 0;
      // 
      // Cipher_text
      // 
      this.Cipher_text.Location = new System.Drawing.Point(6, 279);
      this.Cipher_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Cipher_text.Multiline = true;
      this.Cipher_text.Name = "Cipher_text";
      this.Cipher_text.PlaceholderText = "Cipher text here...";
      this.Cipher_text.ReadOnly = true;
      this.Cipher_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.Cipher_text.Size = new System.Drawing.Size(645, 175);
      this.Cipher_text.TabIndex = 1;
      // 
      // Key
      // 
      this.Key.Location = new System.Drawing.Point(350, 194);
      this.Key.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Key.Name = "Key";
      this.Key.PlaceholderText = "Enter the key";
      this.Key.Size = new System.Drawing.Size(83, 23);
      this.Key.TabIndex = 2;
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Location = new System.Drawing.Point(10, 9);
      this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(665, 486);
      this.tabControl1.TabIndex = 3;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.Reverse);
      this.tabPage1.Controls.Add(this.Remove_spaces);
      this.tabPage1.Controls.Add(this.Remove_punctuation);
      this.tabPage1.Controls.Add(this.Convert);
      this.tabPage1.Controls.Add(this.Plain_text);
      this.tabPage1.Controls.Add(this.Key);
      this.tabPage1.Controls.Add(this.Cipher_text);
      this.tabPage1.Location = new System.Drawing.Point(4, 24);
      this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tabPage1.Size = new System.Drawing.Size(657, 458);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Encrypt";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // Reverse
      // 
      this.Reverse.AutoSize = true;
      this.Reverse.Location = new System.Drawing.Point(202, 240);
      this.Reverse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Reverse.Name = "Reverse";
      this.Reverse.Size = new System.Drawing.Size(66, 19);
      this.Reverse.TabIndex = 0;
      this.Reverse.Text = "Reverse";
      this.Reverse.UseVisualStyleBackColor = true;
      // 
      // Remove_spaces
      // 
      this.Remove_spaces.AutoSize = true;
      this.Remove_spaces.Location = new System.Drawing.Point(202, 217);
      this.Remove_spaces.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Remove_spaces.Name = "Remove_spaces";
      this.Remove_spaces.Size = new System.Drawing.Size(142, 19);
      this.Remove_spaces.TabIndex = 5;
      this.Remove_spaces.Text = "Remove White Spaces";
      this.Remove_spaces.UseVisualStyleBackColor = true;
      // 
      // Remove_punctuation
      // 
      this.Remove_punctuation.AutoSize = true;
      this.Remove_punctuation.Location = new System.Drawing.Point(202, 194);
      this.Remove_punctuation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Remove_punctuation.Name = "Remove_punctuation";
      this.Remove_punctuation.Size = new System.Drawing.Size(137, 19);
      this.Remove_punctuation.TabIndex = 4;
      this.Remove_punctuation.Text = "Remove Punctuation";
      this.Remove_punctuation.UseVisualStyleBackColor = true;
      // 
      // Convert
      // 
      this.Convert.Location = new System.Drawing.Point(350, 221);
      this.Convert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Convert.Name = "Convert";
      this.Convert.Size = new System.Drawing.Size(83, 22);
      this.Convert.TabIndex = 3;
      this.Convert.Text = "Convert";
      this.Convert.UseVisualStyleBackColor = true;
      this.Convert.Click += new System.EventHandler(this.Convert_Click);
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.Convert_cipher);
      this.tabPage2.Controls.Add(this.Plain_text_org);
      this.tabPage2.Controls.Add(this.Ciphered_text);
      this.tabPage2.Controls.Add(this.Key_cipher);
      this.tabPage2.Location = new System.Drawing.Point(4, 24);
      this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tabPage2.Size = new System.Drawing.Size(657, 458);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Decrypt";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // Convert_cipher
      // 
      this.Convert_cipher.Location = new System.Drawing.Point(262, 236);
      this.Convert_cipher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Convert_cipher.Name = "Convert_cipher";
      this.Convert_cipher.Size = new System.Drawing.Size(81, 22);
      this.Convert_cipher.TabIndex = 6;
      this.Convert_cipher.Text = "Convert";
      this.Convert_cipher.UseVisualStyleBackColor = true;
      this.Convert_cipher.Click += new System.EventHandler(this.Convert_cipher_Click);
      // 
      // Plain_text_org
      // 
      this.Plain_text_org.Location = new System.Drawing.Point(6, 280);
      this.Plain_text_org.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Plain_text_org.Multiline = true;
      this.Plain_text_org.Name = "Plain_text_org";
      this.Plain_text_org.PlaceholderText = "Plain text here";
      this.Plain_text_org.ReadOnly = true;
      this.Plain_text_org.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.Plain_text_org.Size = new System.Drawing.Size(645, 174);
      this.Plain_text_org.TabIndex = 5;
      // 
      // Ciphered_text
      // 
      this.Ciphered_text.Location = new System.Drawing.Point(5, 4);
      this.Ciphered_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Ciphered_text.Multiline = true;
      this.Ciphered_text.Name = "Ciphered_text";
      this.Ciphered_text.PlaceholderText = "Ciphered text here...";
      this.Ciphered_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.Ciphered_text.Size = new System.Drawing.Size(646, 166);
      this.Ciphered_text.TabIndex = 3;
      // 
      // Key_cipher
      // 
      this.Key_cipher.Location = new System.Drawing.Point(262, 195);
      this.Key_cipher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Key_cipher.Name = "Key_cipher";
      this.Key_cipher.PlaceholderText = "Enter the key";
      this.Key_cipher.Size = new System.Drawing.Size(81, 23);
      this.Key_cipher.TabIndex = 4;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(687, 506);
      this.Controls.Add(this.tabControl1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.Text = "Rail Fence";
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TextBox Plain_text;
    private System.Windows.Forms.TextBox Cipher_text;
    private System.Windows.Forms.TextBox Key;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.Button Convert;
    private System.Windows.Forms.TextBox Plain_text_org;
    private System.Windows.Forms.TextBox Ciphered_text;
    private System.Windows.Forms.TextBox Key_cipher;
    private System.Windows.Forms.Button Convert_cipher;
    private System.Windows.Forms.CheckBox Remove_spaces;
    private System.Windows.Forms.CheckBox Remove_punctuation;
    private System.Windows.Forms.CheckBox Reverse;
  }
}
