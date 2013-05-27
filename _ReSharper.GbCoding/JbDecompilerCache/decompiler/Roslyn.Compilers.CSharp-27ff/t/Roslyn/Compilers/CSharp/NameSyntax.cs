// Type: Roslyn.Compilers.CSharp.NameSyntax
// Assembly: Roslyn.Compilers.CSharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Program Files (x86)\Reference Assemblies\Microsoft\Roslyn\v1.0\Roslyn.Compilers.CSharp.dll

using Roslyn.Compilers.CSharp.InternalSyntax;

namespace Roslyn.Compilers.CSharp
{
  public abstract class NameSyntax : Roslyn.Compilers.CSharp.TypeSyntax
  {
    public int Arity
    {
      get
      {
        if (!(this is Roslyn.Compilers.CSharp.GenericNameSyntax))
          return 0;
        else
          return ((Roslyn.Compilers.CSharp.GenericNameSyntax) this).TypeArgumentList.Arguments.Count;
      }
    }

    internal NameSyntax(Roslyn.Compilers.CSharp.SyntaxNode parent, Roslyn.Compilers.CSharp.InternalSyntax.SyntaxNode green, int position)
      : base(parent, green, position)
    {
    }
  }
}
