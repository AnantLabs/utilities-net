// <auto-generated>
// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
// </auto-generated>
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Generated;

public partial class GenericEnumerableExtensionsTest
{
[TestMethod]
[PexGeneratedBy(typeof(global::GenericEnumerableExtensionsTest))]
public void Flatten3501()
{
    IEnumerable<int> iEnumerable;
    IEnumerable<int>[] iEnumerables = new IEnumerable<int>[0];
    iEnumerable = this.Flatten<int>((IEnumerable<IEnumerable<int>>)iEnumerables);
    Assert.IsNotNull((object)iEnumerable);
}
[TestMethod]
[PexGeneratedBy(typeof(global::GenericEnumerableExtensionsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void FlattenThrowsArgumentNullException496()
{
    IEnumerable<int> iEnumerable;
    iEnumerable = this.Flatten<int>((IEnumerable<IEnumerable<int>>)null);
}
}
