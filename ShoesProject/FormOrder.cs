using Microsoft.EntityFrameworkCore;
using ShoesProject.Models;
using System;
using System.Linq;
using System.Windows.Forms;
using User = ShoesProject.Models.User;

namespace ShoesProject
{
    public partial class FormOrder : Form
    {
        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }

        public FormOrder(User user, bool guest)
        {
            InitializeComponent();

            var dateOrder = new DataGridViewTextBoxColumn { Name = "dateOrder", HeaderText = "Дата заказа", FillWeight = 30 };
            var dateDelivery = new DataGridViewTextBoxColumn { Name = "dateDelivery", HeaderText = "Дата доставки", FillWeight = 30 };
            var delivery = new DataGridViewTextBoxColumn { Name = "delivery", HeaderText = "Пункт выдачи", FillWeight = 40 };

            var UserName = new DataGridViewTextBoxColumn { Name = "UserName", HeaderText = "ФИО клиента", FillWeight = 60 };
            UserName.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            var Status = new DataGridViewTextBoxColumn { Name = "status", HeaderText = "Статус", FillWeight = 20 };
            dgvOrders.Columns.AddRange(new DataGridViewColumn[] { dateOrder, dateDelivery, delivery, UserName, Status });

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
                        .ToList();

                    dgvOrders.SuspendLayout();
                    dgvOrders.Rows.Clear();

                    foreach (var order in orders)
                    {
                        int rowIndex = dgvOrders.Rows.Add();
                        var row = dgvOrders.Rows[rowIndex];

                        row.Cells["dateOrder"].Value = order.OrderDate;
                        row.Cells["dateDelivery"].Value = order.DeliveryDate;

                        row.Cells["delivery"].Value = order.IdDeliveryPointNavigation?.DeliveryAddress ?? "Не указан";

                        row.Cells["UserName"].Value = order.User?.FullName ?? "Гость";
                        row.Cells["status"].Value = order.Status;
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
