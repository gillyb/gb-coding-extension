// Type: Roslyn.Compilers.CSharp.IdentifierNameSyntax
// Assembly: Roslyn.Compilers.CSharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Program Files (x86)\Reference Assemblies\Microsoft\Roslyn\v1.0\Roslyn.Compilers.CSharp.dll

using Roslyn.Compilers;
using Roslyn.Compilers.CSharp.InternalSyntax;

namespace Roslyn.Compilers.CSharp
{
  public sealed class IdentifierNameSyntax : Roslyn.Compilers.CSharp.SimpleNameSyntax
  {
    public override string PlainName
    {
      get
      {
        return this.Identifier.ValueText;
      }
    }

    public override Roslyn.Compilers.CSharp.SyntaxToken Identifier
    {
      get
      {
        return new Roslyn.Compilers.CSharp.SyntaxToken((Roslyn.Compilers.CSharp.SyntaxNode) this, (Roslyn.Compilers.CSharp.InternalSyntax.SyntaxToken) this.Green.GetSlot(0), this.GetChildPosition(0), this.GetChildIndex(0));
      }
    }

    internal IdentifierNameSyntax(Roslyn.Compilers.CSharp.SyntaxNode parent, Roslyn.Compilers.CSharp.InternalSyntax.SyntaxNode green, int position)
      : base(parent, green, position)
    {
    }

    internal override Roslyn.Compilers.CSharp.SyntaxNode GetNodeSlot(int index)
    {
      return (Roslyn.Compilers.CSharp.SyntaxNode) null;
    }

    internal override Roslyn.Compilers.CSharp.SyntaxNode GetCachedSlot(int index)
    {
      return (Roslyn.Compilers.CSharp.SyntaxNode) null;
    }

    internal override TResult Accept<TResult>(Roslyn.Compilers.CSharp.SyntaxVisitor<TResult> visitor)
    {
      return visitor.VisitIdentifierName(this);
    }

    internal override void Accept(Roslyn.Compilers.CSharp.SyntaxVisitor visitor)
    {
      visitor.VisitIdentifierName(this);
    }

    public Roslyn.Compilers.CSharp.IdentifierNameSyntax Update(Roslyn.Compilers.CSharp.SyntaxToken identifier)
    {
      if (!(identifier != this.Identifier))
        return this;
      Roslyn.Compilers.CSharp.IdentifierNameSyntax node = Roslyn.Compilers.CSharp.Syntax.IdentifierName(identifier);
      SyntaxAnnotation[] annotations = this.GetAnnotations();
      if (annotations != null && annotations.Length > 0)
        return Roslyn.Compilers.CSharp.SyntaxNodeExtensions.WithAnnotations<Roslyn.Compilers.CSharp.IdentifierNameSyntax>(node, annotations);
      else
        return node;
    }
  }
}
