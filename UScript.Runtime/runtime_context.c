#include "runtime_context.h"
#include <stdlib.h>

//! Creates a runtime context.
/*!
	\param[out] ctx The runtime context.
	\param[in] mdCtx The metadata context to use.
*/
USCRIPT_ERR runtime_ctx_create(UScriptRuntimeContext **ctx, UScriptMetadataContext *mdCtx) {
	*ctx = (UScriptRuntimeContext*)malloc(sizeof(UScriptRuntimeContext));
	(*ctx)->md_ctx = mdCtx;

	(*ctx)->frame_count = 1;
	(*ctx)->call_stack = (StackFrame**)malloc(sizeof(StackFrame*));

	(*ctx)->call_stack[0] = (StackFrame*)malloc(sizeof(StackFrame));
	(*ctx)->call_stack[0]->ip = 0;
	(*ctx)->cur_frame = (*ctx)->call_stack[0];

	// Create context for entry code
	__create_basic_function_ctx(&(*ctx)->call_stack[0]->func_ctx);

	mem_mgr_create(&(*ctx)->mem_mgr);

	return USCRIPT_ERR_SUCCESS;
}

//! Creates a stack frame.
/*!
	\param[in] ctx The runtime context.
	\param[out] frame The stack frame.
*/
USCRIPT_ERR stack_frame_create(UScriptRuntimeContext *ctx, StackFrame **frame) {
	*frame = (StackFrame*)malloc(sizeof(StackFrame));
	(*frame)->ip = 0;
	
	function_context_create(&(*frame)->func_ctx);

	return USCRIPT_ERR_SUCCESS;
}

//! Create and push a new stack frame.
/*!
	\param[in] ctx The runtime context to use.
*/
USCRIPT_ERR stack_frame_create_push(UScriptRuntimeContext *ctx) {
	StackFrame *frame;
	USCRIPT_ERR res;

	if((res = stack_frame_create(ctx, &frame)) != USCRIPT_ERR_SUCCESS) {
		return res;
	}

	ctx->call_stack[ctx->frame_count] = frame;
	ctx->cur_frame = ctx->call_stack[ctx->frame_count++];

	return USCRIPT_ERR_SUCCESS;
}

//! Helper method to get previous stack frame from a runtime context.
/*!
	\param[in] ctx The runtime context to use.
*/
USCRIPT_ERR call_stack_get_previous_frame(UScriptRuntimeContext *ctx, StackFrame **frame) {
	if(ctx->frame_count == 1) {
		//TODO: error handling
	}

	*frame = ctx->call_stack[ctx->frame_count - 2];
	return USCRIPT_ERR_SUCCESS; 
}

USCRIPT_ERR call_stack_unwind_one(UScriptRuntimeContext* ctx, StackFrame** frame) {
	if(ctx->frame_count == 1) {
		//TODO: error handling
	}

	*frame = ctx->call_stack[ctx->frame_count-- - 1];
	ctx->cur_frame = ctx->call_stack[ctx->frame_count -1];
	return USCRIPT_ERR_SUCCESS;
}
