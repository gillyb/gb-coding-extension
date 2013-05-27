// Type: Roslyn.Compilers.CSharp.SyntaxToken
// Assembly: Roslyn.Compilers.CSharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Program Files (x86)\Reference Assemblies\Microsoft\Roslyn\v1.0\Roslyn.Compilers.CSharp.dll

using Roslyn.Compilers;
using Roslyn.Compilers.Common;
using Roslyn.Compilers.CSharp.InternalSyntax;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Roslyn.Compilers.CSharp
{
  [DebuggerDisplay("{DebuggerDisplay,nq}")]
  public struct SyntaxToken : IEquatable<Roslyn.Compilers.CSharp.SyntaxToken>
  {
    public static readonly Func<Roslyn.Compilers.CSharp.SyntaxToken, bool> Any = (Func<Roslyn.Compilers.CSharp.SyntaxToken, bool>) (t => true);
    public static readonly Func<Roslyn.Compilers.CSharp.SyntaxToken, bool> NonZeroWidth = (Func<Roslyn.Compilers.CSharp.SyntaxToken, bool>) (t => t.Width > 0);
    private readonly Roslyn.Compilers.CSharp.SyntaxNode parent;
    private readonly Roslyn.Compilers.CSharp.InternalSyntax.SyntaxToken node;
    private readonly int position;
    private readonly int index;

    internal string DebuggerDisplay
    {
      get
      {
        return this.GetType().Name + (object) " " + (string) (object) this.Kind + " " + this.GetText();
      }
    }

    internal Roslyn.Compilers.CSharp.InternalSyntax.SyntaxToken Node
    {
      get
      {
        return this.node;
      }
    }

    internal int Offset
    {
      get
      {
        if (this.parent == null)
          return this.position;
        else
          return this.position - this.parent.Position;
      }
    }

    internal int Index
    {
      get
      {
        return this.index;
      }
    }

    internal int Position
    {
      get
      {
        return this.position;
      }
    }

    internal int End
    {
      get
      {
        return this.position + this.FullWidth;
      }
    }

    public SyntaxKind Kind
    {
      get
      {
        if (this.node == null)
          return SyntaxKind.None;
        else
          return this.node.Kind;
      }
    }

    public SyntaxKind ContextualKind
    {
      get
      {
        if (this.node == null)
          return SyntaxKind.None;
        else
          return this.node.ContextualKind;
      }
    }

    public bool IsMissing
    {
      get
      {
        if (this.node != null)
          return this.node.IsMissing;
        else
          return false;
      }
    }

    internal string Text
    {
      get
      {
        if (this.node == null)
          return string.Empty;
        else
          return this.node.Text;
      }
    }

    public object Value
    {
      get
      {
        if (this.node == null)
          return (object) null;
        else
          return this.node.Value;
      }
    }

    public string ValueText
    {
      get
      {
        if (this.node == null)
          return string.Empty;
        else
          return this.node.ValueText;
      }
    }

    public Roslyn.Compilers.CSharp.SyntaxNode Parent
    {
      get
      {
        return this.parent;
      }
    }

    public TextSpan FullSpan
    {
      get
      {
        return new TextSpan(this.position, this.FullWidth);
      }
    }

    public TextSpan Span
    {
      get
      {
        if (this.node == null)
          return new TextSpan();
        else
          return new TextSpan(this.position + this.node.LeadingWidth, this.node.Width);
      }
    }

    public int FullWidth
    {
      get
      {
        if (this.node == null)
          return 0;
        else
          return this.node.FullWidth;
      }
    }

    public int Width
    {
      get
      {
        if (this.node == null)
          return 0;
        else
          return this.node.Width;
      }
    }

    public int LeadingWidth
    {
      get
      {
        if (this.node == null)
          return 0;
        else
          return this.node.LeadingWidth;
      }
    }

    public int TrailingWidth
    {
      get
      {
        if (this.node == null)
          return 0;
        else
          return this.node.TrailingWidth;
      }
    }

    public bool HasDiagnostics
    {
      get
      {
        if (this.node != null)
          return this.node.HasDiagnostics;
        else
          return false;
      }
    }

    internal bool HasAnnotations
    {
      get
      {
        if (this.node != null)
          return this.node.HasAnnotations;
        else
          return false;
      }
    }

    public bool HasDirectives
    {
      get
      {
        if (this.node != null)
          return this.node.HasDirectives;
        else
          return false;
      }
    }

    public bool HasStructuredTrivia
    {
      get
      {
        if (this.node != null)
          return this.node.HasStructuredTrivia;
        else
          return false;
      }
    }

    internal SyntaxDiagnosticInfoList Errors
    {
      get
      {
        return new SyntaxDiagnosticInfoList((Roslyn.Compilers.CSharp.InternalSyntax.SyntaxNode) this.Node);
      }
    }

    public bool HasLeadingTrivia
    {
      get
      {
        if (this.node != null)
          return this.node.GetLeadingTrivia() != null;
        else
          return false;
      }
    }

    public SyntaxTriviaList LeadingTrivia
    {
      get
      {
        if (this.node != null)
          return new SyntaxTriviaList(this, this.node.GetLeadingTrivia());
        else
          return new SyntaxTriviaList();
      }
    }

    public bool HasTrailingTrivia
    {
      get
      {
        if (this.node != null)
          return this.node.GetTrailingTrivia() != null;
        else
          return false;
      }
    }

    public SyntaxTriviaList TrailingTrivia
    {
      get
      {
        if (this.node == null)
          return new SyntaxTriviaList();
        Roslyn.Compilers.CSharp.InternalSyntax.SyntaxNode leadingTrivia = this.node.GetLeadingTrivia();
        Roslyn.Compilers.CSharp.InternalSyntax.SyntaxNode trailingTrivia = this.node.GetTrailingTrivia();
        if (leadingTrivia == null)
        {
          int index = 0;
          return new SyntaxTriviaList(this, trailingTrivia, this.position + this.node.Width, index);
        }
        else
        {
          int slotCount = leadingTrivia.SlotCount;
          return new SyntaxTriviaList(this, trailingTrivia, this.position + leadingTrivia.FullWidth + this.node.Width, slotCount);
        }
      }
    }

    static SyntaxToken()
    {
    }

    internal SyntaxToken(Roslyn.Compilers.CSharp.SyntaxNode parent, Roslyn.Compilers.CSharp.InternalSyntax.SyntaxToken node, int position, int index)
    {
      this.position = position;
      this.parent = parent;
      this.node = node;
      this.index = index;
    }

    public static implicit operator CommonSyntaxToken(Roslyn.Compilers.CSharp.SyntaxToken token)
    {
      return new CommonSyntaxToken((CommonSyntaxNode) token.parent, (ISyntaxToken) token.node, token.Position, token.index);
    }

    public static explicit operator Roslyn.Compilers.CSharp.SyntaxToken(CommonSyntaxToken token)
    {
      return new Roslyn.Compilers.CSharp.SyntaxToken((Roslyn.Compilers.CSharp.SyntaxNode) token.Parent, (Roslyn.Compilers.CSharp.InternalSyntax.SyntaxToken) token.Node, token.Position, token.Index);
    }

    public static implicit operator CommonSyntaxNodeOrToken(Roslyn.Compilers.CSharp.SyntaxToken token)
    {
      return (CommonSyntaxNodeOrToken) (CommonSyntaxToken) token;
    }

    public static explicit operator Roslyn.Compilers.CSharp.SyntaxToken(CommonSyntaxNodeOrToken nodeOrToken)
    {
      return (Roslyn.Compilers.CSharp.SyntaxToken) (CommonSyntaxToken) nodeOrToken;
    }

    public static bool operator ==(Roslyn.Compilers.CSharp.SyntaxToken a, Roslyn.Compilers.CSharp.SyntaxToken b)
    {
      return a.Equals(b);
    }

    public static bool operator !=(Roslyn.Compilers.CSharp.SyntaxToken a, Roslyn.Compilers.CSharp.SyntaxToken b)
    {
      return !a.Equals(b);
    }

    public string GetFullText()
    {
      if (this.node == null)
        return string.Empty;
      else
        return this.node.GetFullText();
    }

    public string GetText()
    {
      if (this.node == null)
        return string.Empty;
      else
        return this.node.GetText();
    }

    public void WriteTo(TextWriter writer)
    {
      if (this.node == null)
        return;
      this.node.WriteTo(writer, true, true);
    }

    public override string ToString()
    {
      return this.GetFullText();
    }

    public IEnumerable<Roslyn.Compilers.CSharp.SyntaxTrivia> GetAllTrivia()
    {
      if (this.HasLeadingTrivia)
      {
        if (this.HasTrailingTrivia)
          return Enumerable.Concat<Roslyn.Compilers.CSharp.SyntaxTrivia>((IEnumerable<Roslyn.Compilers.CSharp.SyntaxTrivia>) this.LeadingTrivia, (IEnumerable<Roslyn.Compilers.CSharp.SyntaxTrivia>) this.TrailingTrivia);
        else
          return (IEnumerable<Roslyn.Compilers.CSharp.SyntaxTrivia>) this.LeadingTrivia;
      }
      else if (this.HasTrailingTrivia)
        return (IEnumerable<Roslyn.Compilers.CSharp.SyntaxTrivia>) this.TrailingTrivia;
      else
        return SpecializedCollections.EmptyEnumerable<Roslyn.Compilers.CSharp.SyntaxTrivia>();
    }

    public Roslyn.Compilers.CSharp.SyntaxToken WithLeadingTrivia(SyntaxTriviaList trivia)
    {
      if (this.node == null)
        return new Roslyn.Compilers.CSharp.SyntaxToken();
      int position = 0;
      int index = 0;
      return new Roslyn.Compilers.CSharp.SyntaxToken((Roslyn.Compilers.CSharp.SyntaxNode) null, this.node.WithLeadingTrivia(trivia.Node), position, index);
    }

    public Roslyn.Compilers.CSharp.SyntaxToken WithTrailingTrivia(SyntaxTriviaList trivia)
    {
      if (this.node == null)
        return new Roslyn.Compilers.CSharp.SyntaxToken();
      int position = 0;
      int index = 0;
      return new Roslyn.Compilers.CSharp.SyntaxToken((Roslyn.Compilers.CSharp.SyntaxNode) null, this.node.WithTrailingTrivia(trivia.Node), position, index);
    }

    public bool Equals(Roslyn.Compilers.CSharp.SyntaxToken other)
    {
      if (this.parent == other.parent && this.node == other.node && this.position == other.position)
        return this.index == other.index;
      else
        return false;
    }

    public override bool Equals(object obj)
    {
      if (obj is Roslyn.Compilers.CSharp.SyntaxToken)
        return this.Equals((Roslyn.Compilers.CSharp.SyntaxToken) obj);
      else
        return false;
    }

    public bool EquivalentTo(Roslyn.Compilers.CSharp.SyntaxToken other)
    {
      if (this.node != null && other.node != null)
        return this.node.EquivalentTo((Roslyn.Compilers.CSharp.InternalSyntax.SyntaxNode) other.node);
      if (this.node == null)
        return other.node == null;
      else
        return false;
    }

    public override int GetHashCode()
    {
      return (this.parent != null ? this.parent.GetHashCode() : 0) + (this.node != null ? this.node.GetHashCode() : 0) + this.position + this.index;
    }

    public Roslyn.Compilers.CSharp.SyntaxToken WithAdditionalAnnotations(params SyntaxAnnotation[] annotations)
    {
      return (Roslyn.Compilers.CSharp.SyntaxToken) (CommonSyntaxToken) this.WithAdditionalAnnotations(annotations);
    }

    public Roslyn.Compilers.CSharp.SyntaxToken CopyAnnotations(Roslyn.Compilers.CSharp.SyntaxToken to)
    {
      return (Roslyn.Compilers.CSharp.SyntaxToken) (CommonSyntaxToken) this.CopyAnnotations((CommonSyntaxToken) to);
    }

    public Roslyn.Compilers.CSharp.SyntaxToken GetNextToken(bool includeSkipped = false, bool includeDirectives = false, bool includeDocumentationComments = false)
    {
      return SyntaxNavigation.GetNextToken(this, includeSkipped, includeDirectives, includeDocumentationComments);
    }

    public Roslyn.Compilers.CSharp.SyntaxToken GetNextToken(Func<Roslyn.Compilers.CSharp.SyntaxToken, bool> predicate, Func<Roslyn.Compilers.CSharp.SyntaxTrivia, bool> stepInto = null)
    {
      return SyntaxNavigation.GetNextToken(this, predicate, stepInto);
    }

    public Roslyn.Compilers.CSharp.SyntaxToken GetPreviousToken(bool includeSkipped = false, bool includeDirectives = false, bool includeDocumentationComments = false)
    {
      return SyntaxNavigation.GetPreviousToken(this, includeSkipped, includeDirectives, includeDocumentationComments);
    }

    public Roslyn.Compilers.CSharp.SyntaxToken GetPreviousToken(Func<Roslyn.Compilers.CSharp.SyntaxToken, bool> predicate, Func<Roslyn.Compilers.CSharp.SyntaxTrivia, bool> stepInto = null)
    {
      return SyntaxNavigation.GetPreviousToken(this, predicate, stepInto);
    }
  }
}
