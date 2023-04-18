using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;
using Consulta_Pacientes.Code.DTO;

namespace Consulta_Pacientes.Code.DAL
{
    class conexao
    {
        //NpgsqlConnection con = new NpgsqlConnection("Server=127.0.0.1;Port=5432;Database=bancocaminho01;User Id=postgres;Password=admpost;");
               
        private string connString = "Server=bancocaminho01.postgresql.dbaas.com.br;Port=5432;User Id=bancocaminho01;Password=Dticdev@2023;Database=bancocaminho01;";
        private static NpgsqlConnection conn;

        public NpgsqlConnection conectarBD()
        {
            try
            {
                if (conn == null)
                {
                    conn = new NpgsqlConnection(connString);
                }
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                return conn;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + e.Message);
            }
            return conn;
        }
   
        public NpgsqlConnection desconectarBD()
        {
            try
            {
                if (conn == null)
                {
                    conn = new NpgsqlConnection(connString);
                }
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
                return conn;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro na Conexão");
            }
            return conn;
        }

        
        public void limpa(Form f)
        {
        foreach (Control c in f.Controls)
        {
           if (c is TextBox)
           {
               c.Text = "";
           }
           if (c is MaskedTextBox)
           {
               c.Text = "";
           }
           if (c is ComboBox)
           {
               c.Text = "";
           }
       }
       foreach (Control item in f.Controls)
       {
           if (item is TabControl)
           {
               foreach (TabPage page in ((TabControl)item).TabPages)
               {
                   foreach (Control control in page.Controls)
                   {
                       if (control is TextBox)
                       {
                           control.Text = "";
                       }
                       if (control is MaskedTextBox)
                       {
                           control.Text = "";
                       }
                       if (control is ComboBox)
                       {
                           control.Text = "";
                       }
                   }
               }
           }
       }


   }
   public void limpapainel(Control.ControlCollection controles)
   {
       foreach (Control item in controles)
       {
           if (item.GetType() == typeof(TextBox))
           {
               item.Text = "";
           }
           if (item.GetType() == typeof(ComboBox))
           {
               item.Text = "";
           }
           if (item.GetType() == typeof(MaskedTextBox))
           {
               item.Text = "";
           }

       }
   }

        /*

   public static class ValidaCPF
   {
       public static bool IsCpf(string cpf)
       {
           int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
           int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
           string tempCpf;
           string digito;
           int soma;
           int resto;

           cpf = cpf.Trim();
           cpf = cpf.Replace(".", "").Replace("-", "");
           if (cpf.Length != 11)
               return false;
           tempCpf = cpf.Substring(0, 9);
           soma = 0;

           for (int i = 0; i < 9; i++)
               soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
           resto = soma % 11;
           if (resto < 2)
               resto = 0;
           else
               resto = 11 - resto;
           digito = resto.ToString();
           tempCpf = tempCpf + digito;
           soma = 0;
           for (int i = 0; i < 10; i++)
               soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
           resto = soma % 11;
           if (resto < 2)
               resto = 0;
           else
               resto = 11 - resto;
           digito = digito + resto.ToString();
           return cpf.EndsWith(digito);
       }
   }

   public void pegacnpj()
   {
       try
       {
           SqlCommand t = new SqlCommand("select CNPJ from cemiterio", conectarBD());

           SqlDataReader dr;
           dr = t.ExecuteReader();
           while (dr.Read())
           {
               cnpjcemit = dr[0].ToString();
           }
           desconectarBD();
       }
       catch (Exception ee)
       {
           MessageBox.Show(ee.ToString());
       }
   }

   public string usuario(string cod)
   {
       try
       {
           SqlCommand userF = new SqlCommand("select usuario_en from entrada, funcionario where funcionario.cod_fun = entrada.cod_fun and funcionario.cod_fun = @cod_fun", conectarBD());
           userF.Parameters.AddWithValue("@cod_fun", cod);
           user = (string)userF.ExecuteScalar();
       }
       catch { }
       return user;
   }

   public void HistLogon(string data, string usuario, string tipo)
   {
       try
       {
           SqlCommand logoff = new SqlCommand("insert into HistLogon values (@dt, @user, @tipo)", conectarBD());
           logoff.Parameters.Add("@dt", SqlDbType.VarChar).Value = data;
           logoff.Parameters.Add("@user", SqlDbType.VarChar).Value = usuario;
           logoff.Parameters.Add("@tipo", SqlDbType.VarChar).Value = tipo;
           logoff.ExecuteNonQuery();
           desconectarBD();
       }
       catch { }
   } */

    }
}
