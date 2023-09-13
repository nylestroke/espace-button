using System.Drawing.Drawing2D;

namespace EscapeButton
{
    partial class MainWindow
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
            components = new System.ComponentModel.Container();
            escapeButton = new Button();
            gameTimer = new System.Windows.Forms.Timer(components);
            scoreContainer = new ToolStrip();
            scoreLabel = new ToolStripLabel();
            scoreContainer.SuspendLayout();
            SuspendLayout();
            // 
            // escapeButton
            // 
            escapeButton.AutoEllipsis = true;
            escapeButton.BackColor = Color.Khaki;
            escapeButton.Cursor = Cursors.AppStarting;
            escapeButton.FlatStyle = FlatStyle.Flat;
            escapeButton.Location = new Point(317, 171);
            escapeButton.Margin = new Padding(4, 3, 4, 3);
            escapeButton.Name = "escapeButton";
            escapeButton.Size = new Size(84, 28);
            escapeButton.TabIndex = 0;
            escapeButton.Text = "Click me ;)";
            escapeButton.UseVisualStyleBackColor = false;
            escapeButton.Click += escapeButton_Click;
            // 
            // gameTimer
            // 
            gameTimer.Interval = 1000;
            gameTimer.Tick += gameTimer_Tick;
            // 
            // scoreContainer
            // 
            scoreContainer.BackColor = Color.FromArgb(43, 43, 43);
            scoreContainer.Dock = DockStyle.Bottom;
            scoreContainer.Items.AddRange(new ToolStripItem[] { scoreLabel });
            scoreContainer.Location = new Point(0, 409);
            scoreContainer.Name = "scoreContainer";
            scoreContainer.RenderMode = ToolStripRenderMode.System;
            scoreContainer.Size = new Size(674, 25);
            scoreContainer.TabIndex = 1;
            scoreContainer.Text = "toolStrip1";
            // 
            // scoreLabel
            // 
            scoreLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            scoreLabel.ForeColor = Color.White;
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(55, 22);
            scoreLabel.Text = "Score: 0";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 27, 27);
            ClientSize = new Size(674, 434);
            Controls.Add(scoreContainer);
            Controls.Add(escapeButton);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainWindow";
            Text = "Escape Button Game, author: Vladyslav Potapenko, under MIT license";
            scoreContainer.ResumeLayout(false);
            scoreContainer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button escapeButton;
        private System.Windows.Forms.Timer gameTimer;
        private ToolStrip scoreContainer;
        private ToolStripLabel scoreLabel;
    }
}