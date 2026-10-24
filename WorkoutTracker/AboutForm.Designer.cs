namespace WorkoutTracker
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            lblAppTitle = new Label();
            lblDescription = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblAppTitle
            // 
            lblAppTitle.AutoSize = true;
            lblAppTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblAppTitle.Location = new Point(20, 20);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Size = new Size(231, 37);
            lblAppTitle.TabIndex = 0;
            lblAppTitle.Text = "Workout Tracker";
            // 
            // lblDescription
            // 
            lblDescription.Font = new Font("Segoe UI", 10F);
            lblDescription.Location = new Point(20, 65);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(448, 239);
            lblDescription.TabIndex = 1;
            lblDescription.Text = resources.GetString("lblDescription.Text");
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(37, 99, 235);
            btnClose.DialogResult = DialogResult.OK;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(378, 320);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(90, 30);
            btnClose.TabIndex = 2;
            btnClose.Text = "OK";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 372);
            Controls.Add(btnClose);
            Controls.Add(lblDescription);
            Controls.Add(lblAppTitle);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Workout Tracker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppTitle;
        private Label lblDescription;
        private Button btnClose;
    }
}