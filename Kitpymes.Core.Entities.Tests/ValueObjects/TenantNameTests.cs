using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Kitpymes.Core.Entities.ValueObjects.Tests
{
    [TestClass]
    public class TenantNameTests
    {
        #region IsNull

        [DataTestMethod]
        [DataRow("tenant1")]
        [DataRow("Tenant1")]
        [DataRow("TENANT1")]
        [DataRow("tenant_1")]
        [DataRow("Tenant_1")]
        [DataRow("TENANT_1")]
        [DataRow("tenantA")]
        [DataRow("TenantA")]
        [DataRow("TENANTA")]
        [DataRow("tenant_A")]
        [DataRow("Tenant_A")]
        [DataRow("TENANT_A")]
        public void IsNull_Passing_Valid_Value_Returns_False(string name)
        {
            var expected = false;

            var actual = TenantName.Create(name);

            Assert.AreEqual(expected, actual.IsNull);
        }

        [TestMethod]
        public void IsNull_Passing_Null_Value_Returns_True()
        {
            var expected = true;

            var actual = TenantName.Null;

            Assert.AreEqual(expected, actual.IsNull);
        }

        #endregion IsNull

        #region Create

        [DataTestMethod]
        [DataRow("tenant1")]
        [DataRow("Tenant1")]
        [DataRow("TENANT1")]
        [DataRow("tenant_1")]
        [DataRow("Tenant_1")]
        [DataRow("TENANT_1")]
        [DataRow("tenantA")]
        [DataRow("TenantA")]
        [DataRow("TENANTA")]
        [DataRow("tenant_A")]
        [DataRow("Tenant_A")]
        [DataRow("TENANT_A")]
        public void Create_Passing_Valid_Values_Returns_Name(string name)
        {
            var actual = TenantName.Create(name);

            Assert.AreEqual(name, actual.Value);
        }

        [DataTestMethod]
        [DataRow(null)]
        [DataRow("")]
        public void Create_Passing_InvalidOrNull_Value_Returns_ApplicationException(string? name)
        {
            Assert.ThrowsException<ApplicationException>(() => TenantName.Create(name));
        }

        #endregion Create

        #region Change

        [TestMethod]
        public void Change_Passing_Valid_Values_Returns_Name()
        {
            var expected = "carlos";
            var actual = TenantName.Create("pepe");

            actual.Change(expected);

            Assert.AreEqual(expected, actual.Value);
        }

        #endregion Change

        #region ToString

        [DataTestMethod]
        [DataRow("tenant1")]
        [DataRow("Tenant1")]
        [DataRow("TENANT1")]
        [DataRow("tenant_1")]
        [DataRow("Tenant_1")]
        [DataRow("TENANT_1")]
        [DataRow("tenantA")]
        [DataRow("TenantA")]
        [DataRow("TENANTA")]
        [DataRow("tenant_A")]
        [DataRow("Tenant_A")]
        [DataRow("TENANT_A")]
        public void ToString_Passing_Valid_Values_Returns_Name(string name)
        {
            var expected = name;
            var result = TenantName.Create(name);

            var actual = result.ToString();

            Assert.AreEqual(expected, actual);
        }

        #endregion ToString

        #region Equals

        [DataTestMethod]
        [DataRow("tenant1")]
        [DataRow("Tenant1")]
        [DataRow("TENANT1")]
        [DataRow("tenant_1")]
        [DataRow("Tenant_1")]
        [DataRow("TENANT_1")]
        [DataRow("tenantA")]
        [DataRow("TenantA")]
        [DataRow("TENANTA")]
        [DataRow("tenant_A")]
        [DataRow("Tenant_A")]
        [DataRow("TENANT_A")]
        public void Equals_Passing_Valid_Values_Returns_True(string name)
        {
            var left = TenantName.Create(name);
            var right = TenantName.Create(name);

            var isEqual = left.Equals(right);

            Assert.IsTrue(isEqual);
        }

        [DataTestMethod]
        [DataRow("tenant1")]
        [DataRow("Tenant1")]
        [DataRow("TENANT1")]
        [DataRow("tenant_1")]
        [DataRow("Tenant_1")]
        [DataRow("TENANT_1")]
        [DataRow("tenantA")]
        [DataRow("TenantA")]
        [DataRow("TENANTA")]
        [DataRow("tenant_A")]
        [DataRow("Tenant_A")]
        [DataRow("TENANT_A")]
        public void Equals_Passing_Valid_Distinct_Values_Returns_False(string name)
        {
            var left = TenantName.Create(name);
            var right = TenantName.Create("pepe");

            var isEqual = left.Equals(right);

            Assert.IsFalse(isEqual);
        }

        [DataTestMethod]
        [DataRow("tenant1")]
        [DataRow("Tenant1")]
        [DataRow("TENANT1")]
        [DataRow("tenant_1")]
        [DataRow("Tenant_1")]
        [DataRow("TENANT_1")]
        [DataRow("tenantA")]
        [DataRow("TenantA")]
        [DataRow("TENANTA")]
        [DataRow("tenant_A")]
        [DataRow("Tenant_A")]
        [DataRow("TENANT_A")]
        public void OperatorEqual_Passing_Valid_Values_Returns_True(string name)
        {
            var left = TenantName.Create(name);
            var right = TenantName.Create(name);

            var isEqual = left == right;

            Assert.IsTrue(isEqual);
        }

        [DataTestMethod]
        [DataRow("tenant1")]
        [DataRow("Tenant1")]
        [DataRow("TENANT1")]
        [DataRow("tenant_1")]
        [DataRow("Tenant_1")]
        [DataRow("TENANT_1")]
        [DataRow("tenantA")]
        [DataRow("TenantA")]
        [DataRow("TENANTA")]
        [DataRow("tenant_A")]
        [DataRow("Tenant_A")]
        [DataRow("TENANT_A")]
        public void OperatorEqual_Passing_Valid_Distinct_Values_Returns_False(string name)
        {
            var left = TenantName.Create(name);
            var right = TenantName.Create("carlos");

            var isEqual = left == right;

            Assert.IsFalse(isEqual);
        }

        [DataTestMethod]
        [DataRow("tenant1")]
        [DataRow("Tenant1")]
        [DataRow("TENANT1")]
        [DataRow("tenant_1")]
        [DataRow("Tenant_1")]
        [DataRow("TENANT_1")]
        [DataRow("tenantA")]
        [DataRow("TenantA")]
        [DataRow("TENANTA")]
        [DataRow("tenant_A")]
        [DataRow("Tenant_A")]
        [DataRow("TENANT_A")]
        public void OperatorNotEqual_Passing_Valid_Values_Returns_False(string name)
        {
            var left = TenantName.Create(name);
            var right = TenantName.Create(name);

            var isEqual = left != right;

            Assert.IsFalse(isEqual);
        }

        [DataTestMethod]
        [DataRow("tenant1")]
        [DataRow("Tenant1")]
        [DataRow("TENANT1")]
        [DataRow("tenant_1")]
        [DataRow("Tenant_1")]
        [DataRow("TENANT_1")]
        [DataRow("tenantA")]
        [DataRow("TenantA")]
        [DataRow("TENANTA")]
        [DataRow("tenant_A")]
        [DataRow("Tenant_A")]
        [DataRow("TENANT_A")]
        public void OperatorNotEqual_Passing_Valid_Values_Returns_True(string name)
        {
            var left = TenantName.Create(name);
            var right = TenantName.Create("carlos");

            var isEqual = left != right;

            Assert.IsTrue(isEqual);
        }

        #endregion Equals
    }
}
