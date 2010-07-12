//------------------------------------------------------------------------------
//
// Copyright (c) 2002-2006 CodeSmith Tools, LLC.  All rights reserved.
// 
// The terms of use for this software are contained in the file
// named sourcelicense.txt, which can be found in the root of this distribution.
// By using this software in any fashion, you are agreeing to be bound by the
// terms of this license.
// 
// You must not remove this notice, or any other, from this software.
//
//------------------------------------------------------------------------------

using System;

namespace CSharpCodeGeneratorSample
{
	public class EntryPoint
	{
		[STAThread]
		public static void Main(string[] args)
		{
			StringHashtable stringhashtable = new StringHashtable();
            StringIntegerHashtable stringinthashtable = new StringIntegerHashtable();
            IntegerHashtable inthashtable = new IntegerHashtable();
			
			Product product = new Product("1");
            Supplier supplier = new Supplier();
		}
	}
}