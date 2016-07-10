//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\mattias\Documents\Visual Studio 2015\Projects\UScript\UScript.Parser\UScript.g4 by ANTLR 4.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace UScript.Parser {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="UScriptParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.3")]
[System.CLSCompliant(false)]
public interface IUScriptVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="UScriptParser.argList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArgList([NotNull] UScriptParser.ArgListContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="UScriptParser.funcname"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFuncname([NotNull] UScriptParser.FuncnameContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="UScriptParser.operatorAnd"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOperatorAnd([NotNull] UScriptParser.OperatorAndContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="UScriptParser.fieldsep"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFieldsep([NotNull] UScriptParser.FieldsepContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>StringExp</c>
	/// labeled alternative in <see cref="UScriptParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStringExp([NotNull] UScriptParser.StringExpContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="UScriptParser.parlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParlist([NotNull] UScriptParser.ParlistContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>FalseExp</c>
	/// labeled alternative in <see cref="UScriptParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFalseExp([NotNull] UScriptParser.FalseExpContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="UScriptParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitType([NotNull] UScriptParser.TypeContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="UScriptParser.retstat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRetstat([NotNull] UScriptParser.RetstatContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="UScriptParser.operatorBitwise"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOperatorBitwise([NotNull] UScriptParser.OperatorBitwiseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="UScriptParser.number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumber([NotNull] UScriptParser.NumberContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>OrExp</c>
	/// labeled alternative in <see cref="UScriptParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOrExp([NotNull] UScriptParser.OrExpContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="UScriptParser.nameAndArgs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNameAndArgs([NotNull] UScriptParser.NameAndArgsContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="UScriptParser.namelist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNamelist([NotNull] UScriptParser.NamelistContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ReturnStatement</c>
	/// labeled alternative in <see cref="UScriptParser.stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReturnStatement([NotNull] UScriptParser.ReturnStatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="UScriptParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlock([NotNull] UScriptParser.BlockContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AddSubExp</c>
	/// labeled alternative in <see cref="UScriptParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAddSubExp([NotNull] UScriptParser.AddSubExpContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>CmpExp</c>
	/// labeled alternative in <see cref="UScriptParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmpExp([NotNull] UScriptParser.CmpExpContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>MulDivModExp</c>
	/// labeled alternative in <see cref="UScriptParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMulDivModExp([NotNull] UScriptParser.MulDivModExpContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="UScriptParser.funcbody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFuncbody([NotNull] UScriptParser.FuncbodyContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="UScriptParser.operatorPower"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOperatorPower([NotNull] UScriptParser.OperatorPowerContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="UScriptParser.var"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVar([NotNull] UScriptParser.VarContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="UScriptParser.operatorAddSub"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOperatorAddSub([NotNull] UScriptParser.OperatorAddSubContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="UScriptParser.operatorMulDivMod"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOperatorMulDivMod([NotNull] UScriptParser.OperatorMulDivModContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="UScriptParser.module"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitModule([NotNull] UScriptParser.ModuleContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="UScriptParser.field"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitField([NotNull] UScriptParser.FieldContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>UnaryExp</c>
	/// labeled alternative in <see cref="UScriptParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnaryExp([NotNull] UScriptParser.UnaryExpContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>TrueExp</c>
	/// labeled alternative in <see cref="UScriptParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTrueExp([NotNull] UScriptParser.TrueExpContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>NumberExp</c>
	/// labeled alternative in <see cref="UScriptParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumberExp([NotNull] UScriptParser.NumberExpContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="UScriptParser.tableconstructor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTableconstructor([NotNull] UScriptParser.TableconstructorContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AndExp</c>
	/// labeled alternative in <see cref="UScriptParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAndExp([NotNull] UScriptParser.AndExpContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="UScriptParser.operatorUnary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOperatorUnary([NotNull] UScriptParser.OperatorUnaryContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="UScriptParser.string"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitString([NotNull] UScriptParser.StringContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="UScriptParser.functioncall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctioncall([NotNull] UScriptParser.FunctioncallContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>FuncCallStatement</c>
	/// labeled alternative in <see cref="UScriptParser.stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFuncCallStatement([NotNull] UScriptParser.FuncCallStatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="UScriptParser.explist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExplist([NotNull] UScriptParser.ExplistContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="UScriptParser.varOrExp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVarOrExp([NotNull] UScriptParser.VarOrExpContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="UScriptParser.prefixexp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrefixexp([NotNull] UScriptParser.PrefixexpContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="UScriptParser.param"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParam([NotNull] UScriptParser.ParamContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="UScriptParser.functiondef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctiondef([NotNull] UScriptParser.FunctiondefContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>VarExp</c>
	/// labeled alternative in <see cref="UScriptParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVarExp([NotNull] UScriptParser.VarExpContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="UScriptParser.operatorComparison"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOperatorComparison([NotNull] UScriptParser.OperatorComparisonContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="UScriptParser.varlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVarlist([NotNull] UScriptParser.VarlistContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="UScriptParser.operatorOr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOperatorOr([NotNull] UScriptParser.OperatorOrContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="UScriptParser.label"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLabel([NotNull] UScriptParser.LabelContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="UScriptParser.fieldlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFieldlist([NotNull] UScriptParser.FieldlistContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>FunctionDeclStatement</c>
	/// labeled alternative in <see cref="UScriptParser.stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionDeclStatement([NotNull] UScriptParser.FunctionDeclStatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="UScriptParser.operatorStrcat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOperatorStrcat([NotNull] UScriptParser.OperatorStrcatContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="UScriptParser.args"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArgs([NotNull] UScriptParser.ArgsContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>BitwiseExp</c>
	/// labeled alternative in <see cref="UScriptParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBitwiseExp([NotNull] UScriptParser.BitwiseExpContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="UScriptParser.varDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVarDecl([NotNull] UScriptParser.VarDeclContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>PowerExp</c>
	/// labeled alternative in <see cref="UScriptParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPowerExp([NotNull] UScriptParser.PowerExpContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="UScriptParser.varSuffix"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVarSuffix([NotNull] UScriptParser.VarSuffixContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>VarDeclStatement</c>
	/// labeled alternative in <see cref="UScriptParser.stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVarDeclStatement([NotNull] UScriptParser.VarDeclStatementContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>NilExp</c>
	/// labeled alternative in <see cref="UScriptParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNilExp([NotNull] UScriptParser.NilExpContext context);
}
} // namespace UScript.Parser
