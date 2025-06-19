using System.Diagnostics.CodeAnalysis;

namespace PostmanCloneUI;

partial class Dashboard
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.PictureBox logoPicture;
    private System.Windows.Forms.Label headingLabel;
    private System.Windows.Forms.Label methodLabel;
    private System.Windows.Forms.TextBox urlInput;
    private System.Windows.Forms.Button sendButton;
    private System.Windows.Forms.Label responseLabel;
    private System.Windows.Forms.TextBox responseDataOutput;

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
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Postman Clone";
        this.Font = new System.Drawing.Font("Segoe UI", 18F);

        this.logoPicture = new PictureBox();
        this.logoPicture.Name = "logoPicture";
        this.logoPicture.SizeMode = PictureBoxSizeMode.StretchImage;
        this.logoPicture.Location = new Point(0, 0);
        this.logoPicture.Size = new Size(110, 110);
        this.logoPicture.Image = Image.FromFile("./PostmanCloneUI/assets/postman-logo.png");

        this.headingLabel = new Label();
        this.headingLabel.Name = "headingLabel";
        this.headingLabel.Text = "Postman Clone";
        this.headingLabel.Font = new Font("Segoe UI", 30);
        this.headingLabel.AutoSize = false;
        this.headingLabel.Location = new Point(110, 0);
        this.headingLabel.Size = new Size(690, 110);
        this.headingLabel.TabIndex = 0;

        this.methodLabel = new Label();
        this.methodLabel.Name = "methodLabel";
        this.methodLabel.Text = "Get";
        this.methodLabel.Font = new Font("Segoe UI", 16);
        this.methodLabel.AutoSize = false;
        this.methodLabel.Location = new Point(0, 110);
        this.methodLabel.Size = new Size(120, 40);

        this.urlInput = new TextBox
        {
            Name = "urlInput",
            Width = 560,
            Height = 40,
            Location = new Point(120, 110),
        };

        this.sendButton = new Button
        {
            Name = "sendButton",
            Text = "Send",
            Font = new Font("Segoe UI", 14),
            AutoSize = false,
            Location = new Point(680, 110),
            Size = new Size(120, 40),
        };

        this.responseLabel = new Label();
        this.responseLabel.Name = "responseLabel";
        this.responseLabel.Text = "Response Data";
        this.responseLabel.Font = new Font("Segoe UI", 16);
        this.responseLabel.AutoSize = false;
        this.responseLabel.Location = new Point(0, 150);
        this.responseLabel.Size = new Size(800, 40);

        this.responseDataOutput = new TextBox();
        this.responseDataOutput.Name = "responseDataOutput";
        this.responseDataOutput.Multiline = true;
        this.responseDataOutput.Location = new Point(5, 195);
        this.responseDataOutput.Width = 790;
        this.responseDataOutput.Height = 250;
        this.responseDataOutput.ReadOnly = true;

        // Add controls to Dashboard
        this.Controls.Add(this.logoPicture);
        this.Controls.Add(this.headingLabel);
        this.Controls.Add(this.methodLabel);
        this.Controls.Add(this.urlInput);
        this.Controls.Add(this.sendButton);
        this.Controls.Add(this.responseLabel);
        this.Controls.Add(this.responseDataOutput);
    }

    #endregion
}
