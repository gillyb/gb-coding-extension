// Type: Roslyn.Compilers.CSharp.Syntax
// Assembly: Roslyn.Compilers.CSharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Program Files (x86)\Reference Assemblies\Microsoft\Roslyn\v1.0\Roslyn.Compilers.CSharp.dll

using Roslyn.Compilers;
using Roslyn.Compilers.Common;
using Roslyn.Compilers.CSharp.InternalSyntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Roslyn.Compilers.CSharp
{
  public static class Syntax
  {
    public static readonly Roslyn.Compilers.CSharp.SyntaxTrivia CarriageReturnLineFeed = (Roslyn.Compilers.CSharp.SyntaxTrivia) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.CarriageReturnLineFeed;
    public static readonly Roslyn.Compilers.CSharp.SyntaxTrivia LineFeed = (Roslyn.Compilers.CSharp.SyntaxTrivia) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.LineFeed;
    public static readonly Roslyn.Compilers.CSharp.SyntaxTrivia CarriageReturn = (Roslyn.Compilers.CSharp.SyntaxTrivia) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.CarriageReturn;
    public static readonly Roslyn.Compilers.CSharp.SyntaxTrivia Space = (Roslyn.Compilers.CSharp.SyntaxTrivia) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.Space;
    public static readonly Roslyn.Compilers.CSharp.SyntaxTrivia Tab = (Roslyn.Compilers.CSharp.SyntaxTrivia) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.Tab;
    public static readonly Roslyn.Compilers.CSharp.SyntaxTrivia ElasticCarriageReturnLineFeed = (Roslyn.Compilers.CSharp.SyntaxTrivia) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.ElasticCarriageReturnLineFeed;
    public static readonly Roslyn.Compilers.CSharp.SyntaxTrivia ElasticLineFeed = (Roslyn.Compilers.CSharp.SyntaxTrivia) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.ElasticLineFeed;
    public static readonly Roslyn.Compilers.CSharp.SyntaxTrivia ElasticCarriageReturn = (Roslyn.Compilers.CSharp.SyntaxTrivia) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.ElasticCarriageReturn;
    public static readonly Roslyn.Compilers.CSharp.SyntaxTrivia ElasticSpace = (Roslyn.Compilers.CSharp.SyntaxTrivia) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.ElasticSpace;
    public static readonly Roslyn.Compilers.CSharp.SyntaxTrivia ElasticTab = (Roslyn.Compilers.CSharp.SyntaxTrivia) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.ElasticTab;
    public static readonly Roslyn.Compilers.CSharp.SyntaxTrivia ElasticMarker = (Roslyn.Compilers.CSharp.SyntaxTrivia) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.ElasticZeroSpace;

    static Syntax()
    {
    }

    public static Roslyn.Compilers.CSharp.IdentifierNameSyntax IdentifierName(Roslyn.Compilers.CSharp.SyntaxToken identifier)
    {
      switch (identifier.Kind)
      {
        case SyntaxKind.ValueKeyword:
        case SyntaxKind.IdentifierToken:
        case SyntaxKind.ThisKeyword:
        case SyntaxKind.BaseKeyword:
        case SyntaxKind.VarKeyword:
        case SyntaxKind.DynamicKeyword:
        case SyntaxKind.GlobalKeyword:
          return (Roslyn.Compilers.CSharp.IdentifierNameSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.IdentifierName(identifier.Node));
        default:
          throw new ArgumentException("identifier");
      }
    }

    public static Roslyn.Compilers.CSharp.QualifiedNameSyntax QualifiedName(Roslyn.Compilers.CSharp.NameSyntax left, Roslyn.Compilers.CSharp.SyntaxToken dotToken = null, Roslyn.Compilers.CSharp.SimpleNameSyntax right = null)
    {
      if (left == null)
        throw new ArgumentNullException("left");
      switch (dotToken.Kind)
      {
        case SyntaxKind.None:
          dotToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.DotToken);
          goto case SyntaxKind.DotToken;
        case SyntaxKind.DotToken:
          if (right == null)
            throw new ArgumentNullException("right");
          else
            return (Roslyn.Compilers.CSharp.QualifiedNameSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.QualifiedName(left == null ? (Roslyn.Compilers.CSharp.InternalSyntax.NameSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.NameSyntax) left.Green, dotToken.Node, right == null ? (Roslyn.Compilers.CSharp.InternalSyntax.SimpleNameSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.SimpleNameSyntax) right.Green));
        default:
          throw new ArgumentException("dotToken");
      }
    }

    public static Roslyn.Compilers.CSharp.GenericNameSyntax GenericName(Roslyn.Compilers.CSharp.SyntaxToken identifier, Roslyn.Compilers.CSharp.TypeArgumentListSyntax typeArgumentList)
    {
      if (identifier.Kind != SyntaxKind.IdentifierToken)
        throw new ArgumentException("identifier");
      if (typeArgumentList == null)
        throw new ArgumentNullException("typeArgumentList");
      else
        return (Roslyn.Compilers.CSharp.GenericNameSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.GenericName(identifier.Node, typeArgumentList == null ? (Roslyn.Compilers.CSharp.InternalSyntax.TypeArgumentListSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.TypeArgumentListSyntax) typeArgumentList.Green));
    }

    public static Roslyn.Compilers.CSharp.TypeArgumentListSyntax TypeArgumentList(Roslyn.Compilers.CSharp.SyntaxToken lessThanToken = null, SeparatedSyntaxList<Roslyn.Compilers.CSharp.TypeSyntax> arguments = null, Roslyn.Compilers.CSharp.SyntaxToken greaterThanToken = null)
    {
      switch (lessThanToken.Kind)
      {
        case SyntaxKind.None:
          lessThanToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.LessThanToken);
          goto case SyntaxKind.LessThanToken;
        case SyntaxKind.LessThanToken:
          switch (greaterThanToken.Kind)
          {
            case SyntaxKind.None:
              greaterThanToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.GreaterThanToken);
              goto case SyntaxKind.GreaterThanToken;
            case SyntaxKind.GreaterThanToken:
              return (Roslyn.Compilers.CSharp.TypeArgumentListSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.TypeArgumentList(lessThanToken.Node, BaseSyntaxNodeExtensions.ToGreenSeparatedList<Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax>(arguments.Node), greaterThanToken.Node));
            default:
              throw new ArgumentException("greaterThanToken");
          }
        default:
          throw new ArgumentException("lessThanToken");
      }
    }

    public static Roslyn.Compilers.CSharp.AliasQualifiedNameSyntax AliasQualifiedName(Roslyn.Compilers.CSharp.IdentifierNameSyntax alias, Roslyn.Compilers.CSharp.SyntaxToken colonColonToken = null, Roslyn.Compilers.CSharp.SimpleNameSyntax name = null)
    {
      if (alias == null)
        throw new ArgumentNullException("alias");
      switch (colonColonToken.Kind)
      {
        case SyntaxKind.None:
          colonColonToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.ColonColonToken);
          goto case SyntaxKind.ColonColonToken;
        case SyntaxKind.ColonColonToken:
          if (name == null)
            throw new ArgumentNullException("name");
          else
            return (Roslyn.Compilers.CSharp.AliasQualifiedNameSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.AliasQualifiedName(alias == null ? (Roslyn.Compilers.CSharp.InternalSyntax.IdentifierNameSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.IdentifierNameSyntax) alias.Green, colonColonToken.Node, name == null ? (Roslyn.Compilers.CSharp.InternalSyntax.SimpleNameSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.SimpleNameSyntax) name.Green));
        default:
          throw new ArgumentException("colonColonToken");
      }
    }

    public static Roslyn.Compilers.CSharp.PredefinedTypeSyntax PredefinedType(Roslyn.Compilers.CSharp.SyntaxToken keyword)
    {
      switch (keyword.Kind)
      {
        case SyntaxKind.BoolKeyword:
        case SyntaxKind.ByteKeyword:
        case SyntaxKind.SByteKeyword:
        case SyntaxKind.ShortKeyword:
        case SyntaxKind.UShortKeyword:
        case SyntaxKind.IntKeyword:
        case SyntaxKind.UIntKeyword:
        case SyntaxKind.LongKeyword:
        case SyntaxKind.ULongKeyword:
        case SyntaxKind.DoubleKeyword:
        case SyntaxKind.FloatKeyword:
        case SyntaxKind.DecimalKeyword:
        case SyntaxKind.StringKeyword:
        case SyntaxKind.CharKeyword:
        case SyntaxKind.VoidKeyword:
        case SyntaxKind.ObjectKeyword:
          return (Roslyn.Compilers.CSharp.PredefinedTypeSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.PredefinedType(keyword.Node));
        default:
          throw new ArgumentException("keyword");
      }
    }

    public static Roslyn.Compilers.CSharp.ArrayTypeSyntax ArrayType(Roslyn.Compilers.CSharp.TypeSyntax elementType, Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.ArrayRankSpecifierSyntax> rankSpecifiers = null)
    {
      if (elementType == null)
        throw new ArgumentNullException("elementType");
      else
        return (Roslyn.Compilers.CSharp.ArrayTypeSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.ArrayType(elementType == null ? (Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax) elementType.Green, BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.ArrayRankSpecifierSyntax>((IBaseSyntaxNodeExt) rankSpecifiers.Node)));
    }

    public static Roslyn.Compilers.CSharp.ArrayRankSpecifierSyntax ArrayRankSpecifier(Roslyn.Compilers.CSharp.SyntaxToken openBracketToken = null, SeparatedSyntaxList<Roslyn.Compilers.CSharp.ExpressionSyntax> sizes = null, Roslyn.Compilers.CSharp.SyntaxToken closeBracketToken = null)
    {
      switch (openBracketToken.Kind)
      {
        case SyntaxKind.None:
          openBracketToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.OpenBracketToken);
          goto case SyntaxKind.OpenBracketToken;
        case SyntaxKind.OpenBracketToken:
          switch (closeBracketToken.Kind)
          {
            case SyntaxKind.None:
              closeBracketToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.CloseBracketToken);
              goto case SyntaxKind.CloseBracketToken;
            case SyntaxKind.CloseBracketToken:
              return (Roslyn.Compilers.CSharp.ArrayRankSpecifierSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.ArrayRankSpecifier(openBracketToken.Node, BaseSyntaxNodeExtensions.ToGreenSeparatedList<Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax>(sizes.Node), closeBracketToken.Node));
            default:
              throw new ArgumentException("closeBracketToken");
          }
        default:
          throw new ArgumentException("openBracketToken");
      }
    }

    public static Roslyn.Compilers.CSharp.PointerTypeSyntax PointerType(Roslyn.Compilers.CSharp.TypeSyntax elementType, Roslyn.Compilers.CSharp.SyntaxToken asteriskToken = null)
    {
      if (elementType == null)
        throw new ArgumentNullException("elementType");
      switch (asteriskToken.Kind)
      {
        case SyntaxKind.None:
          asteriskToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.AsteriskToken);
          goto case SyntaxKind.AsteriskToken;
        case SyntaxKind.AsteriskToken:
          return (Roslyn.Compilers.CSharp.PointerTypeSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.PointerType(elementType == null ? (Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax) elementType.Green, asteriskToken.Node));
        default:
          throw new ArgumentException("asteriskToken");
      }
    }

    public static Roslyn.Compilers.CSharp.NullableTypeSyntax NullableType(Roslyn.Compilers.CSharp.TypeSyntax elementType, Roslyn.Compilers.CSharp.SyntaxToken questionToken = null)
    {
      if (elementType == null)
        throw new ArgumentNullException("elementType");
      switch (questionToken.Kind)
      {
        case SyntaxKind.None:
          questionToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.QuestionToken);
          goto case SyntaxKind.QuestionToken;
        case SyntaxKind.QuestionToken:
          return (Roslyn.Compilers.CSharp.NullableTypeSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.NullableType(elementType == null ? (Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax) elementType.Green, questionToken.Node));
        default:
          throw new ArgumentException("questionToken");
      }
    }

    public static Roslyn.Compilers.CSharp.ParenthesizedExpressionSyntax ParenthesizedExpression(Roslyn.Compilers.CSharp.SyntaxToken openParenToken = null, Roslyn.Compilers.CSharp.ExpressionSyntax expression = null, Roslyn.Compilers.CSharp.SyntaxToken closeParenToken = null)
    {
      switch (openParenToken.Kind)
      {
        case SyntaxKind.None:
          openParenToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.OpenParenToken);
          goto case SyntaxKind.OpenParenToken;
        case SyntaxKind.OpenParenToken:
          if (expression == null)
            throw new ArgumentNullException("expression");
          switch (closeParenToken.Kind)
          {
            case SyntaxKind.None:
              closeParenToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.CloseParenToken);
              goto case SyntaxKind.CloseParenToken;
            case SyntaxKind.CloseParenToken:
              return (Roslyn.Compilers.CSharp.ParenthesizedExpressionSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.ParenthesizedExpression(openParenToken.Node, expression == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) expression.Green, closeParenToken.Node));
            default:
              throw new ArgumentException("closeParenToken");
          }
        default:
          throw new ArgumentException("openParenToken");
      }
    }

    public static Roslyn.Compilers.CSharp.PrefixUnaryExpressionSyntax PrefixUnaryExpression(SyntaxKind kind, Roslyn.Compilers.CSharp.SyntaxToken operatorToken = null, Roslyn.Compilers.CSharp.ExpressionSyntax operand = null)
    {
      switch (kind)
      {
        case SyntaxKind.PlusExpression:
        case SyntaxKind.NegateExpression:
        case SyntaxKind.BitwiseNotExpression:
        case SyntaxKind.LogicalNotExpression:
        case SyntaxKind.PreIncrementExpression:
        case SyntaxKind.PreDecrementExpression:
        case SyntaxKind.PointerIndirectionExpression:
        case SyntaxKind.AddressOfExpression:
          switch (operatorToken.Kind)
          {
            case SyntaxKind.None:
              switch (kind)
              {
                case SyntaxKind.PlusExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.PlusToken);
                  goto label_13;
                case SyntaxKind.NegateExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.MinusToken);
                  goto label_13;
                case SyntaxKind.BitwiseNotExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.TildeToken);
                  goto label_13;
                case SyntaxKind.LogicalNotExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.ExclamationToken);
                  goto label_13;
                case SyntaxKind.PreIncrementExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.PlusPlusToken);
                  goto label_13;
                case SyntaxKind.PreDecrementExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.MinusMinusToken);
                  goto label_13;
                case SyntaxKind.PointerIndirectionExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.AsteriskToken);
                  goto label_13;
                case SyntaxKind.AddressOfExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.AmpersandToken);
                  goto label_13;
                default:
                  goto label_13;
              }
            case SyntaxKind.TildeToken:
            case SyntaxKind.ExclamationToken:
            case SyntaxKind.AmpersandToken:
            case SyntaxKind.AsteriskToken:
            case SyntaxKind.MinusToken:
            case SyntaxKind.PlusToken:
            case SyntaxKind.MinusMinusToken:
            case SyntaxKind.PlusPlusToken:
label_13:
              if (operand == null)
                throw new ArgumentNullException("operand");
              else
                return (Roslyn.Compilers.CSharp.PrefixUnaryExpressionSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.PrefixUnaryExpression(kind, operatorToken.Node, operand == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) operand.Green));
            default:
              throw new ArgumentException("operatorToken");
          }
        default:
          throw new ArgumentException("kind");
      }
    }

    public static Roslyn.Compilers.CSharp.PostfixUnaryExpressionSyntax PostfixUnaryExpression(SyntaxKind kind, Roslyn.Compilers.CSharp.ExpressionSyntax operand, Roslyn.Compilers.CSharp.SyntaxToken operatorToken = null)
    {
      switch (kind)
      {
        case SyntaxKind.PostIncrementExpression:
        case SyntaxKind.PostDecrementExpression:
          if (operand == null)
            throw new ArgumentNullException("operand");
          switch (operatorToken.Kind)
          {
            case SyntaxKind.None:
              switch (kind)
              {
                case SyntaxKind.PostIncrementExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.PlusPlusToken);
                  goto label_9;
                case SyntaxKind.PostDecrementExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.MinusMinusToken);
                  goto label_9;
                default:
                  goto label_9;
              }
            case SyntaxKind.MinusMinusToken:
            case SyntaxKind.PlusPlusToken:
label_9:
              return (Roslyn.Compilers.CSharp.PostfixUnaryExpressionSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.PostfixUnaryExpression(kind, operand == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) operand.Green, operatorToken.Node));
            default:
              throw new ArgumentException("operatorToken");
          }
        default:
          throw new ArgumentException("kind");
      }
    }

    public static Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax MemberAccessExpression(SyntaxKind kind, Roslyn.Compilers.CSharp.ExpressionSyntax expression, Roslyn.Compilers.CSharp.SyntaxToken operatorToken = null, Roslyn.Compilers.CSharp.SimpleNameSyntax name = null)
    {
      switch (kind)
      {
        case SyntaxKind.MemberAccessExpression:
        case SyntaxKind.PointerMemberAccessExpression:
          if (expression == null)
            throw new ArgumentNullException("expression");
          switch (operatorToken.Kind)
          {
            case SyntaxKind.None:
              switch (kind)
              {
                case SyntaxKind.MemberAccessExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.DotToken);
                  goto label_9;
                case SyntaxKind.PointerMemberAccessExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.MinusGreaterThanToken);
                  goto label_9;
                default:
                  goto label_9;
              }
            case SyntaxKind.DotToken:
            case SyntaxKind.MinusGreaterThanToken:
label_9:
              if (name == null)
                throw new ArgumentNullException("name");
              else
                return (Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.MemberAccessExpression(kind, expression == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) expression.Green, operatorToken.Node, name == null ? (Roslyn.Compilers.CSharp.InternalSyntax.SimpleNameSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.SimpleNameSyntax) name.Green));
            default:
              throw new ArgumentException("operatorToken");
          }
        default:
          throw new ArgumentException("kind");
      }
    }

    public static Roslyn.Compilers.CSharp.BinaryExpressionSyntax BinaryExpression(SyntaxKind kind, Roslyn.Compilers.CSharp.ExpressionSyntax left, Roslyn.Compilers.CSharp.SyntaxToken operatorToken = null, Roslyn.Compilers.CSharp.ExpressionSyntax right = null)
    {
      switch (kind)
      {
        case SyntaxKind.AddExpression:
        case SyntaxKind.SubtractExpression:
        case SyntaxKind.MultiplyExpression:
        case SyntaxKind.DivideExpression:
        case SyntaxKind.ModuloExpression:
        case SyntaxKind.LeftShiftExpression:
        case SyntaxKind.RightShiftExpression:
        case SyntaxKind.LogicalOrExpression:
        case SyntaxKind.LogicalAndExpression:
        case SyntaxKind.BitwiseOrExpression:
        case SyntaxKind.BitwiseAndExpression:
        case SyntaxKind.ExclusiveOrExpression:
        case SyntaxKind.EqualsExpression:
        case SyntaxKind.NotEqualsExpression:
        case SyntaxKind.LessThanExpression:
        case SyntaxKind.LessThanOrEqualExpression:
        case SyntaxKind.GreaterThanExpression:
        case SyntaxKind.GreaterThanOrEqualExpression:
        case SyntaxKind.IsExpression:
        case SyntaxKind.AsExpression:
        case SyntaxKind.CoalesceExpression:
        case SyntaxKind.AssignExpression:
        case SyntaxKind.AddAssignExpression:
        case SyntaxKind.SubtractAssignExpression:
        case SyntaxKind.MultiplyAssignExpression:
        case SyntaxKind.DivideAssignExpression:
        case SyntaxKind.ModuloAssignExpression:
        case SyntaxKind.AndAssignExpression:
        case SyntaxKind.ExclusiveOrAssignExpression:
        case SyntaxKind.OrAssignExpression:
        case SyntaxKind.LeftShiftAssignExpression:
        case SyntaxKind.RightShiftAssignExpression:
          if (left == null)
            throw new ArgumentNullException("left");
          switch (operatorToken.Kind)
          {
            case SyntaxKind.None:
              switch (kind)
              {
                case SyntaxKind.AddExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.PlusToken);
                  goto label_39;
                case SyntaxKind.SubtractExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.MinusToken);
                  goto label_39;
                case SyntaxKind.MultiplyExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.AsteriskToken);
                  goto label_39;
                case SyntaxKind.DivideExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.SlashToken);
                  goto label_39;
                case SyntaxKind.ModuloExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.PercentToken);
                  goto label_39;
                case SyntaxKind.LeftShiftExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.LessThanLessThanToken);
                  goto label_39;
                case SyntaxKind.RightShiftExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.GreaterThanGreaterThanToken);
                  goto label_39;
                case SyntaxKind.LogicalOrExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.BarBarToken);
                  goto label_39;
                case SyntaxKind.LogicalAndExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.AmpersandAmpersandToken);
                  goto label_39;
                case SyntaxKind.BitwiseOrExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.BarToken);
                  goto label_39;
                case SyntaxKind.BitwiseAndExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.AmpersandToken);
                  goto label_39;
                case SyntaxKind.ExclusiveOrExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.CaretToken);
                  goto label_39;
                case SyntaxKind.EqualsExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.EqualsEqualsToken);
                  goto label_39;
                case SyntaxKind.NotEqualsExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.ExclamationEqualsToken);
                  goto label_39;
                case SyntaxKind.LessThanExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.LessThanToken);
                  goto label_39;
                case SyntaxKind.LessThanOrEqualExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.LessThanEqualsToken);
                  goto label_39;
                case SyntaxKind.GreaterThanExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.GreaterThanToken);
                  goto label_39;
                case SyntaxKind.GreaterThanOrEqualExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.GreaterThanEqualsToken);
                  goto label_39;
                case SyntaxKind.IsExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.IsKeyword);
                  goto label_39;
                case SyntaxKind.AsExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.AsKeyword);
                  goto label_39;
                case SyntaxKind.CoalesceExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.QuestionQuestionToken);
                  goto label_39;
                case SyntaxKind.AssignExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.EqualsToken);
                  goto label_39;
                case SyntaxKind.AddAssignExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.PlusEqualsToken);
                  goto label_39;
                case SyntaxKind.SubtractAssignExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.MinusEqualsToken);
                  goto label_39;
                case SyntaxKind.MultiplyAssignExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.AsteriskEqualsToken);
                  goto label_39;
                case SyntaxKind.DivideAssignExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.SlashEqualsToken);
                  goto label_39;
                case SyntaxKind.ModuloAssignExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.PercentEqualsToken);
                  goto label_39;
                case SyntaxKind.AndAssignExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.AmpersandEqualsToken);
                  goto label_39;
                case SyntaxKind.ExclusiveOrAssignExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.CaretEqualsToken);
                  goto label_39;
                case SyntaxKind.OrAssignExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.BarEqualsToken);
                  goto label_39;
                case SyntaxKind.LeftShiftAssignExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.LessThanLessThanEqualsToken);
                  goto label_39;
                case SyntaxKind.RightShiftAssignExpression:
                  operatorToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.GreaterThanGreaterThanEqualsToken);
                  goto label_39;
                default:
                  goto label_39;
              }
            case SyntaxKind.PercentToken:
            case SyntaxKind.CaretToken:
            case SyntaxKind.AmpersandToken:
            case SyntaxKind.AsteriskToken:
            case SyntaxKind.MinusToken:
            case SyntaxKind.PlusToken:
            case SyntaxKind.EqualsToken:
            case SyntaxKind.BarToken:
            case SyntaxKind.LessThanToken:
            case SyntaxKind.GreaterThanToken:
            case SyntaxKind.SlashToken:
            case SyntaxKind.BarBarToken:
            case SyntaxKind.AmpersandAmpersandToken:
            case SyntaxKind.QuestionQuestionToken:
            case SyntaxKind.ExclamationEqualsToken:
            case SyntaxKind.EqualsEqualsToken:
            case SyntaxKind.LessThanEqualsToken:
            case SyntaxKind.LessThanLessThanToken:
            case SyntaxKind.LessThanLessThanEqualsToken:
            case SyntaxKind.GreaterThanEqualsToken:
            case SyntaxKind.GreaterThanGreaterThanToken:
            case SyntaxKind.GreaterThanGreaterThanEqualsToken:
            case SyntaxKind.SlashEqualsToken:
            case SyntaxKind.AsteriskEqualsToken:
            case SyntaxKind.BarEqualsToken:
            case SyntaxKind.AmpersandEqualsToken:
            case SyntaxKind.PlusEqualsToken:
            case SyntaxKind.MinusEqualsToken:
            case SyntaxKind.CaretEqualsToken:
            case SyntaxKind.PercentEqualsToken:
            case SyntaxKind.IsKeyword:
            case SyntaxKind.AsKeyword:
label_39:
              if (right == null)
                throw new ArgumentNullException("right");
              else
                return (Roslyn.Compilers.CSharp.BinaryExpressionSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.BinaryExpression(kind, left == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) left.Green, operatorToken.Node, right == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) right.Green));
            default:
              throw new ArgumentException("operatorToken");
          }
        default:
          throw new ArgumentException("kind");
      }
    }

    public static Roslyn.Compilers.CSharp.ConditionalExpressionSyntax ConditionalExpression(Roslyn.Compilers.CSharp.ExpressionSyntax condition, Roslyn.Compilers.CSharp.SyntaxToken questionToken = null, Roslyn.Compilers.CSharp.ExpressionSyntax whenTrue = null, Roslyn.Compilers.CSharp.SyntaxToken colonToken = null, Roslyn.Compilers.CSharp.ExpressionSyntax whenFalse = null)
    {
      if (condition == null)
        throw new ArgumentNullException("condition");
      switch (questionToken.Kind)
      {
        case SyntaxKind.None:
          questionToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.QuestionToken);
          goto case SyntaxKind.QuestionToken;
        case SyntaxKind.QuestionToken:
          if (whenTrue == null)
            throw new ArgumentNullException("whenTrue");
          switch (colonToken.Kind)
          {
            case SyntaxKind.None:
              colonToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.ColonToken);
              goto case SyntaxKind.ColonToken;
            case SyntaxKind.ColonToken:
              if (whenFalse == null)
                throw new ArgumentNullException("whenFalse");
              else
                return (Roslyn.Compilers.CSharp.ConditionalExpressionSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.ConditionalExpression(condition == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) condition.Green, questionToken.Node, whenTrue == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) whenTrue.Green, colonToken.Node, whenFalse == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) whenFalse.Green));
            default:
              throw new ArgumentException("colonToken");
          }
        default:
          throw new ArgumentException("questionToken");
      }
    }

    public static Roslyn.Compilers.CSharp.ThisExpressionSyntax ThisExpression(Roslyn.Compilers.CSharp.SyntaxToken token = null)
    {
      switch (token.Kind)
      {
        case SyntaxKind.None:
          token = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.ThisKeyword);
          goto case SyntaxKind.ThisKeyword;
        case SyntaxKind.ThisKeyword:
          return (Roslyn.Compilers.CSharp.ThisExpressionSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.ThisExpression(token.Node));
        default:
          throw new ArgumentException("token");
      }
    }

    public static Roslyn.Compilers.CSharp.BaseExpressionSyntax BaseExpression(Roslyn.Compilers.CSharp.SyntaxToken token = null)
    {
      switch (token.Kind)
      {
        case SyntaxKind.None:
          token = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.BaseKeyword);
          goto case SyntaxKind.BaseKeyword;
        case SyntaxKind.BaseKeyword:
          return (Roslyn.Compilers.CSharp.BaseExpressionSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.BaseExpression(token.Node));
        default:
          throw new ArgumentException("token");
      }
    }

    public static Roslyn.Compilers.CSharp.LiteralExpressionSyntax LiteralExpression(SyntaxKind kind, Roslyn.Compilers.CSharp.SyntaxToken token = null)
    {
      switch (kind)
      {
        case SyntaxKind.ArgListExpression:
        case SyntaxKind.NumericLiteralExpression:
        case SyntaxKind.StringLiteralExpression:
        case SyntaxKind.CharacterLiteralExpression:
        case SyntaxKind.TrueLiteralExpression:
        case SyntaxKind.FalseLiteralExpression:
        case SyntaxKind.NullLiteralExpression:
          switch (token.Kind)
          {
            case SyntaxKind.ArgListKeyword:
            case SyntaxKind.NumericLiteralToken:
            case SyntaxKind.CharacterLiteralToken:
            case SyntaxKind.StringLiteralToken:
            case SyntaxKind.NullKeyword:
            case SyntaxKind.TrueKeyword:
            case SyntaxKind.FalseKeyword:
label_12:
              return (Roslyn.Compilers.CSharp.LiteralExpressionSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.LiteralExpression(kind, token.Node));
            case SyntaxKind.None:
              switch (kind)
              {
                case SyntaxKind.ArgListExpression:
                  token = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.ArgListKeyword);
                  goto label_12;
                case SyntaxKind.NumericLiteralExpression:
                  token = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.NumericLiteralToken);
                  goto label_12;
                case SyntaxKind.StringLiteralExpression:
                  token = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.StringLiteralToken);
                  goto label_12;
                case SyntaxKind.CharacterLiteralExpression:
                  token = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.CharacterLiteralToken);
                  goto label_12;
                case SyntaxKind.TrueLiteralExpression:
                  token = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.TrueKeyword);
                  goto label_12;
                case SyntaxKind.FalseLiteralExpression:
                  token = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.FalseKeyword);
                  goto label_12;
                case SyntaxKind.NullLiteralExpression:
                  token = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.NullKeyword);
                  goto label_12;
                default:
                  goto label_12;
              }
            default:
              throw new ArgumentException("token");
          }
        default:
          throw new ArgumentException("kind");
      }
    }

    public static Roslyn.Compilers.CSharp.MakeRefExpressionSyntax MakeRefExpression(Roslyn.Compilers.CSharp.SyntaxToken keyword = null, Roslyn.Compilers.CSharp.ArgumentListSyntax argumentList = null)
    {
      switch (keyword.Kind)
      {
        case SyntaxKind.None:
          keyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.MakeRefKeyword);
          goto case SyntaxKind.MakeRefKeyword;
        case SyntaxKind.MakeRefKeyword:
          if (argumentList == null)
            throw new ArgumentNullException("argumentList");
          else
            return (Roslyn.Compilers.CSharp.MakeRefExpressionSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.MakeRefExpression(keyword.Node, argumentList == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ArgumentListSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ArgumentListSyntax) argumentList.Green));
        default:
          throw new ArgumentException("keyword");
      }
    }

    public static Roslyn.Compilers.CSharp.RefTypeExpressionSyntax RefTypeExpression(Roslyn.Compilers.CSharp.SyntaxToken keyword = null, Roslyn.Compilers.CSharp.ArgumentListSyntax argumentList = null)
    {
      switch (keyword.Kind)
      {
        case SyntaxKind.None:
          keyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.RefTypeKeyword);
          goto case SyntaxKind.RefTypeKeyword;
        case SyntaxKind.RefTypeKeyword:
          if (argumentList == null)
            throw new ArgumentNullException("argumentList");
          else
            return (Roslyn.Compilers.CSharp.RefTypeExpressionSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.RefTypeExpression(keyword.Node, argumentList == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ArgumentListSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ArgumentListSyntax) argumentList.Green));
        default:
          throw new ArgumentException("keyword");
      }
    }

    public static Roslyn.Compilers.CSharp.RefValueExpressionSyntax RefValueExpression(Roslyn.Compilers.CSharp.SyntaxToken keyword = null, Roslyn.Compilers.CSharp.ArgumentListSyntax argumentList = null)
    {
      switch (keyword.Kind)
      {
        case SyntaxKind.None:
          keyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.RefValueKeyword);
          goto case SyntaxKind.RefValueKeyword;
        case SyntaxKind.RefValueKeyword:
          if (argumentList == null)
            throw new ArgumentNullException("argumentList");
          else
            return (Roslyn.Compilers.CSharp.RefValueExpressionSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.RefValueExpression(keyword.Node, argumentList == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ArgumentListSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ArgumentListSyntax) argumentList.Green));
        default:
          throw new ArgumentException("keyword");
      }
    }

    public static Roslyn.Compilers.CSharp.CheckedExpressionSyntax CheckedExpression(SyntaxKind kind, Roslyn.Compilers.CSharp.SyntaxToken keyword = null, Roslyn.Compilers.CSharp.ArgumentListSyntax argumentList = null)
    {
      switch (kind)
      {
        case SyntaxKind.CheckedExpression:
        case SyntaxKind.UncheckedExpression:
          switch (keyword.Kind)
          {
            case SyntaxKind.None:
              switch (kind)
              {
                case SyntaxKind.CheckedExpression:
                  keyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.CheckedKeyword);
                  goto label_7;
                case SyntaxKind.UncheckedExpression:
                  keyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.UncheckedKeyword);
                  goto label_7;
                default:
                  goto label_7;
              }
            case SyntaxKind.CheckedKeyword:
            case SyntaxKind.UncheckedKeyword:
label_7:
              if (argumentList == null)
                throw new ArgumentNullException("argumentList");
              else
                return (Roslyn.Compilers.CSharp.CheckedExpressionSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.CheckedExpression(kind, keyword.Node, argumentList == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ArgumentListSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ArgumentListSyntax) argumentList.Green));
            default:
              throw new ArgumentException("keyword");
          }
        default:
          throw new ArgumentException("kind");
      }
    }

    public static Roslyn.Compilers.CSharp.DefaultExpressionSyntax DefaultExpression(Roslyn.Compilers.CSharp.SyntaxToken keyword = null, Roslyn.Compilers.CSharp.ArgumentListSyntax argumentList = null)
    {
      switch (keyword.Kind)
      {
        case SyntaxKind.None:
          keyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.DefaultKeyword);
          goto case SyntaxKind.DefaultKeyword;
        case SyntaxKind.DefaultKeyword:
          if (argumentList == null)
            throw new ArgumentNullException("argumentList");
          else
            return (Roslyn.Compilers.CSharp.DefaultExpressionSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.DefaultExpression(keyword.Node, argumentList == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ArgumentListSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ArgumentListSyntax) argumentList.Green));
        default:
          throw new ArgumentException("keyword");
      }
    }

    public static Roslyn.Compilers.CSharp.TypeOfExpressionSyntax TypeOfExpression(Roslyn.Compilers.CSharp.SyntaxToken keyword = null, Roslyn.Compilers.CSharp.ArgumentListSyntax argumentList = null)
    {
      switch (keyword.Kind)
      {
        case SyntaxKind.None:
          keyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.TypeOfKeyword);
          goto case SyntaxKind.TypeOfKeyword;
        case SyntaxKind.TypeOfKeyword:
          if (argumentList == null)
            throw new ArgumentNullException("argumentList");
          else
            return (Roslyn.Compilers.CSharp.TypeOfExpressionSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.TypeOfExpression(keyword.Node, argumentList == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ArgumentListSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ArgumentListSyntax) argumentList.Green));
        default:
          throw new ArgumentException("keyword");
      }
    }

    public static Roslyn.Compilers.CSharp.SizeOfExpressionSyntax SizeOfExpression(Roslyn.Compilers.CSharp.SyntaxToken keyword = null, Roslyn.Compilers.CSharp.ArgumentListSyntax argumentList = null)
    {
      switch (keyword.Kind)
      {
        case SyntaxKind.None:
          keyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.SizeOfKeyword);
          goto case SyntaxKind.SizeOfKeyword;
        case SyntaxKind.SizeOfKeyword:
          if (argumentList == null)
            throw new ArgumentNullException("argumentList");
          else
            return (Roslyn.Compilers.CSharp.SizeOfExpressionSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.SizeOfExpression(keyword.Node, argumentList == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ArgumentListSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ArgumentListSyntax) argumentList.Green));
        default:
          throw new ArgumentException("keyword");
      }
    }

    public static Roslyn.Compilers.CSharp.InvocationExpressionSyntax InvocationExpression(Roslyn.Compilers.CSharp.ExpressionSyntax expression, Roslyn.Compilers.CSharp.ArgumentListSyntax argumentList)
    {
      if (expression == null)
        throw new ArgumentNullException("expression");
      if (argumentList == null)
        throw new ArgumentNullException("argumentList");
      else
        return (Roslyn.Compilers.CSharp.InvocationExpressionSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.InvocationExpression(expression == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) expression.Green, argumentList == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ArgumentListSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ArgumentListSyntax) argumentList.Green));
    }

    public static Roslyn.Compilers.CSharp.ElementAccessExpressionSyntax ElementAccessExpression(Roslyn.Compilers.CSharp.ExpressionSyntax expression, Roslyn.Compilers.CSharp.BracketedArgumentListSyntax argumentList)
    {
      if (expression == null)
        throw new ArgumentNullException("expression");
      if (argumentList == null)
        throw new ArgumentNullException("argumentList");
      else
        return (Roslyn.Compilers.CSharp.ElementAccessExpressionSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.ElementAccessExpression(expression == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) expression.Green, argumentList == null ? (Roslyn.Compilers.CSharp.InternalSyntax.BracketedArgumentListSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.BracketedArgumentListSyntax) argumentList.Green));
    }

    public static Roslyn.Compilers.CSharp.ArgumentListSyntax ArgumentList(Roslyn.Compilers.CSharp.SyntaxToken openParenToken = null, SeparatedSyntaxList<Roslyn.Compilers.CSharp.ArgumentSyntax> arguments = null, Roslyn.Compilers.CSharp.SyntaxToken closeParenToken = null)
    {
      switch (openParenToken.Kind)
      {
        case SyntaxKind.None:
          openParenToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.OpenParenToken);
          goto case SyntaxKind.OpenParenToken;
        case SyntaxKind.OpenParenToken:
          switch (closeParenToken.Kind)
          {
            case SyntaxKind.None:
              closeParenToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.CloseParenToken);
              goto case SyntaxKind.CloseParenToken;
            case SyntaxKind.CloseParenToken:
              return (Roslyn.Compilers.CSharp.ArgumentListSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.ArgumentList(openParenToken.Node, BaseSyntaxNodeExtensions.ToGreenSeparatedList<Roslyn.Compilers.CSharp.InternalSyntax.ArgumentSyntax>(arguments.Node), closeParenToken.Node));
            default:
              throw new ArgumentException("closeParenToken");
          }
        default:
          throw new ArgumentException("openParenToken");
      }
    }

    public static Roslyn.Compilers.CSharp.BracketedArgumentListSyntax BracketedArgumentList(Roslyn.Compilers.CSharp.SyntaxToken openBracketToken = null, SeparatedSyntaxList<Roslyn.Compilers.CSharp.ArgumentSyntax> arguments = null, Roslyn.Compilers.CSharp.SyntaxToken closeBracketToken = null)
    {
      switch (openBracketToken.Kind)
      {
        case SyntaxKind.None:
          openBracketToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.OpenBracketToken);
          goto case SyntaxKind.OpenBracketToken;
        case SyntaxKind.OpenBracketToken:
          switch (closeBracketToken.Kind)
          {
            case SyntaxKind.None:
              closeBracketToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.CloseBracketToken);
              goto case SyntaxKind.CloseBracketToken;
            case SyntaxKind.CloseBracketToken:
              return (Roslyn.Compilers.CSharp.BracketedArgumentListSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.BracketedArgumentList(openBracketToken.Node, BaseSyntaxNodeExtensions.ToGreenSeparatedList<Roslyn.Compilers.CSharp.InternalSyntax.ArgumentSyntax>(arguments.Node), closeBracketToken.Node));
            default:
              throw new ArgumentException("closeBracketToken");
          }
        default:
          throw new ArgumentException("openBracketToken");
      }
    }

    public static Roslyn.Compilers.CSharp.ArgumentSyntax Argument(Roslyn.Compilers.CSharp.NameColonSyntax nameColonOpt = null, Roslyn.Compilers.CSharp.SyntaxToken refOrOutKeywordOpt = null, Roslyn.Compilers.CSharp.ExpressionSyntax expression = null)
    {
      switch (refOrOutKeywordOpt.Kind)
      {
        case SyntaxKind.None:
        case SyntaxKind.RefKeyword:
        case SyntaxKind.OutKeyword:
          if (expression == null)
            throw new ArgumentNullException("expression");
          else
            return (Roslyn.Compilers.CSharp.ArgumentSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.Argument(nameColonOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.NameColonSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.NameColonSyntax) nameColonOpt.Green, refOrOutKeywordOpt.Node, expression == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) expression.Green));
        default:
          throw new ArgumentException("refOrOutKeywordOpt");
      }
    }

    public static Roslyn.Compilers.CSharp.NameColonSyntax NameColon(Roslyn.Compilers.CSharp.SyntaxToken identifier, Roslyn.Compilers.CSharp.SyntaxToken colonToken = null)
    {
      if (identifier.Kind != SyntaxKind.IdentifierToken)
        throw new ArgumentException("identifier");
      switch (colonToken.Kind)
      {
        case SyntaxKind.None:
          colonToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.ColonToken);
          goto case SyntaxKind.ColonToken;
        case SyntaxKind.ColonToken:
          return (Roslyn.Compilers.CSharp.NameColonSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.NameColon(identifier.Node, colonToken.Node));
        default:
          throw new ArgumentException("colonToken");
      }
    }

    public static Roslyn.Compilers.CSharp.CastExpressionSyntax CastExpression(Roslyn.Compilers.CSharp.SyntaxToken openParenToken = null, Roslyn.Compilers.CSharp.TypeSyntax type = null, Roslyn.Compilers.CSharp.SyntaxToken closeParenToken = null, Roslyn.Compilers.CSharp.ExpressionSyntax expression = null)
    {
      switch (openParenToken.Kind)
      {
        case SyntaxKind.None:
          openParenToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.OpenParenToken);
          goto case SyntaxKind.OpenParenToken;
        case SyntaxKind.OpenParenToken:
          if (type == null)
            throw new ArgumentNullException("type");
          switch (closeParenToken.Kind)
          {
            case SyntaxKind.None:
              closeParenToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.CloseParenToken);
              goto case SyntaxKind.CloseParenToken;
            case SyntaxKind.CloseParenToken:
              if (expression == null)
                throw new ArgumentNullException("expression");
              else
                return (Roslyn.Compilers.CSharp.CastExpressionSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.CastExpression(openParenToken.Node, type == null ? (Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax) type.Green, closeParenToken.Node, expression == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) expression.Green));
            default:
              throw new ArgumentException("closeParenToken");
          }
        default:
          throw new ArgumentException("openParenToken");
      }
    }

    public static Roslyn.Compilers.CSharp.AnonymousMethodExpressionSyntax AnonymousMethodExpression(Roslyn.Compilers.CSharp.SyntaxToken delegateKeyword = null, Roslyn.Compilers.CSharp.ParameterListSyntax parameterListOpt = null, Roslyn.Compilers.CSharp.BlockSyntax block = null)
    {
      switch (delegateKeyword.Kind)
      {
        case SyntaxKind.None:
          delegateKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.DelegateKeyword);
          goto case SyntaxKind.DelegateKeyword;
        case SyntaxKind.DelegateKeyword:
          if (block == null)
            throw new ArgumentNullException("block");
          else
            return (Roslyn.Compilers.CSharp.AnonymousMethodExpressionSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.AnonymousMethodExpression(delegateKeyword.Node, parameterListOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ParameterListSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ParameterListSyntax) parameterListOpt.Green, block == null ? (Roslyn.Compilers.CSharp.InternalSyntax.BlockSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.BlockSyntax) block.Green));
        default:
          throw new ArgumentException("delegateKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.SimpleLambdaExpressionSyntax SimpleLambdaExpression(Roslyn.Compilers.CSharp.ParameterSyntax parameter, Roslyn.Compilers.CSharp.SyntaxToken arrowToken = null, Roslyn.Compilers.CSharp.SyntaxNode body = null)
    {
      if (parameter == null)
        throw new ArgumentNullException("parameter");
      switch (arrowToken.Kind)
      {
        case SyntaxKind.None:
          arrowToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.EqualsGreaterThanToken);
          goto case SyntaxKind.EqualsGreaterThanToken;
        case SyntaxKind.EqualsGreaterThanToken:
          if (body == null)
            throw new ArgumentNullException("body");
          else
            return (Roslyn.Compilers.CSharp.SimpleLambdaExpressionSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.SimpleLambdaExpression(parameter == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ParameterSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ParameterSyntax) parameter.Green, arrowToken.Node, body == null ? (Roslyn.Compilers.CSharp.InternalSyntax.SyntaxNode) null : body.Green));
        default:
          throw new ArgumentException("arrowToken");
      }
    }

    public static Roslyn.Compilers.CSharp.ParenthesizedLambdaExpressionSyntax ParenthesizedLambdaExpression(Roslyn.Compilers.CSharp.ParameterListSyntax parameterList, Roslyn.Compilers.CSharp.SyntaxToken arrowToken = null, Roslyn.Compilers.CSharp.SyntaxNode body = null)
    {
      if (parameterList == null)
        throw new ArgumentNullException("parameterList");
      switch (arrowToken.Kind)
      {
        case SyntaxKind.None:
          arrowToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.EqualsGreaterThanToken);
          goto case SyntaxKind.EqualsGreaterThanToken;
        case SyntaxKind.EqualsGreaterThanToken:
          if (body == null)
            throw new ArgumentNullException("body");
          else
            return (Roslyn.Compilers.CSharp.ParenthesizedLambdaExpressionSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.ParenthesizedLambdaExpression(parameterList == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ParameterListSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ParameterListSyntax) parameterList.Green, arrowToken.Node, body == null ? (Roslyn.Compilers.CSharp.InternalSyntax.SyntaxNode) null : body.Green));
        default:
          throw new ArgumentException("arrowToken");
      }
    }

    public static Roslyn.Compilers.CSharp.InitializerExpressionSyntax InitializerExpression(Roslyn.Compilers.CSharp.SyntaxToken openBraceToken = null, SeparatedSyntaxList<Roslyn.Compilers.CSharp.ExpressionSyntax> expressions = null, Roslyn.Compilers.CSharp.SyntaxToken closeBraceToken = null)
    {
      switch (openBraceToken.Kind)
      {
        case SyntaxKind.None:
          openBraceToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.OpenBraceToken);
          goto case SyntaxKind.OpenBraceToken;
        case SyntaxKind.OpenBraceToken:
          switch (closeBraceToken.Kind)
          {
            case SyntaxKind.None:
              closeBraceToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.CloseBraceToken);
              goto case SyntaxKind.CloseBraceToken;
            case SyntaxKind.CloseBraceToken:
              return (Roslyn.Compilers.CSharp.InitializerExpressionSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.InitializerExpression(openBraceToken.Node, BaseSyntaxNodeExtensions.ToGreenSeparatedList<Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax>(expressions.Node), closeBraceToken.Node));
            default:
              throw new ArgumentException("closeBraceToken");
          }
        default:
          throw new ArgumentException("openBraceToken");
      }
    }

    public static Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax ObjectCreationExpression(Roslyn.Compilers.CSharp.SyntaxToken newKeyword = null, Roslyn.Compilers.CSharp.TypeSyntax type = null, Roslyn.Compilers.CSharp.ArgumentListSyntax argumentListOpt = null, Roslyn.Compilers.CSharp.InitializerExpressionSyntax initializerOpt = null)
    {
      switch (newKeyword.Kind)
      {
        case SyntaxKind.None:
          newKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.NewKeyword);
          goto case SyntaxKind.NewKeyword;
        case SyntaxKind.NewKeyword:
          if (type == null)
            throw new ArgumentNullException("type");
          else
            return (Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.ObjectCreationExpression(newKeyword.Node, type == null ? (Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax) type.Green, argumentListOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ArgumentListSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ArgumentListSyntax) argumentListOpt.Green, initializerOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.InitializerExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.InitializerExpressionSyntax) initializerOpt.Green));
        default:
          throw new ArgumentException("newKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.AnonymousObjectCreationExpressionSyntax AnonymousObjectCreationExpression(Roslyn.Compilers.CSharp.SyntaxToken newKeyword = null, Roslyn.Compilers.CSharp.InitializerExpressionSyntax initializer = null)
    {
      switch (newKeyword.Kind)
      {
        case SyntaxKind.None:
          newKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.NewKeyword);
          goto case SyntaxKind.NewKeyword;
        case SyntaxKind.NewKeyword:
          if (initializer == null)
            throw new ArgumentNullException("initializer");
          else
            return (Roslyn.Compilers.CSharp.AnonymousObjectCreationExpressionSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.AnonymousObjectCreationExpression(newKeyword.Node, initializer == null ? (Roslyn.Compilers.CSharp.InternalSyntax.InitializerExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.InitializerExpressionSyntax) initializer.Green));
        default:
          throw new ArgumentException("newKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.ArrayCreationExpressionSyntax ArrayCreationExpression(Roslyn.Compilers.CSharp.SyntaxToken newKeyword = null, Roslyn.Compilers.CSharp.ArrayTypeSyntax type = null, Roslyn.Compilers.CSharp.InitializerExpressionSyntax initializerOpt = null)
    {
      switch (newKeyword.Kind)
      {
        case SyntaxKind.None:
          newKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.NewKeyword);
          goto case SyntaxKind.NewKeyword;
        case SyntaxKind.NewKeyword:
          if (type == null)
            throw new ArgumentNullException("type");
          else
            return (Roslyn.Compilers.CSharp.ArrayCreationExpressionSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.ArrayCreationExpression(newKeyword.Node, type == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ArrayTypeSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ArrayTypeSyntax) type.Green, initializerOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.InitializerExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.InitializerExpressionSyntax) initializerOpt.Green));
        default:
          throw new ArgumentException("newKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.ImplicitArrayCreationExpressionSyntax ImplicitArrayCreationExpression(Roslyn.Compilers.CSharp.SyntaxToken newKeyword = null, Roslyn.Compilers.CSharp.SyntaxToken openBracketToken = null, SyntaxTokenList commas = null, Roslyn.Compilers.CSharp.SyntaxToken closeBracketToken = null, Roslyn.Compilers.CSharp.InitializerExpressionSyntax initializer = null)
    {
      switch (newKeyword.Kind)
      {
        case SyntaxKind.None:
          newKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.NewKeyword);
          goto case SyntaxKind.NewKeyword;
        case SyntaxKind.NewKeyword:
          switch (openBracketToken.Kind)
          {
            case SyntaxKind.None:
              openBracketToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.OpenBracketToken);
              goto case SyntaxKind.OpenBracketToken;
            case SyntaxKind.OpenBracketToken:
              switch (closeBracketToken.Kind)
              {
                case SyntaxKind.None:
                  closeBracketToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.CloseBracketToken);
                  goto case SyntaxKind.CloseBracketToken;
                case SyntaxKind.CloseBracketToken:
                  if (initializer == null)
                    throw new ArgumentNullException("initializer");
                  else
                    return (Roslyn.Compilers.CSharp.ImplicitArrayCreationExpressionSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.ImplicitArrayCreationExpression(newKeyword.Node, openBracketToken.Node, (Roslyn.Compilers.CSharp.InternalSyntax.SyntaxList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxToken>) BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxNode>((IBaseSyntaxNodeExt) commas.Node), closeBracketToken.Node, initializer == null ? (Roslyn.Compilers.CSharp.InternalSyntax.InitializerExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.InitializerExpressionSyntax) initializer.Green));
                default:
                  throw new ArgumentException("closeBracketToken");
              }
            default:
              throw new ArgumentException("openBracketToken");
          }
        default:
          throw new ArgumentException("newKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.StackAllocArrayCreationExpressionSyntax StackAllocArrayCreationExpression(Roslyn.Compilers.CSharp.SyntaxToken stackAllocKeyword = null, Roslyn.Compilers.CSharp.TypeSyntax type = null)
    {
      switch (stackAllocKeyword.Kind)
      {
        case SyntaxKind.None:
          stackAllocKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.StackAllocKeyword);
          goto case SyntaxKind.StackAllocKeyword;
        case SyntaxKind.StackAllocKeyword:
          if (type == null)
            throw new ArgumentNullException("type");
          else
            return (Roslyn.Compilers.CSharp.StackAllocArrayCreationExpressionSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.StackAllocArrayCreationExpression(stackAllocKeyword.Node, type == null ? (Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax) type.Green));
        default:
          throw new ArgumentException("stackAllocKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.QueryExpressionSyntax QueryExpression(Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.QueryClauseSyntax> clauses = null, Roslyn.Compilers.CSharp.SelectOrGroupClauseSyntax selectOrGroup = null, Roslyn.Compilers.CSharp.QueryContinuationSyntax continuationOpt = null)
    {
      if (selectOrGroup == null)
        throw new ArgumentNullException("selectOrGroup");
      else
        return (Roslyn.Compilers.CSharp.QueryExpressionSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.QueryExpression(BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.QueryClauseSyntax>((IBaseSyntaxNodeExt) clauses.Node), selectOrGroup == null ? (Roslyn.Compilers.CSharp.InternalSyntax.SelectOrGroupClauseSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.SelectOrGroupClauseSyntax) selectOrGroup.Green, continuationOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.QueryContinuationSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.QueryContinuationSyntax) continuationOpt.Green));
    }

    public static Roslyn.Compilers.CSharp.FromClauseSyntax FromClause(Roslyn.Compilers.CSharp.SyntaxToken fromKeyword = null, Roslyn.Compilers.CSharp.TypeSyntax typeOpt = null, Roslyn.Compilers.CSharp.SyntaxToken identifier = null, Roslyn.Compilers.CSharp.SyntaxToken inKeyword = null, Roslyn.Compilers.CSharp.ExpressionSyntax expression = null)
    {
      switch (fromKeyword.Kind)
      {
        case SyntaxKind.None:
          fromKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.FromKeyword);
          goto case SyntaxKind.FromKeyword;
        case SyntaxKind.FromKeyword:
          if (identifier.Kind != SyntaxKind.IdentifierToken)
            throw new ArgumentException("identifier");
          switch (inKeyword.Kind)
          {
            case SyntaxKind.None:
              inKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.InKeyword);
              goto case SyntaxKind.InKeyword;
            case SyntaxKind.InKeyword:
              if (expression == null)
                throw new ArgumentNullException("expression");
              else
                return (Roslyn.Compilers.CSharp.FromClauseSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.FromClause(fromKeyword.Node, typeOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax) typeOpt.Green, identifier.Node, inKeyword.Node, expression == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) expression.Green));
            default:
              throw new ArgumentException("inKeyword");
          }
        default:
          throw new ArgumentException("fromKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.LetClauseSyntax LetClause(Roslyn.Compilers.CSharp.SyntaxToken letKeyword = null, Roslyn.Compilers.CSharp.SyntaxToken identifier = null, Roslyn.Compilers.CSharp.SyntaxToken equalsToken = null, Roslyn.Compilers.CSharp.ExpressionSyntax expression = null)
    {
      switch (letKeyword.Kind)
      {
        case SyntaxKind.None:
          letKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.LetKeyword);
          goto case SyntaxKind.LetKeyword;
        case SyntaxKind.LetKeyword:
          if (identifier.Kind != SyntaxKind.IdentifierToken)
            throw new ArgumentException("identifier");
          switch (equalsToken.Kind)
          {
            case SyntaxKind.None:
              equalsToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.EqualsToken);
              goto case SyntaxKind.EqualsToken;
            case SyntaxKind.EqualsToken:
              if (expression == null)
                throw new ArgumentNullException("expression");
              else
                return (Roslyn.Compilers.CSharp.LetClauseSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.LetClause(letKeyword.Node, identifier.Node, equalsToken.Node, expression == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) expression.Green));
            default:
              throw new ArgumentException("equalsToken");
          }
        default:
          throw new ArgumentException("letKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.JoinClauseSyntax JoinClause(Roslyn.Compilers.CSharp.SyntaxToken joinKeyword = null, Roslyn.Compilers.CSharp.TypeSyntax typeOpt = null, Roslyn.Compilers.CSharp.SyntaxToken identifier = null, Roslyn.Compilers.CSharp.SyntaxToken inKeyword = null, Roslyn.Compilers.CSharp.ExpressionSyntax inExpression = null, Roslyn.Compilers.CSharp.SyntaxToken onKeyword = null, Roslyn.Compilers.CSharp.ExpressionSyntax leftExpression = null, Roslyn.Compilers.CSharp.SyntaxToken equalsKeyword = null, Roslyn.Compilers.CSharp.ExpressionSyntax rightExpression = null, Roslyn.Compilers.CSharp.JoinIntoClauseSyntax intoOpt = null)
    {
      switch (joinKeyword.Kind)
      {
        case SyntaxKind.None:
          joinKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.JoinKeyword);
          goto case SyntaxKind.JoinKeyword;
        case SyntaxKind.JoinKeyword:
          if (identifier.Kind != SyntaxKind.IdentifierToken)
            throw new ArgumentException("identifier");
          switch (inKeyword.Kind)
          {
            case SyntaxKind.None:
              inKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.InKeyword);
              goto case SyntaxKind.InKeyword;
            case SyntaxKind.InKeyword:
              if (inExpression == null)
                throw new ArgumentNullException("inExpression");
              switch (onKeyword.Kind)
              {
                case SyntaxKind.None:
                  onKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.OnKeyword);
                  goto case SyntaxKind.OnKeyword;
                case SyntaxKind.OnKeyword:
                  if (leftExpression == null)
                    throw new ArgumentNullException("leftExpression");
                  switch (equalsKeyword.Kind)
                  {
                    case SyntaxKind.None:
                      equalsKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.EqualsKeyword);
                      goto case SyntaxKind.EqualsKeyword;
                    case SyntaxKind.EqualsKeyword:
                      if (rightExpression == null)
                        throw new ArgumentNullException("rightExpression");
                      else
                        return (Roslyn.Compilers.CSharp.JoinClauseSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.JoinClause(joinKeyword.Node, typeOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax) typeOpt.Green, identifier.Node, inKeyword.Node, inExpression == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) inExpression.Green, onKeyword.Node, leftExpression == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) leftExpression.Green, equalsKeyword.Node, rightExpression == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) rightExpression.Green, intoOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.JoinIntoClauseSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.JoinIntoClauseSyntax) intoOpt.Green));
                    default:
                      throw new ArgumentException("equalsKeyword");
                  }
                default:
                  throw new ArgumentException("onKeyword");
              }
            default:
              throw new ArgumentException("inKeyword");
          }
        default:
          throw new ArgumentException("joinKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.JoinIntoClauseSyntax JoinIntoClause(Roslyn.Compilers.CSharp.SyntaxToken intoKeyword = null, Roslyn.Compilers.CSharp.SyntaxToken identifier = null)
    {
      switch (intoKeyword.Kind)
      {
        case SyntaxKind.None:
          intoKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.IntoKeyword);
          goto case SyntaxKind.IntoKeyword;
        case SyntaxKind.IntoKeyword:
          if (identifier.Kind != SyntaxKind.IdentifierToken)
            throw new ArgumentException("identifier");
          else
            return (Roslyn.Compilers.CSharp.JoinIntoClauseSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.JoinIntoClause(intoKeyword.Node, identifier.Node));
        default:
          throw new ArgumentException("intoKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.WhereClauseSyntax WhereClause(Roslyn.Compilers.CSharp.SyntaxToken whereKeyword = null, Roslyn.Compilers.CSharp.ExpressionSyntax condition = null)
    {
      switch (whereKeyword.Kind)
      {
        case SyntaxKind.None:
          whereKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.WhereKeyword);
          goto case SyntaxKind.WhereKeyword;
        case SyntaxKind.WhereKeyword:
          if (condition == null)
            throw new ArgumentNullException("condition");
          else
            return (Roslyn.Compilers.CSharp.WhereClauseSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.WhereClause(whereKeyword.Node, condition == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) condition.Green));
        default:
          throw new ArgumentException("whereKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.OrderByClauseSyntax OrderByClause(Roslyn.Compilers.CSharp.SyntaxToken orderByKeyword = null, SeparatedSyntaxList<Roslyn.Compilers.CSharp.OrderingSyntax> orderings = null)
    {
      switch (orderByKeyword.Kind)
      {
        case SyntaxKind.None:
          orderByKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.OrderByKeyword);
          goto case SyntaxKind.OrderByKeyword;
        case SyntaxKind.OrderByKeyword:
          return (Roslyn.Compilers.CSharp.OrderByClauseSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.OrderByClause(orderByKeyword.Node, BaseSyntaxNodeExtensions.ToGreenSeparatedList<Roslyn.Compilers.CSharp.InternalSyntax.OrderingSyntax>(orderings.Node)));
        default:
          throw new ArgumentException("orderByKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.OrderingSyntax Ordering(SyntaxKind kind, Roslyn.Compilers.CSharp.ExpressionSyntax expression, Roslyn.Compilers.CSharp.SyntaxToken ascendingOrDescendingKeywordOpt = null)
    {
      switch (kind)
      {
        case SyntaxKind.AscendingOrdering:
        case SyntaxKind.DescendingOrdering:
          if (expression == null)
            throw new ArgumentNullException("expression");
          switch (ascendingOrDescendingKeywordOpt.Kind)
          {
            case SyntaxKind.None:
            case SyntaxKind.AscendingKeyword:
            case SyntaxKind.DescendingKeyword:
              return (Roslyn.Compilers.CSharp.OrderingSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.Ordering(kind, expression == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) expression.Green, ascendingOrDescendingKeywordOpt.Node));
            default:
              throw new ArgumentException("ascendingOrDescendingKeywordOpt");
          }
        default:
          throw new ArgumentException("kind");
      }
    }

    public static Roslyn.Compilers.CSharp.SelectClauseSyntax SelectClause(Roslyn.Compilers.CSharp.SyntaxToken selectKeyword = null, Roslyn.Compilers.CSharp.ExpressionSyntax expression = null)
    {
      switch (selectKeyword.Kind)
      {
        case SyntaxKind.None:
          selectKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.SelectKeyword);
          goto case SyntaxKind.SelectKeyword;
        case SyntaxKind.SelectKeyword:
          if (expression == null)
            throw new ArgumentNullException("expression");
          else
            return (Roslyn.Compilers.CSharp.SelectClauseSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.SelectClause(selectKeyword.Node, expression == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) expression.Green));
        default:
          throw new ArgumentException("selectKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.GroupClauseSyntax GroupClause(Roslyn.Compilers.CSharp.SyntaxToken groupKeyword = null, Roslyn.Compilers.CSharp.ExpressionSyntax groupExpression = null, Roslyn.Compilers.CSharp.SyntaxToken byKeyword = null, Roslyn.Compilers.CSharp.ExpressionSyntax byExpression = null)
    {
      switch (groupKeyword.Kind)
      {
        case SyntaxKind.None:
          groupKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.GroupKeyword);
          goto case SyntaxKind.GroupKeyword;
        case SyntaxKind.GroupKeyword:
          if (groupExpression == null)
            throw new ArgumentNullException("groupExpression");
          switch (byKeyword.Kind)
          {
            case SyntaxKind.None:
              byKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.ByKeyword);
              goto case SyntaxKind.ByKeyword;
            case SyntaxKind.ByKeyword:
              if (byExpression == null)
                throw new ArgumentNullException("byExpression");
              else
                return (Roslyn.Compilers.CSharp.GroupClauseSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.GroupClause(groupKeyword.Node, groupExpression == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) groupExpression.Green, byKeyword.Node, byExpression == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) byExpression.Green));
            default:
              throw new ArgumentException("byKeyword");
          }
        default:
          throw new ArgumentException("groupKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.QueryContinuationSyntax QueryContinuation(Roslyn.Compilers.CSharp.SyntaxToken intoKeyword = null, Roslyn.Compilers.CSharp.SyntaxToken identifier = null, Roslyn.Compilers.CSharp.QueryExpressionSyntax query = null)
    {
      switch (intoKeyword.Kind)
      {
        case SyntaxKind.None:
          intoKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.IntoKeyword);
          goto case SyntaxKind.IntoKeyword;
        case SyntaxKind.IntoKeyword:
          if (identifier.Kind != SyntaxKind.IdentifierToken)
            throw new ArgumentException("identifier");
          if (query == null)
            throw new ArgumentNullException("query");
          else
            return (Roslyn.Compilers.CSharp.QueryContinuationSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.QueryContinuation(intoKeyword.Node, identifier.Node, query == null ? (Roslyn.Compilers.CSharp.InternalSyntax.QueryExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.QueryExpressionSyntax) query.Green));
        default:
          throw new ArgumentException("intoKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.GlobalStatementSyntax GlobalStatement(Roslyn.Compilers.CSharp.StatementSyntax statement)
    {
      if (statement == null)
        throw new ArgumentNullException("statement");
      else
        return (Roslyn.Compilers.CSharp.GlobalStatementSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.GlobalStatement(statement == null ? (Roslyn.Compilers.CSharp.InternalSyntax.StatementSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.StatementSyntax) statement.Green));
    }

    public static Roslyn.Compilers.CSharp.BlockSyntax Block(Roslyn.Compilers.CSharp.SyntaxToken openBraceToken = null, Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.StatementSyntax> statements = null, Roslyn.Compilers.CSharp.SyntaxToken closeBraceToken = null)
    {
      switch (openBraceToken.Kind)
      {
        case SyntaxKind.None:
          openBraceToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.OpenBraceToken);
          goto case SyntaxKind.OpenBraceToken;
        case SyntaxKind.OpenBraceToken:
          switch (closeBraceToken.Kind)
          {
            case SyntaxKind.None:
              closeBraceToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.CloseBraceToken);
              goto case SyntaxKind.CloseBraceToken;
            case SyntaxKind.CloseBraceToken:
              return (Roslyn.Compilers.CSharp.BlockSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.Block(openBraceToken.Node, BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.StatementSyntax>((IBaseSyntaxNodeExt) statements.Node), closeBraceToken.Node));
            default:
              throw new ArgumentException("closeBraceToken");
          }
        default:
          throw new ArgumentException("openBraceToken");
      }
    }

    public static Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax LocalDeclarationStatement(SyntaxTokenList modifiers = null, Roslyn.Compilers.CSharp.VariableDeclarationSyntax declaration = null, Roslyn.Compilers.CSharp.SyntaxToken semicolonToken = null)
    {
      if (declaration == null)
        throw new ArgumentNullException("declaration");
      switch (semicolonToken.Kind)
      {
        case SyntaxKind.None:
          semicolonToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.SemicolonToken);
          goto case SyntaxKind.SemicolonToken;
        case SyntaxKind.SemicolonToken:
          return (Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.LocalDeclarationStatement((Roslyn.Compilers.CSharp.InternalSyntax.SyntaxList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxToken>) BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxNode>((IBaseSyntaxNodeExt) modifiers.Node), declaration == null ? (Roslyn.Compilers.CSharp.InternalSyntax.VariableDeclarationSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.VariableDeclarationSyntax) declaration.Green, semicolonToken.Node));
        default:
          throw new ArgumentException("semicolonToken");
      }
    }

    public static Roslyn.Compilers.CSharp.VariableDeclarationSyntax VariableDeclaration(Roslyn.Compilers.CSharp.TypeSyntax type, SeparatedSyntaxList<Roslyn.Compilers.CSharp.VariableDeclaratorSyntax> variables = null)
    {
      if (type == null)
        throw new ArgumentNullException("type");
      else
        return (Roslyn.Compilers.CSharp.VariableDeclarationSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.VariableDeclaration(type == null ? (Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax) type.Green, BaseSyntaxNodeExtensions.ToGreenSeparatedList<Roslyn.Compilers.CSharp.InternalSyntax.VariableDeclaratorSyntax>(variables.Node)));
    }

    public static Roslyn.Compilers.CSharp.VariableDeclaratorSyntax VariableDeclarator(Roslyn.Compilers.CSharp.SyntaxToken identifier, Roslyn.Compilers.CSharp.BracketedArgumentListSyntax argumentListOpt = null, Roslyn.Compilers.CSharp.EqualsValueClauseSyntax initializerOpt = null)
    {
      if (identifier.Kind != SyntaxKind.IdentifierToken)
        throw new ArgumentException("identifier");
      else
        return (Roslyn.Compilers.CSharp.VariableDeclaratorSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.VariableDeclarator(identifier.Node, argumentListOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.BracketedArgumentListSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.BracketedArgumentListSyntax) argumentListOpt.Green, initializerOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.EqualsValueClauseSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.EqualsValueClauseSyntax) initializerOpt.Green));
    }

    public static Roslyn.Compilers.CSharp.EqualsValueClauseSyntax EqualsValueClause(Roslyn.Compilers.CSharp.SyntaxToken equalsToken = null, Roslyn.Compilers.CSharp.ExpressionSyntax value = null)
    {
      switch (equalsToken.Kind)
      {
        case SyntaxKind.None:
          equalsToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.EqualsToken);
          goto case SyntaxKind.EqualsToken;
        case SyntaxKind.EqualsToken:
          if (value == null)
            throw new ArgumentNullException("value");
          else
            return (Roslyn.Compilers.CSharp.EqualsValueClauseSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.EqualsValueClause(equalsToken.Node, value == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) value.Green));
        default:
          throw new ArgumentException("equalsToken");
      }
    }

    public static Roslyn.Compilers.CSharp.ExpressionStatementSyntax ExpressionStatement(Roslyn.Compilers.CSharp.ExpressionSyntax expression, Roslyn.Compilers.CSharp.SyntaxToken semicolonToken = null)
    {
      if (expression == null)
        throw new ArgumentNullException("expression");
      switch (semicolonToken.Kind)
      {
        case SyntaxKind.None:
          semicolonToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.SemicolonToken);
          goto case SyntaxKind.SemicolonToken;
        case SyntaxKind.SemicolonToken:
          return (Roslyn.Compilers.CSharp.ExpressionStatementSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.ExpressionStatement(expression == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) expression.Green, semicolonToken.Node));
        default:
          throw new ArgumentException("semicolonToken");
      }
    }

    public static Roslyn.Compilers.CSharp.EmptyStatementSyntax EmptyStatement(Roslyn.Compilers.CSharp.SyntaxToken semicolonToken = null)
    {
      switch (semicolonToken.Kind)
      {
        case SyntaxKind.None:
          semicolonToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.SemicolonToken);
          goto case SyntaxKind.SemicolonToken;
        case SyntaxKind.SemicolonToken:
          return (Roslyn.Compilers.CSharp.EmptyStatementSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.EmptyStatement(semicolonToken.Node));
        default:
          throw new ArgumentException("semicolonToken");
      }
    }

    public static Roslyn.Compilers.CSharp.LabeledStatementSyntax LabeledStatement(Roslyn.Compilers.CSharp.SyntaxToken identifier, Roslyn.Compilers.CSharp.SyntaxToken colonToken = null, Roslyn.Compilers.CSharp.StatementSyntax statement = null)
    {
      if (identifier.Kind != SyntaxKind.IdentifierToken)
        throw new ArgumentException("identifier");
      switch (colonToken.Kind)
      {
        case SyntaxKind.None:
          colonToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.ColonToken);
          goto case SyntaxKind.ColonToken;
        case SyntaxKind.ColonToken:
          if (statement == null)
            throw new ArgumentNullException("statement");
          else
            return (Roslyn.Compilers.CSharp.LabeledStatementSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.LabeledStatement(identifier.Node, colonToken.Node, statement == null ? (Roslyn.Compilers.CSharp.InternalSyntax.StatementSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.StatementSyntax) statement.Green));
        default:
          throw new ArgumentException("colonToken");
      }
    }

    public static Roslyn.Compilers.CSharp.GotoStatementSyntax GotoStatement(SyntaxKind kind, Roslyn.Compilers.CSharp.SyntaxToken gotoKeyword = null, Roslyn.Compilers.CSharp.SyntaxToken caseOrDefaultKeywordOpt = null, Roslyn.Compilers.CSharp.ExpressionSyntax expressionOpt = null, Roslyn.Compilers.CSharp.SyntaxToken semicolonToken = null)
    {
      switch (kind)
      {
        case SyntaxKind.GotoStatement:
        case SyntaxKind.GotoCaseStatement:
        case SyntaxKind.GotoDefaultStatement:
          switch (gotoKeyword.Kind)
          {
            case SyntaxKind.None:
              gotoKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.GotoKeyword);
              goto case SyntaxKind.GotoKeyword;
            case SyntaxKind.GotoKeyword:
              switch (caseOrDefaultKeywordOpt.Kind)
              {
                case SyntaxKind.None:
                case SyntaxKind.CaseKeyword:
                case SyntaxKind.DefaultKeyword:
                  switch (semicolonToken.Kind)
                  {
                    case SyntaxKind.None:
                      semicolonToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.SemicolonToken);
                      goto case SyntaxKind.SemicolonToken;
                    case SyntaxKind.SemicolonToken:
                      return (Roslyn.Compilers.CSharp.GotoStatementSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.GotoStatement(kind, gotoKeyword.Node, caseOrDefaultKeywordOpt.Node, expressionOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) expressionOpt.Green, semicolonToken.Node));
                    default:
                      throw new ArgumentException("semicolonToken");
                  }
                default:
                  throw new ArgumentException("caseOrDefaultKeywordOpt");
              }
            default:
              throw new ArgumentException("gotoKeyword");
          }
        default:
          throw new ArgumentException("kind");
      }
    }

    public static Roslyn.Compilers.CSharp.BreakStatementSyntax BreakStatement(Roslyn.Compilers.CSharp.SyntaxToken breakKeyword = null, Roslyn.Compilers.CSharp.SyntaxToken semicolonToken = null)
    {
      switch (breakKeyword.Kind)
      {
        case SyntaxKind.None:
          breakKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.BreakKeyword);
          goto case SyntaxKind.BreakKeyword;
        case SyntaxKind.BreakKeyword:
          switch (semicolonToken.Kind)
          {
            case SyntaxKind.None:
              semicolonToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.SemicolonToken);
              goto case SyntaxKind.SemicolonToken;
            case SyntaxKind.SemicolonToken:
              return (Roslyn.Compilers.CSharp.BreakStatementSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.BreakStatement(breakKeyword.Node, semicolonToken.Node));
            default:
              throw new ArgumentException("semicolonToken");
          }
        default:
          throw new ArgumentException("breakKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.ContinueStatementSyntax ContinueStatement(Roslyn.Compilers.CSharp.SyntaxToken continueKeyword = null, Roslyn.Compilers.CSharp.SyntaxToken semicolonToken = null)
    {
      switch (continueKeyword.Kind)
      {
        case SyntaxKind.None:
          continueKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.ContinueKeyword);
          goto case SyntaxKind.ContinueKeyword;
        case SyntaxKind.ContinueKeyword:
          switch (semicolonToken.Kind)
          {
            case SyntaxKind.None:
              semicolonToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.SemicolonToken);
              goto case SyntaxKind.SemicolonToken;
            case SyntaxKind.SemicolonToken:
              return (Roslyn.Compilers.CSharp.ContinueStatementSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.ContinueStatement(continueKeyword.Node, semicolonToken.Node));
            default:
              throw new ArgumentException("semicolonToken");
          }
        default:
          throw new ArgumentException("continueKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.ReturnStatementSyntax ReturnStatement(Roslyn.Compilers.CSharp.SyntaxToken returnKeyword = null, Roslyn.Compilers.CSharp.ExpressionSyntax expressionOpt = null, Roslyn.Compilers.CSharp.SyntaxToken semicolonToken = null)
    {
      switch (returnKeyword.Kind)
      {
        case SyntaxKind.None:
          returnKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.ReturnKeyword);
          goto case SyntaxKind.ReturnKeyword;
        case SyntaxKind.ReturnKeyword:
          switch (semicolonToken.Kind)
          {
            case SyntaxKind.None:
              semicolonToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.SemicolonToken);
              goto case SyntaxKind.SemicolonToken;
            case SyntaxKind.SemicolonToken:
              return (Roslyn.Compilers.CSharp.ReturnStatementSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.ReturnStatement(returnKeyword.Node, expressionOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) expressionOpt.Green, semicolonToken.Node));
            default:
              throw new ArgumentException("semicolonToken");
          }
        default:
          throw new ArgumentException("returnKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.ThrowStatementSyntax ThrowStatement(Roslyn.Compilers.CSharp.SyntaxToken throwKeyword = null, Roslyn.Compilers.CSharp.ExpressionSyntax expressionOpt = null, Roslyn.Compilers.CSharp.SyntaxToken semicolonToken = null)
    {
      switch (throwKeyword.Kind)
      {
        case SyntaxKind.None:
          throwKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.ThrowKeyword);
          goto case SyntaxKind.ThrowKeyword;
        case SyntaxKind.ThrowKeyword:
          switch (semicolonToken.Kind)
          {
            case SyntaxKind.None:
              semicolonToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.SemicolonToken);
              goto case SyntaxKind.SemicolonToken;
            case SyntaxKind.SemicolonToken:
              return (Roslyn.Compilers.CSharp.ThrowStatementSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.ThrowStatement(throwKeyword.Node, expressionOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) expressionOpt.Green, semicolonToken.Node));
            default:
              throw new ArgumentException("semicolonToken");
          }
        default:
          throw new ArgumentException("throwKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.YieldStatementSyntax YieldStatement(SyntaxKind kind, Roslyn.Compilers.CSharp.SyntaxToken yieldKeyword = null, Roslyn.Compilers.CSharp.SyntaxToken returnOrBreakKeyword = null, Roslyn.Compilers.CSharp.ExpressionSyntax expressionOpt = null, Roslyn.Compilers.CSharp.SyntaxToken semicolonToken = null)
    {
      switch (kind)
      {
        case SyntaxKind.YieldReturnStatement:
        case SyntaxKind.YieldBreakStatement:
          switch (yieldKeyword.Kind)
          {
            case SyntaxKind.None:
              yieldKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.YieldKeyword);
              goto case SyntaxKind.YieldKeyword;
            case SyntaxKind.YieldKeyword:
              switch (returnOrBreakKeyword.Kind)
              {
                case SyntaxKind.None:
                  switch (kind)
                  {
                    case SyntaxKind.YieldReturnStatement:
                      returnOrBreakKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.ReturnKeyword);
                      goto label_10;
                    case SyntaxKind.YieldBreakStatement:
                      returnOrBreakKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.BreakKeyword);
                      goto label_10;
                    default:
                      goto label_10;
                  }
                case SyntaxKind.BreakKeyword:
                case SyntaxKind.ReturnKeyword:
label_10:
                  switch (semicolonToken.Kind)
                  {
                    case SyntaxKind.None:
                      semicolonToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.SemicolonToken);
                      goto case SyntaxKind.SemicolonToken;
                    case SyntaxKind.SemicolonToken:
                      return (Roslyn.Compilers.CSharp.YieldStatementSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.YieldStatement(kind, yieldKeyword.Node, returnOrBreakKeyword.Node, expressionOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) expressionOpt.Green, semicolonToken.Node));
                    default:
                      throw new ArgumentException("semicolonToken");
                  }
                default:
                  throw new ArgumentException("returnOrBreakKeyword");
              }
            default:
              throw new ArgumentException("yieldKeyword");
          }
        default:
          throw new ArgumentException("kind");
      }
    }

    public static Roslyn.Compilers.CSharp.WhileStatementSyntax WhileStatement(Roslyn.Compilers.CSharp.SyntaxToken whileKeyword = null, Roslyn.Compilers.CSharp.SyntaxToken openParenToken = null, Roslyn.Compilers.CSharp.ExpressionSyntax condition = null, Roslyn.Compilers.CSharp.SyntaxToken closeParenToken = null, Roslyn.Compilers.CSharp.StatementSyntax statement = null)
    {
      switch (whileKeyword.Kind)
      {
        case SyntaxKind.None:
          whileKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.WhileKeyword);
          goto case SyntaxKind.WhileKeyword;
        case SyntaxKind.WhileKeyword:
          switch (openParenToken.Kind)
          {
            case SyntaxKind.None:
              openParenToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.OpenParenToken);
              goto case SyntaxKind.OpenParenToken;
            case SyntaxKind.OpenParenToken:
              if (condition == null)
                throw new ArgumentNullException("condition");
              switch (closeParenToken.Kind)
              {
                case SyntaxKind.None:
                  closeParenToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.CloseParenToken);
                  goto case SyntaxKind.CloseParenToken;
                case SyntaxKind.CloseParenToken:
                  if (statement == null)
                    throw new ArgumentNullException("statement");
                  else
                    return (Roslyn.Compilers.CSharp.WhileStatementSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.WhileStatement(whileKeyword.Node, openParenToken.Node, condition == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) condition.Green, closeParenToken.Node, statement == null ? (Roslyn.Compilers.CSharp.InternalSyntax.StatementSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.StatementSyntax) statement.Green));
                default:
                  throw new ArgumentException("closeParenToken");
              }
            default:
              throw new ArgumentException("openParenToken");
          }
        default:
          throw new ArgumentException("whileKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.DoStatementSyntax DoStatement(Roslyn.Compilers.CSharp.SyntaxToken doKeyword = null, Roslyn.Compilers.CSharp.StatementSyntax statement = null, Roslyn.Compilers.CSharp.SyntaxToken whileKeyword = null, Roslyn.Compilers.CSharp.SyntaxToken openParenToken = null, Roslyn.Compilers.CSharp.ExpressionSyntax condition = null, Roslyn.Compilers.CSharp.SyntaxToken closeParenToken = null, Roslyn.Compilers.CSharp.SyntaxToken semicolonToken = null)
    {
      switch (doKeyword.Kind)
      {
        case SyntaxKind.None:
          doKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.DoKeyword);
          goto case SyntaxKind.DoKeyword;
        case SyntaxKind.DoKeyword:
          if (statement == null)
            throw new ArgumentNullException("statement");
          switch (whileKeyword.Kind)
          {
            case SyntaxKind.None:
              whileKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.WhileKeyword);
              goto case SyntaxKind.WhileKeyword;
            case SyntaxKind.WhileKeyword:
              switch (openParenToken.Kind)
              {
                case SyntaxKind.None:
                  openParenToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.OpenParenToken);
                  goto case SyntaxKind.OpenParenToken;
                case SyntaxKind.OpenParenToken:
                  if (condition == null)
                    throw new ArgumentNullException("condition");
                  switch (closeParenToken.Kind)
                  {
                    case SyntaxKind.None:
                      closeParenToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.CloseParenToken);
                      goto case SyntaxKind.CloseParenToken;
                    case SyntaxKind.CloseParenToken:
                      switch (semicolonToken.Kind)
                      {
                        case SyntaxKind.None:
                          semicolonToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.SemicolonToken);
                          goto case SyntaxKind.SemicolonToken;
                        case SyntaxKind.SemicolonToken:
                          return (Roslyn.Compilers.CSharp.DoStatementSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.DoStatement(doKeyword.Node, statement == null ? (Roslyn.Compilers.CSharp.InternalSyntax.StatementSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.StatementSyntax) statement.Green, whileKeyword.Node, openParenToken.Node, condition == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) condition.Green, closeParenToken.Node, semicolonToken.Node));
                        default:
                          throw new ArgumentException("semicolonToken");
                      }
                    default:
                      throw new ArgumentException("closeParenToken");
                  }
                default:
                  throw new ArgumentException("openParenToken");
              }
            default:
              throw new ArgumentException("whileKeyword");
          }
        default:
          throw new ArgumentException("doKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.ForStatementSyntax ForStatement(Roslyn.Compilers.CSharp.SyntaxToken forKeyword = null, Roslyn.Compilers.CSharp.SyntaxToken openParenToken = null, Roslyn.Compilers.CSharp.VariableDeclarationSyntax declarationOpt = null, SeparatedSyntaxList<Roslyn.Compilers.CSharp.ExpressionSyntax> initializers = null, Roslyn.Compilers.CSharp.SyntaxToken firstSemicolonToken = null, Roslyn.Compilers.CSharp.ExpressionSyntax conditionOpt = null, Roslyn.Compilers.CSharp.SyntaxToken secondSemicolonToken = null, SeparatedSyntaxList<Roslyn.Compilers.CSharp.ExpressionSyntax> incrementors = null, Roslyn.Compilers.CSharp.SyntaxToken closeParenToken = null, Roslyn.Compilers.CSharp.StatementSyntax statement = null)
    {
      switch (forKeyword.Kind)
      {
        case SyntaxKind.None:
          forKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.ForKeyword);
          goto case SyntaxKind.ForKeyword;
        case SyntaxKind.ForKeyword:
          switch (openParenToken.Kind)
          {
            case SyntaxKind.None:
              openParenToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.OpenParenToken);
              goto case SyntaxKind.OpenParenToken;
            case SyntaxKind.OpenParenToken:
              switch (firstSemicolonToken.Kind)
              {
                case SyntaxKind.None:
                  firstSemicolonToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.SemicolonToken);
                  goto case SyntaxKind.SemicolonToken;
                case SyntaxKind.SemicolonToken:
                  switch (secondSemicolonToken.Kind)
                  {
                    case SyntaxKind.None:
                      secondSemicolonToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.SemicolonToken);
                      goto case SyntaxKind.SemicolonToken;
                    case SyntaxKind.SemicolonToken:
                      switch (closeParenToken.Kind)
                      {
                        case SyntaxKind.None:
                          closeParenToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.CloseParenToken);
                          goto case SyntaxKind.CloseParenToken;
                        case SyntaxKind.CloseParenToken:
                          if (statement == null)
                            throw new ArgumentNullException("statement");
                          else
                            return (Roslyn.Compilers.CSharp.ForStatementSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.ForStatement(forKeyword.Node, openParenToken.Node, declarationOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.VariableDeclarationSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.VariableDeclarationSyntax) declarationOpt.Green, BaseSyntaxNodeExtensions.ToGreenSeparatedList<Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax>(initializers.Node), firstSemicolonToken.Node, conditionOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) conditionOpt.Green, secondSemicolonToken.Node, BaseSyntaxNodeExtensions.ToGreenSeparatedList<Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax>(incrementors.Node), closeParenToken.Node, statement == null ? (Roslyn.Compilers.CSharp.InternalSyntax.StatementSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.StatementSyntax) statement.Green));
                        default:
                          throw new ArgumentException("closeParenToken");
                      }
                    default:
                      throw new ArgumentException("secondSemicolonToken");
                  }
                default:
                  throw new ArgumentException("firstSemicolonToken");
              }
            default:
              throw new ArgumentException("openParenToken");
          }
        default:
          throw new ArgumentException("forKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.ForEachStatementSyntax ForEachStatement(Roslyn.Compilers.CSharp.SyntaxToken forEachKeyword = null, Roslyn.Compilers.CSharp.SyntaxToken openParenToken = null, Roslyn.Compilers.CSharp.TypeSyntax type = null, Roslyn.Compilers.CSharp.SyntaxToken identifier = null, Roslyn.Compilers.CSharp.SyntaxToken inKeyword = null, Roslyn.Compilers.CSharp.ExpressionSyntax expression = null, Roslyn.Compilers.CSharp.SyntaxToken closeParenToken = null, Roslyn.Compilers.CSharp.StatementSyntax statement = null)
    {
      switch (forEachKeyword.Kind)
      {
        case SyntaxKind.None:
          forEachKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.ForEachKeyword);
          goto case SyntaxKind.ForEachKeyword;
        case SyntaxKind.ForEachKeyword:
          switch (openParenToken.Kind)
          {
            case SyntaxKind.None:
              openParenToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.OpenParenToken);
              goto case SyntaxKind.OpenParenToken;
            case SyntaxKind.OpenParenToken:
              if (type == null)
                throw new ArgumentNullException("type");
              if (identifier.Kind != SyntaxKind.IdentifierToken)
                throw new ArgumentException("identifier");
              switch (inKeyword.Kind)
              {
                case SyntaxKind.None:
                  inKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.InKeyword);
                  goto case SyntaxKind.InKeyword;
                case SyntaxKind.InKeyword:
                  if (expression == null)
                    throw new ArgumentNullException("expression");
                  switch (closeParenToken.Kind)
                  {
                    case SyntaxKind.None:
                      closeParenToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.CloseParenToken);
                      goto case SyntaxKind.CloseParenToken;
                    case SyntaxKind.CloseParenToken:
                      if (statement == null)
                        throw new ArgumentNullException("statement");
                      else
                        return (Roslyn.Compilers.CSharp.ForEachStatementSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.ForEachStatement(forEachKeyword.Node, openParenToken.Node, type == null ? (Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax) type.Green, identifier.Node, inKeyword.Node, expression == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) expression.Green, closeParenToken.Node, statement == null ? (Roslyn.Compilers.CSharp.InternalSyntax.StatementSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.StatementSyntax) statement.Green));
                    default:
                      throw new ArgumentException("closeParenToken");
                  }
                default:
                  throw new ArgumentException("inKeyword");
              }
            default:
              throw new ArgumentException("openParenToken");
          }
        default:
          throw new ArgumentException("forEachKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.UsingStatementSyntax UsingStatement(Roslyn.Compilers.CSharp.SyntaxToken usingKeyword = null, Roslyn.Compilers.CSharp.SyntaxToken openParenToken = null, Roslyn.Compilers.CSharp.VariableDeclarationSyntax declarationOpt = null, Roslyn.Compilers.CSharp.ExpressionSyntax expressionOpt = null, Roslyn.Compilers.CSharp.SyntaxToken closeParenToken = null, Roslyn.Compilers.CSharp.StatementSyntax statement = null)
    {
      switch (usingKeyword.Kind)
      {
        case SyntaxKind.None:
          usingKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.UsingKeyword);
          goto case SyntaxKind.UsingKeyword;
        case SyntaxKind.UsingKeyword:
          switch (openParenToken.Kind)
          {
            case SyntaxKind.None:
              openParenToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.OpenParenToken);
              goto case SyntaxKind.OpenParenToken;
            case SyntaxKind.OpenParenToken:
              switch (closeParenToken.Kind)
              {
                case SyntaxKind.None:
                  closeParenToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.CloseParenToken);
                  goto case SyntaxKind.CloseParenToken;
                case SyntaxKind.CloseParenToken:
                  if (statement == null)
                    throw new ArgumentNullException("statement");
                  else
                    return (Roslyn.Compilers.CSharp.UsingStatementSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.UsingStatement(usingKeyword.Node, openParenToken.Node, declarationOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.VariableDeclarationSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.VariableDeclarationSyntax) declarationOpt.Green, expressionOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) expressionOpt.Green, closeParenToken.Node, statement == null ? (Roslyn.Compilers.CSharp.InternalSyntax.StatementSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.StatementSyntax) statement.Green));
                default:
                  throw new ArgumentException("closeParenToken");
              }
            default:
              throw new ArgumentException("openParenToken");
          }
        default:
          throw new ArgumentException("usingKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.FixedStatementSyntax FixedStatement(Roslyn.Compilers.CSharp.SyntaxToken fixedKeyword = null, Roslyn.Compilers.CSharp.SyntaxToken openParenToken = null, Roslyn.Compilers.CSharp.VariableDeclarationSyntax declaration = null, Roslyn.Compilers.CSharp.SyntaxToken closeParenToken = null, Roslyn.Compilers.CSharp.StatementSyntax statement = null)
    {
      switch (fixedKeyword.Kind)
      {
        case SyntaxKind.None:
          fixedKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.FixedKeyword);
          goto case SyntaxKind.FixedKeyword;
        case SyntaxKind.FixedKeyword:
          switch (openParenToken.Kind)
          {
            case SyntaxKind.None:
              openParenToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.OpenParenToken);
              goto case SyntaxKind.OpenParenToken;
            case SyntaxKind.OpenParenToken:
              if (declaration == null)
                throw new ArgumentNullException("declaration");
              switch (closeParenToken.Kind)
              {
                case SyntaxKind.None:
                  closeParenToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.CloseParenToken);
                  goto case SyntaxKind.CloseParenToken;
                case SyntaxKind.CloseParenToken:
                  if (statement == null)
                    throw new ArgumentNullException("statement");
                  else
                    return (Roslyn.Compilers.CSharp.FixedStatementSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.FixedStatement(fixedKeyword.Node, openParenToken.Node, declaration == null ? (Roslyn.Compilers.CSharp.InternalSyntax.VariableDeclarationSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.VariableDeclarationSyntax) declaration.Green, closeParenToken.Node, statement == null ? (Roslyn.Compilers.CSharp.InternalSyntax.StatementSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.StatementSyntax) statement.Green));
                default:
                  throw new ArgumentException("closeParenToken");
              }
            default:
              throw new ArgumentException("openParenToken");
          }
        default:
          throw new ArgumentException("fixedKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.CheckedStatementSyntax CheckedStatement(SyntaxKind kind, Roslyn.Compilers.CSharp.SyntaxToken checkedOrUncheckedKeyword = null, Roslyn.Compilers.CSharp.BlockSyntax block = null)
    {
      switch (kind)
      {
        case SyntaxKind.CheckedStatement:
        case SyntaxKind.UncheckedStatement:
          switch (checkedOrUncheckedKeyword.Kind)
          {
            case SyntaxKind.None:
              switch (kind)
              {
                case SyntaxKind.CheckedStatement:
                  checkedOrUncheckedKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.CheckedKeyword);
                  goto label_7;
                case SyntaxKind.UncheckedStatement:
                  checkedOrUncheckedKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.UncheckedKeyword);
                  goto label_7;
                default:
                  goto label_7;
              }
            case SyntaxKind.CheckedKeyword:
            case SyntaxKind.UncheckedKeyword:
label_7:
              if (block == null)
                throw new ArgumentNullException("block");
              else
                return (Roslyn.Compilers.CSharp.CheckedStatementSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.CheckedStatement(kind, checkedOrUncheckedKeyword.Node, block == null ? (Roslyn.Compilers.CSharp.InternalSyntax.BlockSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.BlockSyntax) block.Green));
            default:
              throw new ArgumentException("checkedOrUncheckedKeyword");
          }
        default:
          throw new ArgumentException("kind");
      }
    }

    public static Roslyn.Compilers.CSharp.UnsafeStatementSyntax UnsafeStatement(Roslyn.Compilers.CSharp.SyntaxToken unsafeKeyword = null, Roslyn.Compilers.CSharp.BlockSyntax block = null)
    {
      switch (unsafeKeyword.Kind)
      {
        case SyntaxKind.None:
          unsafeKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.UnsafeKeyword);
          goto case SyntaxKind.UnsafeKeyword;
        case SyntaxKind.UnsafeKeyword:
          if (block == null)
            throw new ArgumentNullException("block");
          else
            return (Roslyn.Compilers.CSharp.UnsafeStatementSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.UnsafeStatement(unsafeKeyword.Node, block == null ? (Roslyn.Compilers.CSharp.InternalSyntax.BlockSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.BlockSyntax) block.Green));
        default:
          throw new ArgumentException("unsafeKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.LockStatementSyntax LockStatement(Roslyn.Compilers.CSharp.SyntaxToken lockKeyword = null, Roslyn.Compilers.CSharp.SyntaxToken openParenToken = null, Roslyn.Compilers.CSharp.ExpressionSyntax expression = null, Roslyn.Compilers.CSharp.SyntaxToken closeParenToken = null, Roslyn.Compilers.CSharp.StatementSyntax statement = null)
    {
      switch (lockKeyword.Kind)
      {
        case SyntaxKind.None:
          lockKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.LockKeyword);
          goto case SyntaxKind.LockKeyword;
        case SyntaxKind.LockKeyword:
          switch (openParenToken.Kind)
          {
            case SyntaxKind.None:
              openParenToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.OpenParenToken);
              goto case SyntaxKind.OpenParenToken;
            case SyntaxKind.OpenParenToken:
              if (expression == null)
                throw new ArgumentNullException("expression");
              switch (closeParenToken.Kind)
              {
                case SyntaxKind.None:
                  closeParenToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.CloseParenToken);
                  goto case SyntaxKind.CloseParenToken;
                case SyntaxKind.CloseParenToken:
                  if (statement == null)
                    throw new ArgumentNullException("statement");
                  else
                    return (Roslyn.Compilers.CSharp.LockStatementSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.LockStatement(lockKeyword.Node, openParenToken.Node, expression == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) expression.Green, closeParenToken.Node, statement == null ? (Roslyn.Compilers.CSharp.InternalSyntax.StatementSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.StatementSyntax) statement.Green));
                default:
                  throw new ArgumentException("closeParenToken");
              }
            default:
              throw new ArgumentException("openParenToken");
          }
        default:
          throw new ArgumentException("lockKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.IfStatementSyntax IfStatement(Roslyn.Compilers.CSharp.SyntaxToken ifKeyword = null, Roslyn.Compilers.CSharp.SyntaxToken openParenToken = null, Roslyn.Compilers.CSharp.ExpressionSyntax condition = null, Roslyn.Compilers.CSharp.SyntaxToken closeParenToken = null, Roslyn.Compilers.CSharp.StatementSyntax statement = null, Roslyn.Compilers.CSharp.ElseClauseSyntax elseOpt = null)
    {
      switch (ifKeyword.Kind)
      {
        case SyntaxKind.None:
          ifKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.IfKeyword);
          goto case SyntaxKind.IfKeyword;
        case SyntaxKind.IfKeyword:
          switch (openParenToken.Kind)
          {
            case SyntaxKind.None:
              openParenToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.OpenParenToken);
              goto case SyntaxKind.OpenParenToken;
            case SyntaxKind.OpenParenToken:
              if (condition == null)
                throw new ArgumentNullException("condition");
              switch (closeParenToken.Kind)
              {
                case SyntaxKind.None:
                  closeParenToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.CloseParenToken);
                  goto case SyntaxKind.CloseParenToken;
                case SyntaxKind.CloseParenToken:
                  if (statement == null)
                    throw new ArgumentNullException("statement");
                  else
                    return (Roslyn.Compilers.CSharp.IfStatementSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.IfStatement(ifKeyword.Node, openParenToken.Node, condition == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) condition.Green, closeParenToken.Node, statement == null ? (Roslyn.Compilers.CSharp.InternalSyntax.StatementSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.StatementSyntax) statement.Green, elseOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ElseClauseSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ElseClauseSyntax) elseOpt.Green));
                default:
                  throw new ArgumentException("closeParenToken");
              }
            default:
              throw new ArgumentException("openParenToken");
          }
        default:
          throw new ArgumentException("ifKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.ElseClauseSyntax ElseClause(Roslyn.Compilers.CSharp.SyntaxToken elseKeyword = null, Roslyn.Compilers.CSharp.StatementSyntax statement = null)
    {
      switch (elseKeyword.Kind)
      {
        case SyntaxKind.None:
          elseKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.ElseKeyword);
          goto case SyntaxKind.ElseKeyword;
        case SyntaxKind.ElseKeyword:
          if (statement == null)
            throw new ArgumentNullException("statement");
          else
            return (Roslyn.Compilers.CSharp.ElseClauseSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.ElseClause(elseKeyword.Node, statement == null ? (Roslyn.Compilers.CSharp.InternalSyntax.StatementSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.StatementSyntax) statement.Green));
        default:
          throw new ArgumentException("elseKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.SwitchStatementSyntax SwitchStatement(Roslyn.Compilers.CSharp.SyntaxToken switchKeyword = null, Roslyn.Compilers.CSharp.SyntaxToken openParenToken = null, Roslyn.Compilers.CSharp.ExpressionSyntax expression = null, Roslyn.Compilers.CSharp.SyntaxToken closeParenToken = null, Roslyn.Compilers.CSharp.SyntaxToken openBraceToken = null, Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.SwitchSectionSyntax> sections = null, Roslyn.Compilers.CSharp.SyntaxToken closeBraceToken = null)
    {
      switch (switchKeyword.Kind)
      {
        case SyntaxKind.None:
          switchKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.SwitchKeyword);
          goto case SyntaxKind.SwitchKeyword;
        case SyntaxKind.SwitchKeyword:
          switch (openParenToken.Kind)
          {
            case SyntaxKind.None:
              openParenToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.OpenParenToken);
              goto case SyntaxKind.OpenParenToken;
            case SyntaxKind.OpenParenToken:
              if (expression == null)
                throw new ArgumentNullException("expression");
              switch (closeParenToken.Kind)
              {
                case SyntaxKind.None:
                  closeParenToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.CloseParenToken);
                  goto case SyntaxKind.CloseParenToken;
                case SyntaxKind.CloseParenToken:
                  switch (openBraceToken.Kind)
                  {
                    case SyntaxKind.None:
                      openBraceToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.OpenBraceToken);
                      goto case SyntaxKind.OpenBraceToken;
                    case SyntaxKind.OpenBraceToken:
                      switch (closeBraceToken.Kind)
                      {
                        case SyntaxKind.None:
                          closeBraceToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.CloseBraceToken);
                          goto case SyntaxKind.CloseBraceToken;
                        case SyntaxKind.CloseBraceToken:
                          return (Roslyn.Compilers.CSharp.SwitchStatementSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.SwitchStatement(switchKeyword.Node, openParenToken.Node, expression == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) expression.Green, closeParenToken.Node, openBraceToken.Node, BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.SwitchSectionSyntax>((IBaseSyntaxNodeExt) sections.Node), closeBraceToken.Node));
                        default:
                          throw new ArgumentException("closeBraceToken");
                      }
                    default:
                      throw new ArgumentException("openBraceToken");
                  }
                default:
                  throw new ArgumentException("closeParenToken");
              }
            default:
              throw new ArgumentException("openParenToken");
          }
        default:
          throw new ArgumentException("switchKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.SwitchSectionSyntax SwitchSection(Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.SwitchLabelSyntax> labels = null, Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.StatementSyntax> statements = null)
    {
      return (Roslyn.Compilers.CSharp.SwitchSectionSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.SwitchSection(BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.SwitchLabelSyntax>((IBaseSyntaxNodeExt) labels.Node), BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.StatementSyntax>((IBaseSyntaxNodeExt) statements.Node)));
    }

    public static Roslyn.Compilers.CSharp.SwitchLabelSyntax SwitchLabel(SyntaxKind kind, Roslyn.Compilers.CSharp.SyntaxToken caseOrDefaultKeyword = null, Roslyn.Compilers.CSharp.ExpressionSyntax valueOpt = null, Roslyn.Compilers.CSharp.SyntaxToken colonToken = null)
    {
      switch (kind)
      {
        case SyntaxKind.CaseSwitchLabel:
        case SyntaxKind.DefaultSwitchLabel:
          switch (caseOrDefaultKeyword.Kind)
          {
            case SyntaxKind.None:
              switch (kind)
              {
                case SyntaxKind.CaseSwitchLabel:
                  caseOrDefaultKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.CaseKeyword);
                  goto label_7;
                case SyntaxKind.DefaultSwitchLabel:
                  caseOrDefaultKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.DefaultKeyword);
                  goto label_7;
                default:
                  goto label_7;
              }
            case SyntaxKind.CaseKeyword:
            case SyntaxKind.DefaultKeyword:
label_7:
              switch (colonToken.Kind)
              {
                case SyntaxKind.None:
                  colonToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.ColonToken);
                  goto case SyntaxKind.ColonToken;
                case SyntaxKind.ColonToken:
                  return (Roslyn.Compilers.CSharp.SwitchLabelSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.SwitchLabel(kind, caseOrDefaultKeyword.Node, valueOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) valueOpt.Green, colonToken.Node));
                default:
                  throw new ArgumentException("colonToken");
              }
            default:
              throw new ArgumentException("caseOrDefaultKeyword");
          }
        default:
          throw new ArgumentException("kind");
      }
    }

    public static Roslyn.Compilers.CSharp.TryStatementSyntax TryStatement(Roslyn.Compilers.CSharp.SyntaxToken tryKeyword = null, Roslyn.Compilers.CSharp.BlockSyntax block = null, Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.CatchClauseSyntax> catches = null, Roslyn.Compilers.CSharp.FinallyClauseSyntax finallyOpt = null)
    {
      switch (tryKeyword.Kind)
      {
        case SyntaxKind.None:
          tryKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.TryKeyword);
          goto case SyntaxKind.TryKeyword;
        case SyntaxKind.TryKeyword:
          if (block == null)
            throw new ArgumentNullException("block");
          else
            return (Roslyn.Compilers.CSharp.TryStatementSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.TryStatement(tryKeyword.Node, block == null ? (Roslyn.Compilers.CSharp.InternalSyntax.BlockSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.BlockSyntax) block.Green, BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.CatchClauseSyntax>((IBaseSyntaxNodeExt) catches.Node), finallyOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.FinallyClauseSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.FinallyClauseSyntax) finallyOpt.Green));
        default:
          throw new ArgumentException("tryKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.CatchClauseSyntax CatchClause(Roslyn.Compilers.CSharp.SyntaxToken catchKeyword = null, Roslyn.Compilers.CSharp.CatchDeclarationSyntax declarationOpt = null, Roslyn.Compilers.CSharp.BlockSyntax block = null)
    {
      switch (catchKeyword.Kind)
      {
        case SyntaxKind.None:
          catchKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.CatchKeyword);
          goto case SyntaxKind.CatchKeyword;
        case SyntaxKind.CatchKeyword:
          if (block == null)
            throw new ArgumentNullException("block");
          else
            return (Roslyn.Compilers.CSharp.CatchClauseSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.CatchClause(catchKeyword.Node, declarationOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.CatchDeclarationSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.CatchDeclarationSyntax) declarationOpt.Green, block == null ? (Roslyn.Compilers.CSharp.InternalSyntax.BlockSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.BlockSyntax) block.Green));
        default:
          throw new ArgumentException("catchKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.CatchDeclarationSyntax CatchDeclaration(Roslyn.Compilers.CSharp.SyntaxToken openParenToken = null, Roslyn.Compilers.CSharp.TypeSyntax type = null, Roslyn.Compilers.CSharp.SyntaxToken identifierOpt = null, Roslyn.Compilers.CSharp.SyntaxToken closeParenToken = null)
    {
      switch (openParenToken.Kind)
      {
        case SyntaxKind.None:
          openParenToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.OpenParenToken);
          goto case SyntaxKind.OpenParenToken;
        case SyntaxKind.OpenParenToken:
          if (type == null)
            throw new ArgumentNullException("type");
          switch (identifierOpt.Kind)
          {
            case SyntaxKind.None:
            case SyntaxKind.IdentifierToken:
              switch (closeParenToken.Kind)
              {
                case SyntaxKind.None:
                  closeParenToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.CloseParenToken);
                  goto case SyntaxKind.CloseParenToken;
                case SyntaxKind.CloseParenToken:
                  return (Roslyn.Compilers.CSharp.CatchDeclarationSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.CatchDeclaration(openParenToken.Node, type == null ? (Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax) type.Green, identifierOpt.Node, closeParenToken.Node));
                default:
                  throw new ArgumentException("closeParenToken");
              }
            default:
              throw new ArgumentException("identifierOpt");
          }
        default:
          throw new ArgumentException("openParenToken");
      }
    }

    public static Roslyn.Compilers.CSharp.FinallyClauseSyntax FinallyClause(Roslyn.Compilers.CSharp.SyntaxToken finallyKeyword = null, Roslyn.Compilers.CSharp.BlockSyntax block = null)
    {
      switch (finallyKeyword.Kind)
      {
        case SyntaxKind.None:
          finallyKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.FinallyKeyword);
          goto case SyntaxKind.FinallyKeyword;
        case SyntaxKind.FinallyKeyword:
          if (block == null)
            throw new ArgumentNullException("block");
          else
            return (Roslyn.Compilers.CSharp.FinallyClauseSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.FinallyClause(finallyKeyword.Node, block == null ? (Roslyn.Compilers.CSharp.InternalSyntax.BlockSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.BlockSyntax) block.Green));
        default:
          throw new ArgumentException("finallyKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.CompilationUnitSyntax CompilationUnit(Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.ExternAliasDirectiveSyntax> externs = null, Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.UsingDirectiveSyntax> usings = null, Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.AttributeDeclarationSyntax> attributes = null, Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.MemberDeclarationSyntax> members = null, Roslyn.Compilers.CSharp.SyntaxToken endOfFileToken = null)
    {
      switch (endOfFileToken.Kind)
      {
        case SyntaxKind.None:
          endOfFileToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.EndOfFileToken);
          goto case SyntaxKind.EndOfFileToken;
        case SyntaxKind.EndOfFileToken:
          return (Roslyn.Compilers.CSharp.CompilationUnitSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.CompilationUnit(BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.ExternAliasDirectiveSyntax>((IBaseSyntaxNodeExt) externs.Node), BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.UsingDirectiveSyntax>((IBaseSyntaxNodeExt) usings.Node), BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.AttributeDeclarationSyntax>((IBaseSyntaxNodeExt) attributes.Node), BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.MemberDeclarationSyntax>((IBaseSyntaxNodeExt) members.Node), endOfFileToken.Node));
        default:
          throw new ArgumentException("endOfFileToken");
      }
    }

    public static Roslyn.Compilers.CSharp.ExternAliasDirectiveSyntax ExternAliasDirective(Roslyn.Compilers.CSharp.SyntaxToken externKeyword = null, Roslyn.Compilers.CSharp.SyntaxToken aliasKeyword = null, Roslyn.Compilers.CSharp.SyntaxToken identifier = null, Roslyn.Compilers.CSharp.SyntaxToken semicolonToken = null)
    {
      switch (externKeyword.Kind)
      {
        case SyntaxKind.None:
          externKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.ExternKeyword);
          goto case SyntaxKind.ExternKeyword;
        case SyntaxKind.ExternKeyword:
          switch (aliasKeyword.Kind)
          {
            case SyntaxKind.None:
              aliasKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.AliasKeyword);
              goto case SyntaxKind.AliasKeyword;
            case SyntaxKind.AliasKeyword:
              if (identifier.Kind != SyntaxKind.IdentifierToken)
                throw new ArgumentException("identifier");
              switch (semicolonToken.Kind)
              {
                case SyntaxKind.None:
                  semicolonToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.SemicolonToken);
                  goto case SyntaxKind.SemicolonToken;
                case SyntaxKind.SemicolonToken:
                  return (Roslyn.Compilers.CSharp.ExternAliasDirectiveSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.ExternAliasDirective(externKeyword.Node, aliasKeyword.Node, identifier.Node, semicolonToken.Node));
                default:
                  throw new ArgumentException("semicolonToken");
              }
            default:
              throw new ArgumentException("aliasKeyword");
          }
        default:
          throw new ArgumentException("externKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.UsingDirectiveSyntax UsingDirective(Roslyn.Compilers.CSharp.SyntaxToken usingKeyword = null, Roslyn.Compilers.CSharp.NameEqualsSyntax aliasOpt = null, Roslyn.Compilers.CSharp.NameSyntax name = null, Roslyn.Compilers.CSharp.SyntaxToken semicolonToken = null)
    {
      switch (usingKeyword.Kind)
      {
        case SyntaxKind.None:
          usingKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.UsingKeyword);
          goto case SyntaxKind.UsingKeyword;
        case SyntaxKind.UsingKeyword:
          if (name == null)
            throw new ArgumentNullException("name");
          switch (semicolonToken.Kind)
          {
            case SyntaxKind.None:
              semicolonToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.SemicolonToken);
              goto case SyntaxKind.SemicolonToken;
            case SyntaxKind.SemicolonToken:
              return (Roslyn.Compilers.CSharp.UsingDirectiveSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.UsingDirective(usingKeyword.Node, aliasOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.NameEqualsSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.NameEqualsSyntax) aliasOpt.Green, name == null ? (Roslyn.Compilers.CSharp.InternalSyntax.NameSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.NameSyntax) name.Green, semicolonToken.Node));
            default:
              throw new ArgumentException("semicolonToken");
          }
        default:
          throw new ArgumentException("usingKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.NamespaceDeclarationSyntax NamespaceDeclaration(Roslyn.Compilers.CSharp.SyntaxToken namespaceKeyword = null, Roslyn.Compilers.CSharp.NameSyntax name = null, Roslyn.Compilers.CSharp.SyntaxToken openBraceToken = null, Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.ExternAliasDirectiveSyntax> externs = null, Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.UsingDirectiveSyntax> usings = null, Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.MemberDeclarationSyntax> members = null, Roslyn.Compilers.CSharp.SyntaxToken closeBraceToken = null, Roslyn.Compilers.CSharp.SyntaxToken semicolonTokenOpt = null)
    {
      switch (namespaceKeyword.Kind)
      {
        case SyntaxKind.None:
          namespaceKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.NamespaceKeyword);
          goto case SyntaxKind.NamespaceKeyword;
        case SyntaxKind.NamespaceKeyword:
          if (name == null)
            throw new ArgumentNullException("name");
          switch (openBraceToken.Kind)
          {
            case SyntaxKind.None:
              openBraceToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.OpenBraceToken);
              goto case SyntaxKind.OpenBraceToken;
            case SyntaxKind.OpenBraceToken:
              switch (closeBraceToken.Kind)
              {
                case SyntaxKind.None:
                  closeBraceToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.CloseBraceToken);
                  goto case SyntaxKind.CloseBraceToken;
                case SyntaxKind.CloseBraceToken:
                  switch (semicolonTokenOpt.Kind)
                  {
                    case SyntaxKind.None:
                    case SyntaxKind.SemicolonToken:
                      return (Roslyn.Compilers.CSharp.NamespaceDeclarationSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.NamespaceDeclaration(namespaceKeyword.Node, name == null ? (Roslyn.Compilers.CSharp.InternalSyntax.NameSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.NameSyntax) name.Green, openBraceToken.Node, BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.ExternAliasDirectiveSyntax>((IBaseSyntaxNodeExt) externs.Node), BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.UsingDirectiveSyntax>((IBaseSyntaxNodeExt) usings.Node), BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.MemberDeclarationSyntax>((IBaseSyntaxNodeExt) members.Node), closeBraceToken.Node, semicolonTokenOpt.Node));
                    default:
                      throw new ArgumentException("semicolonTokenOpt");
                  }
                default:
                  throw new ArgumentException("closeBraceToken");
              }
            default:
              throw new ArgumentException("openBraceToken");
          }
        default:
          throw new ArgumentException("namespaceKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.AttributeDeclarationSyntax AttributeDeclaration(Roslyn.Compilers.CSharp.SyntaxToken openBracketToken = null, Roslyn.Compilers.CSharp.AttributeTargetSpecifierSyntax targetOpt = null, SeparatedSyntaxList<Roslyn.Compilers.CSharp.AttributeSyntax> attributes = null, Roslyn.Compilers.CSharp.SyntaxToken closeBracketToken = null)
    {
      switch (openBracketToken.Kind)
      {
        case SyntaxKind.None:
          openBracketToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.OpenBracketToken);
          goto case SyntaxKind.OpenBracketToken;
        case SyntaxKind.OpenBracketToken:
          switch (closeBracketToken.Kind)
          {
            case SyntaxKind.None:
              closeBracketToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.CloseBracketToken);
              goto case SyntaxKind.CloseBracketToken;
            case SyntaxKind.CloseBracketToken:
              return (Roslyn.Compilers.CSharp.AttributeDeclarationSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.AttributeDeclaration(openBracketToken.Node, targetOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.AttributeTargetSpecifierSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.AttributeTargetSpecifierSyntax) targetOpt.Green, BaseSyntaxNodeExtensions.ToGreenSeparatedList<Roslyn.Compilers.CSharp.InternalSyntax.AttributeSyntax>(attributes.Node), closeBracketToken.Node));
            default:
              throw new ArgumentException("closeBracketToken");
          }
        default:
          throw new ArgumentException("openBracketToken");
      }
    }

    public static Roslyn.Compilers.CSharp.AttributeTargetSpecifierSyntax AttributeTargetSpecifier(Roslyn.Compilers.CSharp.SyntaxToken identifier, Roslyn.Compilers.CSharp.SyntaxToken colonToken = null)
    {
      switch (colonToken.Kind)
      {
        case SyntaxKind.None:
          colonToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.ColonToken);
          goto case SyntaxKind.ColonToken;
        case SyntaxKind.ColonToken:
          return (Roslyn.Compilers.CSharp.AttributeTargetSpecifierSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.AttributeTargetSpecifier(identifier.Node, colonToken.Node));
        default:
          throw new ArgumentException("colonToken");
      }
    }

    public static Roslyn.Compilers.CSharp.AttributeSyntax Attribute(Roslyn.Compilers.CSharp.NameSyntax name, Roslyn.Compilers.CSharp.AttributeArgumentListSyntax argumentListOpt = null)
    {
      if (name == null)
        throw new ArgumentNullException("name");
      else
        return (Roslyn.Compilers.CSharp.AttributeSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.Attribute(name == null ? (Roslyn.Compilers.CSharp.InternalSyntax.NameSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.NameSyntax) name.Green, argumentListOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.AttributeArgumentListSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.AttributeArgumentListSyntax) argumentListOpt.Green));
    }

    public static Roslyn.Compilers.CSharp.AttributeArgumentListSyntax AttributeArgumentList(Roslyn.Compilers.CSharp.SyntaxToken openParenToken = null, SeparatedSyntaxList<Roslyn.Compilers.CSharp.AttributeArgumentSyntax> arguments = null, Roslyn.Compilers.CSharp.SyntaxToken closeParenToken = null)
    {
      switch (openParenToken.Kind)
      {
        case SyntaxKind.None:
          openParenToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.OpenParenToken);
          goto case SyntaxKind.OpenParenToken;
        case SyntaxKind.OpenParenToken:
          switch (closeParenToken.Kind)
          {
            case SyntaxKind.None:
              closeParenToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.CloseParenToken);
              goto case SyntaxKind.CloseParenToken;
            case SyntaxKind.CloseParenToken:
              return (Roslyn.Compilers.CSharp.AttributeArgumentListSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.AttributeArgumentList(openParenToken.Node, BaseSyntaxNodeExtensions.ToGreenSeparatedList<Roslyn.Compilers.CSharp.InternalSyntax.AttributeArgumentSyntax>(arguments.Node), closeParenToken.Node));
            default:
              throw new ArgumentException("closeParenToken");
          }
        default:
          throw new ArgumentException("openParenToken");
      }
    }

    public static Roslyn.Compilers.CSharp.AttributeArgumentSyntax AttributeArgument(Roslyn.Compilers.CSharp.NameEqualsSyntax nameEqualsOpt = null, Roslyn.Compilers.CSharp.NameColonSyntax nameColonOpt = null, Roslyn.Compilers.CSharp.ExpressionSyntax expression = null)
    {
      if (expression == null)
        throw new ArgumentNullException("expression");
      else
        return (Roslyn.Compilers.CSharp.AttributeArgumentSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.AttributeArgument(nameEqualsOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.NameEqualsSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.NameEqualsSyntax) nameEqualsOpt.Green, nameColonOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.NameColonSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.NameColonSyntax) nameColonOpt.Green, expression == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) expression.Green));
    }

    public static Roslyn.Compilers.CSharp.NameEqualsSyntax NameEquals(Roslyn.Compilers.CSharp.SyntaxToken identifier, Roslyn.Compilers.CSharp.SyntaxToken equalsToken = null)
    {
      if (identifier.Kind != SyntaxKind.IdentifierToken)
        throw new ArgumentException("identifier");
      switch (equalsToken.Kind)
      {
        case SyntaxKind.None:
          equalsToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.EqualsToken);
          goto case SyntaxKind.EqualsToken;
        case SyntaxKind.EqualsToken:
          return (Roslyn.Compilers.CSharp.NameEqualsSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.NameEquals(identifier.Node, equalsToken.Node));
        default:
          throw new ArgumentException("equalsToken");
      }
    }

    public static Roslyn.Compilers.CSharp.TypeParameterListSyntax TypeParameterList(Roslyn.Compilers.CSharp.SyntaxToken lessThanToken = null, SeparatedSyntaxList<Roslyn.Compilers.CSharp.TypeParameterSyntax> parameters = null, Roslyn.Compilers.CSharp.SyntaxToken greaterThanToken = null)
    {
      switch (lessThanToken.Kind)
      {
        case SyntaxKind.None:
          lessThanToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.LessThanToken);
          goto case SyntaxKind.LessThanToken;
        case SyntaxKind.LessThanToken:
          switch (greaterThanToken.Kind)
          {
            case SyntaxKind.None:
              greaterThanToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.GreaterThanToken);
              goto case SyntaxKind.GreaterThanToken;
            case SyntaxKind.GreaterThanToken:
              return (Roslyn.Compilers.CSharp.TypeParameterListSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.TypeParameterList(lessThanToken.Node, BaseSyntaxNodeExtensions.ToGreenSeparatedList<Roslyn.Compilers.CSharp.InternalSyntax.TypeParameterSyntax>(parameters.Node), greaterThanToken.Node));
            default:
              throw new ArgumentException("greaterThanToken");
          }
        default:
          throw new ArgumentException("lessThanToken");
      }
    }

    public static Roslyn.Compilers.CSharp.TypeParameterSyntax TypeParameter(Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.AttributeDeclarationSyntax> attributes = null, Roslyn.Compilers.CSharp.SyntaxToken varianceKeywordOpt = null, Roslyn.Compilers.CSharp.SyntaxToken identifier = null)
    {
      switch (varianceKeywordOpt.Kind)
      {
        case SyntaxKind.None:
        case SyntaxKind.OutKeyword:
        case SyntaxKind.InKeyword:
          if (identifier.Kind != SyntaxKind.IdentifierToken)
            throw new ArgumentException("identifier");
          else
            return (Roslyn.Compilers.CSharp.TypeParameterSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.TypeParameter(BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.AttributeDeclarationSyntax>((IBaseSyntaxNodeExt) attributes.Node), varianceKeywordOpt.Node, identifier.Node));
        default:
          throw new ArgumentException("varianceKeywordOpt");
      }
    }

    public static Roslyn.Compilers.CSharp.ClassDeclarationSyntax ClassDeclaration(Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.AttributeDeclarationSyntax> attributes = null, SyntaxTokenList modifiers = null, Roslyn.Compilers.CSharp.SyntaxToken keyword = null, Roslyn.Compilers.CSharp.SyntaxToken identifier = null, Roslyn.Compilers.CSharp.TypeParameterListSyntax typeParameterListOpt = null, Roslyn.Compilers.CSharp.BaseListSyntax baseListOpt = null, Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.TypeParameterConstraintClauseSyntax> constraintClauses = null, Roslyn.Compilers.CSharp.SyntaxToken openBraceToken = null, Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.MemberDeclarationSyntax> members = null, Roslyn.Compilers.CSharp.SyntaxToken closeBraceToken = null, Roslyn.Compilers.CSharp.SyntaxToken semicolonTokenOpt = null)
    {
      switch (keyword.Kind)
      {
        case SyntaxKind.None:
          keyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.ClassKeyword);
          goto case SyntaxKind.ClassKeyword;
        case SyntaxKind.ClassKeyword:
          if (identifier.Kind != SyntaxKind.IdentifierToken)
            throw new ArgumentException("identifier");
          switch (openBraceToken.Kind)
          {
            case SyntaxKind.None:
              openBraceToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.OpenBraceToken);
              goto case SyntaxKind.OpenBraceToken;
            case SyntaxKind.OpenBraceToken:
              switch (closeBraceToken.Kind)
              {
                case SyntaxKind.None:
                  closeBraceToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.CloseBraceToken);
                  goto case SyntaxKind.CloseBraceToken;
                case SyntaxKind.CloseBraceToken:
                  switch (semicolonTokenOpt.Kind)
                  {
                    case SyntaxKind.None:
                    case SyntaxKind.SemicolonToken:
                      return (Roslyn.Compilers.CSharp.ClassDeclarationSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.ClassDeclaration(BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.AttributeDeclarationSyntax>((IBaseSyntaxNodeExt) attributes.Node), (Roslyn.Compilers.CSharp.InternalSyntax.SyntaxList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxToken>) BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxNode>((IBaseSyntaxNodeExt) modifiers.Node), keyword.Node, identifier.Node, typeParameterListOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.TypeParameterListSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.TypeParameterListSyntax) typeParameterListOpt.Green, baseListOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.BaseListSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.BaseListSyntax) baseListOpt.Green, BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.TypeParameterConstraintClauseSyntax>((IBaseSyntaxNodeExt) constraintClauses.Node), openBraceToken.Node, BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.MemberDeclarationSyntax>((IBaseSyntaxNodeExt) members.Node), closeBraceToken.Node, semicolonTokenOpt.Node));
                    default:
                      throw new ArgumentException("semicolonTokenOpt");
                  }
                default:
                  throw new ArgumentException("closeBraceToken");
              }
            default:
              throw new ArgumentException("openBraceToken");
          }
        default:
          throw new ArgumentException("keyword");
      }
    }

    public static Roslyn.Compilers.CSharp.StructDeclarationSyntax StructDeclaration(Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.AttributeDeclarationSyntax> attributes = null, SyntaxTokenList modifiers = null, Roslyn.Compilers.CSharp.SyntaxToken keyword = null, Roslyn.Compilers.CSharp.SyntaxToken identifier = null, Roslyn.Compilers.CSharp.TypeParameterListSyntax typeParameterListOpt = null, Roslyn.Compilers.CSharp.BaseListSyntax baseListOpt = null, Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.TypeParameterConstraintClauseSyntax> constraintClauses = null, Roslyn.Compilers.CSharp.SyntaxToken openBraceToken = null, Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.MemberDeclarationSyntax> members = null, Roslyn.Compilers.CSharp.SyntaxToken closeBraceToken = null, Roslyn.Compilers.CSharp.SyntaxToken semicolonTokenOpt = null)
    {
      switch (keyword.Kind)
      {
        case SyntaxKind.None:
          keyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.StructKeyword);
          goto case SyntaxKind.StructKeyword;
        case SyntaxKind.StructKeyword:
          if (identifier.Kind != SyntaxKind.IdentifierToken)
            throw new ArgumentException("identifier");
          switch (openBraceToken.Kind)
          {
            case SyntaxKind.None:
              openBraceToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.OpenBraceToken);
              goto case SyntaxKind.OpenBraceToken;
            case SyntaxKind.OpenBraceToken:
              switch (closeBraceToken.Kind)
              {
                case SyntaxKind.None:
                  closeBraceToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.CloseBraceToken);
                  goto case SyntaxKind.CloseBraceToken;
                case SyntaxKind.CloseBraceToken:
                  switch (semicolonTokenOpt.Kind)
                  {
                    case SyntaxKind.None:
                    case SyntaxKind.SemicolonToken:
                      return (Roslyn.Compilers.CSharp.StructDeclarationSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.StructDeclaration(BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.AttributeDeclarationSyntax>((IBaseSyntaxNodeExt) attributes.Node), (Roslyn.Compilers.CSharp.InternalSyntax.SyntaxList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxToken>) BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxNode>((IBaseSyntaxNodeExt) modifiers.Node), keyword.Node, identifier.Node, typeParameterListOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.TypeParameterListSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.TypeParameterListSyntax) typeParameterListOpt.Green, baseListOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.BaseListSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.BaseListSyntax) baseListOpt.Green, BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.TypeParameterConstraintClauseSyntax>((IBaseSyntaxNodeExt) constraintClauses.Node), openBraceToken.Node, BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.MemberDeclarationSyntax>((IBaseSyntaxNodeExt) members.Node), closeBraceToken.Node, semicolonTokenOpt.Node));
                    default:
                      throw new ArgumentException("semicolonTokenOpt");
                  }
                default:
                  throw new ArgumentException("closeBraceToken");
              }
            default:
              throw new ArgumentException("openBraceToken");
          }
        default:
          throw new ArgumentException("keyword");
      }
    }

    public static Roslyn.Compilers.CSharp.InterfaceDeclarationSyntax InterfaceDeclaration(Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.AttributeDeclarationSyntax> attributes = null, SyntaxTokenList modifiers = null, Roslyn.Compilers.CSharp.SyntaxToken keyword = null, Roslyn.Compilers.CSharp.SyntaxToken identifier = null, Roslyn.Compilers.CSharp.TypeParameterListSyntax typeParameterListOpt = null, Roslyn.Compilers.CSharp.BaseListSyntax baseListOpt = null, Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.TypeParameterConstraintClauseSyntax> constraintClauses = null, Roslyn.Compilers.CSharp.SyntaxToken openBraceToken = null, Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.MemberDeclarationSyntax> members = null, Roslyn.Compilers.CSharp.SyntaxToken closeBraceToken = null, Roslyn.Compilers.CSharp.SyntaxToken semicolonTokenOpt = null)
    {
      switch (keyword.Kind)
      {
        case SyntaxKind.None:
          keyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.InterfaceKeyword);
          goto case SyntaxKind.InterfaceKeyword;
        case SyntaxKind.InterfaceKeyword:
          if (identifier.Kind != SyntaxKind.IdentifierToken)
            throw new ArgumentException("identifier");
          switch (openBraceToken.Kind)
          {
            case SyntaxKind.None:
              openBraceToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.OpenBraceToken);
              goto case SyntaxKind.OpenBraceToken;
            case SyntaxKind.OpenBraceToken:
              switch (closeBraceToken.Kind)
              {
                case SyntaxKind.None:
                  closeBraceToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.CloseBraceToken);
                  goto case SyntaxKind.CloseBraceToken;
                case SyntaxKind.CloseBraceToken:
                  switch (semicolonTokenOpt.Kind)
                  {
                    case SyntaxKind.None:
                    case SyntaxKind.SemicolonToken:
                      return (Roslyn.Compilers.CSharp.InterfaceDeclarationSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.InterfaceDeclaration(BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.AttributeDeclarationSyntax>((IBaseSyntaxNodeExt) attributes.Node), (Roslyn.Compilers.CSharp.InternalSyntax.SyntaxList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxToken>) BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxNode>((IBaseSyntaxNodeExt) modifiers.Node), keyword.Node, identifier.Node, typeParameterListOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.TypeParameterListSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.TypeParameterListSyntax) typeParameterListOpt.Green, baseListOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.BaseListSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.BaseListSyntax) baseListOpt.Green, BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.TypeParameterConstraintClauseSyntax>((IBaseSyntaxNodeExt) constraintClauses.Node), openBraceToken.Node, BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.MemberDeclarationSyntax>((IBaseSyntaxNodeExt) members.Node), closeBraceToken.Node, semicolonTokenOpt.Node));
                    default:
                      throw new ArgumentException("semicolonTokenOpt");
                  }
                default:
                  throw new ArgumentException("closeBraceToken");
              }
            default:
              throw new ArgumentException("openBraceToken");
          }
        default:
          throw new ArgumentException("keyword");
      }
    }

    public static Roslyn.Compilers.CSharp.EnumDeclarationSyntax EnumDeclaration(Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.AttributeDeclarationSyntax> attributes = null, SyntaxTokenList modifiers = null, Roslyn.Compilers.CSharp.SyntaxToken enumKeyword = null, Roslyn.Compilers.CSharp.SyntaxToken identifier = null, Roslyn.Compilers.CSharp.BaseListSyntax baseListOpt = null, Roslyn.Compilers.CSharp.SyntaxToken openBraceToken = null, SeparatedSyntaxList<Roslyn.Compilers.CSharp.EnumMemberDeclarationSyntax> members = null, Roslyn.Compilers.CSharp.SyntaxToken closeBraceToken = null, Roslyn.Compilers.CSharp.SyntaxToken semicolonTokenOpt = null)
    {
      switch (enumKeyword.Kind)
      {
        case SyntaxKind.None:
          enumKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.EnumKeyword);
          goto case SyntaxKind.EnumKeyword;
        case SyntaxKind.EnumKeyword:
          if (identifier.Kind != SyntaxKind.IdentifierToken)
            throw new ArgumentException("identifier");
          switch (openBraceToken.Kind)
          {
            case SyntaxKind.None:
              openBraceToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.OpenBraceToken);
              goto case SyntaxKind.OpenBraceToken;
            case SyntaxKind.OpenBraceToken:
              switch (closeBraceToken.Kind)
              {
                case SyntaxKind.None:
                  closeBraceToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.CloseBraceToken);
                  goto case SyntaxKind.CloseBraceToken;
                case SyntaxKind.CloseBraceToken:
                  switch (semicolonTokenOpt.Kind)
                  {
                    case SyntaxKind.None:
                    case SyntaxKind.SemicolonToken:
                      return (Roslyn.Compilers.CSharp.EnumDeclarationSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.EnumDeclaration(BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.AttributeDeclarationSyntax>((IBaseSyntaxNodeExt) attributes.Node), (Roslyn.Compilers.CSharp.InternalSyntax.SyntaxList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxToken>) BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxNode>((IBaseSyntaxNodeExt) modifiers.Node), enumKeyword.Node, identifier.Node, baseListOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.BaseListSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.BaseListSyntax) baseListOpt.Green, openBraceToken.Node, BaseSyntaxNodeExtensions.ToGreenSeparatedList<Roslyn.Compilers.CSharp.InternalSyntax.EnumMemberDeclarationSyntax>(members.Node), closeBraceToken.Node, semicolonTokenOpt.Node));
                    default:
                      throw new ArgumentException("semicolonTokenOpt");
                  }
                default:
                  throw new ArgumentException("closeBraceToken");
              }
            default:
              throw new ArgumentException("openBraceToken");
          }
        default:
          throw new ArgumentException("enumKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.DelegateDeclarationSyntax DelegateDeclaration(Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.AttributeDeclarationSyntax> attributes = null, SyntaxTokenList modifiers = null, Roslyn.Compilers.CSharp.SyntaxToken delegateKeyword = null, Roslyn.Compilers.CSharp.TypeSyntax returnType = null, Roslyn.Compilers.CSharp.SyntaxToken identifier = null, Roslyn.Compilers.CSharp.TypeParameterListSyntax typeParameterListOpt = null, Roslyn.Compilers.CSharp.ParameterListSyntax parameterList = null, Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.TypeParameterConstraintClauseSyntax> constraintClauses = null, Roslyn.Compilers.CSharp.SyntaxToken semicolonToken = null)
    {
      switch (delegateKeyword.Kind)
      {
        case SyntaxKind.None:
          delegateKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.DelegateKeyword);
          goto case SyntaxKind.DelegateKeyword;
        case SyntaxKind.DelegateKeyword:
          if (returnType == null)
            throw new ArgumentNullException("returnType");
          if (identifier.Kind != SyntaxKind.IdentifierToken)
            throw new ArgumentException("identifier");
          if (parameterList == null)
            throw new ArgumentNullException("parameterList");
          switch (semicolonToken.Kind)
          {
            case SyntaxKind.None:
              semicolonToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.SemicolonToken);
              goto case SyntaxKind.SemicolonToken;
            case SyntaxKind.SemicolonToken:
              return (Roslyn.Compilers.CSharp.DelegateDeclarationSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.DelegateDeclaration(BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.AttributeDeclarationSyntax>((IBaseSyntaxNodeExt) attributes.Node), (Roslyn.Compilers.CSharp.InternalSyntax.SyntaxList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxToken>) BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxNode>((IBaseSyntaxNodeExt) modifiers.Node), delegateKeyword.Node, returnType == null ? (Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax) returnType.Green, identifier.Node, typeParameterListOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.TypeParameterListSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.TypeParameterListSyntax) typeParameterListOpt.Green, parameterList == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ParameterListSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ParameterListSyntax) parameterList.Green, BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.TypeParameterConstraintClauseSyntax>((IBaseSyntaxNodeExt) constraintClauses.Node), semicolonToken.Node));
            default:
              throw new ArgumentException("semicolonToken");
          }
        default:
          throw new ArgumentException("delegateKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.EnumMemberDeclarationSyntax EnumMemberDeclaration(Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.AttributeDeclarationSyntax> attributes = null, Roslyn.Compilers.CSharp.SyntaxToken identifier = null, Roslyn.Compilers.CSharp.EqualsValueClauseSyntax equalsValueOpt = null)
    {
      if (identifier.Kind != SyntaxKind.IdentifierToken)
        throw new ArgumentException("identifier");
      else
        return (Roslyn.Compilers.CSharp.EnumMemberDeclarationSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.EnumMemberDeclaration(BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.AttributeDeclarationSyntax>((IBaseSyntaxNodeExt) attributes.Node), identifier.Node, equalsValueOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.EqualsValueClauseSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.EqualsValueClauseSyntax) equalsValueOpt.Green));
    }

    public static Roslyn.Compilers.CSharp.BaseListSyntax BaseList(Roslyn.Compilers.CSharp.SyntaxToken colonToken = null, SeparatedSyntaxList<Roslyn.Compilers.CSharp.TypeSyntax> types = null)
    {
      switch (colonToken.Kind)
      {
        case SyntaxKind.None:
          colonToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.ColonToken);
          goto case SyntaxKind.ColonToken;
        case SyntaxKind.ColonToken:
          return (Roslyn.Compilers.CSharp.BaseListSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.BaseList(colonToken.Node, BaseSyntaxNodeExtensions.ToGreenSeparatedList<Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax>(types.Node)));
        default:
          throw new ArgumentException("colonToken");
      }
    }

    public static Roslyn.Compilers.CSharp.TypeParameterConstraintClauseSyntax TypeParameterConstraintClause(Roslyn.Compilers.CSharp.SyntaxToken whereKeyword = null, Roslyn.Compilers.CSharp.SyntaxToken identifier = null, Roslyn.Compilers.CSharp.SyntaxToken colonToken = null, SeparatedSyntaxList<Roslyn.Compilers.CSharp.TypeParameterConstraintSyntax> constraints = null)
    {
      switch (whereKeyword.Kind)
      {
        case SyntaxKind.None:
          whereKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.WhereKeyword);
          goto case SyntaxKind.WhereKeyword;
        case SyntaxKind.WhereKeyword:
          if (identifier.Kind != SyntaxKind.IdentifierToken)
            throw new ArgumentException("identifier");
          switch (colonToken.Kind)
          {
            case SyntaxKind.None:
              colonToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.ColonToken);
              goto case SyntaxKind.ColonToken;
            case SyntaxKind.ColonToken:
              return (Roslyn.Compilers.CSharp.TypeParameterConstraintClauseSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.TypeParameterConstraintClause(whereKeyword.Node, identifier.Node, colonToken.Node, BaseSyntaxNodeExtensions.ToGreenSeparatedList<Roslyn.Compilers.CSharp.InternalSyntax.TypeParameterConstraintSyntax>(constraints.Node)));
            default:
              throw new ArgumentException("colonToken");
          }
        default:
          throw new ArgumentException("whereKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.ConstructorConstraintSyntax ConstructorConstraint(Roslyn.Compilers.CSharp.SyntaxToken newKeyword = null, Roslyn.Compilers.CSharp.SyntaxToken openParenToken = null, Roslyn.Compilers.CSharp.SyntaxToken closeParenToken = null)
    {
      switch (newKeyword.Kind)
      {
        case SyntaxKind.None:
          newKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.NewKeyword);
          goto case SyntaxKind.NewKeyword;
        case SyntaxKind.NewKeyword:
          switch (openParenToken.Kind)
          {
            case SyntaxKind.None:
              openParenToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.OpenParenToken);
              goto case SyntaxKind.OpenParenToken;
            case SyntaxKind.OpenParenToken:
              switch (closeParenToken.Kind)
              {
                case SyntaxKind.None:
                  closeParenToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.CloseParenToken);
                  goto case SyntaxKind.CloseParenToken;
                case SyntaxKind.CloseParenToken:
                  return (Roslyn.Compilers.CSharp.ConstructorConstraintSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.ConstructorConstraint(newKeyword.Node, openParenToken.Node, closeParenToken.Node));
                default:
                  throw new ArgumentException("closeParenToken");
              }
            default:
              throw new ArgumentException("openParenToken");
          }
        default:
          throw new ArgumentException("newKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.ClassOrStructConstraintSyntax ClassOrStructConstraint(SyntaxKind kind, Roslyn.Compilers.CSharp.SyntaxToken classOrStructKeyword = null)
    {
      switch (kind)
      {
        case SyntaxKind.ClassConstraint:
        case SyntaxKind.StructConstraint:
          switch (classOrStructKeyword.Kind)
          {
            case SyntaxKind.None:
              switch (kind)
              {
                case SyntaxKind.ClassConstraint:
                  classOrStructKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.ClassKeyword);
                  goto label_7;
                case SyntaxKind.StructConstraint:
                  classOrStructKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.StructKeyword);
                  goto label_7;
                default:
                  goto label_7;
              }
            case SyntaxKind.ClassKeyword:
            case SyntaxKind.StructKeyword:
label_7:
              return (Roslyn.Compilers.CSharp.ClassOrStructConstraintSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.ClassOrStructConstraint(kind, classOrStructKeyword.Node));
            default:
              throw new ArgumentException("classOrStructKeyword");
          }
        default:
          throw new ArgumentException("kind");
      }
    }

    public static Roslyn.Compilers.CSharp.TypeConstraintSyntax TypeConstraint(Roslyn.Compilers.CSharp.TypeSyntax type)
    {
      if (type == null)
        throw new ArgumentNullException("type");
      else
        return (Roslyn.Compilers.CSharp.TypeConstraintSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.TypeConstraint(type == null ? (Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax) type.Green));
    }

    public static Roslyn.Compilers.CSharp.FieldDeclarationSyntax FieldDeclaration(Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.AttributeDeclarationSyntax> attributes = null, SyntaxTokenList modifiers = null, Roslyn.Compilers.CSharp.VariableDeclarationSyntax declaration = null, Roslyn.Compilers.CSharp.SyntaxToken semicolonToken = null)
    {
      if (declaration == null)
        throw new ArgumentNullException("declaration");
      switch (semicolonToken.Kind)
      {
        case SyntaxKind.None:
          semicolonToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.SemicolonToken);
          goto case SyntaxKind.SemicolonToken;
        case SyntaxKind.SemicolonToken:
          return (Roslyn.Compilers.CSharp.FieldDeclarationSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.FieldDeclaration(BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.AttributeDeclarationSyntax>((IBaseSyntaxNodeExt) attributes.Node), (Roslyn.Compilers.CSharp.InternalSyntax.SyntaxList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxToken>) BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxNode>((IBaseSyntaxNodeExt) modifiers.Node), declaration == null ? (Roslyn.Compilers.CSharp.InternalSyntax.VariableDeclarationSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.VariableDeclarationSyntax) declaration.Green, semicolonToken.Node));
        default:
          throw new ArgumentException("semicolonToken");
      }
    }

    public static Roslyn.Compilers.CSharp.EventFieldDeclarationSyntax EventFieldDeclaration(Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.AttributeDeclarationSyntax> attributes = null, SyntaxTokenList modifiers = null, Roslyn.Compilers.CSharp.SyntaxToken eventKeyword = null, Roslyn.Compilers.CSharp.VariableDeclarationSyntax declaration = null, Roslyn.Compilers.CSharp.SyntaxToken semicolonToken = null)
    {
      switch (eventKeyword.Kind)
      {
        case SyntaxKind.None:
          eventKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.EventKeyword);
          goto case SyntaxKind.EventKeyword;
        case SyntaxKind.EventKeyword:
          if (declaration == null)
            throw new ArgumentNullException("declaration");
          switch (semicolonToken.Kind)
          {
            case SyntaxKind.None:
              semicolonToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.SemicolonToken);
              goto case SyntaxKind.SemicolonToken;
            case SyntaxKind.SemicolonToken:
              return (Roslyn.Compilers.CSharp.EventFieldDeclarationSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.EventFieldDeclaration(BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.AttributeDeclarationSyntax>((IBaseSyntaxNodeExt) attributes.Node), (Roslyn.Compilers.CSharp.InternalSyntax.SyntaxList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxToken>) BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxNode>((IBaseSyntaxNodeExt) modifiers.Node), eventKeyword.Node, declaration == null ? (Roslyn.Compilers.CSharp.InternalSyntax.VariableDeclarationSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.VariableDeclarationSyntax) declaration.Green, semicolonToken.Node));
            default:
              throw new ArgumentException("semicolonToken");
          }
        default:
          throw new ArgumentException("eventKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.ExplicitInterfaceSpecifierSyntax ExplicitInterfaceSpecifier(Roslyn.Compilers.CSharp.NameSyntax name, Roslyn.Compilers.CSharp.SyntaxToken dotToken = null)
    {
      if (name == null)
        throw new ArgumentNullException("name");
      switch (dotToken.Kind)
      {
        case SyntaxKind.None:
          dotToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.DotToken);
          goto case SyntaxKind.DotToken;
        case SyntaxKind.DotToken:
          return (Roslyn.Compilers.CSharp.ExplicitInterfaceSpecifierSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.ExplicitInterfaceSpecifier(name == null ? (Roslyn.Compilers.CSharp.InternalSyntax.NameSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.NameSyntax) name.Green, dotToken.Node));
        default:
          throw new ArgumentException("dotToken");
      }
    }

    public static Roslyn.Compilers.CSharp.MethodDeclarationSyntax MethodDeclaration(Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.AttributeDeclarationSyntax> attributes = null, SyntaxTokenList modifiers = null, Roslyn.Compilers.CSharp.TypeSyntax returnType = null, Roslyn.Compilers.CSharp.ExplicitInterfaceSpecifierSyntax explicitInterfaceSpecifierOpt = null, Roslyn.Compilers.CSharp.SyntaxToken identifier = null, Roslyn.Compilers.CSharp.TypeParameterListSyntax typeParameterListOpt = null, Roslyn.Compilers.CSharp.ParameterListSyntax parameterList = null, Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.TypeParameterConstraintClauseSyntax> constraintClauses = null, Roslyn.Compilers.CSharp.BlockSyntax bodyOpt = null, Roslyn.Compilers.CSharp.SyntaxToken semicolonTokenOpt = null)
    {
      if (returnType == null)
        throw new ArgumentNullException("returnType");
      if (identifier.Kind != SyntaxKind.IdentifierToken)
        throw new ArgumentException("identifier");
      if (parameterList == null)
        throw new ArgumentNullException("parameterList");
      switch (semicolonTokenOpt.Kind)
      {
        case SyntaxKind.None:
        case SyntaxKind.SemicolonToken:
          return (Roslyn.Compilers.CSharp.MethodDeclarationSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.MethodDeclaration(BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.AttributeDeclarationSyntax>((IBaseSyntaxNodeExt) attributes.Node), (Roslyn.Compilers.CSharp.InternalSyntax.SyntaxList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxToken>) BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxNode>((IBaseSyntaxNodeExt) modifiers.Node), returnType == null ? (Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax) returnType.Green, explicitInterfaceSpecifierOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExplicitInterfaceSpecifierSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExplicitInterfaceSpecifierSyntax) explicitInterfaceSpecifierOpt.Green, identifier.Node, typeParameterListOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.TypeParameterListSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.TypeParameterListSyntax) typeParameterListOpt.Green, parameterList == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ParameterListSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ParameterListSyntax) parameterList.Green, BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.TypeParameterConstraintClauseSyntax>((IBaseSyntaxNodeExt) constraintClauses.Node), bodyOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.BlockSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.BlockSyntax) bodyOpt.Green, semicolonTokenOpt.Node));
        default:
          throw new ArgumentException("semicolonTokenOpt");
      }
    }

    public static Roslyn.Compilers.CSharp.OperatorDeclarationSyntax OperatorDeclaration(Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.AttributeDeclarationSyntax> attributes = null, SyntaxTokenList modifiers = null, Roslyn.Compilers.CSharp.TypeSyntax returnType = null, Roslyn.Compilers.CSharp.SyntaxToken operatorKeyword = null, Roslyn.Compilers.CSharp.SyntaxToken operatorToken = null, Roslyn.Compilers.CSharp.ParameterListSyntax parameterList = null, Roslyn.Compilers.CSharp.BlockSyntax bodyOpt = null, Roslyn.Compilers.CSharp.SyntaxToken semicolonTokenOpt = null)
    {
      if (returnType == null)
        throw new ArgumentNullException("returnType");
      switch (operatorKeyword.Kind)
      {
        case SyntaxKind.None:
          operatorKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.OperatorKeyword);
          goto case SyntaxKind.OperatorKeyword;
        case SyntaxKind.OperatorKeyword:
          switch (operatorToken.Kind)
          {
            case SyntaxKind.SlashToken:
            case SyntaxKind.MinusMinusToken:
            case SyntaxKind.PlusPlusToken:
            case SyntaxKind.ExclamationEqualsToken:
            case SyntaxKind.EqualsEqualsToken:
            case SyntaxKind.LessThanEqualsToken:
            case SyntaxKind.LessThanLessThanToken:
            case SyntaxKind.GreaterThanEqualsToken:
            case SyntaxKind.GreaterThanGreaterThanToken:
            case SyntaxKind.TrueKeyword:
            case SyntaxKind.FalseKeyword:
            case SyntaxKind.TildeToken:
            case SyntaxKind.ExclamationToken:
            case SyntaxKind.PercentToken:
            case SyntaxKind.CaretToken:
            case SyntaxKind.AmpersandToken:
            case SyntaxKind.AsteriskToken:
            case SyntaxKind.MinusToken:
            case SyntaxKind.PlusToken:
            case SyntaxKind.BarToken:
            case SyntaxKind.LessThanToken:
            case SyntaxKind.GreaterThanToken:
              if (parameterList == null)
                throw new ArgumentNullException("parameterList");
              switch (semicolonTokenOpt.Kind)
              {
                case SyntaxKind.None:
                case SyntaxKind.SemicolonToken:
                  return (Roslyn.Compilers.CSharp.OperatorDeclarationSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.OperatorDeclaration(BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.AttributeDeclarationSyntax>((IBaseSyntaxNodeExt) attributes.Node), (Roslyn.Compilers.CSharp.InternalSyntax.SyntaxList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxToken>) BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxNode>((IBaseSyntaxNodeExt) modifiers.Node), returnType == null ? (Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax) returnType.Green, operatorKeyword.Node, operatorToken.Node, parameterList == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ParameterListSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ParameterListSyntax) parameterList.Green, bodyOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.BlockSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.BlockSyntax) bodyOpt.Green, semicolonTokenOpt.Node));
                default:
                  throw new ArgumentException("semicolonTokenOpt");
              }
            default:
              throw new ArgumentException("operatorToken");
          }
        default:
          throw new ArgumentException("operatorKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.ConversionOperatorDeclarationSyntax ConversionOperatorDeclaration(Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.AttributeDeclarationSyntax> attributes = null, SyntaxTokenList modifiers = null, Roslyn.Compilers.CSharp.SyntaxToken implicitOrExplicitKeyword = null, Roslyn.Compilers.CSharp.SyntaxToken operatorKeyword = null, Roslyn.Compilers.CSharp.TypeSyntax type = null, Roslyn.Compilers.CSharp.ParameterListSyntax parameterList = null, Roslyn.Compilers.CSharp.BlockSyntax bodyOpt = null, Roslyn.Compilers.CSharp.SyntaxToken semicolonTokenOpt = null)
    {
      switch (implicitOrExplicitKeyword.Kind)
      {
        case SyntaxKind.ExplicitKeyword:
        case SyntaxKind.ImplicitKeyword:
          switch (operatorKeyword.Kind)
          {
            case SyntaxKind.None:
              operatorKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.OperatorKeyword);
              goto case SyntaxKind.OperatorKeyword;
            case SyntaxKind.OperatorKeyword:
              if (type == null)
                throw new ArgumentNullException("type");
              if (parameterList == null)
                throw new ArgumentNullException("parameterList");
              switch (semicolonTokenOpt.Kind)
              {
                case SyntaxKind.None:
                case SyntaxKind.SemicolonToken:
                  return (Roslyn.Compilers.CSharp.ConversionOperatorDeclarationSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.ConversionOperatorDeclaration(BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.AttributeDeclarationSyntax>((IBaseSyntaxNodeExt) attributes.Node), (Roslyn.Compilers.CSharp.InternalSyntax.SyntaxList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxToken>) BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxNode>((IBaseSyntaxNodeExt) modifiers.Node), implicitOrExplicitKeyword.Node, operatorKeyword.Node, type == null ? (Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax) type.Green, parameterList == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ParameterListSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ParameterListSyntax) parameterList.Green, bodyOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.BlockSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.BlockSyntax) bodyOpt.Green, semicolonTokenOpt.Node));
                default:
                  throw new ArgumentException("semicolonTokenOpt");
              }
            default:
              throw new ArgumentException("operatorKeyword");
          }
        default:
          throw new ArgumentException("implicitOrExplicitKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.ConstructorDeclarationSyntax ConstructorDeclaration(Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.AttributeDeclarationSyntax> attributes = null, SyntaxTokenList modifiers = null, Roslyn.Compilers.CSharp.SyntaxToken identifier = null, Roslyn.Compilers.CSharp.ParameterListSyntax parameterList = null, Roslyn.Compilers.CSharp.ConstructorInitializerSyntax initializerOpt = null, Roslyn.Compilers.CSharp.BlockSyntax bodyOpt = null, Roslyn.Compilers.CSharp.SyntaxToken semicolonTokenOpt = null)
    {
      if (identifier.Kind != SyntaxKind.IdentifierToken)
        throw new ArgumentException("identifier");
      if (parameterList == null)
        throw new ArgumentNullException("parameterList");
      switch (semicolonTokenOpt.Kind)
      {
        case SyntaxKind.None:
        case SyntaxKind.SemicolonToken:
          return (Roslyn.Compilers.CSharp.ConstructorDeclarationSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.ConstructorDeclaration(BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.AttributeDeclarationSyntax>((IBaseSyntaxNodeExt) attributes.Node), (Roslyn.Compilers.CSharp.InternalSyntax.SyntaxList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxToken>) BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxNode>((IBaseSyntaxNodeExt) modifiers.Node), identifier.Node, parameterList == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ParameterListSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ParameterListSyntax) parameterList.Green, initializerOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ConstructorInitializerSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ConstructorInitializerSyntax) initializerOpt.Green, bodyOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.BlockSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.BlockSyntax) bodyOpt.Green, semicolonTokenOpt.Node));
        default:
          throw new ArgumentException("semicolonTokenOpt");
      }
    }

    public static Roslyn.Compilers.CSharp.ConstructorInitializerSyntax ConstructorInitializer(SyntaxKind kind, Roslyn.Compilers.CSharp.SyntaxToken colonToken = null, Roslyn.Compilers.CSharp.SyntaxToken thisOrBaseKeyword = null, Roslyn.Compilers.CSharp.ArgumentListSyntax argumentList = null)
    {
      switch (kind)
      {
        case SyntaxKind.BaseConstructorInitializer:
        case SyntaxKind.ThisConstructorInitializer:
          switch (colonToken.Kind)
          {
            case SyntaxKind.None:
              colonToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.ColonToken);
              goto case SyntaxKind.ColonToken;
            case SyntaxKind.ColonToken:
              switch (thisOrBaseKeyword.Kind)
              {
                case SyntaxKind.None:
                  switch (kind)
                  {
                    case SyntaxKind.BaseConstructorInitializer:
                      thisOrBaseKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.BaseKeyword);
                      goto label_10;
                    case SyntaxKind.ThisConstructorInitializer:
                      thisOrBaseKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.ThisKeyword);
                      goto label_10;
                    default:
                      goto label_10;
                  }
                case SyntaxKind.ThisKeyword:
                case SyntaxKind.BaseKeyword:
label_10:
                  if (argumentList == null)
                    throw new ArgumentNullException("argumentList");
                  else
                    return (Roslyn.Compilers.CSharp.ConstructorInitializerSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.ConstructorInitializer(kind, colonToken.Node, thisOrBaseKeyword.Node, argumentList == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ArgumentListSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ArgumentListSyntax) argumentList.Green));
                default:
                  throw new ArgumentException("thisOrBaseKeyword");
              }
            default:
              throw new ArgumentException("colonToken");
          }
        default:
          throw new ArgumentException("kind");
      }
    }

    public static Roslyn.Compilers.CSharp.DestructorDeclarationSyntax DestructorDeclaration(Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.AttributeDeclarationSyntax> attributes = null, SyntaxTokenList modifiers = null, Roslyn.Compilers.CSharp.SyntaxToken tildeToken = null, Roslyn.Compilers.CSharp.SyntaxToken identifier = null, Roslyn.Compilers.CSharp.ParameterListSyntax parameterList = null, Roslyn.Compilers.CSharp.BlockSyntax bodyOpt = null, Roslyn.Compilers.CSharp.SyntaxToken semicolonTokenOpt = null)
    {
      switch (tildeToken.Kind)
      {
        case SyntaxKind.None:
          tildeToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.TildeToken);
          goto case 2;
        case SyntaxKind.TildeToken:
          if (identifier.Kind != SyntaxKind.IdentifierToken)
            throw new ArgumentException("identifier");
          if (parameterList == null)
            throw new ArgumentNullException("parameterList");
          switch (semicolonTokenOpt.Kind)
          {
            case SyntaxKind.None:
            case SyntaxKind.SemicolonToken:
              return (Roslyn.Compilers.CSharp.DestructorDeclarationSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.DestructorDeclaration(BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.AttributeDeclarationSyntax>((IBaseSyntaxNodeExt) attributes.Node), (Roslyn.Compilers.CSharp.InternalSyntax.SyntaxList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxToken>) BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxNode>((IBaseSyntaxNodeExt) modifiers.Node), tildeToken.Node, identifier.Node, parameterList == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ParameterListSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ParameterListSyntax) parameterList.Green, bodyOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.BlockSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.BlockSyntax) bodyOpt.Green, semicolonTokenOpt.Node));
            default:
              throw new ArgumentException("semicolonTokenOpt");
          }
        default:
          throw new ArgumentException("tildeToken");
      }
    }

    public static Roslyn.Compilers.CSharp.PropertyDeclarationSyntax PropertyDeclaration(Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.AttributeDeclarationSyntax> attributes = null, SyntaxTokenList modifiers = null, Roslyn.Compilers.CSharp.TypeSyntax type = null, Roslyn.Compilers.CSharp.ExplicitInterfaceSpecifierSyntax explicitInterfaceSpecifierOpt = null, Roslyn.Compilers.CSharp.SyntaxToken identifier = null, Roslyn.Compilers.CSharp.AccessorListSyntax accessorList = null)
    {
      if (type == null)
        throw new ArgumentNullException("type");
      if (identifier.Kind != SyntaxKind.IdentifierToken)
        throw new ArgumentException("identifier");
      if (accessorList == null)
        throw new ArgumentNullException("accessorList");
      else
        return (Roslyn.Compilers.CSharp.PropertyDeclarationSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.PropertyDeclaration(BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.AttributeDeclarationSyntax>((IBaseSyntaxNodeExt) attributes.Node), (Roslyn.Compilers.CSharp.InternalSyntax.SyntaxList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxToken>) BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxNode>((IBaseSyntaxNodeExt) modifiers.Node), type == null ? (Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax) type.Green, explicitInterfaceSpecifierOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExplicitInterfaceSpecifierSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExplicitInterfaceSpecifierSyntax) explicitInterfaceSpecifierOpt.Green, identifier.Node, accessorList == null ? (Roslyn.Compilers.CSharp.InternalSyntax.AccessorListSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.AccessorListSyntax) accessorList.Green));
    }

    public static Roslyn.Compilers.CSharp.EventDeclarationSyntax EventDeclaration(Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.AttributeDeclarationSyntax> attributes = null, SyntaxTokenList modifiers = null, Roslyn.Compilers.CSharp.SyntaxToken eventKeyword = null, Roslyn.Compilers.CSharp.TypeSyntax type = null, Roslyn.Compilers.CSharp.ExplicitInterfaceSpecifierSyntax explicitInterfaceSpecifierOpt = null, Roslyn.Compilers.CSharp.SyntaxToken identifier = null, Roslyn.Compilers.CSharp.AccessorListSyntax accessorList = null)
    {
      switch (eventKeyword.Kind)
      {
        case SyntaxKind.None:
          eventKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.EventKeyword);
          goto case SyntaxKind.EventKeyword;
        case SyntaxKind.EventKeyword:
          if (type == null)
            throw new ArgumentNullException("type");
          if (identifier.Kind != SyntaxKind.IdentifierToken)
            throw new ArgumentException("identifier");
          if (accessorList == null)
            throw new ArgumentNullException("accessorList");
          else
            return (Roslyn.Compilers.CSharp.EventDeclarationSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.EventDeclaration(BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.AttributeDeclarationSyntax>((IBaseSyntaxNodeExt) attributes.Node), (Roslyn.Compilers.CSharp.InternalSyntax.SyntaxList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxToken>) BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxNode>((IBaseSyntaxNodeExt) modifiers.Node), eventKeyword.Node, type == null ? (Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax) type.Green, explicitInterfaceSpecifierOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExplicitInterfaceSpecifierSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExplicitInterfaceSpecifierSyntax) explicitInterfaceSpecifierOpt.Green, identifier.Node, accessorList == null ? (Roslyn.Compilers.CSharp.InternalSyntax.AccessorListSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.AccessorListSyntax) accessorList.Green));
        default:
          throw new ArgumentException("eventKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.IndexerDeclarationSyntax IndexerDeclaration(Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.AttributeDeclarationSyntax> attributes = null, SyntaxTokenList modifiers = null, Roslyn.Compilers.CSharp.TypeSyntax type = null, Roslyn.Compilers.CSharp.ExplicitInterfaceSpecifierSyntax explicitInterfaceSpecifierOpt = null, Roslyn.Compilers.CSharp.SyntaxToken thisKeyword = null, Roslyn.Compilers.CSharp.BracketedParameterListSyntax parameterList = null, Roslyn.Compilers.CSharp.AccessorListSyntax accessorList = null)
    {
      if (type == null)
        throw new ArgumentNullException("type");
      switch (thisKeyword.Kind)
      {
        case SyntaxKind.None:
          thisKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.ThisKeyword);
          goto case SyntaxKind.ThisKeyword;
        case SyntaxKind.ThisKeyword:
          if (parameterList == null)
            throw new ArgumentNullException("parameterList");
          if (accessorList == null)
            throw new ArgumentNullException("accessorList");
          else
            return (Roslyn.Compilers.CSharp.IndexerDeclarationSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.IndexerDeclaration(BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.AttributeDeclarationSyntax>((IBaseSyntaxNodeExt) attributes.Node), (Roslyn.Compilers.CSharp.InternalSyntax.SyntaxList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxToken>) BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxNode>((IBaseSyntaxNodeExt) modifiers.Node), type == null ? (Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax) type.Green, explicitInterfaceSpecifierOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExplicitInterfaceSpecifierSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExplicitInterfaceSpecifierSyntax) explicitInterfaceSpecifierOpt.Green, thisKeyword.Node, parameterList == null ? (Roslyn.Compilers.CSharp.InternalSyntax.BracketedParameterListSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.BracketedParameterListSyntax) parameterList.Green, accessorList == null ? (Roslyn.Compilers.CSharp.InternalSyntax.AccessorListSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.AccessorListSyntax) accessorList.Green));
        default:
          throw new ArgumentException("thisKeyword");
      }
    }

    public static Roslyn.Compilers.CSharp.AccessorListSyntax AccessorList(Roslyn.Compilers.CSharp.SyntaxToken openBraceToken = null, Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.AccessorDeclarationSyntax> accessors = null, Roslyn.Compilers.CSharp.SyntaxToken closeBraceToken = null)
    {
      switch (openBraceToken.Kind)
      {
        case SyntaxKind.None:
          openBraceToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.OpenBraceToken);
          goto case SyntaxKind.OpenBraceToken;
        case SyntaxKind.OpenBraceToken:
          switch (closeBraceToken.Kind)
          {
            case SyntaxKind.None:
              closeBraceToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.CloseBraceToken);
              goto case SyntaxKind.CloseBraceToken;
            case SyntaxKind.CloseBraceToken:
              return (Roslyn.Compilers.CSharp.AccessorListSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.AccessorList(openBraceToken.Node, BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.AccessorDeclarationSyntax>((IBaseSyntaxNodeExt) accessors.Node), closeBraceToken.Node));
            default:
              throw new ArgumentException("closeBraceToken");
          }
        default:
          throw new ArgumentException("openBraceToken");
      }
    }

    public static Roslyn.Compilers.CSharp.AccessorDeclarationSyntax AccessorDeclaration(SyntaxKind kind, Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.AttributeDeclarationSyntax> attributes = null, SyntaxTokenList modifiers = null, Roslyn.Compilers.CSharp.SyntaxToken keyword = null, Roslyn.Compilers.CSharp.BlockSyntax bodyOpt = null, Roslyn.Compilers.CSharp.SyntaxToken semicolonTokenOpt = null)
    {
      switch (kind)
      {
        case SyntaxKind.GetAccessorDeclaration:
        case SyntaxKind.SetAccessorDeclaration:
        case SyntaxKind.AddAccessorDeclaration:
        case SyntaxKind.RemoveAccessorDeclaration:
        case SyntaxKind.UnknownAccessorDeclaration:
          switch (keyword.Kind)
          {
            case SyntaxKind.None:
              switch (kind)
              {
                case SyntaxKind.GetAccessorDeclaration:
                  keyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.GetKeyword);
                  goto label_10;
                case SyntaxKind.SetAccessorDeclaration:
                  keyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.SetKeyword);
                  goto label_10;
                case SyntaxKind.AddAccessorDeclaration:
                  keyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.AddKeyword);
                  goto label_10;
                case SyntaxKind.RemoveAccessorDeclaration:
                  keyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.RemoveKeyword);
                  goto label_10;
                default:
                  throw new ArgumentException("keyword");
              }
            case SyntaxKind.GetKeyword:
            case SyntaxKind.SetKeyword:
            case SyntaxKind.AddKeyword:
            case SyntaxKind.RemoveKeyword:
            case SyntaxKind.IdentifierToken:
label_10:
              switch (semicolonTokenOpt.Kind)
              {
                case SyntaxKind.None:
                case SyntaxKind.SemicolonToken:
                  return (Roslyn.Compilers.CSharp.AccessorDeclarationSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.AccessorDeclaration(kind, BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.AttributeDeclarationSyntax>((IBaseSyntaxNodeExt) attributes.Node), (Roslyn.Compilers.CSharp.InternalSyntax.SyntaxList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxToken>) BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxNode>((IBaseSyntaxNodeExt) modifiers.Node), keyword.Node, bodyOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.BlockSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.BlockSyntax) bodyOpt.Green, semicolonTokenOpt.Node));
                default:
                  throw new ArgumentException("semicolonTokenOpt");
              }
            default:
              throw new ArgumentException("keyword");
          }
        default:
          throw new ArgumentException("kind");
      }
    }

    public static Roslyn.Compilers.CSharp.ParameterListSyntax ParameterList(Roslyn.Compilers.CSharp.SyntaxToken openParenToken = null, SeparatedSyntaxList<Roslyn.Compilers.CSharp.ParameterSyntax> parameters = null, Roslyn.Compilers.CSharp.SyntaxToken closeParenToken = null)
    {
      switch (openParenToken.Kind)
      {
        case SyntaxKind.None:
          openParenToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.OpenParenToken);
          goto case SyntaxKind.OpenParenToken;
        case SyntaxKind.OpenParenToken:
          switch (closeParenToken.Kind)
          {
            case SyntaxKind.None:
              closeParenToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.CloseParenToken);
              goto case SyntaxKind.CloseParenToken;
            case SyntaxKind.CloseParenToken:
              return (Roslyn.Compilers.CSharp.ParameterListSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.ParameterList(openParenToken.Node, BaseSyntaxNodeExtensions.ToGreenSeparatedList<Roslyn.Compilers.CSharp.InternalSyntax.ParameterSyntax>(parameters.Node), closeParenToken.Node));
            default:
              throw new ArgumentException("closeParenToken");
          }
        default:
          throw new ArgumentException("openParenToken");
      }
    }

    public static Roslyn.Compilers.CSharp.BracketedParameterListSyntax BracketedParameterList(Roslyn.Compilers.CSharp.SyntaxToken openBracketToken = null, SeparatedSyntaxList<Roslyn.Compilers.CSharp.ParameterSyntax> parameters = null, Roslyn.Compilers.CSharp.SyntaxToken closeBracketToken = null)
    {
      switch (openBracketToken.Kind)
      {
        case SyntaxKind.None:
          openBracketToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.OpenBracketToken);
          goto case SyntaxKind.OpenBracketToken;
        case SyntaxKind.OpenBracketToken:
          switch (closeBracketToken.Kind)
          {
            case SyntaxKind.None:
              closeBracketToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.CloseBracketToken);
              goto case SyntaxKind.CloseBracketToken;
            case SyntaxKind.CloseBracketToken:
              return (Roslyn.Compilers.CSharp.BracketedParameterListSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.BracketedParameterList(openBracketToken.Node, BaseSyntaxNodeExtensions.ToGreenSeparatedList<Roslyn.Compilers.CSharp.InternalSyntax.ParameterSyntax>(parameters.Node), closeBracketToken.Node));
            default:
              throw new ArgumentException("closeBracketToken");
          }
        default:
          throw new ArgumentException("openBracketToken");
      }
    }

    public static Roslyn.Compilers.CSharp.ParameterSyntax Parameter(Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.AttributeDeclarationSyntax> attributes = null, SyntaxTokenList modifiers = null, Roslyn.Compilers.CSharp.TypeSyntax typeOpt = null, Roslyn.Compilers.CSharp.SyntaxToken identifier = null, Roslyn.Compilers.CSharp.EqualsValueClauseSyntax defaultOpt = null)
    {
      switch (identifier.Kind)
      {
        case SyntaxKind.ArgListKeyword:
        case SyntaxKind.IdentifierToken:
          return (Roslyn.Compilers.CSharp.ParameterSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.Parameter(BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.AttributeDeclarationSyntax>((IBaseSyntaxNodeExt) attributes.Node), (Roslyn.Compilers.CSharp.InternalSyntax.SyntaxList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxToken>) BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxNode>((IBaseSyntaxNodeExt) modifiers.Node), typeOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax) typeOpt.Green, identifier.Node, defaultOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.EqualsValueClauseSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.EqualsValueClauseSyntax) defaultOpt.Green));
        default:
          throw new ArgumentException("identifier");
      }
    }

    public static Roslyn.Compilers.CSharp.IncompleteMemberSyntax IncompleteMember(Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.AttributeDeclarationSyntax> attributes = null, SyntaxTokenList modifiers = null, Roslyn.Compilers.CSharp.TypeSyntax typeOpt = null)
    {
      return (Roslyn.Compilers.CSharp.IncompleteMemberSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.IncompleteMember(BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.AttributeDeclarationSyntax>((IBaseSyntaxNodeExt) attributes.Node), (Roslyn.Compilers.CSharp.InternalSyntax.SyntaxList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxToken>) BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxNode>((IBaseSyntaxNodeExt) modifiers.Node), typeOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.TypeSyntax) typeOpt.Green));
    }

    public static Roslyn.Compilers.CSharp.SkippedTokensSyntax SkippedTokens(SyntaxTokenList tokens = null)
    {
      return (Roslyn.Compilers.CSharp.SkippedTokensSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.SkippedTokens((Roslyn.Compilers.CSharp.InternalSyntax.SyntaxList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxToken>) BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxNode>((IBaseSyntaxNodeExt) tokens.Node)));
    }

    public static Roslyn.Compilers.CSharp.DocumentationCommentSyntax DocumentationComment(Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.XmlNodeSyntax> nodes = null, Roslyn.Compilers.CSharp.SyntaxToken endOfComment = null)
    {
      switch (endOfComment.Kind)
      {
        case SyntaxKind.None:
          endOfComment = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.EndOfDocumentationCommentToken);
          goto case SyntaxKind.EndOfDocumentationCommentToken;
        case SyntaxKind.EndOfDocumentationCommentToken:
          return (Roslyn.Compilers.CSharp.DocumentationCommentSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.DocumentationComment(BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.XmlNodeSyntax>((IBaseSyntaxNodeExt) nodes.Node), endOfComment.Node));
        default:
          throw new ArgumentException("endOfComment");
      }
    }

    public static Roslyn.Compilers.CSharp.XmlElementSyntax XmlElement(Roslyn.Compilers.CSharp.XmlElementStartTagSyntax startTag, Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.XmlNodeSyntax> content = null, Roslyn.Compilers.CSharp.XmlElementEndTagSyntax endTag = null)
    {
      if (startTag == null)
        throw new ArgumentNullException("startTag");
      if (endTag == null)
        throw new ArgumentNullException("endTag");
      else
        return (Roslyn.Compilers.CSharp.XmlElementSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.XmlElement(startTag == null ? (Roslyn.Compilers.CSharp.InternalSyntax.XmlElementStartTagSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.XmlElementStartTagSyntax) startTag.Green, BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.XmlNodeSyntax>((IBaseSyntaxNodeExt) content.Node), endTag == null ? (Roslyn.Compilers.CSharp.InternalSyntax.XmlElementEndTagSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.XmlElementEndTagSyntax) endTag.Green));
    }

    public static Roslyn.Compilers.CSharp.XmlElementStartTagSyntax XmlElementStartTag(Roslyn.Compilers.CSharp.SyntaxToken lessThanToken = null, Roslyn.Compilers.CSharp.XmlNameSyntax name = null, Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.XmlAttributeSyntax> attributes = null, Roslyn.Compilers.CSharp.SyntaxToken greaterThanToken = null)
    {
      switch (lessThanToken.Kind)
      {
        case SyntaxKind.None:
          lessThanToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.LessThanToken);
          goto case SyntaxKind.LessThanToken;
        case SyntaxKind.LessThanToken:
          if (name == null)
            throw new ArgumentNullException("name");
          switch (greaterThanToken.Kind)
          {
            case SyntaxKind.None:
              greaterThanToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.GreaterThanToken);
              goto case SyntaxKind.GreaterThanToken;
            case SyntaxKind.GreaterThanToken:
              return (Roslyn.Compilers.CSharp.XmlElementStartTagSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.XmlElementStartTag(lessThanToken.Node, name == null ? (Roslyn.Compilers.CSharp.InternalSyntax.XmlNameSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.XmlNameSyntax) name.Green, BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.XmlAttributeSyntax>((IBaseSyntaxNodeExt) attributes.Node), greaterThanToken.Node));
            default:
              throw new ArgumentException("greaterThanToken");
          }
        default:
          throw new ArgumentException("lessThanToken");
      }
    }

    public static Roslyn.Compilers.CSharp.XmlElementEndTagSyntax XmlElementEndTag(Roslyn.Compilers.CSharp.SyntaxToken lessThanSlashToken = null, Roslyn.Compilers.CSharp.XmlNameSyntax name = null, Roslyn.Compilers.CSharp.SyntaxToken greaterThanToken = null)
    {
      switch (lessThanSlashToken.Kind)
      {
        case SyntaxKind.None:
          lessThanSlashToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.LessThanSlashToken);
          goto case SyntaxKind.LessThanSlashToken;
        case SyntaxKind.LessThanSlashToken:
          if (name == null)
            throw new ArgumentNullException("name");
          switch (greaterThanToken.Kind)
          {
            case SyntaxKind.None:
              greaterThanToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.GreaterThanToken);
              goto case SyntaxKind.GreaterThanToken;
            case SyntaxKind.GreaterThanToken:
              return (Roslyn.Compilers.CSharp.XmlElementEndTagSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.XmlElementEndTag(lessThanSlashToken.Node, name == null ? (Roslyn.Compilers.CSharp.InternalSyntax.XmlNameSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.XmlNameSyntax) name.Green, greaterThanToken.Node));
            default:
              throw new ArgumentException("greaterThanToken");
          }
        default:
          throw new ArgumentException("lessThanSlashToken");
      }
    }

    public static Roslyn.Compilers.CSharp.XmlEmptyElementSyntax XmlEmptyElement(Roslyn.Compilers.CSharp.SyntaxToken lessThanToken = null, Roslyn.Compilers.CSharp.XmlNameSyntax name = null, Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.XmlAttributeSyntax> attributes = null, Roslyn.Compilers.CSharp.SyntaxToken slashGreaterThanToken = null)
    {
      switch (lessThanToken.Kind)
      {
        case SyntaxKind.None:
          lessThanToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.LessThanToken);
          goto case SyntaxKind.LessThanToken;
        case SyntaxKind.LessThanToken:
          if (name == null)
            throw new ArgumentNullException("name");
          switch (slashGreaterThanToken.Kind)
          {
            case SyntaxKind.None:
              slashGreaterThanToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.SlashGreaterThanToken);
              goto case SyntaxKind.SlashGreaterThanToken;
            case SyntaxKind.SlashGreaterThanToken:
              return (Roslyn.Compilers.CSharp.XmlEmptyElementSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.XmlEmptyElement(lessThanToken.Node, name == null ? (Roslyn.Compilers.CSharp.InternalSyntax.XmlNameSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.XmlNameSyntax) name.Green, BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.XmlAttributeSyntax>((IBaseSyntaxNodeExt) attributes.Node), slashGreaterThanToken.Node));
            default:
              throw new ArgumentException("slashGreaterThanToken");
          }
        default:
          throw new ArgumentException("lessThanToken");
      }
    }

    public static Roslyn.Compilers.CSharp.XmlNameSyntax XmlName(Roslyn.Compilers.CSharp.XmlPrefixSyntax prefixOpt = null, Roslyn.Compilers.CSharp.SyntaxToken localName = null)
    {
      if (localName.Kind != SyntaxKind.IdentifierToken)
        throw new ArgumentException("localName");
      else
        return (Roslyn.Compilers.CSharp.XmlNameSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.XmlName(prefixOpt == null ? (Roslyn.Compilers.CSharp.InternalSyntax.XmlPrefixSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.XmlPrefixSyntax) prefixOpt.Green, localName.Node));
    }

    public static Roslyn.Compilers.CSharp.XmlPrefixSyntax XmlPrefix(Roslyn.Compilers.CSharp.SyntaxToken prefix, Roslyn.Compilers.CSharp.SyntaxToken colonToken = null)
    {
      if (prefix.Kind != SyntaxKind.IdentifierToken)
        throw new ArgumentException("prefix");
      switch (colonToken.Kind)
      {
        case SyntaxKind.None:
          colonToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.ColonToken);
          goto case SyntaxKind.ColonToken;
        case SyntaxKind.ColonToken:
          return (Roslyn.Compilers.CSharp.XmlPrefixSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.XmlPrefix(prefix.Node, colonToken.Node));
        default:
          throw new ArgumentException("colonToken");
      }
    }

    public static Roslyn.Compilers.CSharp.XmlAttributeSyntax XmlAttribute(Roslyn.Compilers.CSharp.XmlNameSyntax name, Roslyn.Compilers.CSharp.SyntaxToken equalsToken = null, Roslyn.Compilers.CSharp.SyntaxToken startQuoteToken = null, SyntaxTokenList textTokens = null, Roslyn.Compilers.CSharp.SyntaxToken endQuoteToken = null)
    {
      if (name == null)
        throw new ArgumentNullException("name");
      switch (equalsToken.Kind)
      {
        case SyntaxKind.None:
          equalsToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.EqualsToken);
          goto case SyntaxKind.EqualsToken;
        case SyntaxKind.EqualsToken:
          switch (startQuoteToken.Kind)
          {
            case SyntaxKind.DoubleQuoteToken:
            case SyntaxKind.SingleQuoteToken:
              switch (endQuoteToken.Kind)
              {
                case SyntaxKind.DoubleQuoteToken:
                case SyntaxKind.SingleQuoteToken:
                  return (Roslyn.Compilers.CSharp.XmlAttributeSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.XmlAttribute(name == null ? (Roslyn.Compilers.CSharp.InternalSyntax.XmlNameSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.XmlNameSyntax) name.Green, equalsToken.Node, startQuoteToken.Node, (Roslyn.Compilers.CSharp.InternalSyntax.SyntaxList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxToken>) BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxNode>((IBaseSyntaxNodeExt) textTokens.Node), endQuoteToken.Node));
                default:
                  throw new ArgumentException("endQuoteToken");
              }
            default:
              throw new ArgumentException("startQuoteToken");
          }
        default:
          throw new ArgumentException("equalsToken");
      }
    }

    public static Roslyn.Compilers.CSharp.XmlTextSyntax XmlText(SyntaxTokenList textTokens = null)
    {
      return (Roslyn.Compilers.CSharp.XmlTextSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.XmlText((Roslyn.Compilers.CSharp.InternalSyntax.SyntaxList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxToken>) BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxNode>((IBaseSyntaxNodeExt) textTokens.Node)));
    }

    public static Roslyn.Compilers.CSharp.XmlCDataSectionSyntax XmlCDataSection(Roslyn.Compilers.CSharp.SyntaxToken startCDataToken = null, SyntaxTokenList textTokens = null, Roslyn.Compilers.CSharp.SyntaxToken endCDataToken = null)
    {
      switch (startCDataToken.Kind)
      {
        case SyntaxKind.None:
          startCDataToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.XmlCDataStartToken);
          goto case SyntaxKind.XmlCDataStartToken;
        case SyntaxKind.XmlCDataStartToken:
          switch (endCDataToken.Kind)
          {
            case SyntaxKind.None:
              endCDataToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.XmlCDataEndToken);
              goto case SyntaxKind.XmlCDataEndToken;
            case SyntaxKind.XmlCDataEndToken:
              return (Roslyn.Compilers.CSharp.XmlCDataSectionSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.XmlCDataSection(startCDataToken.Node, (Roslyn.Compilers.CSharp.InternalSyntax.SyntaxList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxToken>) BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxNode>((IBaseSyntaxNodeExt) textTokens.Node), endCDataToken.Node));
            default:
              throw new ArgumentException("endCDataToken");
          }
        default:
          throw new ArgumentException("startCDataToken");
      }
    }

    public static Roslyn.Compilers.CSharp.XmlProcessingInstructionSyntax XmlProcessingInstruction(Roslyn.Compilers.CSharp.SyntaxToken startProcessingInstructionToken = null, Roslyn.Compilers.CSharp.XmlNameSyntax name = null, SyntaxTokenList textTokens = null, Roslyn.Compilers.CSharp.SyntaxToken endProcessingInstructionToken = null)
    {
      switch (startProcessingInstructionToken.Kind)
      {
        case SyntaxKind.None:
          startProcessingInstructionToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.XmlProcessingInstructionStartToken);
          goto case SyntaxKind.XmlProcessingInstructionStartToken;
        case SyntaxKind.XmlProcessingInstructionStartToken:
          if (name == null)
            throw new ArgumentNullException("name");
          switch (endProcessingInstructionToken.Kind)
          {
            case SyntaxKind.None:
              endProcessingInstructionToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.XmlProcessingInstructionEndToken);
              goto case SyntaxKind.XmlProcessingInstructionEndToken;
            case SyntaxKind.XmlProcessingInstructionEndToken:
              return (Roslyn.Compilers.CSharp.XmlProcessingInstructionSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.XmlProcessingInstruction(startProcessingInstructionToken.Node, name == null ? (Roslyn.Compilers.CSharp.InternalSyntax.XmlNameSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.XmlNameSyntax) name.Green, (Roslyn.Compilers.CSharp.InternalSyntax.SyntaxList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxToken>) BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxNode>((IBaseSyntaxNodeExt) textTokens.Node), endProcessingInstructionToken.Node));
            default:
              throw new ArgumentException("endProcessingInstructionToken");
          }
        default:
          throw new ArgumentException("startProcessingInstructionToken");
      }
    }

    public static Roslyn.Compilers.CSharp.XmlCommentSyntax XmlComment(Roslyn.Compilers.CSharp.SyntaxToken lessThanExclamationMinusMinusToken = null, SyntaxTokenList textTokens = null, Roslyn.Compilers.CSharp.SyntaxToken minusMinusGreaterThanToken = null)
    {
      switch (lessThanExclamationMinusMinusToken.Kind)
      {
        case SyntaxKind.None:
          lessThanExclamationMinusMinusToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.XmlCommentStartToken);
          goto case SyntaxKind.XmlCommentStartToken;
        case SyntaxKind.XmlCommentStartToken:
          switch (minusMinusGreaterThanToken.Kind)
          {
            case SyntaxKind.None:
              minusMinusGreaterThanToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.XmlCommentEndToken);
              goto case SyntaxKind.XmlCommentEndToken;
            case SyntaxKind.XmlCommentEndToken:
              return (Roslyn.Compilers.CSharp.XmlCommentSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.XmlComment(lessThanExclamationMinusMinusToken.Node, (Roslyn.Compilers.CSharp.InternalSyntax.SyntaxList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxToken>) BaseSyntaxNodeExtensions.ToGreenList<Roslyn.Compilers.CSharp.InternalSyntax.SyntaxNode>((IBaseSyntaxNodeExt) textTokens.Node), minusMinusGreaterThanToken.Node));
            default:
              throw new ArgumentException("minusMinusGreaterThanToken");
          }
        default:
          throw new ArgumentException("lessThanExclamationMinusMinusToken");
      }
    }

    public static Roslyn.Compilers.CSharp.IfDirectiveSyntax IfDirective(Roslyn.Compilers.CSharp.SyntaxToken hashToken = null, Roslyn.Compilers.CSharp.SyntaxToken ifKeyword = null, Roslyn.Compilers.CSharp.ExpressionSyntax condition = null, Roslyn.Compilers.CSharp.SyntaxToken endOfDirectiveToken = null, bool isActive = false, bool branchTaken = false, bool conditionValue = false)
    {
      switch (hashToken.Kind)
      {
        case SyntaxKind.None:
          hashToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.HashToken);
          goto case SyntaxKind.HashToken;
        case SyntaxKind.HashToken:
          switch (ifKeyword.Kind)
          {
            case SyntaxKind.None:
              ifKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.IfKeyword);
              goto case SyntaxKind.IfKeyword;
            case SyntaxKind.IfKeyword:
              if (condition == null)
                throw new ArgumentNullException("condition");
              switch (endOfDirectiveToken.Kind)
              {
                case SyntaxKind.None:
                  endOfDirectiveToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.EndOfDirectiveToken);
                  goto case SyntaxKind.EndOfDirectiveToken;
                case SyntaxKind.EndOfDirectiveToken:
                  return (Roslyn.Compilers.CSharp.IfDirectiveSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.IfDirective(hashToken.Node, ifKeyword.Node, condition == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) condition.Green, endOfDirectiveToken.Node, isActive, branchTaken, conditionValue));
                default:
                  throw new ArgumentException("endOfDirectiveToken");
              }
            default:
              throw new ArgumentException("ifKeyword");
          }
        default:
          throw new ArgumentException("hashToken");
      }
    }

    public static Roslyn.Compilers.CSharp.ElifDirectiveSyntax ElifDirective(Roslyn.Compilers.CSharp.SyntaxToken hashToken = null, Roslyn.Compilers.CSharp.SyntaxToken elifKeyword = null, Roslyn.Compilers.CSharp.ExpressionSyntax condition = null, Roslyn.Compilers.CSharp.SyntaxToken endOfDirectiveToken = null, bool isActive = false, bool branchTaken = false, bool conditionValue = false)
    {
      switch (hashToken.Kind)
      {
        case SyntaxKind.None:
          hashToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.HashToken);
          goto case SyntaxKind.HashToken;
        case SyntaxKind.HashToken:
          switch (elifKeyword.Kind)
          {
            case SyntaxKind.None:
              elifKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.ElifKeyword);
              goto case SyntaxKind.ElifKeyword;
            case SyntaxKind.ElifKeyword:
              if (condition == null)
                throw new ArgumentNullException("condition");
              switch (endOfDirectiveToken.Kind)
              {
                case SyntaxKind.None:
                  endOfDirectiveToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.EndOfDirectiveToken);
                  goto case SyntaxKind.EndOfDirectiveToken;
                case SyntaxKind.EndOfDirectiveToken:
                  return (Roslyn.Compilers.CSharp.ElifDirectiveSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.ElifDirective(hashToken.Node, elifKeyword.Node, condition == null ? (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) null : (Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax) condition.Green, endOfDirectiveToken.Node, isActive, branchTaken, conditionValue));
                default:
                  throw new ArgumentException("endOfDirectiveToken");
              }
            default:
              throw new ArgumentException("elifKeyword");
          }
        default:
          throw new ArgumentException("hashToken");
      }
    }

    public static Roslyn.Compilers.CSharp.ElseDirectiveSyntax ElseDirective(Roslyn.Compilers.CSharp.SyntaxToken hashToken = null, Roslyn.Compilers.CSharp.SyntaxToken elseKeyword = null, Roslyn.Compilers.CSharp.SyntaxToken endOfDirectiveToken = null, bool isActive = false, bool branchTaken = false)
    {
      switch (hashToken.Kind)
      {
        case SyntaxKind.None:
          hashToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.HashToken);
          goto case SyntaxKind.HashToken;
        case SyntaxKind.HashToken:
          switch (elseKeyword.Kind)
          {
            case SyntaxKind.None:
              elseKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.ElseKeyword);
              goto case SyntaxKind.ElseKeyword;
            case SyntaxKind.ElseKeyword:
              switch (endOfDirectiveToken.Kind)
              {
                case SyntaxKind.None:
                  endOfDirectiveToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.EndOfDirectiveToken);
                  goto case SyntaxKind.EndOfDirectiveToken;
                case SyntaxKind.EndOfDirectiveToken:
                  return (Roslyn.Compilers.CSharp.ElseDirectiveSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.ElseDirective(hashToken.Node, elseKeyword.Node, endOfDirectiveToken.Node, isActive, branchTaken));
                default:
                  throw new ArgumentException("endOfDirectiveToken");
              }
            default:
              throw new ArgumentException("elseKeyword");
          }
        default:
          throw new ArgumentException("hashToken");
      }
    }

    public static Roslyn.Compilers.CSharp.EndIfDirectiveSyntax EndIfDirective(Roslyn.Compilers.CSharp.SyntaxToken hashToken = null, Roslyn.Compilers.CSharp.SyntaxToken endIfKeyword = null, Roslyn.Compilers.CSharp.SyntaxToken endOfDirectiveToken = null, bool isActive = false)
    {
      switch (hashToken.Kind)
      {
        case SyntaxKind.None:
          hashToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.HashToken);
          goto case SyntaxKind.HashToken;
        case SyntaxKind.HashToken:
          switch (endIfKeyword.Kind)
          {
            case SyntaxKind.None:
              endIfKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.EndIfKeyword);
              goto case SyntaxKind.EndIfKeyword;
            case SyntaxKind.EndIfKeyword:
              switch (endOfDirectiveToken.Kind)
              {
                case SyntaxKind.None:
                  endOfDirectiveToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.EndOfDirectiveToken);
                  goto case SyntaxKind.EndOfDirectiveToken;
                case SyntaxKind.EndOfDirectiveToken:
                  return (Roslyn.Compilers.CSharp.EndIfDirectiveSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.EndIfDirective(hashToken.Node, endIfKeyword.Node, endOfDirectiveToken.Node, isActive));
                default:
                  throw new ArgumentException("endOfDirectiveToken");
              }
            default:
              throw new ArgumentException("endIfKeyword");
          }
        default:
          throw new ArgumentException("hashToken");
      }
    }

    public static Roslyn.Compilers.CSharp.RegionDirectiveSyntax RegionDirective(Roslyn.Compilers.CSharp.SyntaxToken hashToken = null, Roslyn.Compilers.CSharp.SyntaxToken regionKeyword = null, Roslyn.Compilers.CSharp.SyntaxToken endOfDirectiveToken = null, bool isActive = false)
    {
      switch (hashToken.Kind)
      {
        case SyntaxKind.None:
          hashToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.HashToken);
          goto case SyntaxKind.HashToken;
        case SyntaxKind.HashToken:
          switch (regionKeyword.Kind)
          {
            case SyntaxKind.None:
              regionKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.RegionKeyword);
              goto case SyntaxKind.RegionKeyword;
            case SyntaxKind.RegionKeyword:
              switch (endOfDirectiveToken.Kind)
              {
                case SyntaxKind.None:
                  endOfDirectiveToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.EndOfDirectiveToken);
                  goto case SyntaxKind.EndOfDirectiveToken;
                case SyntaxKind.EndOfDirectiveToken:
                  return (Roslyn.Compilers.CSharp.RegionDirectiveSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.RegionDirective(hashToken.Node, regionKeyword.Node, endOfDirectiveToken.Node, isActive));
                default:
                  throw new ArgumentException("endOfDirectiveToken");
              }
            default:
              throw new ArgumentException("regionKeyword");
          }
        default:
          throw new ArgumentException("hashToken");
      }
    }

    public static Roslyn.Compilers.CSharp.EndRegionDirectiveSyntax EndRegionDirective(Roslyn.Compilers.CSharp.SyntaxToken hashToken = null, Roslyn.Compilers.CSharp.SyntaxToken endRegionKeyword = null, Roslyn.Compilers.CSharp.SyntaxToken endOfDirectiveToken = null, bool isActive = false)
    {
      switch (hashToken.Kind)
      {
        case SyntaxKind.None:
          hashToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.HashToken);
          goto case SyntaxKind.HashToken;
        case SyntaxKind.HashToken:
          switch (endRegionKeyword.Kind)
          {
            case SyntaxKind.None:
              endRegionKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.EndRegionKeyword);
              goto case SyntaxKind.EndRegionKeyword;
            case SyntaxKind.EndRegionKeyword:
              switch (endOfDirectiveToken.Kind)
              {
                case SyntaxKind.None:
                  endOfDirectiveToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.EndOfDirectiveToken);
                  goto case SyntaxKind.EndOfDirectiveToken;
                case SyntaxKind.EndOfDirectiveToken:
                  return (Roslyn.Compilers.CSharp.EndRegionDirectiveSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.EndRegionDirective(hashToken.Node, endRegionKeyword.Node, endOfDirectiveToken.Node, isActive));
                default:
                  throw new ArgumentException("endOfDirectiveToken");
              }
            default:
              throw new ArgumentException("endRegionKeyword");
          }
        default:
          throw new ArgumentException("hashToken");
      }
    }

    public static Roslyn.Compilers.CSharp.ErrorDirectiveSyntax ErrorDirective(Roslyn.Compilers.CSharp.SyntaxToken hashToken = null, Roslyn.Compilers.CSharp.SyntaxToken errorKeyword = null, Roslyn.Compilers.CSharp.SyntaxToken endOfDirectiveToken = null, bool isActive = false)
    {
      switch (hashToken.Kind)
      {
        case SyntaxKind.None:
          hashToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.HashToken);
          goto case SyntaxKind.HashToken;
        case SyntaxKind.HashToken:
          switch (errorKeyword.Kind)
          {
            case SyntaxKind.None:
              errorKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.ErrorKeyword);
              goto case SyntaxKind.ErrorKeyword;
            case SyntaxKind.ErrorKeyword:
              switch (endOfDirectiveToken.Kind)
              {
                case SyntaxKind.None:
                  endOfDirectiveToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.EndOfDirectiveToken);
                  goto case SyntaxKind.EndOfDirectiveToken;
                case SyntaxKind.EndOfDirectiveToken:
                  return (Roslyn.Compilers.CSharp.ErrorDirectiveSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.ErrorDirective(hashToken.Node, errorKeyword.Node, endOfDirectiveToken.Node, isActive));
                default:
                  throw new ArgumentException("endOfDirectiveToken");
              }
            default:
              throw new ArgumentException("errorKeyword");
          }
        default:
          throw new ArgumentException("hashToken");
      }
    }

    public static Roslyn.Compilers.CSharp.WarningDirectiveSyntax WarningDirective(Roslyn.Compilers.CSharp.SyntaxToken hashToken = null, Roslyn.Compilers.CSharp.SyntaxToken warningKeyword = null, Roslyn.Compilers.CSharp.SyntaxToken endOfDirectiveToken = null, bool isActive = false)
    {
      switch (hashToken.Kind)
      {
        case SyntaxKind.None:
          hashToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.HashToken);
          goto case SyntaxKind.HashToken;
        case SyntaxKind.HashToken:
          switch (warningKeyword.Kind)
          {
            case SyntaxKind.None:
              warningKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.WarningKeyword);
              goto case SyntaxKind.WarningKeyword;
            case SyntaxKind.WarningKeyword:
              switch (endOfDirectiveToken.Kind)
              {
                case SyntaxKind.None:
                  endOfDirectiveToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.EndOfDirectiveToken);
                  goto case SyntaxKind.EndOfDirectiveToken;
                case SyntaxKind.EndOfDirectiveToken:
                  return (Roslyn.Compilers.CSharp.WarningDirectiveSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.WarningDirective(hashToken.Node, warningKeyword.Node, endOfDirectiveToken.Node, isActive));
                default:
                  throw new ArgumentException("endOfDirectiveToken");
              }
            default:
              throw new ArgumentException("warningKeyword");
          }
        default:
          throw new ArgumentException("hashToken");
      }
    }

    public static Roslyn.Compilers.CSharp.BadDirectiveSyntax BadDirective(Roslyn.Compilers.CSharp.SyntaxToken hashToken = null, Roslyn.Compilers.CSharp.SyntaxToken identifier = null, Roslyn.Compilers.CSharp.SyntaxToken endOfDirectiveToken = null, bool isActive = false)
    {
      switch (hashToken.Kind)
      {
        case SyntaxKind.None:
          hashToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.HashToken);
          goto case SyntaxKind.HashToken;
        case SyntaxKind.HashToken:
          switch (endOfDirectiveToken.Kind)
          {
            case SyntaxKind.None:
              endOfDirectiveToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.EndOfDirectiveToken);
              goto case SyntaxKind.EndOfDirectiveToken;
            case SyntaxKind.EndOfDirectiveToken:
              return (Roslyn.Compilers.CSharp.BadDirectiveSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.BadDirective(hashToken.Node, identifier.Node, endOfDirectiveToken.Node, isActive));
            default:
              throw new ArgumentException("endOfDirectiveToken");
          }
        default:
          throw new ArgumentException("hashToken");
      }
    }

    public static Roslyn.Compilers.CSharp.DefineDirectiveSyntax DefineDirective(Roslyn.Compilers.CSharp.SyntaxToken hashToken = null, Roslyn.Compilers.CSharp.SyntaxToken defineKeyword = null, Roslyn.Compilers.CSharp.SyntaxToken name = null, Roslyn.Compilers.CSharp.SyntaxToken endOfDirectiveToken = null, bool isActive = false)
    {
      switch (hashToken.Kind)
      {
        case SyntaxKind.None:
          hashToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.HashToken);
          goto case SyntaxKind.HashToken;
        case SyntaxKind.HashToken:
          switch (defineKeyword.Kind)
          {
            case SyntaxKind.None:
              defineKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.DefineKeyword);
              goto case SyntaxKind.DefineKeyword;
            case SyntaxKind.DefineKeyword:
              if (name.Kind != SyntaxKind.IdentifierToken)
                throw new ArgumentException("name");
              switch (endOfDirectiveToken.Kind)
              {
                case SyntaxKind.None:
                  endOfDirectiveToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.EndOfDirectiveToken);
                  goto case SyntaxKind.EndOfDirectiveToken;
                case SyntaxKind.EndOfDirectiveToken:
                  return (Roslyn.Compilers.CSharp.DefineDirectiveSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.DefineDirective(hashToken.Node, defineKeyword.Node, name.Node, endOfDirectiveToken.Node, isActive));
                default:
                  throw new ArgumentException("endOfDirectiveToken");
              }
            default:
              throw new ArgumentException("defineKeyword");
          }
        default:
          throw new ArgumentException("hashToken");
      }
    }

    public static Roslyn.Compilers.CSharp.UndefDirectiveSyntax UndefDirective(Roslyn.Compilers.CSharp.SyntaxToken hashToken = null, Roslyn.Compilers.CSharp.SyntaxToken undefKeyword = null, Roslyn.Compilers.CSharp.SyntaxToken name = null, Roslyn.Compilers.CSharp.SyntaxToken endOfDirectiveToken = null, bool isActive = false)
    {
      switch (hashToken.Kind)
      {
        case SyntaxKind.None:
          hashToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.HashToken);
          goto case SyntaxKind.HashToken;
        case SyntaxKind.HashToken:
          switch (undefKeyword.Kind)
          {
            case SyntaxKind.None:
              undefKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.UndefKeyword);
              goto case SyntaxKind.UndefKeyword;
            case SyntaxKind.UndefKeyword:
              if (name.Kind != SyntaxKind.IdentifierToken)
                throw new ArgumentException("name");
              switch (endOfDirectiveToken.Kind)
              {
                case SyntaxKind.None:
                  endOfDirectiveToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.EndOfDirectiveToken);
                  goto case SyntaxKind.EndOfDirectiveToken;
                case SyntaxKind.EndOfDirectiveToken:
                  return (Roslyn.Compilers.CSharp.UndefDirectiveSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.UndefDirective(hashToken.Node, undefKeyword.Node, name.Node, endOfDirectiveToken.Node, isActive));
                default:
                  throw new ArgumentException("endOfDirectiveToken");
              }
            default:
              throw new ArgumentException("undefKeyword");
          }
        default:
          throw new ArgumentException("hashToken");
      }
    }

    public static Roslyn.Compilers.CSharp.LineDirectiveSyntax LineDirective(Roslyn.Compilers.CSharp.SyntaxToken hashToken = null, Roslyn.Compilers.CSharp.SyntaxToken lineKeyword = null, Roslyn.Compilers.CSharp.SyntaxToken line = null, Roslyn.Compilers.CSharp.SyntaxToken fileOpt = null, Roslyn.Compilers.CSharp.SyntaxToken endOfDirectiveToken = null, bool isActive = false)
    {
      switch (hashToken.Kind)
      {
        case SyntaxKind.None:
          hashToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.HashToken);
          goto case SyntaxKind.HashToken;
        case SyntaxKind.HashToken:
          switch (lineKeyword.Kind)
          {
            case SyntaxKind.None:
              lineKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.LineKeyword);
              goto case SyntaxKind.LineKeyword;
            case SyntaxKind.LineKeyword:
              switch (line.Kind)
              {
                case SyntaxKind.DefaultKeyword:
                case SyntaxKind.HiddenKeyword:
                case SyntaxKind.NumericLiteralToken:
                  switch (fileOpt.Kind)
                  {
                    case SyntaxKind.None:
                    case SyntaxKind.StringLiteralToken:
                      switch (endOfDirectiveToken.Kind)
                      {
                        case SyntaxKind.None:
                          endOfDirectiveToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.EndOfDirectiveToken);
                          goto case SyntaxKind.EndOfDirectiveToken;
                        case SyntaxKind.EndOfDirectiveToken:
                          return (Roslyn.Compilers.CSharp.LineDirectiveSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.LineDirective(hashToken.Node, lineKeyword.Node, line.Node, fileOpt.Node, endOfDirectiveToken.Node, isActive));
                        default:
                          throw new ArgumentException("endOfDirectiveToken");
                      }
                    default:
                      throw new ArgumentException("fileOpt");
                  }
                default:
                  throw new ArgumentException("line");
              }
            default:
              throw new ArgumentException("lineKeyword");
          }
        default:
          throw new ArgumentException("hashToken");
      }
    }

    public static Roslyn.Compilers.CSharp.PragmaWarningDirectiveSyntax PragmaWarningDirective(Roslyn.Compilers.CSharp.SyntaxToken hashToken = null, Roslyn.Compilers.CSharp.SyntaxToken pragmaKeyword = null, Roslyn.Compilers.CSharp.SyntaxToken warningKeyword = null, Roslyn.Compilers.CSharp.SyntaxToken disableOrRestoreKeyword = null, SeparatedSyntaxList<Roslyn.Compilers.CSharp.ExpressionSyntax> errorCodes = null, Roslyn.Compilers.CSharp.SyntaxToken endOfDirectiveToken = null, bool isActive = false)
    {
      switch (hashToken.Kind)
      {
        case SyntaxKind.None:
          hashToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.HashToken);
          goto case SyntaxKind.HashToken;
        case SyntaxKind.HashToken:
          switch (pragmaKeyword.Kind)
          {
            case SyntaxKind.None:
              pragmaKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.PragmaKeyword);
              goto case SyntaxKind.PragmaKeyword;
            case SyntaxKind.PragmaKeyword:
              switch (warningKeyword.Kind)
              {
                case SyntaxKind.None:
                  warningKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.WarningKeyword);
                  goto case SyntaxKind.WarningKeyword;
                case SyntaxKind.WarningKeyword:
                  switch (disableOrRestoreKeyword.Kind)
                  {
                    case SyntaxKind.DisableKeyword:
                    case SyntaxKind.RestoreKeyword:
                      switch (endOfDirectiveToken.Kind)
                      {
                        case SyntaxKind.None:
                          endOfDirectiveToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.EndOfDirectiveToken);
                          goto case SyntaxKind.EndOfDirectiveToken;
                        case SyntaxKind.EndOfDirectiveToken:
                          return (Roslyn.Compilers.CSharp.PragmaWarningDirectiveSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.PragmaWarningDirective(hashToken.Node, pragmaKeyword.Node, warningKeyword.Node, disableOrRestoreKeyword.Node, BaseSyntaxNodeExtensions.ToGreenSeparatedList<Roslyn.Compilers.CSharp.InternalSyntax.ExpressionSyntax>(errorCodes.Node), endOfDirectiveToken.Node, isActive));
                        default:
                          throw new ArgumentException("endOfDirectiveToken");
                      }
                    default:
                      throw new ArgumentException("disableOrRestoreKeyword");
                  }
                default:
                  throw new ArgumentException("warningKeyword");
              }
            default:
              throw new ArgumentException("pragmaKeyword");
          }
        default:
          throw new ArgumentException("hashToken");
      }
    }

    public static Roslyn.Compilers.CSharp.PragmaChecksumDirectiveSyntax PragmaChecksumDirective(Roslyn.Compilers.CSharp.SyntaxToken hashToken = null, Roslyn.Compilers.CSharp.SyntaxToken pragmaKeyword = null, Roslyn.Compilers.CSharp.SyntaxToken checksumKeyword = null, Roslyn.Compilers.CSharp.SyntaxToken file = null, Roslyn.Compilers.CSharp.SyntaxToken guid = null, Roslyn.Compilers.CSharp.SyntaxToken bytes = null, Roslyn.Compilers.CSharp.SyntaxToken endOfDirectiveToken = null, bool isActive = false)
    {
      switch (hashToken.Kind)
      {
        case SyntaxKind.None:
          hashToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.HashToken);
          goto case SyntaxKind.HashToken;
        case SyntaxKind.HashToken:
          switch (pragmaKeyword.Kind)
          {
            case SyntaxKind.None:
              pragmaKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.PragmaKeyword);
              goto case SyntaxKind.PragmaKeyword;
            case SyntaxKind.PragmaKeyword:
              switch (checksumKeyword.Kind)
              {
                case SyntaxKind.None:
                  checksumKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.ChecksumKeyword);
                  goto case SyntaxKind.ChecksumKeyword;
                case SyntaxKind.ChecksumKeyword:
                  switch (file.Kind)
                  {
                    case SyntaxKind.None:
                      file = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.StringLiteralToken);
                      goto case SyntaxKind.StringLiteralToken;
                    case SyntaxKind.StringLiteralToken:
                      switch (guid.Kind)
                      {
                        case SyntaxKind.None:
                          guid = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.StringLiteralToken);
                          goto case SyntaxKind.StringLiteralToken;
                        case SyntaxKind.StringLiteralToken:
                          switch (bytes.Kind)
                          {
                            case SyntaxKind.None:
                              bytes = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.StringLiteralToken);
                              goto case SyntaxKind.StringLiteralToken;
                            case SyntaxKind.StringLiteralToken:
                              switch (endOfDirectiveToken.Kind)
                              {
                                case SyntaxKind.None:
                                  endOfDirectiveToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.EndOfDirectiveToken);
                                  goto case SyntaxKind.EndOfDirectiveToken;
                                case SyntaxKind.EndOfDirectiveToken:
                                  return (Roslyn.Compilers.CSharp.PragmaChecksumDirectiveSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.PragmaChecksumDirective(hashToken.Node, pragmaKeyword.Node, checksumKeyword.Node, file.Node, guid.Node, bytes.Node, endOfDirectiveToken.Node, isActive));
                                default:
                                  throw new ArgumentException("endOfDirectiveToken");
                              }
                            default:
                              throw new ArgumentException("bytes");
                          }
                        default:
                          throw new ArgumentException("guid");
                      }
                    default:
                      throw new ArgumentException("file");
                  }
                default:
                  throw new ArgumentException("checksumKeyword");
              }
            default:
              throw new ArgumentException("pragmaKeyword");
          }
        default:
          throw new ArgumentException("hashToken");
      }
    }

    public static Roslyn.Compilers.CSharp.ReferenceDirectiveSyntax ReferenceDirective(Roslyn.Compilers.CSharp.SyntaxToken hashToken = null, Roslyn.Compilers.CSharp.SyntaxToken referenceKeyword = null, Roslyn.Compilers.CSharp.SyntaxToken file = null, Roslyn.Compilers.CSharp.SyntaxToken endOfDirectiveToken = null, bool isActive = false)
    {
      switch (hashToken.Kind)
      {
        case SyntaxKind.None:
          hashToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.HashToken);
          goto case SyntaxKind.HashToken;
        case SyntaxKind.HashToken:
          switch (referenceKeyword.Kind)
          {
            case SyntaxKind.None:
              referenceKeyword = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.ReferenceKeyword);
              goto case SyntaxKind.ReferenceKeyword;
            case SyntaxKind.ReferenceKeyword:
              switch (file.Kind)
              {
                case SyntaxKind.None:
                  file = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.StringLiteralToken);
                  goto case SyntaxKind.StringLiteralToken;
                case SyntaxKind.StringLiteralToken:
                  switch (endOfDirectiveToken.Kind)
                  {
                    case SyntaxKind.None:
                      endOfDirectiveToken = Roslyn.Compilers.CSharp.Syntax.Token(SyntaxKind.EndOfDirectiveToken);
                      goto case SyntaxKind.EndOfDirectiveToken;
                    case SyntaxKind.EndOfDirectiveToken:
                      return (Roslyn.Compilers.CSharp.ReferenceDirectiveSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.ReferenceDirective(hashToken.Node, referenceKeyword.Node, file.Node, endOfDirectiveToken.Node, isActive));
                    default:
                      throw new ArgumentException("endOfDirectiveToken");
                  }
                default:
                  throw new ArgumentException("file");
              }
            default:
              throw new ArgumentException("referenceKeyword");
          }
        default:
          throw new ArgumentException("hashToken");
      }
    }

    public static Roslyn.Compilers.CSharp.SyntaxTrivia EndOfLine(string text, bool elastic = true)
    {
      return (Roslyn.Compilers.CSharp.SyntaxTrivia) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.EndOfLine(text, elastic);
    }

    public static Roslyn.Compilers.CSharp.SyntaxTrivia Whitespace(string text, bool elastic = true)
    {
      return (Roslyn.Compilers.CSharp.SyntaxTrivia) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.Whitespace(text, elastic);
    }

    public static Roslyn.Compilers.CSharp.SyntaxTrivia Comment(string text)
    {
      return (Roslyn.Compilers.CSharp.SyntaxTrivia) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.Comment(text);
    }

    public static Roslyn.Compilers.CSharp.SyntaxTrivia DisabledText(string text)
    {
      return (Roslyn.Compilers.CSharp.SyntaxTrivia) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.DisabledText(text);
    }

    public static Roslyn.Compilers.CSharp.SyntaxTrivia PreprocessingMessage(string text)
    {
      return (Roslyn.Compilers.CSharp.SyntaxTrivia) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.PreprocessingMessage(text);
    }

    public static Roslyn.Compilers.CSharp.SyntaxToken Token(SyntaxKind kind)
    {
      return (Roslyn.Compilers.CSharp.SyntaxToken) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.Token(Roslyn.Compilers.CSharp.Syntax.ElasticMarker.UnderlyingNode, kind, Roslyn.Compilers.CSharp.Syntax.ElasticMarker.UnderlyingNode);
    }

    public static Roslyn.Compilers.CSharp.SyntaxToken Token(SyntaxTriviaList leading, SyntaxKind kind)
    {
      return (Roslyn.Compilers.CSharp.SyntaxToken) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.Token(leading.Node, kind, Roslyn.Compilers.CSharp.Syntax.ElasticMarker.UnderlyingNode);
    }

    public static Roslyn.Compilers.CSharp.SyntaxToken Token(SyntaxKind kind, SyntaxTriviaList trailing)
    {
      SyntaxKind kind1 = kind;
      Roslyn.Compilers.CSharp.InternalSyntax.SyntaxNode node = trailing.Node;
      return (Roslyn.Compilers.CSharp.SyntaxToken) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.Token(Roslyn.Compilers.CSharp.Syntax.ElasticMarker.UnderlyingNode, kind1, node);
    }

    public static Roslyn.Compilers.CSharp.SyntaxToken Token(SyntaxTriviaList leading, SyntaxKind kind, SyntaxTriviaList trailing)
    {
      return (Roslyn.Compilers.CSharp.SyntaxToken) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.Token(leading.Node, kind, trailing.Node);
    }

    public static Roslyn.Compilers.CSharp.SyntaxToken MissingToken(SyntaxKind kind)
    {
      return (Roslyn.Compilers.CSharp.SyntaxToken) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.MissingToken(Roslyn.Compilers.CSharp.Syntax.ElasticMarker.UnderlyingNode, kind, Roslyn.Compilers.CSharp.Syntax.ElasticMarker.UnderlyingNode);
    }

    public static Roslyn.Compilers.CSharp.SyntaxToken MissingToken(SyntaxTriviaList leading, SyntaxKind kind, SyntaxTriviaList trailing)
    {
      return (Roslyn.Compilers.CSharp.SyntaxToken) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.MissingToken(leading.Node, kind, trailing.Node);
    }

    public static Roslyn.Compilers.CSharp.SyntaxToken Identifier(string text)
    {
      return (Roslyn.Compilers.CSharp.SyntaxToken) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.Identifier(Roslyn.Compilers.CSharp.Syntax.ElasticMarker.UnderlyingNode, text, Roslyn.Compilers.CSharp.Syntax.ElasticMarker.UnderlyingNode);
    }

    public static Roslyn.Compilers.CSharp.SyntaxToken Identifier(SyntaxTriviaList leading, string text, SyntaxTriviaList trailing)
    {
      return (Roslyn.Compilers.CSharp.SyntaxToken) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.Identifier(leading.Node, text, trailing.Node);
    }

    public static Roslyn.Compilers.CSharp.SyntaxToken Identifier(string text, SyntaxTriviaList trailing)
    {
      return (Roslyn.Compilers.CSharp.SyntaxToken) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.Identifier(SyntaxKind.IdentifierToken, Roslyn.Compilers.CSharp.Syntax.ElasticMarker.UnderlyingNode, text, text, trailing.Node);
    }

    public static Roslyn.Compilers.CSharp.SyntaxToken Identifier(SyntaxKind contextualKind, SyntaxTriviaList leading, string text, string valueText, SyntaxTriviaList trailing)
    {
      return (Roslyn.Compilers.CSharp.SyntaxToken) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.Identifier(contextualKind, leading.Node, text, valueText, trailing.Node);
    }

    public static Roslyn.Compilers.CSharp.SyntaxToken Literal(string text, int value)
    {
      return (Roslyn.Compilers.CSharp.SyntaxToken) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.Literal(Roslyn.Compilers.CSharp.Syntax.ElasticMarker.UnderlyingNode, text, value, Roslyn.Compilers.CSharp.Syntax.ElasticMarker.UnderlyingNode);
    }

    public static Roslyn.Compilers.CSharp.SyntaxToken Literal(SyntaxTriviaList leading, string text, int value, SyntaxTriviaList trailing)
    {
      return (Roslyn.Compilers.CSharp.SyntaxToken) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.Literal(leading.Node, text, value, trailing.Node);
    }

    public static Roslyn.Compilers.CSharp.SyntaxToken Literal(string text, uint value)
    {
      return (Roslyn.Compilers.CSharp.SyntaxToken) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.Literal(Roslyn.Compilers.CSharp.Syntax.ElasticMarker.UnderlyingNode, text, value, Roslyn.Compilers.CSharp.Syntax.ElasticMarker.UnderlyingNode);
    }

    public static Roslyn.Compilers.CSharp.SyntaxToken Literal(SyntaxTriviaList leading, string text, uint value, SyntaxTriviaList trailing)
    {
      return (Roslyn.Compilers.CSharp.SyntaxToken) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.Literal(leading.Node, text, value, trailing.Node);
    }

    public static Roslyn.Compilers.CSharp.SyntaxToken Literal(string text, long value)
    {
      return (Roslyn.Compilers.CSharp.SyntaxToken) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.Literal(Roslyn.Compilers.CSharp.Syntax.ElasticMarker.UnderlyingNode, text, value, Roslyn.Compilers.CSharp.Syntax.ElasticMarker.UnderlyingNode);
    }

    public static Roslyn.Compilers.CSharp.SyntaxToken Literal(SyntaxTriviaList leading, string text, long value, SyntaxTriviaList trailing)
    {
      return (Roslyn.Compilers.CSharp.SyntaxToken) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.Literal(leading.Node, text, value, trailing.Node);
    }

    public static Roslyn.Compilers.CSharp.SyntaxToken Literal(string text, ulong value)
    {
      return (Roslyn.Compilers.CSharp.SyntaxToken) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.Literal(Roslyn.Compilers.CSharp.Syntax.ElasticMarker.UnderlyingNode, text, value, Roslyn.Compilers.CSharp.Syntax.ElasticMarker.UnderlyingNode);
    }

    public static Roslyn.Compilers.CSharp.SyntaxToken Literal(SyntaxTriviaList leading, string text, ulong value, SyntaxTriviaList trailing)
    {
      return (Roslyn.Compilers.CSharp.SyntaxToken) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.Literal(leading.Node, text, value, trailing.Node);
    }

    public static Roslyn.Compilers.CSharp.SyntaxToken Literal(string text, float value)
    {
      return (Roslyn.Compilers.CSharp.SyntaxToken) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.Literal(Roslyn.Compilers.CSharp.Syntax.ElasticMarker.UnderlyingNode, text, value, Roslyn.Compilers.CSharp.Syntax.ElasticMarker.UnderlyingNode);
    }

    public static Roslyn.Compilers.CSharp.SyntaxToken Literal(SyntaxTriviaList leading, string text, float value, SyntaxTriviaList trailing)
    {
      return (Roslyn.Compilers.CSharp.SyntaxToken) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.Literal(leading.Node, text, value, trailing.Node);
    }

    public static Roslyn.Compilers.CSharp.SyntaxToken Literal(string text, double value)
    {
      return (Roslyn.Compilers.CSharp.SyntaxToken) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.Literal(Roslyn.Compilers.CSharp.Syntax.ElasticMarker.UnderlyingNode, text, value, Roslyn.Compilers.CSharp.Syntax.ElasticMarker.UnderlyingNode);
    }

    public static Roslyn.Compilers.CSharp.SyntaxToken Literal(SyntaxTriviaList leading, string text, double value, SyntaxTriviaList trailing)
    {
      return (Roslyn.Compilers.CSharp.SyntaxToken) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.Literal(leading.Node, text, value, trailing.Node);
    }

    public static Roslyn.Compilers.CSharp.SyntaxToken Literal(string text, Decimal value)
    {
      return (Roslyn.Compilers.CSharp.SyntaxToken) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.Literal(Roslyn.Compilers.CSharp.Syntax.ElasticMarker.UnderlyingNode, text, value, Roslyn.Compilers.CSharp.Syntax.ElasticMarker.UnderlyingNode);
    }

    public static Roslyn.Compilers.CSharp.SyntaxToken Literal(SyntaxTriviaList leading, string text, Decimal value, SyntaxTriviaList trailing)
    {
      return (Roslyn.Compilers.CSharp.SyntaxToken) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.Literal(leading.Node, text, value, trailing.Node);
    }

    public static Roslyn.Compilers.CSharp.SyntaxToken Literal(string text, string value)
    {
      return (Roslyn.Compilers.CSharp.SyntaxToken) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.Literal(Roslyn.Compilers.CSharp.Syntax.ElasticMarker.UnderlyingNode, text, value, Roslyn.Compilers.CSharp.Syntax.ElasticMarker.UnderlyingNode);
    }

    public static Roslyn.Compilers.CSharp.SyntaxToken Literal(SyntaxTriviaList leading, string text, string value, SyntaxTriviaList trailing)
    {
      return (Roslyn.Compilers.CSharp.SyntaxToken) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.Literal(leading.Node, text, value, trailing.Node);
    }

    public static Roslyn.Compilers.CSharp.SyntaxToken Literal(string text, char value)
    {
      return (Roslyn.Compilers.CSharp.SyntaxToken) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.Literal(Roslyn.Compilers.CSharp.Syntax.ElasticMarker.UnderlyingNode, text, value, Roslyn.Compilers.CSharp.Syntax.ElasticMarker.UnderlyingNode);
    }

    public static Roslyn.Compilers.CSharp.SyntaxToken Literal(SyntaxTriviaList leading, string text, char value, SyntaxTriviaList trailing)
    {
      return (Roslyn.Compilers.CSharp.SyntaxToken) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.Literal(leading.Node, text, value, trailing.Node);
    }

    public static Roslyn.Compilers.CSharp.SyntaxToken BadToken(SyntaxTriviaList leading, string text, SyntaxTriviaList trailing)
    {
      return (Roslyn.Compilers.CSharp.SyntaxToken) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.BadToken(leading.Node, text, trailing.Node);
    }

    public static Roslyn.Compilers.CSharp.SyntaxToken XmlText(SyntaxTriviaList leading, string text, string value, SyntaxTriviaList trailing)
    {
      return (Roslyn.Compilers.CSharp.SyntaxToken) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.XmlText(leading.Node, text, value, trailing.Node);
    }

    public static Roslyn.Compilers.CSharp.SyntaxToken XmlTextNewLine(SyntaxTriviaList leading, string text, string value, SyntaxTriviaList trailing)
    {
      return (Roslyn.Compilers.CSharp.SyntaxToken) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.XmlTextNewLine(leading.Node, text, value, trailing.Node);
    }

    public static Roslyn.Compilers.CSharp.SyntaxToken XmlEntity(SyntaxTriviaList leading, string text, string value, SyntaxTriviaList trailing)
    {
      return (Roslyn.Compilers.CSharp.SyntaxToken) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.XmlEntity(leading.Node, text, value, trailing.Node);
    }

    public static Roslyn.Compilers.CSharp.SyntaxTrivia DocumentationCommentExteriorTrivia(string text)
    {
      return (Roslyn.Compilers.CSharp.SyntaxTrivia) Roslyn.Compilers.CSharp.InternalSyntax.Syntax.DocumentationCommentExteriorTrivia(text);
    }

    public static Roslyn.Compilers.CSharp.SyntaxList<TNode> List<TNode>() where TNode : Roslyn.Compilers.CSharp.SyntaxNode
    {
      return new Roslyn.Compilers.CSharp.SyntaxList<TNode>();
    }

    public static Roslyn.Compilers.CSharp.SyntaxList<TNode> List<TNode>(TNode node) where TNode : Roslyn.Compilers.CSharp.SyntaxNode
    {
      return new Roslyn.Compilers.CSharp.SyntaxList<TNode>((Roslyn.Compilers.CSharp.SyntaxNode) node);
    }

    public static Roslyn.Compilers.CSharp.SyntaxList<TNode> List<TNode>(params TNode[] nodes) where TNode : Roslyn.Compilers.CSharp.SyntaxNode
    {
      if (nodes == null)
        return new Roslyn.Compilers.CSharp.SyntaxList<TNode>();
      Roslyn.Compilers.CSharp.SyntaxListBuilder<TNode> syntaxListBuilder = new Roslyn.Compilers.CSharp.SyntaxListBuilder<TNode>(nodes.Length);
      syntaxListBuilder.AddRange(nodes, 0, nodes.Length);
      return syntaxListBuilder.ToList();
    }

    public static Roslyn.Compilers.CSharp.SyntaxList<TNode> List<TNode>(IEnumerable<TNode> nodes) where TNode : Roslyn.Compilers.CSharp.SyntaxNode
    {
      if (nodes == null)
        return new Roslyn.Compilers.CSharp.SyntaxList<TNode>();
      ICollection<TNode> collection = nodes as ICollection<TNode>;
      Roslyn.Compilers.CSharp.SyntaxListBuilder<TNode> syntaxListBuilder = collection != null ? new Roslyn.Compilers.CSharp.SyntaxListBuilder<TNode>(collection.Count) : Roslyn.Compilers.CSharp.SyntaxListBuilder<TNode>.Create();
      foreach (TNode node in nodes)
        syntaxListBuilder.Add(node);
      return syntaxListBuilder.ToList();
    }

    public static SyntaxTokenList TokenList()
    {
      return new SyntaxTokenList();
    }

    public static SyntaxTokenList TokenList(Roslyn.Compilers.CSharp.SyntaxToken token)
    {
      return new SyntaxTokenList(token);
    }

    public static SyntaxTokenList TokenList(params Roslyn.Compilers.CSharp.SyntaxToken[] tokens)
    {
      if (tokens == null)
        return new SyntaxTokenList();
      SyntaxTokenListBuilder tokenListBuilder = new SyntaxTokenListBuilder(tokens.Length);
      for (int index = 0; index < tokens.Length; ++index)
        tokenListBuilder.Add(tokens[index].Node);
      return tokenListBuilder.ToList();
    }

    public static SyntaxTokenList TokenList(IEnumerable<Roslyn.Compilers.CSharp.SyntaxToken> tokens)
    {
      if (tokens == null)
        return new SyntaxTokenList();
      SyntaxTokenListBuilder tokenListBuilder = SyntaxTokenListBuilder.Create();
      foreach (Roslyn.Compilers.CSharp.SyntaxToken syntaxToken in tokens)
        tokenListBuilder.Add(syntaxToken.Node);
      return tokenListBuilder.ToList();
    }

    public static Roslyn.Compilers.CSharp.SyntaxTrivia Trivia(Roslyn.Compilers.CSharp.StructuredTriviaSyntax node)
    {
      int position = 0;
      int index = 0;
      return new Roslyn.Compilers.CSharp.SyntaxTrivia(new Roslyn.Compilers.CSharp.SyntaxToken(), node.Green, position, index);
    }

    public static SyntaxTriviaList TriviaList()
    {
      return new SyntaxTriviaList();
    }

    public static SyntaxTriviaList TriviaList(Roslyn.Compilers.CSharp.SyntaxTrivia trivia)
    {
      return new SyntaxTriviaList(trivia);
    }

    public static SyntaxTriviaList TriviaList(params Roslyn.Compilers.CSharp.SyntaxTrivia[] trivias)
    {
      if (trivias == null)
        return new SyntaxTriviaList();
      SyntaxTriviaListBuilder triviaListBuilder = new SyntaxTriviaListBuilder(trivias.Length);
      triviaListBuilder.Add(trivias);
      return triviaListBuilder.ToList();
    }

    public static SyntaxTriviaList TriviaList(IEnumerable<Roslyn.Compilers.CSharp.SyntaxTrivia> trivias)
    {
      if (trivias == null)
        return new SyntaxTriviaList();
      SyntaxTriviaListBuilder triviaListBuilder = SyntaxTriviaListBuilder.Create();
      foreach (Roslyn.Compilers.CSharp.SyntaxTrivia syntaxTrivia in trivias)
        triviaListBuilder.Add(syntaxTrivia);
      return triviaListBuilder.ToList();
    }

    public static SeparatedSyntaxList<TNode> SeparatedList<TNode>() where TNode : Roslyn.Compilers.CSharp.SyntaxNode
    {
      return new SeparatedSyntaxList<TNode>();
    }

    public static SeparatedSyntaxList<TNode> SeparatedList<TNode>(TNode node) where TNode : Roslyn.Compilers.CSharp.SyntaxNode
    {
      int position = 0;
      int index = 0;
      return new SeparatedSyntaxList<TNode>(new SyntaxNodeOrTokenList((Roslyn.Compilers.CSharp.SyntaxNode) null, (IBaseSyntaxNodeExt) node, position, index));
    }

    public static SeparatedSyntaxList<TNode> SeparatedList<TNode>(params SyntaxNodeOrToken[] nodes) where TNode : Roslyn.Compilers.CSharp.SyntaxNode
    {
      if (nodes == null)
        return new SeparatedSyntaxList<TNode>();
      SeparatedSyntaxListBuilder<TNode> syntaxListBuilder = new SeparatedSyntaxListBuilder<TNode>(nodes.Length);
      for (int index = 0; index < nodes.Length; ++index)
      {
        SyntaxNodeOrToken syntaxNodeOrToken = nodes[index];
        if (syntaxNodeOrToken.IsNode)
          syntaxListBuilder.Add((TNode) syntaxNodeOrToken.AsNode());
        else
          syntaxListBuilder.AddSeparator(syntaxNodeOrToken.AsToken());
      }
      return syntaxListBuilder.ToList();
    }

    public static SeparatedSyntaxList<TNode> SeparatedList<TNode>(IEnumerable<SyntaxNodeOrToken> nodes) where TNode : Roslyn.Compilers.CSharp.SyntaxNode
    {
      if (nodes == null)
        return new SeparatedSyntaxList<TNode>();
      SeparatedSyntaxListBuilder<TNode> syntaxListBuilder = SeparatedSyntaxListBuilder<TNode>.Create();
      foreach (SyntaxNodeOrToken syntaxNodeOrToken in nodes)
      {
        if (syntaxNodeOrToken.IsNode)
          syntaxListBuilder.Add((TNode) syntaxNodeOrToken.AsNode());
        else
          syntaxListBuilder.AddSeparator(syntaxNodeOrToken.AsToken());
      }
      return syntaxListBuilder.ToList();
    }

    public static SeparatedSyntaxList<TNode> SeparatedList<TNode>(IEnumerable<TNode> nodes, IEnumerable<Roslyn.Compilers.CSharp.SyntaxToken> separators) where TNode : Roslyn.Compilers.CSharp.SyntaxNode
    {
      if (nodes != null)
      {
        IEnumerator<TNode> enumerator = nodes.GetEnumerator();
        SeparatedSyntaxListBuilder<TNode> syntaxListBuilder = SeparatedSyntaxListBuilder<TNode>.Create();
        if (separators != null)
        {
          foreach (Roslyn.Compilers.CSharp.SyntaxToken seperatorToken in separators)
          {
            if (!enumerator.MoveNext())
              throw new ArgumentException();
            syntaxListBuilder.Add(enumerator.Current);
            syntaxListBuilder.AddSeparator(seperatorToken);
          }
        }
        if (enumerator.MoveNext())
        {
          syntaxListBuilder.Add(enumerator.Current);
          if (enumerator.MoveNext())
            throw new ArgumentException();
        }
        return syntaxListBuilder.ToList();
      }
      else if (separators != null)
        throw new ArgumentException();
      else
        return new SeparatedSyntaxList<TNode>();
    }

    public static Roslyn.Compilers.CSharp.IdentifierNameSyntax IdentifierName(string name)
    {
      return Roslyn.Compilers.CSharp.Syntax.IdentifierName(Roslyn.Compilers.CSharp.Syntax.Identifier(name));
    }

    public static SyntaxTriviaList ParseLeadingTrivia(string text, int offset = 0)
    {
      using (Lexer lexer = new Lexer(Roslyn.Compilers.CSharp.Syntax.MakeIText(text, offset), ParseOptions.Default))
        return lexer.LexSyntaxLeadingTrivia();
    }

    public static SyntaxTriviaList ParseTrailingTrivia(string text, int offset = 0)
    {
      using (Lexer lexer = new Lexer(Roslyn.Compilers.CSharp.Syntax.MakeIText(text, offset), ParseOptions.Default))
        return lexer.LexSyntaxTrailingTrivia();
    }

    public static Roslyn.Compilers.CSharp.SyntaxToken ParseToken(string text, int offset = 0)
    {
      using (Lexer lexer = new Lexer(Roslyn.Compilers.CSharp.Syntax.MakeIText(text, offset), ParseOptions.Default))
        return (Roslyn.Compilers.CSharp.SyntaxToken) lexer.Lex(LexerMode.Syntax);
    }

    public static IEnumerable<Roslyn.Compilers.CSharp.SyntaxToken> ParseTokens(string text, int offset = 0, int initialTokenPosition = 0)
    {
      using (Lexer lexer = new Lexer(Roslyn.Compilers.CSharp.Syntax.MakeIText(text, offset), ParseOptions.Default))
      {
        int position = initialTokenPosition;
        Roslyn.Compilers.CSharp.InternalSyntax.SyntaxToken token;
        do
        {
          token = lexer.Lex(LexerMode.Syntax);
          yield return new Roslyn.Compilers.CSharp.SyntaxToken((Roslyn.Compilers.CSharp.SyntaxNode) null, token, position, 0);
          position += token.FullWidth;
        }
        while (token.Kind != SyntaxKind.EndOfFileToken);
      }
    }

    public static Roslyn.Compilers.CSharp.NameSyntax ParseName(string text, int offset = 0)
    {
      using (LanguageParser languageParser = Roslyn.Compilers.CSharp.Syntax.MakeParser(text, offset, (ParseOptions) null))
        return (Roslyn.Compilers.CSharp.NameSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) languageParser.ParseName());
    }

    public static Roslyn.Compilers.CSharp.TypeSyntax ParseTypeName(string text, int offset = 0)
    {
      using (LanguageParser languageParser = Roslyn.Compilers.CSharp.Syntax.MakeParser(text, offset, (ParseOptions) null))
        return (Roslyn.Compilers.CSharp.TypeSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) languageParser.ParseTypeName());
    }

    public static Roslyn.Compilers.CSharp.ExpressionSyntax ParseExpression(string text, int offset = 0, ParseOptions options = null)
    {
      using (LanguageParser languageParser = Roslyn.Compilers.CSharp.Syntax.MakeParser(text, offset, options))
        return (Roslyn.Compilers.CSharp.ExpressionSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) languageParser.ParseExpression());
    }

    public static Roslyn.Compilers.CSharp.StatementSyntax ParseStatement(string text, int offset = 0, ParseOptions options = null)
    {
      using (LanguageParser languageParser = Roslyn.Compilers.CSharp.Syntax.MakeParser(text, offset, options))
        return (Roslyn.Compilers.CSharp.StatementSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) languageParser.ParseStatement());
    }

    public static Roslyn.Compilers.CSharp.CompilationUnitSyntax ParseCompilationUnit(string text, int offset = 0, ParseOptions options = null)
    {
      using (LanguageParser languageParser = Roslyn.Compilers.CSharp.Syntax.MakeParser(text, offset, options))
        return (Roslyn.Compilers.CSharp.CompilationUnitSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) languageParser.ParseCompilationUnit());
    }

    public static Roslyn.Compilers.CSharp.ParameterListSyntax ParseParameterList(string text, int offset = 0, ParseOptions options = null)
    {
      using (LanguageParser languageParser = Roslyn.Compilers.CSharp.Syntax.MakeParser(text, offset, options))
        return (Roslyn.Compilers.CSharp.ParameterListSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) languageParser.ParseParenthesizedParameterList(true, true));
    }

    public static Roslyn.Compilers.CSharp.BracketedParameterListSyntax ParseBracketedParameterList(string text, int offset = 0, ParseOptions options = null)
    {
      using (LanguageParser languageParser = Roslyn.Compilers.CSharp.Syntax.MakeParser(text, offset, options))
        return (Roslyn.Compilers.CSharp.BracketedParameterListSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) languageParser.ParseBracketedParameterList(true));
    }

    public static Roslyn.Compilers.CSharp.ArgumentListSyntax ParseArgumentList(string text, int offset = 0, ParseOptions options = null)
    {
      using (LanguageParser languageParser = Roslyn.Compilers.CSharp.Syntax.MakeParser(text, offset, options))
        return (Roslyn.Compilers.CSharp.ArgumentListSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) languageParser.ParseParenthesizedArgumentList());
    }

    public static Roslyn.Compilers.CSharp.BracketedArgumentListSyntax ParseBracketedArgumentList(string text, int offset = 0, ParseOptions options = null)
    {
      using (LanguageParser languageParser = Roslyn.Compilers.CSharp.Syntax.MakeParser(text, offset, options))
        return (Roslyn.Compilers.CSharp.BracketedArgumentListSyntax) BaseSyntaxNodeExtensions.ToRed((IBaseSyntaxNodeExt) languageParser.ParseBracketedArgumentList());
    }

    private static IText MakeIText(string text, int offset)
    {
      IText underlying = (IText) new StringText(text);
      if (offset <= 0)
        return underlying;
      else
        return (IText) new OffsetText(underlying, offset);
    }

    private static LanguageParser MakeParser(string text, int offset, ParseOptions options = null)
    {
      return new LanguageParser(Roslyn.Compilers.CSharp.Syntax.MakeIText(text, offset), (SyntaxTree) null, (IEnumerable<TextChangeRange>) null, options ?? ParseOptions.Default, new LexerCache(), new CancellationToken());
    }

    public static bool AreEquivalent(SyntaxTree oldTree, SyntaxTree newTree, bool topLevel)
    {
      return SyntaxEquivalence.AreEquivalent(oldTree, newTree, topLevel);
    }

    public static bool AreEquivalent(Roslyn.Compilers.CSharp.SyntaxNode oldNode, Roslyn.Compilers.CSharp.SyntaxNode newNode, bool topLevel)
    {
      return SyntaxEquivalence.AreEquivalent(oldNode, newNode, topLevel);
    }

    public static Roslyn.Compilers.CSharp.SyntaxNode GetStandAloneExpression(Roslyn.Compilers.CSharp.SyntaxNode node)
    {
      if (node != null)
      {
        Roslyn.Compilers.CSharp.ExpressionSyntax expressionSyntax = node.Parent as Roslyn.Compilers.CSharp.ExpressionSyntax;
        if (expressionSyntax != null && (node.Kind == SyntaxKind.IdentifierName || node.Kind == SyntaxKind.GenericName))
        {
          switch (expressionSyntax.Kind)
          {
            case SyntaxKind.QualifiedName:
              if (((Roslyn.Compilers.CSharp.QualifiedNameSyntax) expressionSyntax).Right == node)
                return (Roslyn.Compilers.CSharp.SyntaxNode) expressionSyntax;
              else
                break;
            case SyntaxKind.AliasQualifiedName:
              if (((Roslyn.Compilers.CSharp.AliasQualifiedNameSyntax) expressionSyntax).Name == node)
                return (Roslyn.Compilers.CSharp.SyntaxNode) expressionSyntax;
              else
                break;
            case SyntaxKind.MemberAccessExpression:
            case SyntaxKind.PointerMemberAccessExpression:
              if (((Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax) expressionSyntax).Name == node)
                return (Roslyn.Compilers.CSharp.SyntaxNode) expressionSyntax;
              else
                break;
          }
        }
      }
      return node;
    }

    public static Roslyn.Compilers.CSharp.ExpressionSyntax GetNonGenericExpression(Roslyn.Compilers.CSharp.ExpressionSyntax expression)
    {
      if (expression != null)
      {
        switch (expression.Kind)
        {
          case SyntaxKind.QualifiedName:
            Roslyn.Compilers.CSharp.QualifiedNameSyntax qualifiedNameSyntax1 = (Roslyn.Compilers.CSharp.QualifiedNameSyntax) expression;
            if (qualifiedNameSyntax1.Right.Kind == SyntaxKind.GenericName)
            {
              Roslyn.Compilers.CSharp.GenericNameSyntax genericNameSyntax = (Roslyn.Compilers.CSharp.GenericNameSyntax) qualifiedNameSyntax1.Right;
              return (Roslyn.Compilers.CSharp.ExpressionSyntax) Roslyn.Compilers.CSharp.Syntax.QualifiedName(qualifiedNameSyntax1.Left, qualifiedNameSyntax1.DotToken, (Roslyn.Compilers.CSharp.SimpleNameSyntax) Roslyn.Compilers.CSharp.Syntax.IdentifierName(genericNameSyntax.Identifier));
            }
            else
              break;
          case SyntaxKind.AliasQualifiedName:
            Roslyn.Compilers.CSharp.AliasQualifiedNameSyntax qualifiedNameSyntax2 = (Roslyn.Compilers.CSharp.AliasQualifiedNameSyntax) expression;
            if (qualifiedNameSyntax2.Name.Kind == SyntaxKind.GenericName)
            {
              Roslyn.Compilers.CSharp.GenericNameSyntax genericNameSyntax = (Roslyn.Compilers.CSharp.GenericNameSyntax) qualifiedNameSyntax2.Name;
              return (Roslyn.Compilers.CSharp.ExpressionSyntax) Roslyn.Compilers.CSharp.Syntax.AliasQualifiedName(qualifiedNameSyntax2.Alias, qualifiedNameSyntax2.ColonColonToken, (Roslyn.Compilers.CSharp.SimpleNameSyntax) Roslyn.Compilers.CSharp.Syntax.IdentifierName(genericNameSyntax.Identifier));
            }
            else
              break;
          case SyntaxKind.MemberAccessExpression:
          case SyntaxKind.PointerMemberAccessExpression:
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax expressionSyntax = (Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax) expression;
            if (expressionSyntax.Name.Kind == SyntaxKind.GenericName)
            {
              Roslyn.Compilers.CSharp.GenericNameSyntax genericNameSyntax = (Roslyn.Compilers.CSharp.GenericNameSyntax) expressionSyntax.Name;
              return (Roslyn.Compilers.CSharp.ExpressionSyntax) Roslyn.Compilers.CSharp.Syntax.BinaryExpression(expression.Kind, expressionSyntax.Expression, expressionSyntax.OperatorToken, (Roslyn.Compilers.CSharp.ExpressionSyntax) Roslyn.Compilers.CSharp.Syntax.IdentifierName(genericNameSyntax.Identifier));
            }
            else
              break;
        }
      }
      return expression;
    }

    public static void DecomposeName(Roslyn.Compilers.CSharp.ExpressionSyntax expression, out Roslyn.Compilers.CSharp.ExpressionSyntax qualifier, out string name, out int arity)
    {
      switch (expression.Kind)
      {
        case SyntaxKind.IdentifierName:
          Roslyn.Compilers.CSharp.IdentifierNameSyntax identifierNameSyntax = (Roslyn.Compilers.CSharp.IdentifierNameSyntax) expression;
          qualifier = (Roslyn.Compilers.CSharp.ExpressionSyntax) null;
          name = identifierNameSyntax.PlainName;
          arity = 0;
          break;
        case SyntaxKind.QualifiedName:
          Roslyn.Compilers.CSharp.QualifiedNameSyntax qualifiedNameSyntax1 = (Roslyn.Compilers.CSharp.QualifiedNameSyntax) expression;
          qualifier = (Roslyn.Compilers.CSharp.ExpressionSyntax) qualifiedNameSyntax1.Left;
          name = qualifiedNameSyntax1.PlainName;
          arity = qualifiedNameSyntax1.Arity;
          break;
        case SyntaxKind.GenericName:
          Roslyn.Compilers.CSharp.GenericNameSyntax genericNameSyntax = (Roslyn.Compilers.CSharp.GenericNameSyntax) expression;
          qualifier = (Roslyn.Compilers.CSharp.ExpressionSyntax) null;
          name = genericNameSyntax.PlainName;
          arity = genericNameSyntax.Arity;
          break;
        case SyntaxKind.AliasQualifiedName:
          Roslyn.Compilers.CSharp.AliasQualifiedNameSyntax qualifiedNameSyntax2 = (Roslyn.Compilers.CSharp.AliasQualifiedNameSyntax) expression;
          qualifier = (Roslyn.Compilers.CSharp.ExpressionSyntax) qualifiedNameSyntax2.Alias;
          name = qualifiedNameSyntax2.Name.PlainName;
          arity = qualifiedNameSyntax2.Name.Arity;
          break;
        case SyntaxKind.MemberAccessExpression:
        case SyntaxKind.PointerMemberAccessExpression:
          Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax expressionSyntax = (Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax) expression;
          qualifier = expressionSyntax.Expression;
          name = expressionSyntax.Name.PlainName;
          arity = expressionSyntax.Name.Arity;
          break;
        default:
          qualifier = (Roslyn.Compilers.CSharp.ExpressionSyntax) null;
          name = (string) null;
          arity = 0;
          break;
      }
    }

    public static bool IsCompleteSubmission(SyntaxTree tree)
    {
      if (tree == null)
        throw new ArgumentNullException("tree");
      if (!tree.Root.HasDiagnostics)
        return true;
      Roslyn.Compilers.CSharp.CompilationUnitSyntax compilationUnitSyntax = (Roslyn.Compilers.CSharp.CompilationUnitSyntax) tree.Root;
      foreach (DiagnosticInfo diagnosticInfo in compilationUnitSyntax.EndOfFileToken.Errors)
      {
        switch ((ErrorCode) diagnosticInfo.Code)
        {
          case ErrorCode.ERR_EndifDirectiveExpected:
          case ErrorCode.ERR_OpenEndedComment:
          case ErrorCode.ERR_EndRegionDirectiveExpected:
            return false;
          default:
            continue;
        }
      }
      Roslyn.Compilers.CSharp.SyntaxNode syntaxNode1 = Enumerable.LastOrDefault<Roslyn.Compilers.CSharp.SyntaxNode>(compilationUnitSyntax.ChildNodes());
      if (syntaxNode1 == null)
        return true;
      if (syntaxNode1.HasTrailingTrivia && syntaxNode1.HasDiagnostics && Roslyn.Compilers.CSharp.Syntax.HasUnterminatedMultiLineComment(syntaxNode1.GetTrailingTrivia()) || syntaxNode1.Kind == SyntaxKind.IncompleteMember)
        return false;
      if (syntaxNode1.Kind != SyntaxKind.GlobalStatement)
        return !syntaxNode1.GetLastToken(Roslyn.Compilers.CSharp.SyntaxToken.Any, (Func<Roslyn.Compilers.CSharp.SyntaxTrivia, bool>) null).IsMissing;
      Roslyn.Compilers.CSharp.GlobalStatementSyntax globalStatementSyntax = (Roslyn.Compilers.CSharp.GlobalStatementSyntax) syntaxNode1;
      Roslyn.Compilers.CSharp.SyntaxNode syntaxNode2 = syntaxNode1;
      Func<Roslyn.Compilers.CSharp.SyntaxToken, bool> func1 = Roslyn.Compilers.CSharp.SyntaxToken.Any;
      Func<Roslyn.Compilers.CSharp.SyntaxTrivia, bool> func2 = Roslyn.Compilers.CSharp.SyntaxTrivia.Any;
      Func<Roslyn.Compilers.CSharp.SyntaxToken, bool> predicate1 = func1;
      Func<Roslyn.Compilers.CSharp.SyntaxTrivia, bool> stepInto1 = func2;
      Roslyn.Compilers.CSharp.SyntaxToken syntaxToken = syntaxNode2.GetLastToken(predicate1, stepInto1);
      if (syntaxToken.IsMissing)
      {
        if (tree.Options.Kind != SourceCodeKind.Interactive || globalStatementSyntax.Statement.Kind != SyntaxKind.ExpressionStatement || syntaxToken.Kind != SyntaxKind.SemicolonToken)
          return false;
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        Roslyn.Compilers.CSharp.SyntaxToken& local = @syntaxToken;
        Func<Roslyn.Compilers.CSharp.SyntaxToken, bool> func3 = Roslyn.Compilers.CSharp.SyntaxToken.Any;
        Func<Roslyn.Compilers.CSharp.SyntaxTrivia, bool> func4 = Roslyn.Compilers.CSharp.SyntaxTrivia.Any;
        Func<Roslyn.Compilers.CSharp.SyntaxToken, bool> predicate2 = func3;
        Func<Roslyn.Compilers.CSharp.SyntaxTrivia, bool> stepInto2 = func4;
        // ISSUE: explicit reference operation
        syntaxToken = (^local).GetPreviousToken(predicate2, stepInto2);
        if (syntaxToken.IsMissing)
          return false;
      }
      foreach (DiagnosticInfo diagnosticInfo in syntaxToken.Errors)
      {
        switch ((ErrorCode) diagnosticInfo.Code)
        {
          case ErrorCode.ERR_UnterminatedStringLit:
          case ErrorCode.ERR_GlobalDefinitionOrStatementExpected:
          case ErrorCode.ERR_NewlineInConst:
          case ErrorCode.ERR_EOFExpected:
            return false;
          default:
            continue;
        }
      }
      return true;
    }

    private static bool HasUnterminatedMultiLineComment(SyntaxTriviaList triviaList)
    {
      foreach (Roslyn.Compilers.CSharp.SyntaxTrivia syntaxTrivia in triviaList)
      {
        if (syntaxTrivia.HasDiagnostics && syntaxTrivia.Kind == SyntaxKind.MultiLineCommentTrivia)
          return true;
      }
      return false;
    }

    internal static Roslyn.Compilers.CSharp.TypeDeclarationSyntax TypeDeclaration(DeclarationKind declarationKind = DeclarationKind.Namespace, Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.AttributeDeclarationSyntax> attributes = null, SyntaxTokenList modifiers = null, Roslyn.Compilers.CSharp.SyntaxToken keyword = null, Roslyn.Compilers.CSharp.SyntaxToken identifier = null, Roslyn.Compilers.CSharp.TypeParameterListSyntax typeParameterListOpt = null, Roslyn.Compilers.CSharp.BaseListSyntax baseListOpt = null, Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.TypeParameterConstraintClauseSyntax> constraintClauses = null, Roslyn.Compilers.CSharp.SyntaxToken openBraceToken = null, Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.MemberDeclarationSyntax> members = null, Roslyn.Compilers.CSharp.SyntaxToken closeBraceToken = null, Roslyn.Compilers.CSharp.SyntaxToken semicolonTokenOpt = null)
    {
      switch (declarationKind)
      {
        case DeclarationKind.Class:
          return (Roslyn.Compilers.CSharp.TypeDeclarationSyntax) Roslyn.Compilers.CSharp.Syntax.ClassDeclaration(attributes, modifiers, keyword, identifier, typeParameterListOpt, baseListOpt, constraintClauses, openBraceToken, members, closeBraceToken, semicolonTokenOpt);
        case DeclarationKind.Interface:
          return (Roslyn.Compilers.CSharp.TypeDeclarationSyntax) Roslyn.Compilers.CSharp.Syntax.InterfaceDeclaration(attributes, modifiers, keyword, identifier, typeParameterListOpt, baseListOpt, constraintClauses, openBraceToken, members, closeBraceToken, semicolonTokenOpt);
        case DeclarationKind.Struct:
          return (Roslyn.Compilers.CSharp.TypeDeclarationSyntax) Roslyn.Compilers.CSharp.Syntax.StructDeclaration(attributes, modifiers, keyword, identifier, typeParameterListOpt, baseListOpt, constraintClauses, openBraceToken, members, closeBraceToken, semicolonTokenOpt);
        default:
          return (Roslyn.Compilers.CSharp.TypeDeclarationSyntax) null;
      }
    }

    public static Roslyn.Compilers.CSharp.TypeDeclarationSyntax TypeDeclaration(SyntaxKind syntaxKind = SyntaxKind.None, Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.AttributeDeclarationSyntax> attributes = null, SyntaxTokenList modifiers = null, Roslyn.Compilers.CSharp.SyntaxToken keyword = null, Roslyn.Compilers.CSharp.SyntaxToken identifier = null, Roslyn.Compilers.CSharp.TypeParameterListSyntax typeParameterListOpt = null, Roslyn.Compilers.CSharp.BaseListSyntax baseListOpt = null, Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.TypeParameterConstraintClauseSyntax> constraintClauses = null, Roslyn.Compilers.CSharp.SyntaxToken openBraceToken = null, Roslyn.Compilers.CSharp.SyntaxList<Roslyn.Compilers.CSharp.MemberDeclarationSyntax> members = null, Roslyn.Compilers.CSharp.SyntaxToken closeBraceToken = null, Roslyn.Compilers.CSharp.SyntaxToken semicolonTokenOpt = null)
    {
      switch (syntaxKind)
      {
        case SyntaxKind.ClassDeclaration:
          return (Roslyn.Compilers.CSharp.TypeDeclarationSyntax) Roslyn.Compilers.CSharp.Syntax.ClassDeclaration(attributes, modifiers, keyword, identifier, typeParameterListOpt, baseListOpt, constraintClauses, openBraceToken, members, closeBraceToken, semicolonTokenOpt);
        case SyntaxKind.StructDeclaration:
          return (Roslyn.Compilers.CSharp.TypeDeclarationSyntax) Roslyn.Compilers.CSharp.Syntax.StructDeclaration(attributes, modifiers, keyword, identifier, typeParameterListOpt, baseListOpt, constraintClauses, openBraceToken, members, closeBraceToken, semicolonTokenOpt);
        case SyntaxKind.InterfaceDeclaration:
          return (Roslyn.Compilers.CSharp.TypeDeclarationSyntax) Roslyn.Compilers.CSharp.Syntax.InterfaceDeclaration(attributes, modifiers, keyword, identifier, typeParameterListOpt, baseListOpt, constraintClauses, openBraceToken, members, closeBraceToken, semicolonTokenOpt);
        default:
          return (Roslyn.Compilers.CSharp.TypeDeclarationSyntax) null;
      }
    }
  }
}
