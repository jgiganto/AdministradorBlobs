namespace AdministradorBlobs
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtContenedor = new System.Windows.Forms.TextBox();
            this.Contenedores = new System.Windows.Forms.Label();
            this.lstContenedores = new System.Windows.Forms.ListBox();
            this.btnCrearContenedor = new System.Windows.Forms.Button();
            this.btnSubirArchivoBlob = new System.Windows.Forms.Button();
            this.btnMostrarBlobs = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminarBlob = new System.Windows.Forms.Button();
            this.lstListaBlobs = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contenedor";
            // 
            // txtContenedor
            // 
            this.txtContenedor.Location = new System.Drawing.Point(134, 26);
            this.txtContenedor.Name = "txtContenedor";
            this.txtContenedor.Size = new System.Drawing.Size(100, 20);
            this.txtContenedor.TabIndex = 1;
            // 
            // Contenedores
            // 
            this.Contenedores.AutoSize = true;
            this.Contenedores.Location = new System.Drawing.Point(405, 26);
            this.Contenedores.Name = "Contenedores";
            this.Contenedores.Size = new System.Drawing.Size(73, 13);
            this.Contenedores.TabIndex = 2;
            this.Contenedores.Text = "Contenedores";
            // 
            // lstContenedores
            // 
            this.lstContenedores.FormattingEnabled = true;
            this.lstContenedores.Location = new System.Drawing.Point(408, 64);
            this.lstContenedores.Name = "lstContenedores";
            this.lstContenedores.Size = new System.Drawing.Size(145, 277);
            this.lstContenedores.TabIndex = 3;
            this.lstContenedores.SelectedIndexChanged += new System.EventHandler(this.lstContenedores_SelectedIndexChanged);
            // 
            // btnCrearContenedor
            // 
            this.btnCrearContenedor.Location = new System.Drawing.Point(121, 84);
            this.btnCrearContenedor.Name = "btnCrearContenedor";
            this.btnCrearContenedor.Size = new System.Drawing.Size(160, 89);
            this.btnCrearContenedor.TabIndex = 4;
            this.btnCrearContenedor.Text = "Crear Contenedor";
            this.btnCrearContenedor.UseVisualStyleBackColor = true;
            this.btnCrearContenedor.Click += new System.EventHandler(this.btnCrearContenedor_Click);
            // 
            // btnSubirArchivoBlob
            // 
            this.btnSubirArchivoBlob.Location = new System.Drawing.Point(121, 197);
            this.btnSubirArchivoBlob.Name = "btnSubirArchivoBlob";
            this.btnSubirArchivoBlob.Size = new System.Drawing.Size(160, 89);
            this.btnSubirArchivoBlob.TabIndex = 5;
            this.btnSubirArchivoBlob.Text = "Subir Archivo Blob";
            this.btnSubirArchivoBlob.UseVisualStyleBackColor = true;
            this.btnSubirArchivoBlob.Click += new System.EventHandler(this.btnSubirArchivoBlob_Click);
            // 
            // btnMostrarBlobs
            // 
            this.btnMostrarBlobs.Location = new System.Drawing.Point(121, 319);
            this.btnMostrarBlobs.Name = "btnMostrarBlobs";
            this.btnMostrarBlobs.Size = new System.Drawing.Size(160, 89);
            this.btnMostrarBlobs.TabIndex = 6;
            this.btnMostrarBlobs.Text = "Mostrar Blobs";
            this.btnMostrarBlobs.UseVisualStyleBackColor = true;
            this.btnMostrarBlobs.Click += new System.EventHandler(this.btnMostrarBlobs_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(601, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 281);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnEliminarBlob
            // 
            this.btnEliminarBlob.ForeColor = System.Drawing.Color.Red;
            this.btnEliminarBlob.Location = new System.Drawing.Point(626, 468);
            this.btnEliminarBlob.Name = "btnEliminarBlob";
            this.btnEliminarBlob.Size = new System.Drawing.Size(202, 109);
            this.btnEliminarBlob.TabIndex = 8;
            this.btnEliminarBlob.Text = "Eliminar Blob";
            this.btnEliminarBlob.UseVisualStyleBackColor = true;
            this.btnEliminarBlob.Click += new System.EventHandler(this.btnEliminarBlob_Click);
            // 
            // lstListaBlobs
            // 
            this.lstListaBlobs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstListaBlobs.Location = new System.Drawing.Point(104, 468);
            this.lstListaBlobs.Name = "lstListaBlobs";
            this.lstListaBlobs.Size = new System.Drawing.Size(407, 97);
            this.lstListaBlobs.TabIndex = 9;
            this.lstListaBlobs.UseCompatibleStateImageBehavior = false;
            this.lstListaBlobs.View = System.Windows.Forms.View.Details;
            this.lstListaBlobs.SelectedIndexChanged += new System.EventHandler(this.lstListaBlobs_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "URI BLOB";
            this.columnHeader1.Width = 195;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tamaño";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Blobs";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 647);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstListaBlobs);
            this.Controls.Add(this.btnEliminarBlob);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMostrarBlobs);
            this.Controls.Add(this.btnSubirArchivoBlob);
            this.Controls.Add(this.btnCrearContenedor);
            this.Controls.Add(this.lstContenedores);
            this.Controls.Add(this.Contenedores);
            this.Controls.Add(this.txtContenedor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContenedor;
        private System.Windows.Forms.Label Contenedores;
        private System.Windows.Forms.ListBox lstContenedores;
        private System.Windows.Forms.Button btnCrearContenedor;
        private System.Windows.Forms.Button btnSubirArchivoBlob;
        private System.Windows.Forms.Button btnMostrarBlobs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEliminarBlob;
        private System.Windows.Forms.ListView lstListaBlobs;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

