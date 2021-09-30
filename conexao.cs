﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginCadastro
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();
        public Conexao() 
        {
            con.ConnectionString = @"";
        }
        // Metodo Conectar
        public SqlConnection conectar() 
        {
            if (con.State == System.Data.ConnectionState.Closed) 
            {
                con.Open();
            }
            return con;
        }
        //Metodo Desconectar
        public void desconectar() 
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }

        }
    }
}
