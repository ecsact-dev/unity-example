// GENERATED FILE - DO NOT EDIT
#include "example.ecsact.systems.hh"
void example__AddToExample(struct ecsact_system_execution_context* cctx) {
	example::AddToExample::context ctx{cctx};
	example::AddToExample::impl(ctx);
}
void example__CollisionComparer(struct ecsact_system_execution_context* cctx) {
	example::CollisionComparer::context ctx{cctx};
	example::CollisionComparer::impl(ctx);
}
void example__CollisionComparer__CheckCollision(struct ecsact_system_execution_context* cctx) {
	example::CollisionComparer::CheckCollision::context ctx{cctx};
	example::CollisionComparer::CheckCollision::impl(ctx);
}
void example__ApplyVelocity(struct ecsact_system_execution_context* cctx) {
	example::ApplyVelocity::context ctx{cctx};
	example::ApplyVelocity::impl(ctx);
}
void example__GenerateBlock(struct ecsact_system_execution_context* cctx) {
	example::GenerateBlock::context ctx{cctx};
	example::GenerateBlock::impl(ctx);
}
void example__RemoveQueueBlock(struct ecsact_system_execution_context* cctx) {
	example::RemoveQueueBlock::context ctx{cctx};
	example::RemoveQueueBlock::impl(ctx);
}
void example__Move(struct ecsact_system_execution_context* cctx) {
	example::Move::context ctx{cctx};
	example::Move::impl(ctx);
}
void example__PerformGenerateBlock(struct ecsact_system_execution_context* cctx) {
	example::PerformGenerateBlock::context ctx{cctx};
	example::PerformGenerateBlock::impl(ctx);
}
