namespace MHD;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        zastavky = new System.Windows.Forms.ComboBox();
        linky = new System.Windows.Forms.ComboBox();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // zastavky
        // 
        zastavky.FormattingEnabled = true;
        zastavky.Location = new System.Drawing.Point(85, 27);
        zastavky.Name = "zastavky";
        zastavky.Size = new System.Drawing.Size(173, 23);
        zastavky.TabIndex = 0;
        zastavky.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        // 
        // linky
        // 
        linky.FormattingEnabled = true;
        linky.Location = new System.Drawing.Point(85, 56);
        linky.Name = "linky";
        linky.Size = new System.Drawing.Size(173, 23);
        linky.TabIndex = 1;
        linky.SelectedIndexChanged += linky_SelectedIndexChanged;
        // 
        // pictureBox1
        // 
        pictureBox1.BackgroundImage = ((System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage"));
        pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        pictureBox1.Location = new System.Drawing.Point(276, -62);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(529, 542);
        pictureBox1.TabIndex = 2;
        pictureBox1.TabStop = false;
        // 
        // label1
        // 
        label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        label1.Location = new System.Drawing.Point(22, 27);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(60, 23);
        label1.TabIndex = 3;
        label1.Text = "zastávka:";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(25, 59);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(57, 23);
        label2.TabIndex = 4;
        label2.Text = "linka:";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(pictureBox1);
        Controls.Add(linky);
        Controls.Add(zastavky);
        Text = "Form1";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.PictureBox pictureBox1;

    private System.Windows.Forms.ComboBox zastavky;
    private System.Windows.Forms.ComboBox linky;

    #endregion
}