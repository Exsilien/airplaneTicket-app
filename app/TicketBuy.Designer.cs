namespace Ticket_sales
{
    partial class TicketBuy
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
            depart_date = new TextBox();
            label4 = new Label();
            arrive = new TextBox();
            label2 = new Label();
            label3 = new Label();
            depart = new TextBox();
            label1 = new Label();
            arrive_date = new TextBox();
            label6 = new Label();
            isReturn = new CheckBox();
            search = new Button();
            SuspendLayout();
            // 
            // depart_date
            // 
            depart_date.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            depart_date.Location = new Point(234, 293);
            depart_date.Name = "depart_date";
            depart_date.Size = new Size(334, 26);
            depart_date.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(234, 254);
            label4.Name = "label4";
            label4.Size = new Size(194, 27);
            label4.TabIndex = 20;
            label4.Text = "Дата отправления";
            // 
            // arrive
            // 
            arrive.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            arrive.Location = new Point(233, 210);
            arrive.Name = "arrive";
            arrive.Size = new Size(334, 26);
            arrive.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(233, 171);
            label2.Name = "label2";
            label2.Size = new Size(184, 27);
            label2.TabIndex = 18;
            label2.Text = "Место прибытия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(234, 32);
            label3.Name = "label3";
            label3.Size = new Size(334, 36);
            label3.TabIndex = 17;
            label3.Text = "Введите данные рейса";
            // 
            // depart
            // 
            depart.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            depart.Location = new Point(234, 124);
            depart.Name = "depart";
            depart.Size = new Size(334, 26);
            depart.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(234, 85);
            label1.Name = "label1";
            label1.Size = new Size(213, 27);
            label1.TabIndex = 15;
            label1.Text = "Место отправления";
            // 
            // arrive_date
            // 
            arrive_date.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            arrive_date.Location = new Point(234, 421);
            arrive_date.Name = "arrive_date";
            arrive_date.Size = new Size(334, 26);
            arrive_date.TabIndex = 23;
            arrive_date.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(234, 382);
            label6.Name = "label6";
            label6.Size = new Size(194, 27);
            label6.TabIndex = 22;
            label6.Text = "Дата отправления";
            label6.Visible = false;
            // 
            // isReturn
            // 
            isReturn.AutoSize = true;
            isReturn.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            isReturn.Location = new Point(234, 339);
            isReturn.Name = "isReturn";
            isReturn.RightToLeft = RightToLeft.Yes;
            isReturn.Size = new Size(198, 31);
            isReturn.TabIndex = 25;
            isReturn.Text = "Обратный билет";
            isReturn.TextAlign = ContentAlignment.MiddleRight;
            isReturn.UseVisualStyleBackColor = true;
            isReturn.CheckedChanged += isReturn_CheckedChanged;
            // 
            // search
            // 
            search.BackColor = SystemColors.ButtonHighlight;
            search.Cursor = Cursors.Hand;
            search.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search.Location = new Point(233, 474);
            search.Name = "search";
            search.Size = new Size(335, 40);
            search.TabIndex = 26;
            search.Text = "Поиск";
            search.UseVisualStyleBackColor = false;
            search.Click += search_Click;
            // 
            // TicketBuy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 541);
            Controls.Add(search);
            Controls.Add(isReturn);
            Controls.Add(arrive_date);
            Controls.Add(label6);
            Controls.Add(depart_date);
            Controls.Add(label4);
            Controls.Add(arrive);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(depart);
            Controls.Add(label1);
            Name = "TicketBuy";
            Text = "Покупка билета";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox depart_date;
        private Label label4;
        private TextBox arrive;
        private Label label2;
        private Label label3;
        private TextBox depart;
        private Label label1;
        private TextBox arrive_date;
        private Label label6;
        private CheckBox isReturn;
        private Button search;
    }
}