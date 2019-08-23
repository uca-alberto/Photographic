namespace Photographic
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cameraControl1 = new DevExpress.XtraEditors.Camera.CameraControl();
            this.CapturarImagen = new MaterialSkin.Controls.MaterialRaisedButton();
            this.GuardarImagen = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.Articulo_Row = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cameraControl1
            // 
            this.cameraControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.cameraControl1.Location = new System.Drawing.Point(12, 43);
            this.cameraControl1.Name = "cameraControl1";
            this.cameraControl1.Size = new System.Drawing.Size(429, 395);
            this.cameraControl1.TabIndex = 0;
            this.cameraControl1.Text = "cameraControl1";
            // 
            // CapturarImagen
            // 
            this.CapturarImagen.Depth = 0;
            this.CapturarImagen.Location = new System.Drawing.Point(447, 310);
            this.CapturarImagen.MouseState = MaterialSkin.MouseState.HOVER;
            this.CapturarImagen.Name = "CapturarImagen";
            this.CapturarImagen.Primary = true;
            this.CapturarImagen.Size = new System.Drawing.Size(167, 30);
            this.CapturarImagen.TabIndex = 2;
            this.CapturarImagen.Text = "Capturar Imagen";
            this.CapturarImagen.UseVisualStyleBackColor = true;
            this.CapturarImagen.Click += new System.EventHandler(this.CapturarImagen_Click);
            // 
            // GuardarImagen
            // 
            this.GuardarImagen.Depth = 0;
            this.GuardarImagen.Location = new System.Drawing.Point(631, 310);
            this.GuardarImagen.MouseState = MaterialSkin.MouseState.HOVER;
            this.GuardarImagen.Name = "GuardarImagen";
            this.GuardarImagen.Primary = true;
            this.GuardarImagen.Size = new System.Drawing.Size(157, 30);
            this.GuardarImagen.TabIndex = 3;
            this.GuardarImagen.Text = "Guardar Imagen";
            this.GuardarImagen.UseVisualStyleBackColor = true;
            this.GuardarImagen.Click += new System.EventHandler(this.GuardarImagen_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.Location = new System.Drawing.Point(447, 43);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(341, 261);
            this.pictureEdit1.TabIndex = 4;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 21);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(66, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Articulo:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(84, 21);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(0, 19);
            this.materialLabel2.TabIndex = 6;
            // 
            // Articulo_Row
            // 
            this.Articulo_Row.AutoSize = true;
            this.Articulo_Row.Depth = 0;
            this.Articulo_Row.Font = new System.Drawing.Font("Roboto", 11F);
            this.Articulo_Row.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Articulo_Row.Location = new System.Drawing.Point(84, 21);
            this.Articulo_Row.MouseState = MaterialSkin.MouseState.HOVER;
            this.Articulo_Row.Name = "Articulo_Row";
            this.Articulo_Row.Size = new System.Drawing.Size(0, 19);
            this.Articulo_Row.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Articulo_Row);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.GuardarImagen);
            this.Controls.Add(this.CapturarImagen);
            this.Controls.Add(this.cameraControl1);
            this.Name = "Form1";
            this.Text = "Foto";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.Camera.CameraControl cameraControl1;
        private MaterialSkin.Controls.MaterialRaisedButton CapturarImagen;
        private MaterialSkin.Controls.MaterialRaisedButton GuardarImagen;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel Articulo_Row;
    }
}

