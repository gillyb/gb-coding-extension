// Type: Roslyn.Compilers.CSharp.SeparatedSyntaxList`1
// Assembly: Roslyn.Compilers.CSharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Program Files (x86)\Reference Assemblies\Microsoft\Roslyn\v1.0\Roslyn.Compilers.CSharp.dll

using Roslyn.Compilers.Common;
using Roslyn.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Roslyn.Compilers.CSharp
{
  public struct SeparatedSyntaxList<TNode> : IEquatable<SeparatedSyntaxList<TNode>>, IEnumerable<TNode>, IEnumerable where TNode : SyntaxNode
  {
    private readonly SyntaxNodeOrTokenList list;
    private int count;
    private int sepCount;

    internal IBaseSyntaxNodeExt Node
    {
      get
      {
        return this.list.Node;
      }
    }

    public int Count
    {
      get
      {
        if (this.count == -1)
          this.CountElements();
        return this.count;
      }
    }

    public int SeparatorCount
    {
      get
      {
        if (this.sepCount == -1)
          this.CountElements();
        return this.sepCount;
      }
    }

    public TNode this[int index]
    {
      get
      {
        if (index < 0 || index >= this.Count)
          throw new IndexOutOfRangeException();
        int num = 0;
        foreach (TNode node in this)
        {
          if (num == index)
            return node;
          ++num;
        }
        return default (TNode);
      }
    }

    TNode[] Nodes
    {
      private get
      {
        return Enumerable.ToArray<TNode>((IEnumerable<TNode>) this);
      }
    }

    SyntaxNodeOrToken[] NodesWithSeperators
    {
      private get
      {
        return Enumerable.ToArray<SyntaxNodeOrToken>((IEnumerable<SyntaxNodeOrToken>) this.list);
      }
    }

    internal SeparatedSyntaxList(SyntaxNodeOrTokenList list)
    {
      this.list = list;
      this.count = -1;
      this.sepCount = -1;
    }

    public static bool operator ==(SeparatedSyntaxList<TNode> left, SeparatedSyntaxList<TNode> right)
    {
      return left.Equals(right);
    }

    public static bool operator !=(SeparatedSyntaxList<TNode> left, SeparatedSyntaxList<TNode> right)
    {
      return !left.Equals(right);
    }

    private void CountElements()
    {
      this.count = 0;
      this.sepCount = 0;
      foreach (SyntaxNodeOrToken syntaxNodeOrToken in this.list)
      {
        if (syntaxNodeOrToken.IsNode && syntaxNodeOrToken.UnderlyingNode is TNode)
          ++this.count;
        else
          ++this.sepCount;
      }
    }

    public SyntaxToken GetSeparator(int index)
    {
      if (index < 0 || index >= this.SeparatorCount)
        throw new IndexOutOfRangeException();
      int num = 0;
      foreach (SyntaxNodeOrToken syntaxNodeOrToken in this.list)
      {
        if (!(syntaxNodeOrToken.UnderlyingNode is TNode))
        {
          if (num == index)
            return (SyntaxToken) syntaxNodeOrToken;
          ++num;
        }
      }
      throw Contract.Unreachable;
    }

    public TNode First()
    {
      return this[0];
    }

    public TNode FirstOrDefault()
    {
      if (this.Count > 0)
        return this[0];
      else
        return default (TNode);
    }

    public TNode Last()
    {
      return this[this.Count - 1];
    }

    public TNode LastOrDefault()
    {
      if (this.Count > 0)
        return this[this.Count - 1];
      else
        return default (TNode);
    }

    public bool Contains(TNode node)
    {
      return this.IndexOf(node) >= 0;
    }

    public int IndexOf(TNode node)
    {
      int num = 0;
      foreach (TNode node1 in this)
      {
        if (object.Equals((object) node1, (object) node))
          return num;
        ++num;
      }
      return -1;
    }

    public int IndexOf(Func<TNode, bool> predicate)
    {
      int num = 0;
      foreach (TNode node in this)
      {
        if (predicate(node))
          return num;
        ++num;
      }
      return -1;
    }

    public int LastIndexOf(TNode node)
    {
      for (int index = this.Count - 1; index >= 0; --index)
      {
        if (object.Equals((object) this[index], (object) node))
          return index;
      }
      return -1;
    }

    public int LastIndexOf(Func<TNode, bool> predicate)
    {
      for (int index = this.Count - 1; index >= 0; --index)
      {
        if (predicate(this[index]))
          return index;
      }
      return -1;
    }

    public bool Any()
    {
      if (this.count >= 0)
        return this.count > 0;
      else
        return this.GetEnumerator().MoveNext();
    }

    public bool Any(SyntaxKind kind)
    {
      foreach (TNode node in this)
      {
        if (node.Kind == kind)
          return true;
      }
      return false;
    }

    public SyntaxNodeOrTokenList GetWithSeparators()
    {
      return this.list;
    }

    public bool Equals(SeparatedSyntaxList<TNode> other)
    {
      return this.list == other.list;
    }

    public override bool Equals(object obj)
    {
      if (obj is SeparatedSyntaxList<TNode>)
        return this.Equals((SeparatedSyntaxList<TNode>) obj);
      else
        return false;
    }

    public override int GetHashCode()
    {
      return this.list.GetHashCode();
    }

    public SeparatedSyntaxList<TNode>.Enumerator GetEnumerator()
    {
      return new SeparatedSyntaxList<TNode>.Enumerator(this.list);
    }

    IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
    {
      if (this.list.Node == null)
        return SpecializedCollections.EmptyEnumerator<TNode>();
      else
        return (IEnumerator<TNode>) this.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      if (this.list.Node == null)
        return (IEnumerator) SpecializedCollections.EmptyEnumerator<TNode>();
      else
        return (IEnumerator) this.GetEnumerator();
    }

    public struct Enumerator : IEnumerator<TNode>, IDisposable, IEnumerator
    {
      private SyntaxNodeOrTokenList.Enumerator en;
      private TNode current;

      public TNode Current
      {
        get
        {
          return this.current;
        }
      }

      object IEnumerator.Current
      {
        get
        {
          return (object) this.Current;
        }
      }

      internal Enumerator(SyntaxNodeOrTokenList list)
      {
        this.en = list.GetEnumerator();
        this.current = default (TNode);
      }

      public bool MoveNext()
      {
        while (this.en.MoveNext())
        {
          this.current = this.en.Current.AsNode() as TNode;
          if ((object) this.current != null)
            return true;
        }
        return false;
      }

      void IDisposable.Dispose()
      {
      }

      void IEnumerator.Reset()
      {
      }
    }
  }
}
