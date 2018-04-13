using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;


namespace AdministradorBlobs
{
    public partial class Form1 : Form
    {
        CloudBlobClient cliente;
        public Form1()
        {
            InitializeComponent();
            String claves =
                CloudConfigurationManager.GetSetting("cuentastorage");
            CloudStorageAccount cuenta = CloudStorageAccount.Parse(claves);
            this.cliente =
                cuenta.CreateCloudBlobClient();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearContenedor_Click(object sender, EventArgs e)
        {
            String nombrecontainer = this.txtContenedor.Text;
            CloudBlobContainer contenedor =
                this.cliente.GetContainerReference(nombrecontainer);

            contenedor.SetPermissions(
                new BlobContainerPermissions { PublicAccess = BlobContainerPublicAccessType.Blob });

            contenedor.CreateIfNotExists();
            this.lstContenedores.Items.Add(nombrecontainer);
        }

        private void btnSubirArchivoBlob_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Imagenes JPG|*.jpg|PNG|*.png";
            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                //C:\IMAGENES\1.jpg
                String ruta = openFileDialog1.FileName;
                int posicion = ruta.LastIndexOf("\\") + 1;
                String nombreblob = ruta.Substring(posicion);
                String nombrecontenedor = this.lstContenedores.SelectedItem.ToString();
                CloudBlobContainer contenedor = this.cliente.GetContainerReference(nombrecontenedor);
                CloudBlockBlob blob = contenedor.GetBlockBlobReference(nombreblob);

                using(FileStream stream=new FileStream(ruta, FileMode.Open))
                {
                    blob.UploadFromStream(stream);
                }
                MessageBox.Show("Blob subido correctamente");
            }
        }

        private void btnMostrarBlobs_Click(object sender, EventArgs e)
        {
            this.lstListaBlobs.Items.Clear();
            String nombrecontenedor = this.lstContenedores.SelectedItem.ToString();
            CloudBlobContainer contenedor = this.cliente.GetContainerReference(nombrecontenedor);
            IEnumerable<IListBlobItem> blobs =
                contenedor.ListBlobs();
            foreach(var b in blobs)
            {
                ListViewItem it = new ListViewItem();
                it.Text = b.Uri.ToString();
                CloudBlockBlob bb = b as CloudBlockBlob;
                it.SubItems.Add(bb.Properties.Length.ToString());
                //this.lstContenedores.Items.Add(it);
                this.lstListaBlobs.Items.Add(it);

            }
        }

        private void btnEliminarBlob_Click(object sender, EventArgs e)
        {
            String nombrecontenedor =
                this.lstContenedores.SelectedItem.ToString();
            CloudBlobContainer contenedor =
                cliente.GetContainerReference(nombrecontenedor);
            String uri = this.lstListaBlobs.SelectedItems[0].Text;
            int posicion = uri.LastIndexOf("/") + 1;
            String nombreblob = uri.Substring(posicion);
            CloudBlockBlob blob = contenedor.GetBlockBlobReference(nombreblob);
            blob.Delete();
            MessageBox.Show("Eliminado correctamente");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lstContenedores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstListaBlobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstListaBlobs.SelectedItems.Count != 0)
            {
                String uri =
                    this.lstListaBlobs.SelectedItems[0].Text;
                this.pictureBox1.Load(uri);
            }

        }
    }
}
