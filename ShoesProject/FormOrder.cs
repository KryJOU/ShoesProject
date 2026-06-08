using Microsoft.EntityFrameworkCore;
using ShoesProject.Models;
using System;
using System.Linq;
using System.Windows.Forms;
using User = ShoesProject.Models.User;

//

namespace ShoesProject
{
    public partial class FormOrder : Form
    {
        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }

        public FormOrder(User user, bool guest)
        {
            InitializeComponent();
            dgvOrders.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            var Order = new DataGridViewTextBoxColumn { Name = "Order", HeaderText = "Информация о заказе", FillWeight = 100 };
            var DeliveryDate = new DataGridViewTextBoxColumn { Name = "DeliveryDate", HeaderText = "Дата доставки", FillWeight = 100 };

            dgvOrders.Columns.AddRange(new DataGridViewColumn[] { Order, DeliveryDate });

            CurrentUser = user;
            IsGuest = guest;
            lblUserName.Text = IsGuest ? "Гость" : CurrentUser.FullName;
            LoadOrders();
        }

        private void LoadOrders()
        {
            try
            {
                using (var db = new ShopDbContext())
                {
                    var orders = db.Orders
                     .Include(o => o.IdDeliveryPointNavigation)
                     .Include(o => o.User)
                     .Include(o => o.Status)
                     .ToList();

                    dgvOrders.SuspendLayout();
                    dgvOrders.Rows.Clear();

                    foreach (var order in orders)
                    {
                        int rowIndex = dgvOrders.Rows.Add();
                        var row = dgvOrders.Rows[rowIndex];
                        row.Cells["Order"].Value = $"{order.Id}"
                            + Environment.NewLine + $"{order.Status?.StatusName ?? "Не определен"}"
                            + Environment.NewLine + $"{order.IdDeliveryPointNavigation?.DeliveryAddress ?? "Не указан"}"
                            + Environment.NewLine + $"{order.OrderDate}";
                        row.Cells["DeliveryDate"].Value = $"{order.DeliveryDate}";
                    }

                    dgvOrders.ResumeLayout();
                    dgvOrders.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
