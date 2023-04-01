namespace AL_SULTAN.Gui.GuiHome
{
    partial class HomeUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonOutPut = new System.Windows.Forms.Button();
            this.buttonInPut = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonAddProject = new System.Windows.Forms.Button();
            this.buttonAddSupplier = new System.Windows.Forms.Button();
            this.buttonAddCoustomer = new System.Windows.Forms.Button();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 459);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 141);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F);
            this.label1.Location = new System.Drawing.Point(496, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "الوصول السريع";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.buttonOutPut);
            this.groupBox1.Controls.Add(this.buttonInPut);
            this.groupBox1.Controls.Add(this.buttonAddUser);
            this.groupBox1.Controls.Add(this.buttonAddProject);
            this.groupBox1.Controls.Add(this.buttonAddSupplier);
            this.groupBox1.Controls.Add(this.buttonAddCoustomer);
            this.groupBox1.Controls.Add(this.buttonAddCategory);
            this.groupBox1.Location = new System.Drawing.Point(114, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1098, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اضافة";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.labelCompanyName);
            this.panel2.Controls.Add(this.pictureBoxLogo);
            this.panel2.Location = new System.Drawing.Point(598, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 104);
            this.panel2.TabIndex = 1;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCompanyName.Font = new System.Drawing.Font("Calibri", 18F);
            this.labelCompanyName.Location = new System.Drawing.Point(0, 0);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(389, 104);
            this.labelCompanyName.TabIndex = 2;
            this.labelCompanyName.Text = "السلطان";
            this.labelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWelcome
            // 
            this.labelWelcome.Font = new System.Drawing.Font("Calibri", 14F);
            this.labelWelcome.Location = new System.Drawing.Point(65, 57);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(286, 158);
            this.labelWelcome.TabIndex = 3;
            this.labelWelcome.Text = "مرحبا بك مجدداً رامي المسالمه";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxLogo.Image = global::AL_SULTAN.Properties.Resources.icons8_java_64;
            this.pictureBoxLogo.Location = new System.Drawing.Point(389, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(85, 104);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::AL_SULTAN.Properties.Resources.icons8_quick_access_to_record_from_single_touch_button_40;
            this.pictureBox1.Location = new System.Drawing.Point(456, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonOutPut
            // 
            this.buttonOutPut.BackColor = System.Drawing.Color.White;
            this.buttonOutPut.Image = global::AL_SULTAN.Properties.Resources.icons8_flying_money_40;
            this.buttonOutPut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonOutPut.Location = new System.Drawing.Point(210, 33);
            this.buttonOutPut.Margin = new System.Windows.Forms.Padding(10);
            this.buttonOutPut.Name = "buttonOutPut";
            this.buttonOutPut.Size = new System.Drawing.Size(124, 47);
            this.buttonOutPut.TabIndex = 7;
            this.buttonOutPut.Text = "صرف";
            this.buttonOutPut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOutPut.UseVisualStyleBackColor = false;
            // 
            // buttonInPut
            // 
            this.buttonInPut.BackColor = System.Drawing.Color.White;
            this.buttonInPut.Image = global::AL_SULTAN.Properties.Resources.icons8_receive_dollar_40;
            this.buttonInPut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonInPut.Location = new System.Drawing.Point(73, 33);
            this.buttonInPut.Margin = new System.Windows.Forms.Padding(10);
            this.buttonInPut.Name = "buttonInPut";
            this.buttonInPut.Size = new System.Drawing.Size(124, 47);
            this.buttonInPut.TabIndex = 6;
            this.buttonInPut.Text = "قبض";
            this.buttonInPut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInPut.UseVisualStyleBackColor = false;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.BackColor = System.Drawing.Color.White;
            this.buttonAddUser.Image = global::AL_SULTAN.Properties.Resources.icons8_people_40;
            this.buttonAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddUser.Location = new System.Drawing.Point(347, 33);
            this.buttonAddUser.Margin = new System.Windows.Forms.Padding(10);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(124, 47);
            this.buttonAddUser.TabIndex = 5;
            this.buttonAddUser.Text = "مستخدم";
            this.buttonAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddUser.UseVisualStyleBackColor = false;
            // 
            // buttonAddProject
            // 
            this.buttonAddProject.BackColor = System.Drawing.Color.White;
            this.buttonAddProject.Image = global::AL_SULTAN.Properties.Resources.icons8_project_40;
            this.buttonAddProject.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddProject.Location = new System.Drawing.Point(484, 33);
            this.buttonAddProject.Margin = new System.Windows.Forms.Padding(10);
            this.buttonAddProject.Name = "buttonAddProject";
            this.buttonAddProject.Size = new System.Drawing.Size(124, 47);
            this.buttonAddProject.TabIndex = 4;
            this.buttonAddProject.Text = "مشروع";
            this.buttonAddProject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddProject.UseVisualStyleBackColor = false;
            // 
            // buttonAddSupplier
            // 
            this.buttonAddSupplier.BackColor = System.Drawing.Color.White;
            this.buttonAddSupplier.Image = global::AL_SULTAN.Properties.Resources.icons8_supplier_40;
            this.buttonAddSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddSupplier.Location = new System.Drawing.Point(621, 33);
            this.buttonAddSupplier.Margin = new System.Windows.Forms.Padding(10);
            this.buttonAddSupplier.Name = "buttonAddSupplier";
            this.buttonAddSupplier.Size = new System.Drawing.Size(124, 47);
            this.buttonAddSupplier.TabIndex = 3;
            this.buttonAddSupplier.Text = "مورد";
            this.buttonAddSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddSupplier.UseVisualStyleBackColor = false;
            // 
            // buttonAddCoustomer
            // 
            this.buttonAddCoustomer.BackColor = System.Drawing.Color.White;
            this.buttonAddCoustomer.Image = global::AL_SULTAN.Properties.Resources.icons8_customer_40;
            this.buttonAddCoustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddCoustomer.Location = new System.Drawing.Point(758, 33);
            this.buttonAddCoustomer.Margin = new System.Windows.Forms.Padding(10);
            this.buttonAddCoustomer.Name = "buttonAddCoustomer";
            this.buttonAddCoustomer.Size = new System.Drawing.Size(124, 47);
            this.buttonAddCoustomer.TabIndex = 2;
            this.buttonAddCoustomer.Text = "عميل";
            this.buttonAddCoustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddCoustomer.UseVisualStyleBackColor = false;
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.BackColor = System.Drawing.Color.White;
            this.buttonAddCategory.Image = global::AL_SULTAN.Properties.Resources.icons8_categorize_40;
            this.buttonAddCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddCategory.Location = new System.Drawing.Point(895, 33);
            this.buttonAddCategory.Margin = new System.Windows.Forms.Padding(10);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(124, 47);
            this.buttonAddCategory.TabIndex = 1;
            this.buttonAddCategory.Text = "صنف";
            this.buttonAddCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddCategory.UseVisualStyleBackColor = false;
            // 
            // HomeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HomeUserControl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1262, 600);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonOutPut;
        private System.Windows.Forms.Button buttonInPut;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonAddProject;
        private System.Windows.Forms.Button buttonAddSupplier;
        private System.Windows.Forms.Button buttonAddCoustomer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelWelcome;
    }
}
