#include "example.ecsact.hh"
#include "example.ecsact.systems.hh"

void example::PerformGenerateBlock::impl(context& ctx) {
	auto action = ctx.action();
	ctx.add(QueueBlock {
		.pos_x = action.pos_x,
		.pos_y = action.pos_y
	});
}

void example::GenerateBlock::impl(context& ctx) {
	auto block = ctx.get<QueueBlock>();

	ctx._ctx.generate(
		CanMove{},
		Block{},
		Position{
			.x = static_cast<float>(block.pos_x),
			.y = static_cast<float>(block.pos_y)
		},
		Collider{.x_radius = 4, .y_radius = 4},
		Velocity{.x_value = 0, .y_value = 0, .speed = 0.1f}
	);
}
