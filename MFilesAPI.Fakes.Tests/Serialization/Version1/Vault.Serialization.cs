﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFilesAPI.Fakes.Tests.Serialization.Version1
{
	[TestClass]
	public class VaultSerializationTests
	{
		[TestMethod]
		public void IsNotNull()
		{
			var vault = new Vault();
			var serializer = new MFilesAPI.Fakes.Serialization.Version1.JsonSerializer();

			var output = serializer.Serialize(vault);

			Assert.IsNotNull(output);
		}

		[TestMethod]
		public void Name()
		{
			var vault = new Vault() { Name = "hello world" };
			var serializer = new MFilesAPI.Fakes.Serialization.Version1.JsonSerializer();

			var output = serializer.Serialize(vault);

			Assert.AreEqual("hello world", output["name"]);
		}

		[TestMethod]
		public void Guid()
		{
			var guid = System.Guid.NewGuid();
			var vault = new Vault() { Guid = guid };
			var serializer = new MFilesAPI.Fakes.Serialization.Version1.JsonSerializer();

			var output = serializer.Serialize(vault);

			Assert.AreEqual(guid.ToString("B"), output["guid"]);
		}
	}
}
