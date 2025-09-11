using System.Windows.Forms;

namespace Dacuma
{
	public class ChatBotForm : Form
    {
        private Label label1;

        public ChatBotForm()
		{
			InitializeComponent();
			this.Text = "Chat Bot";
		}

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chat Bot";
            // 
            // ChatBotForm
            // 
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.label1);
            this.Name = "ChatBotForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}


