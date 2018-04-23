﻿using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraPivotGrid.Data;
using DevExpress.XtraPivotGrid.ViewInfo;
using DevExpress.XtraEditors.Filtering;
using DevExpress.XtraEditors.Repository;

namespace WindowsApplication53
{
    public class MyPivotGridControl : PivotGridControl
    {
        public MyPivotGridControl() : base() { }
        public MyPivotGridControl(PivotGridViewInfoData viewInfoData) : base(viewInfoData) { }

        protected override PivotGridViewInfoData CreateData()
        {
            return new MyPivotGridViewInfoData(this);
        }
    }

    public class MyPivotGridViewInfoData : PivotGridViewInfoData, IFilteredComponent 
    {
        public MyPivotGridViewInfoData() : base() { }
        public MyPivotGridViewInfoData(IViewInfoControl control) : base(control) { }


        #region IFilteredComponent Members

        FilterColumnCollection IFilteredComponent.CreateFilterColumnCollection()
        {
            FilterColumnCollection collection = new FilterColumnCollection();
            for (int i = 0; i < Fields.Count; i++)
            {
                if (Fields[i].CanShowInPrefilter)
                {
                    FieldFilterColumn filterColumn = new FieldFilterColumn(Fields[i], MenuManager);
                    UpdateFieldFilterColumn(filterColumn);
                    collection.Add(filterColumn); 
                }
            }
            return collection;
        }

        private void UpdateFieldFilterColumn(FieldFilterColumn filterColumn)
        {
            RepositoryItemComboBox comboBox = filterColumn.ColumnEditor as RepositoryItemComboBox;
            if (comboBox != null)
            {
                comboBox.AutoComplete = false;
            }
        }
        #endregion

        
    }

}
