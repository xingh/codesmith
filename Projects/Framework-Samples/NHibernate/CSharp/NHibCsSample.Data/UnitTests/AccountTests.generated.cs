using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NHibCsSample.Generated.ManagerObjects;
using NHibCsSample.Generated.BusinessObjects;
using NHibCsSample.Generated.Base;

namespace NHibCsSample.Generated.UnitTests
{
	[TestFixture]
    public partial class AccountTests : UNuitTestBase
    {
        protected IAccountManager manager;
		
		public AccountTests()
        {
            manager = managerFactory.GetAccountManager();
        }
		
		protected Account CreateNewAccount()
		{
			Account entity = new Account();
			
			
			entity.Email = "Test Test Test Test Test Test Test Test Test Test Test T";
			entity.FirstName = "Test Test Test Test Test ";
			entity.LastName = "Test Test Test Test Tes";
			entity.Address1 = "Test Test Test";
			entity.Address2 = "Test Test Test Test Test Test ";
			entity.City = "Test Test Test Test Test Tes";
			entity.State = "Test Test Test Test Test Test Test Test Test Test Test Test Test ";
			entity.Zip = "Test Tes";
			entity.Country = "Test T";
			entity.Phone = "Test";
			
			IProfileManager profileManager = managerFactory.GetProfileManager();
			entity.Profile = profileManager.GetAll(1)[0];
			
			return entity;
		}
		protected Account GetFirstAccount()
        {
            IList<Account> entityList = manager.GetAll(1);
            if (entityList.Count == 0)
                Assert.Fail("All tables must have at least one row for unit tests to succeed.");
            return entityList[0];
        }
		
		[Test]
        public void Create()
        {
            try
            {
				Account entity = CreateNewAccount();
				
                object result = manager.Save(entity);

                Assert.IsNotNull(result);
            }
            catch(Exception ex)
            {
                Assert.Fail(ex.ToString());
            }
        }
        [Test]
        public void Read()
        {
            try
            {
                Account entityA = CreateNewAccount();
				manager.Save(entityA);

                Account entityB = manager.GetById(entityA.Id);

                Assert.AreEqual(entityA, entityB);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.ToString());
            }
        }
		[Test]
		public void Update()
        {
            try
            {
                Account entityA = GetFirstAccount();
				
				entityA.Email = "Test Test Test Test Test Test Tes";
				
				manager.Update(entityA);

                Account entityB = manager.GetById(entityA.Id);

                Assert.AreEqual(entityA.Email, entityB.Email);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.ToString());
            }
        }
        [Test]
        public void Delete()
        {
            try
            {
                Account entity = GetFirstAccount();
				
                manager.Delete(entity);

                entity = manager.GetById(entity.Id);
                Assert.IsNull(entity);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.ToString());
            }
        }
	}
}

