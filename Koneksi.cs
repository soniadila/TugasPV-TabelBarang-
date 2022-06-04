/*
 * Created by SharpDevelop.
 * User: User
 * Date: 22/05/2022
 * Time: 14:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data.SqlClient;

namespace LatihanPV
{
	/// <summary>
	/// Description of Koneksi.
	/// </summary>
	public class Koneksi
	{
		public SqlConnection GetConn()
		{
			SqlConnection Conn = new SqlConnection();
			Conn.ConnectionString = "Data Source=USER\\SQLEXPRESS; initial catalog = kasir; integrated security = true";
			return Conn;
		}
	}
}
