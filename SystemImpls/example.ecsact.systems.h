// GENERATED FILE - DO NOT EDIT
#ifndef EXAMPLE_H
#define EXAMPLE_H

#ifdef __cplusplus
#	define ECSACT_SYSTEM_EXTERN extern "C"
#else
#	define ECSACT_SYSTEM_EXTERN extern
#endif

ECSACT_SYSTEM_EXTERN void example__Move(struct ecsact_system_execution_context*);
ECSACT_SYSTEM_EXTERN void example__PerformGenerateBlock(struct ecsact_system_execution_context*);
ECSACT_SYSTEM_EXTERN void example__AddToExample(struct ecsact_system_execution_context*);
ECSACT_SYSTEM_EXTERN void example__CollisionComparer(struct ecsact_system_execution_context*);
ECSACT_SYSTEM_EXTERN void example__CollisionComparer__CheckCollision(struct ecsact_system_execution_context*);
ECSACT_SYSTEM_EXTERN void example__ApplyVelocity(struct ecsact_system_execution_context*);
ECSACT_SYSTEM_EXTERN void example__GenerateBlock(struct ecsact_system_execution_context*);
ECSACT_SYSTEM_EXTERN void example__RemoveQueueBlock(struct ecsact_system_execution_context*);

#undef ECSACT_SYSTEM_EXTERN
#endif//EXAMPLE_H
