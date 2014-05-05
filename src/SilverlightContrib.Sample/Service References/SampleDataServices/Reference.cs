//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Original file name:
// Generation date: 12/14/2010 1:20:48 PM
namespace SilverlightContrib.Sample.SampleDataServices
{
    
    /// <summary>
    /// There are no comments for SampleDataServiceContext in the schema.
    /// </summary>
    public partial class SampleDataServiceContext : global::System.Data.Services.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new SampleDataServiceContext object.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public SampleDataServiceContext(global::System.Uri serviceRoot) : 
                base(serviceRoot)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            if (typeName.StartsWith("SilverlightContrib.Sample.Web", global::System.StringComparison.Ordinal))
            {
                return this.GetType().Assembly.GetType(string.Concat("SilverlightContrib.Sample.SampleDataServices", typeName.Substring(29)), false);
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            if (clientType.Namespace.Equals("SilverlightContrib.Sample.SampleDataServices", global::System.StringComparison.Ordinal))
            {
                return string.Concat("SilverlightContrib.Sample.Web.", clientType.Name);
            }
            return null;
        }
        /// <summary>
        /// There are no comments for Customers in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Customer> Customers
        {
            get
            {
                if ((this._Customers == null))
                {
                    this._Customers = base.CreateQuery<Customer>("Customers");
                }
                return this._Customers;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Customer> _Customers;
        /// <summary>
        /// There are no comments for Customers in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToCustomers(Customer customer)
        {
            base.AddObject("Customers", customer);
        }
    }
    /// <summary>
    /// There are no comments for SilverlightContrib.Sample.Web.Customer in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CustomerID
    /// </KeyProperties>
    [global::System.Data.Services.Common.DataServiceKeyAttribute("CustomerID")]
    public partial class Customer
    {
        /// <summary>
        /// Create a new Customer object.
        /// </summary>
        /// <param name="customerID">Initial value of CustomerID.</param>
        /// <param name="birthDate">Initial value of BirthDate.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Customer CreateCustomer(int customerID, global::System.DateTime birthDate)
        {
            Customer customer = new Customer();
            customer.CustomerID = customerID;
            customer.BirthDate = birthDate;
            return customer;
        }
        /// <summary>
        /// There are no comments for Property CustomerID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int CustomerID
        {
            get
            {
                return this._CustomerID;
            }
            set
            {
                this.OnCustomerIDChanging(value);
                this._CustomerID = value;
                this.OnCustomerIDChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _CustomerID;
        partial void OnCustomerIDChanging(int value);
        partial void OnCustomerIDChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property BirthDate in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.DateTime BirthDate
        {
            get
            {
                return this._BirthDate;
            }
            set
            {
                this.OnBirthDateChanging(value);
                this._BirthDate = value;
                this.OnBirthDateChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.DateTime _BirthDate;
        partial void OnBirthDateChanging(global::System.DateTime value);
        partial void OnBirthDateChanged();
    }
}
