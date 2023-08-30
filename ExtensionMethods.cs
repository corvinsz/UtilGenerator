using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Text;

namespace UtilGenerator
{
	internal static class ExtensionMethods
	{
		internal static string GetFieldName(this FieldDeclarationSyntax fieldDeclaration) 
			=> fieldDeclaration.Declaration.Variables.FirstOrDefault()?.Identifier.Value?.ToString();

		internal static string GetFieldType(this FieldDeclarationSyntax fieldDeclaration)
			=> fieldDeclaration.Declaration.Type.ToString();
	}
}
