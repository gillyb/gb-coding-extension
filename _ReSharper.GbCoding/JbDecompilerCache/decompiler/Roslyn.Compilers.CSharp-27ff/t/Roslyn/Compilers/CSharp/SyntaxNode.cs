// Type: Roslyn.Compilers.CSharp.SyntaxNode
// Assembly: Roslyn.Compilers.CSharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Program Files (x86)\Reference Assemblies\Microsoft\Roslyn\v1.0\Roslyn.Compilers.CSharp.dll

using Roslyn.Compilers;
using Roslyn.Compilers.Common;
using Roslyn.Compilers.CSharp.InternalSyntax;
using Roslyn.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace Roslyn.Compilers.CSharp
{
  public abstract class SyntaxNode : CommonSyntaxNode, IBaseSyntaxNodeExt, IBaseSyntaxNode
  {
    private readonly Roslyn.Compilers.CSharp.SyntaxNode parent;
    private readonly int position;
    internal readonly Roslyn.Compilers.CSharp.InternalSyntax.SyntaxNode Green;

    public Roslyn.Compilers.CSharp.SyntaxNode Parent
    {
      get
      {
        return this.parent;
      }
    }

    protected internal override string DebuggerDisplay
    {
      get
      {
        return this.GetType().Name + " " + ((object) this.Kind).ToString() + " " + this.GetText();
      }
    }

    public SyntaxKind Kind
    {
      get
      {
        return this.Green.Kind;
      }
    }

    internal override sealed int Position
    {
      get
      {
        return this.position;
      }
    }

    public override sealed bool HasChildren
    {
      get
      {
        return this.Green.HasChildren;
      }
    }

    public override sealed bool HasDirectives
    {
      get
      {
        return this.Green.HasDirectives;
      }
    }

    public override sealed bool HasDiagnostics
    {
      get
      {
        return this.Green.HasDiagnostics;
      }
    }

    public override bool HasAnnotations
    {
      get
      {
        return this.Green.HasAnnotations;
      }
    }

    internal bool HasSkippedText
    {
      get
      {
        return this.Green.HasSkippedText;
      }
    }

    public override sealed bool HasLeadingTrivia
    {
      get
      {
        return this.Green.HasLeadingTrivia;
      }
    }

    public override sealed bool HasTrailingTrivia
    {
      get
      {
        return this.Green.HasTrailingTrivia;
      }
    }

    internal bool IsList
    {
      get
      {
        return this.Green.IsList;
      }
    }

    internal bool IsElastic
    {
      get
      {
        return this.Green.IsElastic;
      }
    }

    public override sealed bool IsStructuredTrivia
    {
      get
      {
        return this.Green.IsStructuredTrivia;
      }
    }

    public override bool HasStructuredTrivia
    {
      get
      {
        if (this.Green.HasStructuredTrivia)
          return !this.Green.IsStructuredTrivia;
        else
          return false;
      }
    }

    public override sealed bool IsMissing
    {
      get
      {
        return this.Green.IsMissing;
      }
    }

    internal bool HasElasticTrivia
    {
      get
      {
        return this.Green.HasElasticTrivia;
      }
    }

    internal int End
    {
      get
      {
        return this.position + this.Green.FullWidth;
      }
    }

    public override sealed TextSpan FullSpan
    {
      get
      {
        return new TextSpan(this.position, this.Green.FullWidth);
      }
    }

    public override sealed TextSpan Span
    {
      get
      {
        return new TextSpan(this.position + this.Green.LeadingWidth, this.Width);
      }
    }

    public override sealed int Width
    {
      get
      {
        return this.Green.Width;
      }
    }

    public override sealed int FullWidth
    {
      get
      {
        return this.Green.FullWidth;
      }
    }

    internal int SlotCount
    {
      get
      {
        return this.Green.SlotCount;
      }
    }

    internal SyntaxDiagnosticInfoList Errors
    {
      get
      {
        return new SyntaxDiagnosticInfoList(this.Green);
      }
    }

    int IBaseSyntaxNode.Kind
    {
      get
      {
        return (int) this.Kind;
      }
    }

    int IBaseSyntaxNode.Width
    {
      get
      {
        return this.Width;
      }
    }

    int IBaseSyntaxNode.FullWidth
    {
      get
      {
        return this.Green.FullWidth;
      }
    }

    bool IBaseSyntaxNodeExt.IsList
    {
      get
      {
        return this.IsList;
      }
    }

    bool IBaseSyntaxNodeExt.IsStructuredTrivia
    {
      get
      {
        return this.Green.IsStructuredTrivia;
      }
    }

    bool IBaseSyntaxNodeExt.IsDirective
    {
      get
      {
        return this.Green.IsDirective;
      }
    }

    bool IBaseSyntaxNodeExt.IsElastic
    {
      get
      {
        return this.IsElastic;
      }
    }

    bool IBaseSyntaxNodeExt.HasElasticTrivia
    {
      get
      {
        return this.HasElasticTrivia;
      }
    }

    int IBaseSyntaxNodeExt.SlotCount
    {
      get
      {
        return this.SlotCount;
      }
    }

    int IBaseSyntaxNodeExt.LeadingWidth
    {
      get
      {
        return this.Green.LeadingWidth;
      }
    }

    int IBaseSyntaxNodeExt.TrailingWidth
    {
      get
      {
        return this.Green.TrailingWidth;
      }
    }

    protected override int KindCore
    {
      get
      {
        return (int) this.Kind;
      }
    }

    protected override CommonSyntaxNode ParentCore
    {
      get
      {
        return (CommonSyntaxNode) this.Parent;
      }
    }

    internal SyntaxNode(Roslyn.Compilers.CSharp.SyntaxNode parent, Roslyn.Compilers.CSharp.InternalSyntax.SyntaxNode green, int position)
    {
      this.parent = parent;
      this.Green = green;
      this.position = position;
    }

    public SyntaxTriviaList GetLeadingTrivia()
    {
      return this.GetFirstToken(true, false, false).LeadingTrivia;
    }

    public SyntaxTriviaList GetTrailingTrivia()
    {
      return this.GetLastToken(true, false, false).TrailingTrivia;
    }

    internal abstract Roslyn.Compilers.CSharp.SyntaxNode GetCachedSlot(int index);

    internal abstract Roslyn.Compilers.CSharp.SyntaxNode GetNodeSlot(int index);

    internal IBaseSyntaxNodeExt GetSlot(int slot)
    {
      return (IBaseSyntaxNodeExt) this.GetNodeSlot(slot) ?? (IBaseSyntaxNodeExt) this.Green.GetSlot(slot);
    }

    internal int GetSlotOffset(int slot)
    {
      return this.Green.GetSlotOffset(slot);
    }

    internal int GetChildIndex(int slot)
    {
      int num = 0;
      for (int index = 0; index < slot; ++index)
      {
        Roslyn.Compilers.CSharp.InternalSyntax.SyntaxNode slot1 = this.Green.GetSlot(index);
        if (slot1 != null)
        {
          if (slot1.IsList)
            num += slot1.SlotCount;
          else
            ++num;
        }
      }
      return num;
    }

    internal abstract TResult Accept<TResult>(Roslyn.Compilers.CSharp.SyntaxVisitor<TResult> visitor);

    internal abstract void Accept(Roslyn.Compilers.CSharp.SyntaxVisitor visitor);

    public override sealed string GetFullText()
    {
      return this.Green.GetFullText();
    }

    public override sealed string GetText()
    {
      return this.Green.GetText();
    }

    public override void WriteTo(TextWriter writer)
    {
      this.Green.WriteTo(writer, true, true);
    }

    public override string ToString()
    {
      return this.GetFullText();
    }

    internal virtual int GetChildPosition(int index)
    {
      int num = 0;
      while (index > 0)
      {
        --index;
        Roslyn.Compilers.CSharp.SyntaxNode cachedSlot = this.GetCachedSlot(index);
        if (cachedSlot != null)
          return cachedSlot.End + num;
        Roslyn.Compilers.CSharp.InternalSyntax.SyntaxNode slot = this.Green.GetSlot(index);
        if (slot != null)
          num += slot.FullWidth;
      }
      return this.position + num;
    }

    internal IBaseSyntaxNodeExt GetRedOrToken(ref Roslyn.Compilers.CSharp.SyntaxNode field, int slot)
    {
      Roslyn.Compilers.CSharp.SyntaxNode syntaxNode = field;
      if (syntaxNode == null)
      {
        Roslyn.Compilers.CSharp.InternalSyntax.SyntaxNode slot1 = this.Green.GetSlot(slot);
        if (slot1 != null)
        {
          if (slot1.IsToken)
            return (IBaseSyntaxNodeExt) slot1;
          int childPosition = this.GetChildPosition(slot);
          syntaxNode = slot1.ToRed(this, childPosition);
          if (Interlocked.CompareExchange<Roslyn.Compilers.CSharp.SyntaxNode>(ref field, syntaxNode, (Roslyn.Compilers.CSharp.SyntaxNode) null) != null)
            syntaxNode = field;
        }
      }
      return (IBaseSyntaxNodeExt) syntaxNode;
    }

    internal Roslyn.Compilers.CSharp.SyntaxNode GetRedOnly(ref Roslyn.Compilers.CSharp.SyntaxNode field, int slot)
    {
      Roslyn.Compilers.CSharp.SyntaxNode syntaxNode = field;
      if (syntaxNode == null)
      {
        Roslyn.Compilers.CSharp.InternalSyntax.SyntaxNode slot1 = this.Green.GetSlot(slot);
        if (slot1 != null && !slot1.IsToken)
        {
          int childPosition = this.GetChildPosition(slot);
          syntaxNode = slot1.ToRed(this, childPosition);
          if (Interlocked.CompareExchange<Roslyn.Compilers.CSharp.SyntaxNode>(ref field, syntaxNode, (Roslyn.Compilers.CSharp.SyntaxNode) null) != null)
            syntaxNode = field;
        }
      }
      return syntaxNode;
    }

    protected T GetRed<T>(ref T field, int slot) where T : Roslyn.Compilers.CSharp.SyntaxNode
    {
      T obj = field;
      if ((object) obj == null)
      {
        Roslyn.Compilers.CSharp.InternalSyntax.SyntaxNode slot1 = this.Green.GetSlot(slot);
        if (slot1 != null)
        {
          int childPosition = this.GetChildPosition(slot);
          obj = (T) slot1.ToRed(this, childPosition);
          if ((object) Interlocked.CompareExchange<T>(ref field, obj, default (T)) != null)
            obj = field;
        }
      }
      return obj;
    }

    public bool EquivalentTo(Roslyn.Compilers.CSharp.SyntaxNode other)
    {
      if (this == other)
        return true;
      if (other == null)
        return false;
      else
        return this.Green.EquivalentTo(other.Green);
    }

    internal IList<Roslyn.Compilers.CSharp.DirectiveSyntax> GetDirectives()
    {
      return Roslyn.Compilers.CSharp.SyntaxNode.GetDirectives<Roslyn.Compilers.CSharp.DirectiveSyntax>((SyntaxNodeOrToken) this, (Func<Roslyn.Compilers.CSharp.DirectiveSyntax, bool>) null);
    }

    public Roslyn.Compilers.CSharp.DirectiveSyntax GetFirstDirective(Func<Roslyn.Compilers.CSharp.DirectiveSyntax, bool> predicate = null)
    {
      foreach (SyntaxNodeOrToken syntaxNodeOrToken in this.ChildNodesAndTokens())
      {
        if (syntaxNodeOrToken.HasDirectives)
        {
          if (syntaxNodeOrToken.IsNode)
          {
            Roslyn.Compilers.CSharp.DirectiveSyntax firstDirective = syntaxNodeOrToken.AsNode().GetFirstDirective(predicate);
            if (firstDirective != null)
              return firstDirective;
          }
          else
          {
            foreach (Roslyn.Compilers.CSharp.SyntaxTrivia syntaxTrivia in syntaxNodeOrToken.AsToken().LeadingTrivia)
            {
              if (syntaxTrivia.IsDirective)
              {
                Roslyn.Compilers.CSharp.DirectiveSyntax directiveSyntax = (Roslyn.Compilers.CSharp.DirectiveSyntax) syntaxTrivia.GetStructure();
                if (predicate == null || predicate(directiveSyntax))
                  return directiveSyntax;
              }
            }
          }
        }
      }
      return (Roslyn.Compilers.CSharp.DirectiveSyntax) null;
    }

    public Roslyn.Compilers.CSharp.DirectiveSyntax GetLastDirective(Func<Roslyn.Compilers.CSharp.DirectiveSyntax, bool> predicate = null)
    {
      foreach (SyntaxNodeOrToken syntaxNodeOrToken in this.ChildNodesAndTokens().Reverse())
      {
        if (syntaxNodeOrToken.HasDirectives)
        {
          if (syntaxNodeOrToken.IsNode)
          {
            Roslyn.Compilers.CSharp.DirectiveSyntax lastDirective = syntaxNodeOrToken.AsNode().GetLastDirective(predicate);
            if (lastDirective != null)
              return lastDirective;
          }
          else
          {
            Roslyn.Compilers.CSharp.SyntaxToken syntaxToken = syntaxNodeOrToken.AsToken();
            for (int index = syntaxToken.LeadingTrivia.Count - 1; index >= 0; --index)
            {
              Roslyn.Compilers.CSharp.SyntaxTrivia syntaxTrivia = syntaxToken.LeadingTrivia[index];
              if (syntaxTrivia.IsDirective)
              {
                Roslyn.Compilers.CSharp.DirectiveSyntax directiveSyntax = (Roslyn.Compilers.CSharp.DirectiveSyntax) syntaxTrivia.GetStructure();
                if (predicate == null || predicate(directiveSyntax))
                  return directiveSyntax;
              }
            }
          }
        }
      }
      return (Roslyn.Compilers.CSharp.DirectiveSyntax) null;
    }

    internal static IList<TDirective> GetDirectives<TDirective>(SyntaxNodeOrToken node, Func<TDirective, bool> filter = null) where TDirective : Roslyn.Compilers.CSharp.DirectiveSyntax
    {
      List<TDirective> directives = (List<TDirective>) null;
      Roslyn.Compilers.CSharp.SyntaxNode.GetDirectives<TDirective>(node, filter, ref directives);
      return (IList<TDirective>) directives ?? SpecializedCollections.EmptyList<TDirective>();
    }

    private static void GetDirectives<TDirective>(SyntaxNodeOrToken node, Func<TDirective, bool> filter, ref List<TDirective> directives) where TDirective : Roslyn.Compilers.CSharp.DirectiveSyntax
    {
      if (node.IsNode)
      {
        Roslyn.Compilers.CSharp.SyntaxNode.GetDirectives<TDirective>(node.AsNode(), filter, ref directives);
      }
      else
      {
        if (!node.IsToken)
          return;
        Roslyn.Compilers.CSharp.SyntaxNode.GetDirectives<TDirective>(node.AsToken(), filter, ref directives);
      }
    }

    private static void GetDirectives<TDirective>(Roslyn.Compilers.CSharp.SyntaxNode node, Func<TDirective, bool> filter, ref List<TDirective> directives) where TDirective : Roslyn.Compilers.CSharp.DirectiveSyntax
    {
      if (!node.HasDirectives)
        return;
      foreach (SyntaxNodeOrToken node1 in node.ChildNodesAndTokens())
      {
        if (node1.HasDirectives)
          Roslyn.Compilers.CSharp.SyntaxNode.GetDirectives<TDirective>(node1, filter, ref directives);
      }
    }

    private static void GetDirectives<TDirective>(Roslyn.Compilers.CSharp.SyntaxToken token, Func<TDirective, bool> filter, ref List<TDirective> directives) where TDirective : Roslyn.Compilers.CSharp.DirectiveSyntax
    {
      if (!token.HasDirectives)
        return;
      Roslyn.Compilers.CSharp.SyntaxNode.GetDirectives<TDirective>(token.LeadingTrivia, filter, ref directives);
      Roslyn.Compilers.CSharp.SyntaxNode.GetDirectives<TDirective>(token.TrailingTrivia, filter, ref directives);
    }

    private static void GetDirectives<TDirective>(SyntaxTriviaList trivia, Func<TDirective, bool> filter, ref List<TDirective> directives) where TDirective : Roslyn.Compilers.CSharp.DirectiveSyntax
    {
      foreach (Roslyn.Compilers.CSharp.SyntaxTrivia syntaxTrivia in trivia)
      {
        if (syntaxTrivia.HasStructure)
        {
          TDirective directive = syntaxTrivia.GetStructure() as TDirective;
          if ((object) directive != null && (filter == null || filter(directive)))
          {
            if (directives == null)
              directives = new List<TDirective>();
            directives.Add(directive);
          }
        }
      }
    }

    public override bool HasAnnotation(SyntaxAnnotation annotation)
    {
      return this.Green.HasAnnotation(annotation);
    }

    internal SyntaxAnnotation[] GetAnnotations()
    {
      return this.Green.GetAnnotations();
    }

    SyntaxAnnotation[] IBaseSyntaxNodeExt.GetAnnotations()
    {
      return this.GetAnnotations();
    }

    public Roslyn.Compilers.CSharp.SyntaxNode WithAdditionalAnnotations(params SyntaxAnnotation[] annotations)
    {
      return (Roslyn.Compilers.CSharp.SyntaxNode) base.WithAdditionalAnnotations(annotations);
    }

    public IEnumerable<SyntaxNodeOrToken> GetAnnotatedNodesAndTokens(SyntaxAnnotation annotation)
    {
      return Enumerable.Select<CommonSyntaxNodeOrToken, SyntaxNodeOrToken>(base.GetAnnotatedNodesAndTokens(annotation), (Func<CommonSyntaxNodeOrToken, SyntaxNodeOrToken>) (n => (SyntaxNodeOrToken) n));
    }

    public IEnumerable<Roslyn.Compilers.CSharp.SyntaxTrivia> GetAnnotatedTrivia(SyntaxAnnotation annotation)
    {
      return Enumerable.Select<CommonSyntaxTrivia, Roslyn.Compilers.CSharp.SyntaxTrivia>(base.GetAnnotatedTrivia(annotation), (Func<CommonSyntaxTrivia, Roslyn.Compilers.CSharp.SyntaxTrivia>) (n => (Roslyn.Compilers.CSharp.SyntaxTrivia) n));
    }

    public IEnumerable<Roslyn.Compilers.CSharp.SyntaxNode> ChildNodes()
    {
      return Enumerable.OfType<Roslyn.Compilers.CSharp.SyntaxNode>((IEnumerable) base.ChildNodes());
    }

    public Roslyn.Compilers.CSharp.ChildSyntaxList ChildNodesAndTokens()
    {
      return new Roslyn.Compilers.CSharp.ChildSyntaxList(this);
    }

    public IEnumerable<Roslyn.Compilers.CSharp.SyntaxNode> Ancestors(bool ascendOutOfTrivia = true)
    {
      if (this.Parent == null)
        return SpecializedCollections.EmptyEnumerable<Roslyn.Compilers.CSharp.SyntaxNode>();
      else
        return this.Parent.AncestorsAndSelf(ascendOutOfTrivia);
    }

    public IEnumerable<Roslyn.Compilers.CSharp.SyntaxNode> AncestorsAndSelf(bool ascendOutOfTrivia = true)
    {
      return Enumerable.Select<CommonSyntaxNode, Roslyn.Compilers.CSharp.SyntaxNode>(base.AncestorsAndSelf(ascendOutOfTrivia), (Func<CommonSyntaxNode, Roslyn.Compilers.CSharp.SyntaxNode>) (cn => (Roslyn.Compilers.CSharp.SyntaxNode) cn));
    }

    public IEnumerable<Roslyn.Compilers.CSharp.SyntaxNode> DescendentNodes(Func<Roslyn.Compilers.CSharp.SyntaxNode, bool> descendIntoChildren = null, bool descendIntoTrivia = false)
    {
      return Enumerable.Cast<Roslyn.Compilers.CSharp.SyntaxNode>((IEnumerable) base.DescendentNodes(Roslyn.Compilers.CSharp.SyntaxNode.ToCommon(descendIntoChildren), descendIntoTrivia));
    }

    private static Func<CommonSyntaxNode, bool> ToCommon(Func<Roslyn.Compilers.CSharp.SyntaxNode, bool> predicate)
    {
      if (predicate != null)
        return (Func<CommonSyntaxNode, bool>) (cn => predicate((Roslyn.Compilers.CSharp.SyntaxNode) cn));
      else
        return (Func<CommonSyntaxNode, bool>) null;
    }

    public IEnumerable<Roslyn.Compilers.CSharp.SyntaxNode> DescendentNodes(TextSpan span, Func<Roslyn.Compilers.CSharp.SyntaxNode, bool> descendIntoChildren = null, bool descendIntoTrivia = false)
    {
      return Enumerable.Cast<Roslyn.Compilers.CSharp.SyntaxNode>((IEnumerable) base.DescendentNodes(span, Roslyn.Compilers.CSharp.SyntaxNode.ToCommon(descendIntoChildren), descendIntoTrivia));
    }

    public IEnumerable<Roslyn.Compilers.CSharp.SyntaxNode> DescendentNodesAndSelf(Func<Roslyn.Compilers.CSharp.SyntaxNode, bool> descendIntoChildren = null, bool descendIntoTrivia = false)
    {
      return Enumerable.Cast<Roslyn.Compilers.CSharp.SyntaxNode>((IEnumerable) base.DescendentNodesAndSelf(Roslyn.Compilers.CSharp.SyntaxNode.ToCommon(descendIntoChildren), descendIntoTrivia));
    }

    public IEnumerable<Roslyn.Compilers.CSharp.SyntaxNode> DescendentNodesAndSelf(TextSpan span, Func<Roslyn.Compilers.CSharp.SyntaxNode, bool> descendIntoChildren = null, bool descendIntoTrivia = false)
    {
      return Enumerable.Cast<Roslyn.Compilers.CSharp.SyntaxNode>((IEnumerable) base.DescendentNodesAndSelf(span, Roslyn.Compilers.CSharp.SyntaxNode.ToCommon(descendIntoChildren), descendIntoTrivia));
    }

    public IEnumerable<SyntaxNodeOrToken> DescendentNodesAndTokens(Func<Roslyn.Compilers.CSharp.SyntaxNode, bool> descendIntoChildren = null, bool descendIntoTrivia = false)
    {
      return Enumerable.Select<CommonSyntaxNodeOrToken, SyntaxNodeOrToken>(base.DescendentNodesAndTokens(Roslyn.Compilers.CSharp.SyntaxNode.ToCommon(descendIntoChildren), descendIntoTrivia), (Func<CommonSyntaxNodeOrToken, SyntaxNodeOrToken>) (csnot => (SyntaxNodeOrToken) csnot));
    }

    public IEnumerable<SyntaxNodeOrToken> DescendentNodesAndTokens(TextSpan span, Func<Roslyn.Compilers.CSharp.SyntaxNode, bool> descendIntoChildren = null, bool descendIntoTrivia = false)
    {
      return Enumerable.Select<CommonSyntaxNodeOrToken, SyntaxNodeOrToken>(base.DescendentNodesAndTokens(span, Roslyn.Compilers.CSharp.SyntaxNode.ToCommon(descendIntoChildren), descendIntoTrivia), (Func<CommonSyntaxNodeOrToken, SyntaxNodeOrToken>) (csnot => (SyntaxNodeOrToken) csnot));
    }

    public IEnumerable<SyntaxNodeOrToken> DescendentNodesAndTokensAndSelf(Func<Roslyn.Compilers.CSharp.SyntaxNode, bool> descendIntoChildren = null, bool descendIntoTrivia = false)
    {
      return Enumerable.Select<CommonSyntaxNodeOrToken, SyntaxNodeOrToken>(base.DescendentNodesAndTokensAndSelf(Roslyn.Compilers.CSharp.SyntaxNode.ToCommon(descendIntoChildren), descendIntoTrivia), (Func<CommonSyntaxNodeOrToken, SyntaxNodeOrToken>) (csnot => (SyntaxNodeOrToken) csnot));
    }

    public IEnumerable<SyntaxNodeOrToken> DescendentNodesAndTokensAndSelf(TextSpan span, Func<Roslyn.Compilers.CSharp.SyntaxNode, bool> descendIntoChildren = null, bool descendIntoTrivia = false)
    {
      return Enumerable.Select<CommonSyntaxNodeOrToken, SyntaxNodeOrToken>(base.DescendentNodesAndTokensAndSelf(span, Roslyn.Compilers.CSharp.SyntaxNode.ToCommon(descendIntoChildren), descendIntoTrivia), (Func<CommonSyntaxNodeOrToken, SyntaxNodeOrToken>) (csnot => (SyntaxNodeOrToken) csnot));
    }

    public Roslyn.Compilers.CSharp.SyntaxToken GetFirstToken(bool includeSkipped = false, bool includeDirectives = false, bool includeDocumentationComments = false)
    {
      return SyntaxNavigation.GetFirstToken(this, includeSkipped, includeDirectives, includeDocumentationComments);
    }

    public Roslyn.Compilers.CSharp.SyntaxToken GetFirstToken(Func<Roslyn.Compilers.CSharp.SyntaxToken, bool> predicate, Func<Roslyn.Compilers.CSharp.SyntaxTrivia, bool> stepInto = null)
    {
      return SyntaxNavigation.GetFirstToken(this, predicate, stepInto);
    }

    public Roslyn.Compilers.CSharp.SyntaxToken GetLastToken(bool includeSkipped = false, bool includeDirectives = false, bool includeDocumentationComments = false)
    {
      return SyntaxNavigation.GetLastToken(this, includeSkipped, includeDirectives, includeDocumentationComments);
    }

    public Roslyn.Compilers.CSharp.SyntaxToken GetLastToken(Func<Roslyn.Compilers.CSharp.SyntaxToken, bool> predicate, Func<Roslyn.Compilers.CSharp.SyntaxTrivia, bool> stepInto = null)
    {
      return SyntaxNavigation.GetLastToken(this, predicate, stepInto);
    }

    public IEnumerable<Roslyn.Compilers.CSharp.SyntaxToken> DescendentTokens(Func<Roslyn.Compilers.CSharp.SyntaxNode, bool> descendIntoChildren = null, bool descendIntoTrivia = false)
    {
      return Enumerable.Select<CommonSyntaxToken, Roslyn.Compilers.CSharp.SyntaxToken>(base.DescendentTokens(Roslyn.Compilers.CSharp.SyntaxNode.ToCommon(descendIntoChildren), descendIntoTrivia), (Func<CommonSyntaxToken, Roslyn.Compilers.CSharp.SyntaxToken>) (ct => (Roslyn.Compilers.CSharp.SyntaxToken) ct));
    }

    public IEnumerable<Roslyn.Compilers.CSharp.SyntaxToken> DescendentTokens(TextSpan span, Func<Roslyn.Compilers.CSharp.SyntaxNode, bool> descendIntoChildren = null, bool descendIntoTrivia = false)
    {
      return Enumerable.Select<CommonSyntaxToken, Roslyn.Compilers.CSharp.SyntaxToken>(base.DescendentTokens(span, Roslyn.Compilers.CSharp.SyntaxNode.ToCommon(descendIntoChildren), descendIntoTrivia), (Func<CommonSyntaxToken, Roslyn.Compilers.CSharp.SyntaxToken>) (ct => (Roslyn.Compilers.CSharp.SyntaxToken) ct));
    }

    internal Roslyn.Compilers.CSharp.SyntaxToken FindTokenInternal(int position)
    {
      SyntaxNodeOrToken syntaxNodeOrToken = (SyntaxNodeOrToken) this;
      while (syntaxNodeOrToken.AsNode() != null)
        syntaxNodeOrToken = Roslyn.Compilers.CSharp.SyntaxNode.GetChildThatContainsPosition(syntaxNodeOrToken.ChildNodesAndTokens(), position);
      return syntaxNodeOrToken.AsToken();
    }

    public Roslyn.Compilers.CSharp.SyntaxToken FindToken(int position, Func<Roslyn.Compilers.CSharp.SyntaxTrivia, bool> findInsideTrivia)
    {
      Roslyn.Compilers.CSharp.SyntaxToken syntaxToken = this.FindToken(position, false);
      if (findInsideTrivia != null)
      {
        Roslyn.Compilers.CSharp.SyntaxTrivia syntaxTrivia = new Roslyn.Compilers.CSharp.SyntaxTrivia();
        TextSpan span = syntaxToken.Span;
        if (position < span.Start && syntaxToken.HasLeadingTrivia)
          syntaxTrivia = Roslyn.Compilers.CSharp.SyntaxNode.GetTriviaThatContainsPosition(syntaxToken.LeadingTrivia, position);
        else if (position >= span.End && syntaxToken.HasTrailingTrivia)
          syntaxTrivia = Roslyn.Compilers.CSharp.SyntaxNode.GetTriviaThatContainsPosition(syntaxToken.TrailingTrivia, position);
        if (syntaxTrivia.HasStructure && findInsideTrivia(syntaxTrivia))
          syntaxToken = syntaxTrivia.GetStructure().FindTokenInternal(position);
      }
      return syntaxToken;
    }

    private bool TryGetEofAt(int position, out Roslyn.Compilers.CSharp.SyntaxToken Eof)
    {
      if (position == this.End)
      {
        Roslyn.Compilers.CSharp.CompilationUnitSyntax compilationUnitSyntax = this as Roslyn.Compilers.CSharp.CompilationUnitSyntax;
        if (compilationUnitSyntax != null)
        {
          Eof = compilationUnitSyntax.EndOfFileToken;
          return true;
        }
      }
      Eof = new Roslyn.Compilers.CSharp.SyntaxToken();
      return false;
    }

    public Roslyn.Compilers.CSharp.SyntaxToken FindToken(int position, bool findInsideTrivia = false)
    {
      if (findInsideTrivia)
        return this.FindToken(position, Roslyn.Compilers.CSharp.SyntaxTrivia.Any);
      Roslyn.Compilers.CSharp.SyntaxToken Eof;
      if (this.TryGetEofAt(position, out Eof))
        return Eof;
      if (!this.FullSpan.Contains(position))
        throw new IndexOutOfRangeException("position");
      else
        return this.FindTokenInternal(position);
    }

    internal static SyntaxNodeOrToken GetChildThatContainsPosition(Roslyn.Compilers.CSharp.ChildSyntaxList list, int position)
    {
      int num1 = 0;
      int num2 = list.Count - 1;
      while (num1 <= num2)
      {
        int index = num1 + (num2 - num1 >> 1);
        SyntaxNodeOrToken syntaxNodeOrToken = Roslyn.Compilers.CSharp.ChildSyntaxList.ItemInternal(list.Node, index);
        if (position < syntaxNodeOrToken.Position)
        {
          num2 = index - 1;
        }
        else
        {
          if (position < syntaxNodeOrToken.End)
            return syntaxNodeOrToken;
          num1 = index + 1;
        }
      }
      return new SyntaxNodeOrToken();
    }

    internal static Roslyn.Compilers.CSharp.SyntaxTrivia GetTriviaThatContainsPosition(SyntaxTriviaList list, int position)
    {
      foreach (Roslyn.Compilers.CSharp.SyntaxTrivia syntaxTrivia in list)
      {
        if (syntaxTrivia.FullSpan.Contains(position))
          return syntaxTrivia;
        if (syntaxTrivia.Position > position)
          break;
      }
      return new Roslyn.Compilers.CSharp.SyntaxTrivia();
    }

    public Roslyn.Compilers.CSharp.SyntaxTrivia FindTrivia(int position, Func<Roslyn.Compilers.CSharp.SyntaxTrivia, bool> stepInto)
    {
      for (Roslyn.Compilers.CSharp.SyntaxNode node = this; node != null; node = node.Parent)
      {
        if (node.FullSpan.Contains(position))
          return Roslyn.Compilers.CSharp.SyntaxNode.FindTriviaByOffset(node, position - node.position, stepInto);
      }
      return new Roslyn.Compilers.CSharp.SyntaxTrivia();
    }

    public Roslyn.Compilers.CSharp.SyntaxTrivia FindTrivia(int position, bool findInsideTrivia = false)
    {
      return this.FindTrivia(position, findInsideTrivia ? Roslyn.Compilers.CSharp.SyntaxTrivia.Any : (Func<Roslyn.Compilers.CSharp.SyntaxTrivia, bool>) null);
    }

    internal static Roslyn.Compilers.CSharp.SyntaxTrivia FindTriviaByOffset(Roslyn.Compilers.CSharp.SyntaxNode node, int textOffset, Func<Roslyn.Compilers.CSharp.SyntaxTrivia, bool> stepInto = null)
    {
      if (textOffset >= 0)
      {
        foreach (SyntaxNodeOrToken syntaxNodeOrToken in node.ChildNodesAndTokens())
        {
          int fullWidth = syntaxNodeOrToken.FullWidth;
          if (textOffset < fullWidth)
          {
            if (syntaxNodeOrToken.IsNode)
              return Roslyn.Compilers.CSharp.SyntaxNode.FindTriviaByOffset(syntaxNodeOrToken.AsNode(), textOffset, stepInto);
            if (syntaxNodeOrToken.IsToken)
            {
              Roslyn.Compilers.CSharp.SyntaxToken syntaxToken = syntaxNodeOrToken.AsToken();
              int leadingWidth = syntaxToken.LeadingWidth;
              if (textOffset < syntaxToken.LeadingWidth)
              {
                foreach (Roslyn.Compilers.CSharp.SyntaxTrivia syntaxTrivia in syntaxToken.LeadingTrivia)
                {
                  if (textOffset < syntaxTrivia.FullWidth)
                  {
                    if (syntaxTrivia.HasStructure && stepInto != null && stepInto(syntaxTrivia))
                      return Roslyn.Compilers.CSharp.SyntaxNode.FindTriviaByOffset((Roslyn.Compilers.CSharp.SyntaxNode) syntaxTrivia.GetStructure(), textOffset, stepInto);
                    else
                      return syntaxTrivia;
                  }
                  else
                    textOffset -= syntaxTrivia.FullWidth;
                }
              }
              else if (textOffset >= leadingWidth + syntaxToken.Width)
              {
                textOffset -= leadingWidth + syntaxToken.Width;
                foreach (Roslyn.Compilers.CSharp.SyntaxTrivia syntaxTrivia in syntaxToken.TrailingTrivia)
                {
                  if (textOffset < syntaxTrivia.FullWidth)
                  {
                    if (syntaxTrivia.HasStructure && stepInto != null && stepInto(syntaxTrivia))
                      return Roslyn.Compilers.CSharp.SyntaxNode.FindTriviaByOffset((Roslyn.Compilers.CSharp.SyntaxNode) syntaxTrivia.GetStructure(), textOffset, stepInto);
                    else
                      return syntaxTrivia;
                  }
                  else
                    textOffset -= syntaxTrivia.FullWidth;
                }
              }
              return new Roslyn.Compilers.CSharp.SyntaxTrivia();
            }
          }
          textOffset -= fullWidth;
        }
      }
      return new Roslyn.Compilers.CSharp.SyntaxTrivia();
    }

    public IEnumerable<Roslyn.Compilers.CSharp.SyntaxTrivia> DescendentTrivia(Func<Roslyn.Compilers.CSharp.SyntaxNode, bool> descendIntoChildren = null, bool descendIntoTrivia = false)
    {
      return Enumerable.Select<CommonSyntaxTrivia, Roslyn.Compilers.CSharp.SyntaxTrivia>(base.DescendentTrivia(Roslyn.Compilers.CSharp.SyntaxNode.ToCommon(descendIntoChildren), descendIntoTrivia), (Func<CommonSyntaxTrivia, Roslyn.Compilers.CSharp.SyntaxTrivia>) (tr => (Roslyn.Compilers.CSharp.SyntaxTrivia) tr));
    }

    public IEnumerable<Roslyn.Compilers.CSharp.SyntaxTrivia> DescendentTrivia(TextSpan span, Func<Roslyn.Compilers.CSharp.SyntaxNode, bool> descendIntoChildren = null, bool descendIntoTrivia = false)
    {
      return Enumerable.Select<CommonSyntaxTrivia, Roslyn.Compilers.CSharp.SyntaxTrivia>(base.DescendentTrivia(span, Roslyn.Compilers.CSharp.SyntaxNode.ToCommon(descendIntoChildren), descendIntoTrivia), (Func<CommonSyntaxTrivia, Roslyn.Compilers.CSharp.SyntaxTrivia>) (tr => (Roslyn.Compilers.CSharp.SyntaxTrivia) tr));
    }

    CommonChildSyntaxList IBaseSyntaxNode.ChildNodesAndTokens()
    {
      return new CommonChildSyntaxList((IBaseSyntaxNodeExt) this);
    }

    string IBaseSyntaxNode.GetText()
    {
      return this.GetText();
    }

    string IBaseSyntaxNode.GetFullText()
    {
      return this.GetFullText();
    }

    CommonSyntaxNode IBaseSyntaxNodeExt.GetStructure(CommonSyntaxTrivia trivia)
    {
      return (CommonSyntaxNode) this;
    }

    IBaseSyntaxNodeExt IBaseSyntaxNodeExt.GetSlot(int index)
    {
      return this.GetSlot(index);
    }

    int IBaseSyntaxNodeExt.GetSlotOffset(int index)
    {
      return this.GetSlotOffset(index);
    }

    IBaseSyntaxNodeExt IBaseSyntaxNodeExt.WithAdditionalAnnotations(params SyntaxAnnotation[] syntaxAnnotations)
    {
      return (IBaseSyntaxNodeExt) BaseSyntaxNodeExtensions.ToRed(this.Green.WithAdditionalAnnotations(syntaxAnnotations));
    }

    IBaseSyntaxNodeExt IBaseSyntaxNodeExt.GetUnderlyingGreenNode()
    {
      return (IBaseSyntaxNodeExt) this.Green;
    }

    protected override CommonChildSyntaxList ChildNodesAndTokensCore()
    {
      return new CommonChildSyntaxList((IBaseSyntaxNodeExt) this);
    }

    protected override bool EquivalentToCore(CommonSyntaxNode other)
    {
      return this.EquivalentTo(other as Roslyn.Compilers.CSharp.SyntaxNode);
    }

    protected override CommonSyntaxToken FindTokenCore(int position, bool findInsideTrivia)
    {
      return (CommonSyntaxToken) this.FindToken(position, findInsideTrivia);
    }

    protected override CommonSyntaxTrivia FindTriviaCore(int position, bool findInsideTrivia)
    {
      return (CommonSyntaxTrivia) this.FindTrivia(position, findInsideTrivia);
    }

    protected override CommonSyntaxToken GetFirstTokenCore()
    {
      return (CommonSyntaxToken) this.GetFirstToken(Roslyn.Compilers.CSharp.SyntaxToken.NonZeroWidth, (Func<Roslyn.Compilers.CSharp.SyntaxTrivia, bool>) null);
    }

    protected override CommonSyntaxToken GetFirstTokenCore(Func<CommonSyntaxToken, bool> predicate, Func<CommonSyntaxTrivia, bool> stepInto)
    {
      return (CommonSyntaxToken) this.GetFirstToken(FunctionExtensions.ToLanguageSpecific(predicate), FunctionExtensions.ToLanguageSpecific(stepInto));
    }

    protected override CommonSyntaxToken GetLastTokenCore()
    {
      return (CommonSyntaxToken) this.GetLastToken(Roslyn.Compilers.CSharp.SyntaxToken.NonZeroWidth, (Func<Roslyn.Compilers.CSharp.SyntaxTrivia, bool>) null);
    }

    protected override CommonSyntaxToken GetLastTokenCore(Func<CommonSyntaxToken, bool> predicate, Func<CommonSyntaxTrivia, bool> stepInto)
    {
      return (CommonSyntaxToken) this.GetLastToken(FunctionExtensions.ToLanguageSpecific(predicate), FunctionExtensions.ToLanguageSpecific(stepInto));
    }
  }
}
