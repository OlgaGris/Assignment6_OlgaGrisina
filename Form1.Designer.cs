namespace Assignment6_OlgaGrisina
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rock = new System.Windows.Forms.Button();
            this.paper = new System.Windows.Forms.Button();
            this.scissor = new System.Windows.Forms.Button();
            this.comp = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Computer";
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result.Location = new System.Drawing.Point(144, 151);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(164, 40);
            this.result.TabIndex = 2;
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rock
            // 
            this.rock.Location = new System.Drawing.Point(12, 21);
            this.rock.Name = "rock";
            this.rock.Size = new System.Drawing.Size(125, 31);
            this.rock.TabIndex = 4;
            this.rock.Text = "Rock";
            this.rock.UseVisualStyleBackColor = true;
            this.rock.Click += new System.EventHandler(this.rock_Click);
            // 
            // paper
            // 
            this.paper.Location = new System.Drawing.Point(156, 21);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(125, 31);
            this.paper.TabIndex = 4;
            this.paper.Text = "Paper";
            this.paper.UseVisualStyleBackColor = true;
            this.paper.Click += new System.EventHandler(this.paper_Click);
            // 
            // scissor
            // 
            this.scissor.Location = new System.Drawing.Point(301, 21);
            this.scissor.Name = "scissor";
            this.scissor.Size = new System.Drawing.Size(125, 31);
            this.scissor.TabIndex = 4;
            this.scissor.Text = "Scissors";
            this.scissor.UseVisualStyleBackColor = true;
            this.scissor.Click += new System.EventHandler(this.scissor_Click);
            // 
            // comp
            // 
            this.comp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.comp.Location = new System.Drawing.Point(235, 99);
            this.comp.Name = "comp";
            this.comp.Size = new System.Drawing.Size(114, 42);
            this.comp.TabIndex = 5;
            this.comp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player
            // 
            this.player.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player.Location = new System.Drawing.Point(101, 99);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(114, 42);
            this.player.TabIndex = 5;
            this.player.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.player.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 228);
            this.Controls.Add(this.player);
            this.Controls.Add(this.comp);
            this.Controls.Add(this.scissor);
            this.Controls.Add(this.paper);
            this.Controls.Add(this.rock);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Rock-Paper-Scissors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label result;
        private Button button1;
        private Button rock;
        private Button paper;
        private Button scissor;
        private Label comp;
        private Label player;
    }
}