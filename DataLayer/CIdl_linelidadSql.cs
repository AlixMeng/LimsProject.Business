using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using Npgsql;
using NpgsqlTypes;

namespace LimsProject.BusinessLayer.DataLayer
{
	/// <summary>
	/// Data access layer class for CIdl_linelidad
	/// </summary>
	partial class CIdl_linelidadSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CIdl_linelidadSql()
		{
			// Nothing for now.
		}

        #endregion

        #region Public Methods

        /// <summary>
        /// insert new row in the table
        /// </summary>
		/// <param name="businessObject">business object</param>
		/// <returns>true of successfully insert</returns>
		public bool Insert(CIdl_linelidad businessObject)
		{
			NpgsqlCommand	sqlCommand = new NpgsqlCommand();
			sqlCommand.CommandText = "public.sp_idl_linelidad_Insert";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.AddWithValue("p_elemento", businessObject.Elemento);
				sqlCommand.Parameters["p_elemento"].NpgsqlDbType = NpgsqlDbType.Char;
				sqlCommand.Parameters.AddWithValue("p_lectura", businessObject.Lectura);
				sqlCommand.Parameters["p_lectura"].NpgsqlDbType = NpgsqlDbType.Char;
				sqlCommand.Parameters.AddWithValue("p_mdl", businessObject.Mdl);
				sqlCommand.Parameters["p_mdl"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_idl", businessObject.Idl);
				sqlCommand.Parameters["p_idl"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_ldr", businessObject.Ldr);
				sqlCommand.Parameters["p_ldr"].NpgsqlDbType = NpgsqlDbType.Numeric;

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                
				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("CIdl_linelidad::Insert::Error occured.", ex);
			}
			finally
			{			
				MainConnection.Close();
				sqlCommand.Dispose();
			}
		}

         /// <summary>
        /// update row in the table
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <returns>true for successfully updated</returns>
        public bool Update(CIdl_linelidad businessObject)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_idl_linelidad_Update";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.AddWithValue("p_elemento", businessObject.Elemento);
				sqlCommand.Parameters["p_elemento"].NpgsqlDbType = NpgsqlDbType.Char;
				sqlCommand.Parameters.AddWithValue("p_lectura", businessObject.Lectura);
				sqlCommand.Parameters["p_lectura"].NpgsqlDbType = NpgsqlDbType.Char;
				sqlCommand.Parameters.AddWithValue("p_mdl", businessObject.Mdl);
				sqlCommand.Parameters["p_mdl"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_idl", businessObject.Idl);
				sqlCommand.Parameters["p_idl"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_ldr", businessObject.Ldr);
				sqlCommand.Parameters["p_ldr"].NpgsqlDbType = NpgsqlDbType.Numeric;

                
                MainConnection.Open();

                if (Convert.ToInt32(sqlCommand.ExecuteScalar()) > 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("CIdl_linelidad::Update::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }
        }

        /// <summary>
        /// Select by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>CIdl_linelidad business object</returns>
        public CIdl_linelidad SelectByPrimaryKey(CIdl_linelidadKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_idl_linelidad_SelectByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {


                
                MainConnection.Open();

                NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    CIdl_linelidad businessObject = new CIdl_linelidad();

                    PopulateBusinessObjectFromReader(businessObject, dataReader);

                    return businessObject;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("CIdl_linelidad::SelectByPrimaryKey::Error occured.", ex);
            }
            finally
            {             
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        /// <summary>
        /// Select all rescords
        /// </summary>
        /// <returns>list of CIdl_linelidad</returns>
        public List<CIdl_linelidad> SelectAll()
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_idl_linelidad_SelectAll";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
                MainConnection.Open();

                NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();

                return PopulateObjectsFromReader(dataReader);

            }
            catch (Exception ex)
            {                
                throw new Exception("CIdl_linelidad::SelectAll::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        public DataTable SelectAllDataTable()
        {
            
            DataTable dt = new DataTable();
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_idl_linelidad_SelectAll";
            sqlCommand.CommandType = CommandType.StoredProcedure;                        
            sqlCommand.Connection = MainConnection;
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sqlCommand);

            try
            {                
                MainConnection.Open();

                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("CIdl_linelidad::SelectAll::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        /// <summary>
        /// Select records by field
        /// </summary>
        /// <param name="fieldName">name of field</param>
        /// <param name="value">value of field</param>
        /// <returns>list of CIdl_linelidad</returns>
        public List<CIdl_linelidad> SelectByField(string fieldName, object value)
        {

            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_idl_linelidad_SelectByField";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

                sqlCommand.Parameters.Add(new NpgsqlParameter("FieldName", fieldName));
                sqlCommand.Parameters.Add(new NpgsqlParameter("Value", value));

                MainConnection.Open();
                
                NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();

                return PopulateObjectsFromReader(dataReader);

            }
            catch (Exception ex)
            {
                throw new Exception("CIdl_linelidad::SelectByField::Error occured.", ex);
            }
            finally
            {

                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        /// <summary>
        /// Delete by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CIdl_linelidadKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_idl_linelidad_DeleteByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {



                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CIdl_linelidad::DeleteByKey::Error occured.", ex);
            }
            finally
            {                
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        /// <summary>
        /// Delete records by field
        /// </summary>
        /// <param name="fieldName">name of field</param>
        /// <param name="value">value of field</param>
        /// <returns>true for successfully deleted</returns>
        public bool DeleteByField(string fieldName, object value)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_idl_linelidad_DeleteByField";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

                sqlCommand.Parameters.Add(new NpgsqlParameter("FieldName", fieldName));
                sqlCommand.Parameters.Add(new NpgsqlParameter("Value", value));
                
                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;

            }
            catch (Exception ex)
            {                
                throw new Exception("CIdl_linelidad::DeleteByField::Error occured.", ex);
            }
            finally
            {             
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Populate business object from data reader
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <param name="dataReader">data reader</param>
        internal void PopulateBusinessObjectFromReader(CIdl_linelidad businessObject, IDataReader dataReader)
        {


				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CIdl_linelidad.CIdl_linelidadFields.Elemento.ToString())))
				{
					businessObject.Elemento = dataReader.GetChar(dataReader.GetOrdinal(CIdl_linelidad.CIdl_linelidadFields.Elemento.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CIdl_linelidad.CIdl_linelidadFields.Lectura.ToString())))
				{
					businessObject.Lectura = dataReader.GetChar(dataReader.GetOrdinal(CIdl_linelidad.CIdl_linelidadFields.Lectura.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CIdl_linelidad.CIdl_linelidadFields.Mdl.ToString())))
				{
					businessObject.Mdl = dataReader.GetDecimal(dataReader.GetOrdinal(CIdl_linelidad.CIdl_linelidadFields.Mdl.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CIdl_linelidad.CIdl_linelidadFields.Idl.ToString())))
				{
					businessObject.Idl = dataReader.GetDecimal(dataReader.GetOrdinal(CIdl_linelidad.CIdl_linelidadFields.Idl.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CIdl_linelidad.CIdl_linelidadFields.Ldr.ToString())))
				{
					businessObject.Ldr = dataReader.GetDecimal(dataReader.GetOrdinal(CIdl_linelidad.CIdl_linelidadFields.Ldr.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of CIdl_linelidad</returns>
        internal List<CIdl_linelidad> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<CIdl_linelidad> list = new List<CIdl_linelidad>();

            while (dataReader.Read())
            {
                CIdl_linelidad businessObject = new CIdl_linelidad();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
