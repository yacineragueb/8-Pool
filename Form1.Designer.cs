namespace _8Pool
{
    partial class Form1
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
            this.poolTable1 = new _8Pool.PoolTable();
            this.poolTable2 = new _8Pool.PoolTable();
            this.poolTable3 = new _8Pool.PoolTable();
            this.poolTable4 = new _8Pool.PoolTable();
            this.poolTable5 = new _8Pool.PoolTable();
            this.poolTable6 = new _8Pool.PoolTable();
            this.SuspendLayout();
            // 
            // poolTable1
            // 
            this.poolTable1.BackColor = System.Drawing.Color.Black;
            this.poolTable1.HourlyRate = 10F;
            this.poolTable1.Location = new System.Drawing.Point(12, 12);
            this.poolTable1.Name = "poolTable1";
            this.poolTable1.PlayerName = "Player Name";
            this.poolTable1.Size = new System.Drawing.Size(402, 323);
            this.poolTable1.TabIndex = 0;
            this.poolTable1.TableTitle = "Table Title";
            this.poolTable1.TableCompleted += new System.EventHandler<_8Pool.PoolTable.TableCompletedEventArgs>(this.poolTable_TableCompleted);
            // 
            // poolTable2
            // 
            this.poolTable2.BackColor = System.Drawing.Color.Black;
            this.poolTable2.HourlyRate = 10F;
            this.poolTable2.Location = new System.Drawing.Point(420, 12);
            this.poolTable2.Name = "poolTable2";
            this.poolTable2.PlayerName = "Player Name";
            this.poolTable2.Size = new System.Drawing.Size(402, 323);
            this.poolTable2.TabIndex = 1;
            this.poolTable2.TableTitle = "Table Title";
            this.poolTable2.TableCompleted += new System.EventHandler<_8Pool.PoolTable.TableCompletedEventArgs>(this.poolTable_TableCompleted);
            // 
            // poolTable3
            // 
            this.poolTable3.BackColor = System.Drawing.Color.Black;
            this.poolTable3.HourlyRate = 10F;
            this.poolTable3.Location = new System.Drawing.Point(828, 12);
            this.poolTable3.Name = "poolTable3";
            this.poolTable3.PlayerName = "Player Name";
            this.poolTable3.Size = new System.Drawing.Size(402, 323);
            this.poolTable3.TabIndex = 2;
            this.poolTable3.TableTitle = "Table Title";
            this.poolTable3.TableCompleted += new System.EventHandler<_8Pool.PoolTable.TableCompletedEventArgs>(this.poolTable_TableCompleted);
            // 
            // poolTable4
            // 
            this.poolTable4.BackColor = System.Drawing.Color.Black;
            this.poolTable4.HourlyRate = 10F;
            this.poolTable4.Location = new System.Drawing.Point(828, 341);
            this.poolTable4.Name = "poolTable4";
            this.poolTable4.PlayerName = "Player Name";
            this.poolTable4.Size = new System.Drawing.Size(402, 323);
            this.poolTable4.TabIndex = 5;
            this.poolTable4.TableTitle = "Table Title";
            this.poolTable4.TableCompleted += new System.EventHandler<_8Pool.PoolTable.TableCompletedEventArgs>(this.poolTable_TableCompleted);
            // 
            // poolTable5
            // 
            this.poolTable5.BackColor = System.Drawing.Color.Black;
            this.poolTable5.HourlyRate = 10F;
            this.poolTable5.Location = new System.Drawing.Point(420, 341);
            this.poolTable5.Name = "poolTable5";
            this.poolTable5.PlayerName = "Player Name";
            this.poolTable5.Size = new System.Drawing.Size(402, 323);
            this.poolTable5.TabIndex = 4;
            this.poolTable5.TableTitle = "Table Title";
            this.poolTable5.TableCompleted += new System.EventHandler<_8Pool.PoolTable.TableCompletedEventArgs>(this.poolTable_TableCompleted);
            // 
            // poolTable6
            // 
            this.poolTable6.BackColor = System.Drawing.Color.Black;
            this.poolTable6.HourlyRate = 10F;
            this.poolTable6.Location = new System.Drawing.Point(12, 341);
            this.poolTable6.Name = "poolTable6";
            this.poolTable6.PlayerName = "Player Name";
            this.poolTable6.Size = new System.Drawing.Size(402, 323);
            this.poolTable6.TabIndex = 3;
            this.poolTable6.TableTitle = "Table Title";
            this.poolTable6.TableCompleted += new System.EventHandler<_8Pool.PoolTable.TableCompletedEventArgs>(this.poolTable_TableCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1242, 678);
            this.Controls.Add(this.poolTable4);
            this.Controls.Add(this.poolTable5);
            this.Controls.Add(this.poolTable6);
            this.Controls.Add(this.poolTable3);
            this.Controls.Add(this.poolTable2);
            this.Controls.Add(this.poolTable1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "8 Pool";
            this.ResumeLayout(false);

        }

        #endregion

        private PoolTable poolTable1;
        private PoolTable poolTable2;
        private PoolTable poolTable3;
        private PoolTable poolTable4;
        private PoolTable poolTable5;
        private PoolTable poolTable6;
    }
}

