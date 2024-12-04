namespace Ticket_sales
{
    partial class Main
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
            buy_ticket = new Button();
            label1 = new Label();
            label2 = new Label();
            auth = new Button();
            add_ticket = new Button();
            SuspendLayout();
            // 
            // buy_ticket
            // 
            buy_ticket.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buy_ticket.Location = new Point(254, 70);
            buy_ticket.Name = "buy_ticket";
            buy_ticket.Size = new Size(297, 78);
            buy_ticket.TabIndex = 0;
            buy_ticket.Text = "Купить билет";
            buy_ticket.UseVisualStyleBackColor = true;
            buy_ticket.Click += buy_ticket_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(305, 18);
            label1.Name = "label1";
            label1.Size = new Size(197, 36);
            label1.TabIndex = 1;
            label1.Text = "Для клиента";
            label1.UseMnemonic = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(245, 164);
            label2.Name = "label2";
            label2.Size = new Size(315, 36);
            label2.TabIndex = 2;
            label2.Text = "Для администратора";
            label2.UseMnemonic = false;
            // 
            // auth
            // 
            auth.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            auth.Location = new Point(254, 221);
            auth.Name = "auth";
            auth.Size = new Size(297, 78);
            auth.TabIndex = 3;
            auth.Text = "Войти как администратор";
            auth.UseVisualStyleBackColor = true;
            auth.Click += auth_Click;
            // 
            // add_ticket
            // 
            add_ticket.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add_ticket.Location = new Point(254, 323);
            add_ticket.Name = "add_ticket";
            add_ticket.Size = new Size(297, 78);
            add_ticket.TabIndex = 4;
            add_ticket.Text = "Добавить рейс в базу данных";
            add_ticket.UseVisualStyleBackColor = true;
            add_ticket.Click += add_ticket_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(add_ticket);
            Controls.Add(auth);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buy_ticket);
            Name = "Main";
            Text = "Главное окно";
            Load += Main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buy_ticket;
        private Label label1;
        private Label label2;
        private Button auth;
        private Button add_ticket;
    }
}