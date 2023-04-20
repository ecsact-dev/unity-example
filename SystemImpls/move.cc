#include "example.ecsact.hh"
#include "example.ecsact.systems.hh"

void example::Move::impl(context& ctx) {
	auto velocity = ctx.get<Velocity>();
	auto move = ctx.action();

	velocity.x_value = move.dir_x;
	velocity.y_value = move.dir_y; 

	ctx.update<Velocity>(velocity);
}

void example::ApplyVelocity::impl(context& ctx) {
	auto position = ctx.get<Position>();
	auto velocity = ctx.get<Velocity>();

	position.prev_x = position.x;
	position.prev_y = position.y;

	position.x += velocity.x_value;
	position.y += velocity.y_value;

	ctx.update<Position>(position);
}
