using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Entidades.cs;
using Negocios;
using Negocios.cs;

namespace Presentacion
{


    public partial class FormAdmProfes : Form
    {

        public Profesional objEntProf = new Profesional();
        public NegProfesionales objNegProf = new NegProfesionales();
        public FormAdmProfes()
        {
            InitializeComponent();
            dgvProfesionales.ColumnCount = 2;
            dgvProfesionales.Columns[0].HeaderText = "Código";
            dgvProfesionales.Columns[1].HeaderText = "Nombre";
            dgvProfesionales.Columns[0].Width = 60;
            dgvProfesionales.Columns[1].Width = 200;
            LlenarDGV();

        }

        private void LlenarDGV()
        {
            dgvProfesionales.Rows.Clear();
            DataSet ds = new DataSet();
            ds = objNegProf.listadoProfesionales("Todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    //Lo que quieres mostrar esta en dr[0].ToString(), dr[1].ToString(), etc..
                    dgvProfesionales.Rows.Add(dr[0].ToString(), dr[1]);
                }
            }
            else
                lblInfo.Text = "No hay profesionales cargados en el sistema";
        }

        private void TxtBox_a_Obj() //Prepara el objeto a enviar a la capa de Negocio
        {
            objEntProf.CodProf = int.Parse(txtCod.Text);
            objEntProf.Nombre = txtNom.Text;
        }

        private void btnGrab_Click(object sender, EventArgs e)
        {
            int nGrabados = -1;
            //llamo al método que carga los datos del objeto
            TxtBox_a_Obj();
            nGrabados = objNegProf.abmProfesionales("Agregar", objEntProf); //invoco a la capa de negocio
            if (nGrabados == -1)
                lblInfo.Text = "No pudo grabar profesionales en el sistema";
            else
            {
                lblInfo.Text = "Se grabó con éxito profesionales.";
                LlenarDGV();
                Limpiar();
            }
        }
        private void Limpiar()
        {
            txtCod.Text = string.Empty;
            txtNom.Text = string.Empty;
        }

        private void dgvProfesionales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataSet ds = new DataSet();
            objEntProf.CodProf = Convert.ToInt32(dgvProfesionales.CurrentRow.Cells[0].Value);
            ds = objNegProf.listadoProfesionales(objEntProf.CodProf.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                Ds_a_TxtBox(ds);
                btnGrab.Visible = false;
                lblInfo.Text = string.Empty;
            }


        }

        private void Ds_a_TxtBox(DataSet ds)
        {
            txtCod.Text = ds.Tables[0].Rows[0]["CodProf"].ToString();
            txtNom.Text = ds.Tables[0].Rows[0]["Nombre"].ToString();
            txtCod.Enabled = false;
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            int nResultado = -1;
            TxtBox_a_Obj();
            nResultado = objNegProf.abmProfesionales("Modificar", objEntProf); //invoco a la capa de negocio
            if (nResultado != -1)
            {
                MessageBox.Show ("Aviso", "El Profesional fue Modificado con éxito");
                Limpiar();
                LlenarDGV();

                txtCod.Enabled = true;

            }
            else
                MessageBox.Show ("Error", "Se produjo un error al intentar modificar el Profesional");
        }
    }
}
