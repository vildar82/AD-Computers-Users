namespace WindowsFormsApplication2
{
   partial class Form1
   {
      /// <summary>
      /// Обязательная переменная конструктора.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Освободить все используемые ресурсы.
      /// </summary>
      /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Код, автоматически созданный конструктором форм Windows

      /// <summary>
      /// Требуемый метод для поддержки конструктора — не изменяйте 
      /// содержимое этого метода с помощью редактора кода.
      /// </summary>
      private void InitializeComponent()
      {
         this.textBoxGroup = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.textBoxDomain = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.buttonGetUsers = new System.Windows.Forms.Button();
         this.listBoxUsers = new System.Windows.Forms.ListBox();
         this.buttonGetComps = new System.Windows.Forms.Button();
         this.listBoxComps = new System.Windows.Forms.ListBox();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // textBoxGroup
         // 
         this.textBoxGroup.Location = new System.Drawing.Point(27, 25);
         this.textBoxGroup.Name = "textBoxGroup";
         this.textBoxGroup.Size = new System.Drawing.Size(137, 20);
         this.textBoxGroup.TabIndex = 0;
         this.textBoxGroup.Text = "fld-dsk3-ecp-u";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(24, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(42, 13);
         this.label1.TabIndex = 1;
         this.label1.Text = "Группа";
         // 
         // textBoxDomain
         // 
         this.textBoxDomain.Location = new System.Drawing.Point(170, 25);
         this.textBoxDomain.Name = "textBoxDomain";
         this.textBoxDomain.Size = new System.Drawing.Size(100, 20);
         this.textBoxDomain.TabIndex = 0;
         this.textBoxDomain.Text = "picompany.ru";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(167, 9);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(42, 13);
         this.label2.TabIndex = 1;
         this.label2.Text = "Домен";
         // 
         // buttonGetUsers
         // 
         this.buttonGetUsers.Location = new System.Drawing.Point(308, 22);
         this.buttonGetUsers.Name = "buttonGetUsers";
         this.buttonGetUsers.Size = new System.Drawing.Size(75, 23);
         this.buttonGetUsers.TabIndex = 2;
         this.buttonGetUsers.Text = "GetUsers";
         this.buttonGetUsers.UseVisualStyleBackColor = true;
         this.buttonGetUsers.Click += new System.EventHandler(this.buttonGetUsers_Click);
         // 
         // listBoxUsers
         // 
         this.listBoxUsers.FormattingEnabled = true;
         this.listBoxUsers.Location = new System.Drawing.Point(27, 62);
         this.listBoxUsers.Name = "listBoxUsers";
         this.listBoxUsers.Size = new System.Drawing.Size(347, 381);
         this.listBoxUsers.Sorted = true;
         this.listBoxUsers.TabIndex = 3;
         // 
         // buttonGetComps
         // 
         this.buttonGetComps.Location = new System.Drawing.Point(403, 22);
         this.buttonGetComps.Name = "buttonGetComps";
         this.buttonGetComps.Size = new System.Drawing.Size(75, 23);
         this.buttonGetComps.TabIndex = 4;
         this.buttonGetComps.Text = "Comps";
         this.buttonGetComps.UseVisualStyleBackColor = true;
         this.buttonGetComps.Click += new System.EventHandler(this.buttonGetComps_Click);
         // 
         // listBoxComps
         // 
         this.listBoxComps.FormattingEnabled = true;
         this.listBoxComps.Location = new System.Drawing.Point(390, 62);
         this.listBoxComps.Name = "listBoxComps";
         this.listBoxComps.Size = new System.Drawing.Size(338, 381);
         this.listBoxComps.TabIndex = 5;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(517, 9);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(81, 13);
         this.label3.TabIndex = 6;
         this.label3.Text = "Сохраняется в";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(517, 32);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(221, 13);
         this.label4.TabIndex = 7;
         this.label4.Text = "c:\\temp\\САПР\\РеестрПользователейЕЦП";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(762, 474);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.listBoxComps);
         this.Controls.Add(this.buttonGetComps);
         this.Controls.Add(this.listBoxUsers);
         this.Controls.Add(this.buttonGetUsers);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.textBoxDomain);
         this.Controls.Add(this.textBoxGroup);
         this.Name = "Form1";
         this.Text = "Form1";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox textBoxGroup;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox textBoxDomain;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Button buttonGetUsers;
      private System.Windows.Forms.ListBox listBoxUsers;
      private System.Windows.Forms.Button buttonGetComps;
      private System.Windows.Forms.ListBox listBoxComps;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
   }
}

