using Licence360.BLL.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licence360.BLL.Repository.Service
{
    public class EntityService 
    {
        public EntityService()
        {
            _adminUserService = new AdminUserRepository();
            _customerService = new CustomerRepository();
            _customerLicenceService = new CustomerLicenceRepository();
            _productService = new ProductRepository();
            _licenceTimeService = new LicenceTimeRepository();
        }

        private AdminUserRepository _adminUserService;

        public AdminUserRepository AdminUserService
        {
            get { return _adminUserService; }
            set { _adminUserService = value; }
        }

        private CustomerRepository _customerService;

        public CustomerRepository CustomerService
        {
            get { return _customerService; }
            set { _customerService = value; }
        }

        private CustomerLicenceRepository _customerLicenceService;

        public CustomerLicenceRepository CustomerLicenceService
        {
            get { return _customerLicenceService; }
            set { _customerLicenceService = value; }
        }

        private ProductRepository _productService;

        public ProductRepository ProductService
        {
            get { return _productService; }
            set { _productService = value; }
        }

        private LicenceTimeRepository _licenceTimeService;

        public LicenceTimeRepository LicenceTimeService
        {
            get { return _licenceTimeService; }
            set { _licenceTimeService = value; }
        }

    }
}
