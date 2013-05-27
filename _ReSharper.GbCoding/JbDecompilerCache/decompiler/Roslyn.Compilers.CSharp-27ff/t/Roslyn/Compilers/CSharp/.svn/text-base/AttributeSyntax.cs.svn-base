// Type: Roslyn.Compilers.CSharp.AttributeSyntax
// Assembly: Roslyn.Compilers.CSharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Program Files (x86)\Reference Assemblies\Microsoft\Roslyn\v1.0\Roslyn.Compilers.CSharp.dll

using Roslyn.Compilers;
using Roslyn.Compilers.CSharp.InternalSyntax;

namespace Roslyn.Compilers.CSharp
{
  public sealed class AttributeSyntax : Roslyn.Compilers.CSharp.SyntaxNode
  {
    private Roslyn.Compilers.CSharp.NameSyntax name;
    private Roslyn.Compilers.CSharp.AttributeArgumentListSyntax argumentListOpt;

    public Roslyn.Compilers.CSharp.NameSyntax Name
    {
      get
      {
        return this.GetRed<Roslyn.Compilers.CSharp.NameSyntax>(ref this.name, 0);
      }
    }

    public Roslyn.Compilers.CSharp.AttributeArgumentListSyntax ArgumentListOpt
    {
      get
      {
        return this.GetRed<Roslyn.Compilers.CSharp.AttributeArgumentListSyntax>(ref this.argumentListOpt, 1);
      }
    }

    internal AttributeSyntax(Roslyn.Compilers.CSharp.SyntaxNode parent, Roslyn.Compilers.CSharp.InternalSyntax.SyntaxNode green, int position)
      : base(parent, green, position)
    {
    }

    internal override Roslyn.Compilers.CSharp.SyntaxNode GetNodeSlot(int index)
    {
      switch (index)
      {
        case 0:
          return (Roslyn.Compilers.CSharp.SyntaxNode) this.GetRed<Roslyn.Compilers.CSharp.NameSyntax>(ref this.name, 0);
        case 1:
          return (Roslyn.Compilers.CSharp.SyntaxNode) this.GetRed<Roslyn.Compilers.CSharp.AttributeArgumentListSyntax>(ref this.argumentListOpt, 1);
        default:
          return (Roslyn.Compilers.CSharp.SyntaxNode) null;
      }
    }

    internal override Roslyn.Compilers.CSharp.SyntaxNode GetCachedSlot(int index)
    {
      switch (index)
      {
        case 0:
          return (Roslyn.Compilers.CSharp.SyntaxNode) this.name;
        case 1:
          return (Roslyn.Compilers.CSharp.SyntaxNode) this.argumentListOpt;
        default:
          return (Roslyn.Compilers.CSharp.SyntaxNode) null;
      }
    }

    internal override TResult Accept<TResult>(Roslyn.Compilers.CSharp.SyntaxVisitor<TResult> visitor)
    {
      return visitor.VisitAttribute(this);
    }

    internal override void Accept(Roslyn.Compilers.CSharp.SyntaxVisitor visitor)
    {
      visitor.VisitAttribute(this);
    }

    public Roslyn.Compilers.CSharp.AttributeSyntax Update(Roslyn.Compilers.CSharp.NameSyntax name, Roslyn.Compilers.CSharp.AttributeArgumentListSyntax argumentListOpt)
    {
      if (name == this.Name && argumentListOpt == this.ArgumentListOpt)
        return this;
      Roslyn.Compilers.CSharp.AttributeSyntax node = Roslyn.Compilers.CSharp.Syntax.Attribute(name, argumentListOpt);
      SyntaxAnnotation[] annotations = this.GetAnnotations();
      if (annotations != null && annotations.Length > 0)
        return Roslyn.Compilers.CSharp.SyntaxNodeExtensions.WithAnnotations<Roslyn.Compilers.CSharp.AttributeSyntax>(node, annotations);
      else
        return node;
    }
  }
}
