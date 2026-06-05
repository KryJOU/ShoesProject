using System;
using System.Windows.Forms;

namespace ShoesProject
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool exitProgram = false;

            while (!exitProgram)
            {
                using (var formLogin = new FormLogin())
                {
                    if (formLogin.ShowDialog() != DialogResult.OK)
                    {
                        exitProgram = true;
                        break;
                    }

                    using (var chooseForm = new ChooseForm())
                    {
                        DialogResult chooseResult = chooseForm.ShowDialog();

                        if (chooseResult == DialogResult.Cancel)
                        {
                            continue;
                        }

                        if (chooseResult == DialogResult.OK)
                        {
                            if (chooseForm.Choose == 2)
                            {
                                using (var formProducts = new FormProducts(formLogin.CurrentUser, formLogin.IsGuest))
                                {
                                    formProducts.ShowDialog();
                                    continue;
                                }
                            }
                            if (chooseForm.Choose == 1)
                            {
                                using (var formOrders = new FormOrder(formLogin.CurrentUser, formLogin.IsGuest))
                                {
                                    formOrders.ShowDialog();
                                    continue;
                                }
                            }
                        }
                        exitProgram = true;
                    }
                }
            }
        }
    }
}
