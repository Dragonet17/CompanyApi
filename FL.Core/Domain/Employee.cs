using System;
using System.Collections.Generic;
using System.Text;

namespace FL.Core.Domain
{
    public class Employee : Entity
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string CompanyPosition { get; private set; }
        public string Description { get; private set; }
        public string ContractType { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime HiredAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
        public bool Deleted { get; private set; }

        public Employee(string name, string surname, string companyPosition,string contractType, string description, DateTime hiredAt)
        {
            Name = SetName(name);
            Surname = SetSurname(surname);
            CompanyPosition = SetCompanyPosition(companyPosition);
            ContractType = SetContractType(contractType);
            Description = SetDescription(description);
            HiredAt = hiredAt;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
            Deleted = false;
        }

        public void Update(string name, string surname, string companyPosition, string contractType, string description, DateTime hiredAt)
        {
            Name = SetName(name);
            Surname = SetSurname(surname);
            CompanyPosition = SetCompanyPosition(companyPosition);
            ContractType = SetContractType(contractType);
            Description = SetDescription(description);
            HiredAt = hiredAt;
            UpdatedAt = DateTime.UtcNow;
        }

        #region public Methods

        public void Delete()
        {
            Deleted = true;
        }

        public void Restore()
        {
            if (Deleted == false)
            {
                throw new Exception("You can not retore existed employee");
            }
            Deleted = false;
        }

        #endregion


        #region private Methods
        private string SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Employee can not have a empty name");
            }
            return name;
        }
        private string SetSurname(string surname)
        {
            if (string.IsNullOrEmpty(surname))
            {
                throw new Exception("Employee can not have a empty surname");
            }
            return surname;
        }
        private string SetCompanyPosition(string companyPosition)
        {
            if (string.IsNullOrEmpty(companyPosition))
            {
                throw new Exception("Employee can not have a empty company position");
            }
            return companyPosition;
        }
        private string SetContractType(string contractType)
        {
            if (string.IsNullOrEmpty(contractType))
            {
                throw new Exception("Employee can not have a empty contract type");
            }
            return contractType;
        }
        private string SetDescription(string description)
        {
            if (string.IsNullOrEmpty(description))
            {
                throw new Exception("Employee can not have a empty description");
            }
            return description;
        }


        #endregion



    }
}
