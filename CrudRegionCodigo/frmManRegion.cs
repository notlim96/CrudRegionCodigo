using Business;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CrudRegionCodigo
{
    public partial class frmManRegion : Form
    {
        public frmManRegion()
        {
            InitializeComponent();

            ListarRegiones();

            txtIdRegion.Enabled = false;
        }

        //  funcion para registrar datos..
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                RegionBusiness bregion = new RegionBusiness();

                Entity.RegionEntity region = new Entity.RegionEntity { RegionName = txtRegion.Text };

                bregion.RegistrarRegionBusiness(region);

                ListarRegiones();

                MessageBox.Show("SUCCESSFUL");
            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }

        }

        private void ListarRegiones()
        {
            try
            {
                //  validamos  los datos
                RegionBusiness bregion = new RegionBusiness();
                Entity.RegionEntity regionEntity = new Entity.RegionEntity { RegionId = 0 };

                List<RegionEntity> list = new List<RegionEntity>();

                list = bregion.ListarRegionBusiness(regionEntity);

                dxDataGrid.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void dxDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dxDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (dxDataGrid.SelectedRows.Count > 0)
            {
                // obtener  la  persona seleccionada
                RegionEntity regionSeleecionada = dxDataGrid.SelectedRows[0].DataBoundItem as RegionEntity;

                if (regionSeleecionada != null)
                {
                    int ID;
                    string Nombre;
                    bool Estado;
                    ID = regionSeleecionada.RegionId;
                    Nombre = regionSeleecionada.RegionName;
                    Estado = regionSeleecionada.Enabled;

                    //  asignamos a los text box
                    txtIdRegion.Text = Convert.ToString(ID);
                    txtRegion.Text = Nombre;
                    if (Estado)
                        chkEstado.Checked = true;
                    else
                        chkEstado.Checked = false;

                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // validamos que tenga registro, el campo ID 
                if (txtIdRegion.Text != "")
                {

                    //  asignamos a los text box
                    bool estado;
                    if (chkEstado.Checked)
                    {
                        estado = true;
                    }
                    else
                    {
                        estado = false;
                    }

                    //  hacemos la instancia a NEGOIO
                    RegionBusiness regionBusiness = new RegionBusiness();
                    //  llenamos las ENTIDADES y LLENAMOS
                    Entity.RegionEntity regionEntity = new Entity.RegionEntity { RegionId = Convert.ToInt32(txtIdRegion.Text), RegionName = txtRegion.Text, Enabled = estado };
                    //  enviamos 
                    regionBusiness.ActualizarRegionBusiness(regionEntity);

                    ListarRegiones();

                    MessageBox.Show("ACTUALIZADO");


                }
                else
                {
                    MessageBox.Show("Debe de selecioanr un dato en el tabla de datos..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se registro");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // validamos que tenga registro, el campo ID 
                if (txtIdRegion.Text != "")
                { 

                    //  hacemos la instancia a NEGOIO
                    RegionBusiness regionBusiness = new RegionBusiness();
                    //  llenamos las ENTIDADES y LLENAMOS
                    Entity.RegionEntity regionEntity = new Entity.RegionEntity { RegionId = Convert.ToInt32(txtIdRegion.Text) };
                    //  enviamos 
                    regionBusiness.EliminarRegionBusiness(regionEntity);

                    ListarRegiones();

                    MessageBox.Show("ELIMINADO");


                }
                else
                {
                    MessageBox.Show("Debe de selecioanr un dato en el tabla de datos..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se registro");
            }
        }
    }
}
