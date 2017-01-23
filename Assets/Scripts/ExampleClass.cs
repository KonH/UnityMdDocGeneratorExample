using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TestNamespace {
	/// <summary>
	/// Example class. Inline code: <c>string s = "str"; // Some code</c> 
	/// </summary>
	/// <example>
	/// Some example:
	/// <code>
	/// int x = 42;
	/// int y = 0;
	/// </code>
	/// </example>
	/// <remarks>
    /// You may have some additional information about this class.
    /// </remarks>
	public class ExampleClass : MonoBehaviour {
		
		string _name;

        /// <summary>The Name property represents the employee's name.</summary>
        /// <value>The Name property gets/sets the value of the string field, _name.</value>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

		/// <summary>
		/// Basic method and see it inline: <see cref="TestNamespace.ExampleClass.MethodReturns()"/>
		/// </summary>
		/// <exception cref="System.Exception">Thrown when...</exception>
		/// <permission cref="System.Security.PermissionSet">Everyone can access this method.</permission>
		public void SimpleMethod() {
		}

		/// <summary>
		/// Method that returns
		/// </summary>
		/// <returns>integer</returns>
		/// <seealso cref="TestNamespace.ExampleClass.MethodWithParam(int)"/>
		public int MethodReturns() {
			/// <summary>
			/// Inner comment
			/// </summary>
			var x = 42;
			return x;
		}

		/// <summary>
		/// Method with param <paramref name="x"/> and return
		/// </summary>
		/// <param name="x">some param</param>
		/// <returns>some return</returns>
		public int MethodWithParam(int x) {
			return 0;
		}

		/// <summary>
		/// Method with params
		/// </summary>
		/// <param name="a"></param>
		/// <param name="x">int param</param>
		/// <param name="y">string param</param>
		/// <param name="z">class param</param>
		/// <param name="w">struct param</param>
		public void MethodWithParams(int a, int x, string y, ExampleClass z, ExampleStruct w) {
		}

		/// <summary>
		/// Generic method with <typeparamref name="T2"/> param
		/// </summary>
		/// <param name="arg">T2 param</param>
		/// <returns>T1</returns>
		public T1 Generic<T1, T2>(T2 arg) {
			return default(T1);
		}
	}

	/// <summary>
	/// Another class summary.
	/// <para>
	/// Paragraph1
	/// </para>
	/// <para>
	/// Paragraph2
	/// </para>
	/// /// <para>Here is an example of a bulleted list:
	/// <list type="bullet">
	/// <item>
	/// <description>Item 1.</description>
	/// </item>
	/// <item>
	/// <description>Item 2.</description>
	/// </item>
	/// </list>
	/// </para>
	/// </summary>
	public class AnotherExampleClass {
		
		/// <summary>
		/// Nested class summary
		/// </summary>
		public class NestedClass {

			/// <summary>
			/// Nested method summary
			/// </summary>
			public void NestedMetod() {

			}
		}

		public class NestedClass2 {
			/// <summary>
			/// Nested method summary (2)
			/// </summary>
			public void NestedMetod() {

			}
		}
	}
}

/// <summary>
/// WithoutNamespaceClass summary
/// </summary>
class WithoutNamespaceClass {

}
