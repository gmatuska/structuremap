using System;
using System.Reflection;
using System.Security;

//
// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
//

[assembly: AssemblyTitle("StructureMap")]
#if !NCRUNCH
[assembly: AllowPartiallyTrustedCallers]
#endif
[assembly: CLSCompliant(true)]