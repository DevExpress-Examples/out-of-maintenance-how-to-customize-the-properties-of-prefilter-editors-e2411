<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128581828/14.2.10%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2411)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication53/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication53/Form1.vb))
* [MyPivotGrid.cs](./CS/WindowsApplication53/MyPivotGrid.cs) (VB: [MyPivotGrid.vb](./VB/WindowsApplication53/MyPivotGrid.vb))
* [Program.cs](./CS/WindowsApplication53/Program.cs) (VB: [Program.vb](./VB/WindowsApplication53/Program.vb))
<!-- default file list end -->
# How to customize the properties of Prefilter editors


<p>This example demonstrates how to create a custom PivotGridControl descendant that allows customizing properties of the Prefilter editor. The collection of the Prefilter columns is created via the <strong>IFilteredComponent.CreateFilterColumnCollection()</strong> method. To access created editor you can use the <strong>FieldFilterColumn.ColumnEditor</strong> property. This solution simply turns off the auto complete function of the ComboBox editors.</p>

<br/>


