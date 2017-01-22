using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TestNamespace {
	/// <summary>
	/// Struct summary
	/// </summary>
	public struct ExampleStruct {
		/// <summary>
		/// Struct field
		/// </summary>
		public int StructField;
		/// <summary>
		/// Struct property
		/// </summary>
		public int StructProperty { get; private set; }

		/// <summary>
		/// Struct constructor
		/// </summary>
		/// <param name="x">x param</param>
		/// <param name="y">y param</param>
		public ExampleStruct(int x, int y) {
			StructField = x;
			StructProperty = y;
		}
	}
}
