namespace KinectSpecialties
{
    partial class MainForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            tbDes = new TextBox();
            btnAdd = new Button();
            lSelected = new Label();
            btnSendRequest = new Button();
            panel1 = new Panel();
            l1Best = new Label();
            l9Best = new Label();
            l8Best = new Label();
            l7Best = new Label();
            l6Best = new Label();
            l5Best = new Label();
            l4Best = new Label();
            l3Best = new Label();
            l2Best = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 358);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1345, 349);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // tbDes
            // 
            tbDes.Location = new Point(12, 327);
            tbDes.Multiline = true;
            tbDes.Name = "tbDes";
            tbDes.PlaceholderText = "Enter description...";
            tbDes.Size = new Size(1198, 25);
            tbDes.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightCyan;
            btnAdd.Location = new Point(1235, 327);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(98, 25);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lSelected
            // 
            lSelected.AutoSize = true;
            lSelected.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lSelected.ForeColor = SystemColors.ButtonFace;
            lSelected.Location = new Point(7, 299);
            lSelected.Name = "lSelected";
            lSelected.Size = new Size(148, 25);
            lSelected.TabIndex = 3;
            lSelected.Text = "Now selected: ";
            // 
            // btnSendRequest
            // 
            btnSendRequest.BackColor = Color.LightCyan;
            btnSendRequest.Location = new Point(1235, 12);
            btnSendRequest.Name = "btnSendRequest";
            btnSendRequest.Size = new Size(98, 25);
            btnSendRequest.TabIndex = 5;
            btnSendRequest.Text = "Send request";
            btnSendRequest.UseVisualStyleBackColor = false;
            btnSendRequest.Click += btnSendRequest_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(l1Best);
            panel1.Controls.Add(l9Best);
            panel1.Controls.Add(l8Best);
            panel1.Controls.Add(l7Best);
            panel1.Controls.Add(l6Best);
            panel1.Controls.Add(l5Best);
            panel1.Controls.Add(l4Best);
            panel1.Controls.Add(l3Best);
            panel1.Controls.Add(l2Best);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1198, 270);
            panel1.TabIndex = 6;
            // 
            // l1Best
            // 
            l1Best.AutoSize = true;
            l1Best.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            l1Best.Location = new Point(3, 7);
            l1Best.Name = "l1Best";
            l1Best.Size = new Size(352, 28);
            l1Best.TabIndex = 9;
            l1Best.Text = "Press send request to view result ->";
            // 
            // l9Best
            // 
            l9Best.AutoSize = true;
            l9Best.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            l9Best.Location = new Point(3, 236);
            l9Best.Name = "l9Best";
            l9Best.Size = new Size(35, 28);
            l9Best.TabIndex = 8;
            l9Best.Text = "9. ";
            l9Best.Visible = false;
            // 
            // l8Best
            // 
            l8Best.AutoSize = true;
            l8Best.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            l8Best.Location = new Point(3, 208);
            l8Best.Name = "l8Best";
            l8Best.Size = new Size(35, 28);
            l8Best.TabIndex = 7;
            l8Best.Text = "8. ";
            l8Best.Visible = false;
            // 
            // l7Best
            // 
            l7Best.AutoSize = true;
            l7Best.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            l7Best.Location = new Point(3, 180);
            l7Best.Name = "l7Best";
            l7Best.Size = new Size(35, 28);
            l7Best.TabIndex = 6;
            l7Best.Text = "7. ";
            l7Best.Visible = false;
            // 
            // l6Best
            // 
            l6Best.AutoSize = true;
            l6Best.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            l6Best.Location = new Point(3, 152);
            l6Best.Name = "l6Best";
            l6Best.Size = new Size(35, 28);
            l6Best.TabIndex = 5;
            l6Best.Text = "6. ";
            l6Best.Visible = false;
            // 
            // l5Best
            // 
            l5Best.AutoSize = true;
            l5Best.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            l5Best.Location = new Point(3, 121);
            l5Best.Name = "l5Best";
            l5Best.Size = new Size(35, 28);
            l5Best.TabIndex = 4;
            l5Best.Text = "5. ";
            l5Best.Visible = false;
            // 
            // l4Best
            // 
            l4Best.AutoSize = true;
            l4Best.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            l4Best.Location = new Point(3, 93);
            l4Best.Name = "l4Best";
            l4Best.Size = new Size(35, 28);
            l4Best.TabIndex = 3;
            l4Best.Text = "4. ";
            l4Best.Visible = false;
            // 
            // l3Best
            // 
            l3Best.AutoSize = true;
            l3Best.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            l3Best.Location = new Point(3, 65);
            l3Best.Name = "l3Best";
            l3Best.Size = new Size(35, 28);
            l3Best.TabIndex = 2;
            l3Best.Text = "3. ";
            l3Best.Visible = false;
            // 
            // l2Best
            // 
            l2Best.AutoSize = true;
            l2Best.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            l2Best.Location = new Point(3, 37);
            l2Best.Name = "l2Best";
            l2Best.Size = new Size(35, 28);
            l2Best.TabIndex = 1;
            l2Best.Text = "2. ";
            l2Best.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1345, 707);
            Controls.Add(panel1);
            Controls.Add(btnSendRequest);
            Controls.Add(lSelected);
            Controls.Add(btnAdd);
            Controls.Add(tbDes);
            Controls.Add(flowLayoutPanel1);
            Name = "MainForm";
            Text = "Main";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox tbDes;
        private Button btnAdd;
        private Label lSelected;
        private Button btnSendRequest;
        private Panel panel1;
        private Label l2Best;
        private Label l9Best;
        private Label l8Best;
        private Label l7Best;
        private Label l6Best;
        private Label l5Best;
        private Label l4Best;
        private Label l3Best;
        private Label l1Best;
    }
}
