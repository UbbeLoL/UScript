#ifndef RUNTIME_CONTEXT_H
#define RUNTIME_CONTEXT_H

#include <stdint.h>
#include "metadata_context.h"
#include "function_context.h"

typedef struct StackFrame {
	uint32_t ip;
	FunctionContext *func_ctx;
	int32_t param_count;

} StackFrame;

typedef struct UScriptRuntimeContext {
	UScriptMetadataContext* md_ctx;
	StackFrame* cur_frame;
	int32_t frame_count; 
	StackFrame** call_stack;
} UScriptRuntimeContext;

typedef struct RuntimeError {
	USCRIPT_ERR err_code;
	StackFrame frame;
} RuntimeError;

//! Creates a runtime context.
USCRIPT_ERR runtime_ctx_create(UScriptRuntimeContext **ctx, UScriptMetadataContext *mdCtx);

//! Creates a stack frame.
USCRIPT_ERR stack_frame_create(UScriptRuntimeContext *ctx, StackFrame **frame);

//! Create and push a new stack frame.
USCRIPT_ERR stack_frame_create_push(UScriptRuntimeContext *ctx);

//! Helper method to get previous stack frame from a runtime context.
StackFrame* stack_frame_get_previous(UScriptRuntimeContext *ctx);
#endif
