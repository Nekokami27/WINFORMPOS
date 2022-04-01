using System;
using System.Windows.Forms;
using WINFORM_PRAC.Repository;


namespace WINFORM_PRAC
{
    public partial class Auth_Page : Form
    {
        private readonly IItemRepo _repo;
        public Auth_Page(IItemRepo repo)
        {
            InitializeComponent();
            _repo = repo;
            InitialDataGridView();
        }

        //protected override void OnClosed(EventArgs e)
        //{
        //    base.OnClosed(e);
        //    if (_repo is IDisposable disposable)
        //    {
        //        disposable.Dispose();
        //    }
        //}

        #region Useless Shits(Ignore~)
        // Useless Shits>>>>>>>>>
        private void Input1_TextChanged(object sender, EventArgs e) { }

        private void Input2_TextChanged(object sender, EventArgs e) { }

        private void Auth_Page_Load(object sender, EventArgs e) { }

        private void Auth_List1_SelectedIndexChanged(object sender, EventArgs e) { }
        // <<<<<<<<<Useless Shits
        #endregion

        #region DataGridView
        private void InitialDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;


            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Item_ID",
                Name = "ColItemID",
                HeaderText = "產品編號",
                Width = 100,
                Visible = true,
                ReadOnly = true
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ItemName",
                Name = "ColItemName",
                HeaderText = "產品名稱",
                Width = 100,
                Visible = true,
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ItemPrice",
                Name = "ColItemPrice",
                HeaderText = "產品價格",
                Width = 100,
                Visible = true,
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });

            DataGridViewDisplay();
        }
        private void DataGridViewRefresh()
        {
            dataGridView1.Rows.Clear();
            DataGridViewDisplay();
        }
        private void DataGridViewDisplay()
        {
            foreach (Item item in _repo.List())
            {
                if (!item.IsDeleted)
                {
                    string[ ] row = new string[ ] { item.Id.ToString(), item.Name, item.Price.ToString() };
                    dataGridView1.Rows.Add(row);
                }
            }
        }

        private void DataGridViewRefreshSpecial()
        {
            dataGridView1.Rows.Clear();
            DataGridViewDisplayIsDel();
        }
        private void DataGridViewDisplayIsDel()
        {
            foreach (Item item in _repo.List())
            {
                string[ ] row = new string[ ] { item.Id.ToString(), item.Name, item.Price.ToString() };
                dataGridView1.Rows.Add(row);
            }
        }
        #endregion

        //CRUD
        private void Add_Click(object sender, EventArgs e)
        {
            int parm = int.Parse(Input2.Text);
            var item = _repo.Insert(Input1.Text, parm, false);
            DataGridViewRefresh();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            int parm = int.Parse(Input2.Text);
            if (dataGridView1.SelectedCells.Count > 0)
            {
                //visible row_num
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                int cellValue = Convert.ToInt16(selectedRow.Cells["ColItemID"].Value);
                _repo.Update(cellValue, Input1.Text, parm);
                DataGridViewRefresh();
            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                //visible row_num
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                int cellValue = Convert.ToInt16(selectedRow.Cells["ColItemID"].Value);
                _repo.Delete(cellValue);
                DataGridViewRefresh();
            }
        }

        //Number only~~
        private void Input2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & ((int)e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
        //checkbox visible IsDel
        private void IsDelItemVisible_CheckedChanged(object sender, System.EventArgs e)
        {
            if (IsDelItemVisible.Checked)
            {
                DataGridViewRefreshSpecial();
            }
            else
            {
                DataGridViewRefresh();
            }
        }


    }
}
