namespace WindowsFormsApp1
{
    partial class cabinet
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
            this.profilePhoto = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.infoWindow = new System.Windows.Forms.Label();
            this.mpButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.joinHello = new System.Windows.Forms.Label();
            this.fullName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profilePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // profilePhoto
            // 
            this.profilePhoto.Location = new System.Drawing.Point(12, 100);
            this.profilePhoto.Name = "profilePhoto";
            this.profilePhoto.Size = new System.Drawing.Size(215, 370);
            this.profilePhoto.TabIndex = 0;
            this.profilePhoto.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 141);
            this.button1.TabIndex = 1;
            this.button1.Text = "Мой профиль";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // infoWindow
            // 
            this.infoWindow.AutoSize = true;
            this.infoWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoWindow.Location = new System.Drawing.Point(228, 9);
            this.infoWindow.Name = "infoWindow";
            this.infoWindow.Size = new System.Drawing.Size(116, 46);
            this.infoWindow.TabIndex = 2;
            this.infoWindow.Text = "Окно";
            // 
            // mpButton
            // 
            this.mpButton.Location = new System.Drawing.Point(329, 199);
            this.mpButton.Margin = new System.Windows.Forms.Padding(5);
            this.mpButton.Name = "mpButton";
            this.mpButton.Padding = new System.Windows.Forms.Padding(15);
            this.mpButton.Size = new System.Drawing.Size(286, 139);
            this.mpButton.TabIndex = 3;
            this.mpButton.Text = "Мероприятия";
            this.mpButton.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(329, 368);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(286, 139);
            this.button3.TabIndex = 4;
            this.button3.Text = "Участники";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(329, 530);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(286, 139);
            this.button4.TabIndex = 5;
            this.button4.Text = "Жюри";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // joinHello
            // 
            this.joinHello.AutoSize = true;
            this.joinHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.joinHello.Location = new System.Drawing.Point(333, 100);
            this.joinHello.Name = "joinHello";
            this.joinHello.Size = new System.Drawing.Size(164, 29);
            this.joinHello.TabIndex = 6;
            this.joinHello.Text = "Приветствие";
            // 
            // fullName
            // 
            this.fullName.AutoSize = true;
            this.fullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullName.Location = new System.Drawing.Point(333, 146);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(164, 29);
            this.fullName.TabIndex = 7;
            this.fullName.Text = "Приветствие";
            // 
            // cabinet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 693);
            this.Controls.Add(this.fullName);
            this.Controls.Add(this.joinHello);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.mpButton);
            this.Controls.Add(this.infoWindow);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.profilePhoto);
            this.Name = "cabinet";
            this.Text = "cabinet";
            this.Load += new System.EventHandler(this.cabinet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox profilePhoto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label infoWindow;
        private System.Windows.Forms.Button mpButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label joinHello;
        private System.Windows.Forms.Label fullName;
    }
}