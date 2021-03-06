using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CProcess_user_systemFactory
    {

        #region data Members

        CProcess_user_systemSql _dataObject = null;

        #endregion

        #region Constructor

        public CProcess_user_systemFactory()
        {
            _dataObject = new CProcess_user_systemSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CProcess_user_system
        /// </summary>
        /// <param name="businessObject">CProcess_user_system object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CProcess_user_system businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CProcess_user_system
        /// </summary>
        /// <param name="businessObject">CProcess_user_system object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CProcess_user_system businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CProcess_user_system by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CProcess_user_system GetByPrimaryKey(CProcess_user_systemKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CProcess_user_systems
        /// </summary>
        /// <returns>list</returns>
        public List<CProcess_user_system> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CProcess_user_systems
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CProcess_user_system by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CProcess_user_system> GetAllBy(CProcess_user_system.CProcess_user_systemFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CProcess_user_systemKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CProcess_user_system by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CProcess_user_system.CProcess_user_systemFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
