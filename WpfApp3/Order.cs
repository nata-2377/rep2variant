//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp3
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int order_number { get; set; }
        public Nullable<System.DateTime> order_date { get; set; }
        public Nullable<System.DateTime> delivery_date { get; set; }
        public Nullable<int> ID_item { get; set; }
        public Nullable<int> ID_client { get; set; }
        public Nullable<int> code_to_get { get; set; }
        public string status { get; set; }
    
        public virtual Order_composition Order_composition { get; set; }
        public virtual Point_of_issue Point_of_issue { get; set; }
        public virtual Users Users { get; set; }
    }
}
