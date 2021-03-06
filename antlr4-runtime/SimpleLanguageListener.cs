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
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="SimpleLanguageParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public interface ISimpleLanguageListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleLanguageParser.parse"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParse([NotNull] SimpleLanguageParser.ParseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleLanguageParser.parse"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParse([NotNull] SimpleLanguageParser.ParseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleLanguageParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlock([NotNull] SimpleLanguageParser.BlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleLanguageParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlock([NotNull] SimpleLanguageParser.BlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleLanguageParser.stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStat([NotNull] SimpleLanguageParser.StatContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleLanguageParser.stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStat([NotNull] SimpleLanguageParser.StatContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleLanguageParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignment([NotNull] SimpleLanguageParser.AssignmentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleLanguageParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignment([NotNull] SimpleLanguageParser.AssignmentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleLanguageParser.if_stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIf_stat([NotNull] SimpleLanguageParser.If_statContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleLanguageParser.if_stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIf_stat([NotNull] SimpleLanguageParser.If_statContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleLanguageParser.condition_block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCondition_block([NotNull] SimpleLanguageParser.Condition_blockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleLanguageParser.condition_block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCondition_block([NotNull] SimpleLanguageParser.Condition_blockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleLanguageParser.stat_block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStat_block([NotNull] SimpleLanguageParser.Stat_blockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleLanguageParser.stat_block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStat_block([NotNull] SimpleLanguageParser.Stat_blockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleLanguageParser.while_stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhile_stat([NotNull] SimpleLanguageParser.While_statContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleLanguageParser.while_stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhile_stat([NotNull] SimpleLanguageParser.While_statContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleLanguageParser.log"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLog([NotNull] SimpleLanguageParser.LogContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleLanguageParser.log"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLog([NotNull] SimpleLanguageParser.LogContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>notExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNotExpr([NotNull] SimpleLanguageParser.NotExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>notExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNotExpr([NotNull] SimpleLanguageParser.NotExprContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>unaryMinusExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnaryMinusExpr([NotNull] SimpleLanguageParser.UnaryMinusExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>unaryMinusExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnaryMinusExpr([NotNull] SimpleLanguageParser.UnaryMinusExprContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>multiplicationExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiplicationExpr([NotNull] SimpleLanguageParser.MultiplicationExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>multiplicationExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiplicationExpr([NotNull] SimpleLanguageParser.MultiplicationExprContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>atomExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAtomExpr([NotNull] SimpleLanguageParser.AtomExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>atomExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAtomExpr([NotNull] SimpleLanguageParser.AtomExprContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>orExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOrExpr([NotNull] SimpleLanguageParser.OrExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>orExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOrExpr([NotNull] SimpleLanguageParser.OrExprContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>additiveExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdditiveExpr([NotNull] SimpleLanguageParser.AdditiveExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>additiveExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdditiveExpr([NotNull] SimpleLanguageParser.AdditiveExprContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>powExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPowExpr([NotNull] SimpleLanguageParser.PowExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>powExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPowExpr([NotNull] SimpleLanguageParser.PowExprContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>relationalExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRelationalExpr([NotNull] SimpleLanguageParser.RelationalExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>relationalExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRelationalExpr([NotNull] SimpleLanguageParser.RelationalExprContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>equalityExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEqualityExpr([NotNull] SimpleLanguageParser.EqualityExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>equalityExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEqualityExpr([NotNull] SimpleLanguageParser.EqualityExprContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>andExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAndExpr([NotNull] SimpleLanguageParser.AndExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>andExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAndExpr([NotNull] SimpleLanguageParser.AndExprContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>parExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParExpr([NotNull] SimpleLanguageParser.ParExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>parExpr</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParExpr([NotNull] SimpleLanguageParser.ParExprContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>numberAtom</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumberAtom([NotNull] SimpleLanguageParser.NumberAtomContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>numberAtom</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumberAtom([NotNull] SimpleLanguageParser.NumberAtomContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>booleanAtom</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBooleanAtom([NotNull] SimpleLanguageParser.BooleanAtomContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>booleanAtom</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBooleanAtom([NotNull] SimpleLanguageParser.BooleanAtomContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>idAtom</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdAtom([NotNull] SimpleLanguageParser.IdAtomContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>idAtom</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdAtom([NotNull] SimpleLanguageParser.IdAtomContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>stringAtom</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStringAtom([NotNull] SimpleLanguageParser.StringAtomContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>stringAtom</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStringAtom([NotNull] SimpleLanguageParser.StringAtomContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>nilAtom</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNilAtom([NotNull] SimpleLanguageParser.NilAtomContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>nilAtom</c>
	/// labeled alternative in <see cref="SimpleLanguageParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNilAtom([NotNull] SimpleLanguageParser.NilAtomContext context);
}
