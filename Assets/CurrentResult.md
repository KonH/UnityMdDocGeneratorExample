# TestNamespace


## AnotherExampleClass

<member name="T:TestNamespace.AnotherExampleClass">
  <summary>
            Another class summary.
            <para>
            Paragraph1
            </para><para>
            Paragraph2
            </para>
            /// <para>Here is an example of a bulleted list:
            <list type="bullet"><item><description>Item 1.</description></item><item><description>Item 2.</description></item></list></para></summary>
</member>

## NestedClass

<member name="T:TestNamespace.AnotherExampleClass.NestedClass">
  <summary>
            Nested class summary
            </summary>
</member>

*Methods:*


**NestedMetod**

<member name="M:TestNamespace.AnotherExampleClass.NestedClass.NestedMetod">
  <summary>
            Nested method summary
            </summary>
</member>

## NestedClass2


*Methods:*


**NestedMetod**

<member name="M:TestNamespace.AnotherExampleClass.NestedClass2.NestedMetod">
  <summary>
            Nested method summary (2)
            </summary>
</member>

## ExampleClass

<member name="T:TestNamespace.ExampleClass">
  <summary>
            Example class. Inline code: <c>string s = "str"; // Some code</c></summary>
  <example>
            Some example:
            <code>
            int x = 42;
            int y = 0;
            </code></example>
  <remarks>
            You may have some additional information about this class.
            </remarks>
</member>

*Properties:*


**Name**

<member name="P:TestNamespace.ExampleClass.Name">
  <summary>The Name property represents the employee's name.</summary>
  <value>The Name property gets/sets the value of the string field, _name.</value>
</member>

*Methods:*


**Generic``2(``1)**

<member name="M:TestNamespace.ExampleClass.Generic``2(``1)">
  <summary>
            Generic method with <typeparamref name="T2" /> param
            </summary>
  <param name="arg">T2 param</param>
  <returns>T1</returns>
</member>

**MethodReturns**

<member name="M:TestNamespace.ExampleClass.MethodReturns">
  <summary>
            Method that returns
            </summary>
  <returns>integer</returns>
  <seealso cref="M:TestNamespace.ExampleClass.MethodWithParam(System.Int32)" />
</member>

**MethodWithParam(System.Int32)**

<member name="M:TestNamespace.ExampleClass.MethodWithParam(System.Int32)">
  <summary>
            Method with param <paramref name="x" /> and return
            </summary>
  <param name="x">some param</param>
  <returns>some return</returns>
</member>

**MethodWithParams(System.Int32,System.Int32,System.String,TestNamespace.ExampleClass,TestNamespace.ExampleStruct)**

<member name="M:TestNamespace.ExampleClass.MethodWithParams(System.Int32,System.Int32,System.String,TestNamespace.ExampleClass,TestNamespace.ExampleStruct)">
  <summary>
            Method with params
            </summary>
  <param name="a">
  </param>
  <param name="x">int param</param>
  <param name="y">string param</param>
  <param name="z">class param</param>
  <param name="w">struct param</param>
</member>

**SimpleMethod**

<member name="M:TestNamespace.ExampleClass.SimpleMethod">
  <summary>
            Basic method and see it inline: <see cref="M:TestNamespace.ExampleClass.MethodReturns" /></summary>
  <exception cref="T:System.Exception">Thrown when...</exception>
  <permission cref="T:System.Security.PermissionSet">Everyone can access this method.</permission>
</member>

## ExampleEnum

<member name="T:TestNamespace.ExampleEnum">
  <summary>
            Example enum
            </summary>
</member>

*Fields:*


**EnumValue0**

<member name="F:TestNamespace.ExampleEnum.EnumValue0">
  <summary>
            Enum field 1	
            </summary>
</member>

**EnumValue1**

<member name="F:TestNamespace.ExampleEnum.EnumValue1">
  <summary>
            Enum field 2	
            </summary>
</member>

## ExampleStruct

<member name="T:TestNamespace.ExampleStruct">
  <summary>
            Struct summary
            </summary>
</member>

*Fields:*


**StructField**

<member name="F:TestNamespace.ExampleStruct.StructField">
  <summary>
            Struct field
            </summary>
</member>

*Properties:*


**StructProperty**

<member name="P:TestNamespace.ExampleStruct.StructProperty">
  <summary>
            Struct property
            </summary>
</member>

*Methods:*


**#ctor(System.Int32,System.Int32)**

<member name="M:TestNamespace.ExampleStruct.#ctor(System.Int32,System.Int32)">
  <summary>
            Struct constructor
            </summary>
  <param name="x">x param</param>
  <param name="y">y param</param>
</member>

# IgnoreNamespace


## IgnorableClass


*Methods:*


**SomeMethod**

<member name="M:TestNamespace.IgnoreNamespace.IgnorableClass.SomeMethod">
  <summary>
            Does not want this comment
            </summary>
</member>

# Editor


## EditorClass

<member name="T:TestNamespace.Editor.EditorClass">
  <summary>
            Editor class summary
            </summary>
</member>

## WithoutNamespaceClass

<member name="T:WithoutNamespaceClass">
  <summary>
            WithoutNamespaceClass summary
            </summary>
</member>

