using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CControl_sample_conditionFactory
    {

        #region data Members

        CControl_sample_conditionSql _dataObject = null;

        #endregion

        #region Constructor

        public CControl_sample_conditionFactory()
        {
            _dataObject = new CControl_sample_conditionSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CControl_sample_condition
        /// </summary>
        /// <param name="businessObject">CControl_sample_condition object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CControl_sample_condition businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CControl_sample_condition
        /// </summary>
        /// <param name="businessObject">CControl_sample_condition object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CControl_sample_condition businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CControl_sample_condition by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CControl_sample_condition GetByPrimaryKey(CControl_sample_conditionKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CControl_sample_conditions
        /// </summary>
        /// <returns>list</returns>
        public List<CControl_sample_condition> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CControl_sample_conditions
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CControl_sample_condition by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CControl_sample_condition> GetAllBy(CControl_sample_condition.CControl_sample_conditionFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CControl_sample_conditionKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CControl_sample_condition by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CControl_sample_condition.CControl_sample_conditionFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
