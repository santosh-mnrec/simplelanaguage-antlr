//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\Poc and Personal\GrammarDemo\SimpleLanguage.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419


using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="ISimpleLanguageListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public partial class SimpleLanguageBaseListener : ISimpleLanguageListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleLanguageParser.parse"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParse([NotNull] SimpleLanguageParser.ParseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleLanguageParser.parse"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParse([NotNull] SimpleLanguageParser.ParseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleLanguageParser.block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBlock([NotNull] SimpleLanguageParser.BlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleLanguageParser.block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBlock([NotNull] SimpleLanguageParser.BlockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleLanguageParser.stat"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStat([NotNull] SimpleLanguageParser.StatContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleLanguageParser.stat"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStat([NotNull] SimpleLanguageParser.StatContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleLanguageParser.assignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignment([NotNull] SimpleLanguageParser.AssignmentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleLanguageParser.assignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignment([NotNull] SimpleLanguageParser.AssignmentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleLanguageParser.if_stat"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIf_stat([NotNull] SimpleLanguageParser.If_statContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleLanguageParser.if_stat"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIf_stat([NotNull] SimpleLanguageParser.If_statContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleLanguageParser.condition_block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCondition_block([NotNull] SimpleLanguageParser.Condition_blockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleLanguageParser.condition_block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCondition_block([NotNull] SimpleLanguageParser.Condition_blockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleLanguageParser.stat_block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStat_block([NotNull] SimpleLanguageParser.Stat_blockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleLanguageParser.stat_block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStat_block([NotNull] SimpleLanguageParser.Stat_blockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleLanguageParser.while_stat"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhile_stat([NotNull] SimpleLanguageParser.While_statContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleLanguageParser.while_stat"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhile_stat([NotNull] SimpleLanguageParser.While_statContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleLanguageParser.log"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLog([NotNull] SimpleLanguageParser.LogContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleLanguageParser.log"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLog([NotNull] SimpleLanguageParser.LogContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>notExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNotExpr([NotNull] SimpleLanguageParser.NotExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>notExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNotExpr([NotNull] SimpleLanguageParser.NotExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>unaryMinusExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnaryMinusExpr([NotNull] SimpleLanguageParser.UnaryMinusExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>unaryMinusExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnaryMinusExpr([NotNull] SimpleLanguageParser.UnaryMinusExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>multiplicationExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMultiplicationExpr([NotNull] SimpleLanguageParser.MultiplicationExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>multiplicationExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMultiplicationExpr([NotNull] SimpleLanguageParser.MultiplicationExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>atomExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAtomExpr([NotNull] SimpleLanguageParser.AtomExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>atomExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAtomExpr([NotNull] SimpleLanguageParser.AtomExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>orExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOrExpr([NotNull] SimpleLanguageParser.OrExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>orExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOrExpr([NotNull] SimpleLanguageParser.OrExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>additiveExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAdditiveExpr([NotNull] SimpleLanguageParser.AdditiveExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>additiveExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAdditiveExpr([NotNull] SimpleLanguageParser.AdditiveExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>powExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPowExpr([NotNull] SimpleLanguageParser.PowExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>powExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPowExpr([NotNull] SimpleLanguageParser.PowExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>relationalExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRelationalExpr([NotNull] SimpleLanguageParser.RelationalExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>relationalExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRelationalExpr([NotNull] SimpleLanguageParser.RelationalExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>equalityExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEqualityExpr([NotNull] SimpleLanguageParser.EqualityExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>equalityExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEqualityExpr([NotNull] SimpleLanguageParser.EqualityExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>andExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAndExpr([NotNull] SimpleLanguageParser.AndExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>andExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAndExpr([NotNull] SimpleLanguageParser.AndExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>parExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParExpr([NotNull] SimpleLanguageParser.ParExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>parExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParExpr([NotNull] SimpleLanguageParser.ParExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>numberAtom</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumberAtom([NotNull] SimpleLanguageParser.NumberAtomContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>numberAtom</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumberAtom([NotNull] SimpleLanguageParser.NumberAtomContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>booleanAtom</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBooleanAtom([NotNull] SimpleLanguageParser.BooleanAtomContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>booleanAtom</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBooleanAtom([NotNull] SimpleLanguageParser.BooleanAtomContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>idAtom</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdAtom([NotNull] SimpleLanguageParser.IdAtomContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>idAtom</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdAtom([NotNull] SimpleLanguageParser.IdAtomContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>stringAtom</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStringAtom([NotNull] SimpleLanguageParser.StringAtomContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>stringAtom</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStringAtom([NotNull] SimpleLanguageParser.StringAtomContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>nilAtom</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNilAtom([NotNull] SimpleLanguageParser.NilAtomContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>nilAtom</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNilAtom([NotNull] SimpleLanguageParser.NilAtomContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
